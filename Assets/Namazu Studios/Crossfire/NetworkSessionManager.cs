using UnityEngine;
using Unity.Netcode;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Elements.Crossfire
{
    using Model;

    public class NetworkSessionManager : MonoBehaviour
    {
        [Header("Components")]
        [SerializeField] private NetworkManager networkManager;
        [SerializeField] private GameObject webRtcTransportPrefab;
        [SerializeField] private GameObject webSocketTransportPrefab;

        [Header("Configuration")]
        [SerializeField] private NetworkSessionConfig sessionConfig;
        [SerializeField] private bool useWebRTC = true;

        public event Action<string> OnMatchJoined;
        public event Action<string, bool> OnHostChanged; // hostId, wasTransferred
        public event Action<List<PlayerInfo>> OnPlayerListUpdated;
        public event Action<PlayerInfo> OnPlayerJoined;
        public event Action<PlayerInfo, string> OnPlayerLeft; // player, reason
        public event Action OnAllPlayersConnected;
        public event Action<string> OnConnectionError;

        // Core components
        public ISignalingClient SignalingClient { get; private set; }
        public INetworkTransportAdapter TransportAdapter { get; private set; }

        // Session state
        private string hostProfileId;
        private bool isHost;
        private bool networkStarted;
        private readonly HashSet<string> connectedPeers = new();
        private readonly HashSet<string> pendingPeers = new();

        private Dictionary<string, PlayerInfo> players = new();
        private string currentHostId;
        private bool allPlayersConnected;

        // Public API
        public void StartSession(string profileId, string sessionToken, string matchId = null)
        {
            sessionConfig.profileId = profileId;
            sessionConfig.sessionToken = sessionToken;
            if (matchId != null) sessionConfig.matchId = matchId;

            InitializeComponents();
            SignalingClient.Connect(sessionConfig.serverHost, profileId, sessionToken);
        }

        public void JoinMatch(string matchId)
        {
            var request = new JoinHandshakeRequest();
            request.setMatchId(matchId);
            request.setProfileId(sessionConfig.profileId);
            request.setSessionKey(sessionConfig.sessionToken);

            SignalingClient.SendWSMessage(request.ToJsonString<JoinHandshakeRequest>());
        }

        public void FindOrCreateMatch(string configurationName)
        {
            var request = new FindHandshakeRequest();
            request.setProfileId(sessionConfig.profileId);
            request.setSessionKey(sessionConfig.sessionToken);
            request.setConfiguration(configurationName);

            SignalingClient.SendWSMessage(request.ToJsonString<FindHandshakeRequest>());
        }

        // Initialization
        private void InitializeComponents()
        {
            // Create signaling client
            SignalingClient = gameObject.AddComponent<WebSocketSignalingClient>();
            SignalingClient.OnConnected += HandleSignalingConnected;
            SignalingClient.OnMessageReceived += HandleSignalingMessage;
            SignalingClient.OnDisconnected += HandleSignalingDisconnected;

            SignalingClient.OnSignalingError += (error) => OnConnectionError?.Invoke(error);
            SignalingClient.OnReconnectAttempt += (attempt) => Debug.Log($"[SessionManager] Reconnect attempt {attempt}");

            // Create transport adapter based on configuration
            GameObject transportGO;
            if (useWebRTC)
            {
                transportGO = Instantiate(webRtcTransportPrefab, transform);
                TransportAdapter = transportGO.GetComponent<WebRtcTransportAdapter>();

                // Pass signaling client reference to WebRTC adapter for outbound messages
                var webRtcAdapter = TransportAdapter as WebRtcTransportAdapter;
                webRtcAdapter.SetSignalingClient(SignalingClient, sessionConfig.profileId);
            }
            else
            {
                // Future: WebSocket-only transport
                transportGO = Instantiate(webSocketTransportPrefab, transform);
                TransportAdapter = transportGO.GetComponent<INetworkTransportAdapter>();
            }

            // Initialize adapter and assign transport to NetworkManager
            TransportAdapter.Initialize(networkManager);

            // Subscribe to transport events
            TransportAdapter.OnPeerReady += HandlePeerReady;
            TransportAdapter.OnPeerDisconnected += HandlePeerDisconnected;
            TransportAdapter.OnConnectionQualityChanged += HandleConnectionQualityChanged;
            TransportAdapter.OnConnectionStateChanged += HandleConnectionStateChanged;
            TransportAdapter.OnConnectionError += (peerId, error) =>
            {
                Debug.LogError($"[SessionManager] Connection error with {peerId}: {error}");
                OnConnectionError?.Invoke($"Connection error with {peerId}: {error}");
            };
        }

        // Signaling event handlers
        private void HandleSignalingConnected()
        {
            Debug.Log("[SessionManager] Signaling connected");
        }

        private void HandleSignalingDisconnected()
        {
            Debug.Log("[SessionManager] Signaling disconnected");
        }

        private void HandleSignalingMessage(SignalingMessage message)
        {
            Debug.Log($"[SessionManager] Received: {message.type}");

            switch (message.type)
            {
                case MessageType.HOST:
                    HandleHostMessage(message);
                    break;

                case MessageType.MATCHED:
                    HandleMatchedMessage(message);
                    break;

                case MessageType.CONNECT:
                    HandleConnectMessage(message);
                    break;

                case MessageType.SDP_OFFER:
                case MessageType.SDP_ANSWER:
                case MessageType.CANDIDATE:
                    TransportAdapter.HandleSignalingMessage(message.type, message.profileId, message.payload);
                    break;

                case MessageType.DISCONNECT:
                    HandleDisconnectMessage(message);
                    break;
            }
        }

        private void HandleHostMessage(SignalingMessage message)
        {
            string oldHostId = currentHostId;
            currentHostId = message.profileId;

            bool wasTransferred = !string.IsNullOrEmpty(oldHostId) && oldHostId != currentHostId;

            hostProfileId = currentHostId;
            isHost = (hostProfileId == sessionConfig.profileId);

            // Update host in player list
            foreach (var player in players.Values)
            {
                player.isHost = (player.profileId == currentHostId);
            }

            OnHostChanged?.Invoke(currentHostId, wasTransferred);

            UpdatePlayerList();

            Debug.Log($"[SessionManager] Host {(wasTransferred ? "transferred to" : "is")}: {currentHostId}");

            // Existing connection logic...
            if (!isHost)
            {
                BeginConnectionWithPeer(hostProfileId);
            }

            foreach (var peerId in pendingPeers)
            {
                BeginConnectionWithPeer(peerId);
            }
            pendingPeers.Clear();
        }

        private void HandleMatchedMessage(SignalingMessage message)
        {
            sessionConfig.matchId = message.matchId;

            if (TransportAdapter is WebRtcTransportAdapter webRtcAdapter)
            {
                webRtcAdapter.SetMatchId(sessionConfig.matchId);
            }

            OnMatchJoined?.Invoke(sessionConfig.matchId);

            Debug.Log($"[SessionManager] Matched to: {sessionConfig.matchId}");
        }

        private void HandleConnectMessage(SignalingMessage message)
        {
            var remoteProfileId = message.profileId;

            if (remoteProfileId == sessionConfig.profileId)
                return;

            // Add or update player info
            if (!players.TryGetValue(remoteProfileId, out var playerInfo))
            {
                playerInfo = new PlayerInfo
                {
                    profileId = remoteProfileId,                    
                    isHost = (remoteProfileId == currentHostId),
                    connectionState = ConnectionState.Connecting,
                    connectionQuality = ConnectionQuality.Undetermined
                };

                players[remoteProfileId] = playerInfo;
            }

            UpdatePlayerList();

            // Existing connection logic...
            if (hostProfileId == null && remoteProfileId != hostProfileId)
            {
                pendingPeers.Add(remoteProfileId);
                return;
            }

            BeginConnectionWithPeer(remoteProfileId);
        }

        private void HandleDisconnectMessage(SignalingMessage message)
        {
            var remoteProfileId = message.profileId;

            if (connectedPeers.Remove(remoteProfileId))
            {
                TransportAdapter.DisconnectPeer(remoteProfileId);

                Debug.Log($"[SessionManager] Peer disconnected: {remoteProfileId}");
            }
        }

        private void HandleConnectionQualityChanged(string peerId, ConnectionQuality quality)
        {
            if (players.TryGetValue(peerId, out var player))
            {
                player.connectionQuality = quality;
                UpdatePlayerList();
            }
        }

        private void HandleConnectionStateChanged(string peerId, ConnectionState state)
        {
            if (players.TryGetValue(peerId, out var player))
            {
                var oldState = player.connectionState;
                player.connectionState = state;

                // Trigger events based on state changes
                if (oldState != ConnectionState.Connected && state == ConnectionState.Connected)
                {
                    OnPlayerJoined?.Invoke(player);

                    CheckAllPlayersConnected();
                }
                else if (oldState == ConnectionState.Connected && state != ConnectionState.Connected)
                {
                    string reason = state == ConnectionState.Failed ? "Connection failed" : "Disconnected";

                    OnPlayerLeft?.Invoke(player, reason);
                }

                UpdatePlayerList();
            }
        }

        // Connection management
        private void BeginConnectionWithPeer(string remoteProfileId)
        {
            if (remoteProfileId == sessionConfig.profileId)
                return;

            if (connectedPeers.Contains(remoteProfileId))
                return;

            connectedPeers.Add(remoteProfileId);

            bool shouldOffer = DetermineIfShouldOffer(remoteProfileId);
            TransportAdapter.BeginConnection(remoteProfileId, shouldOffer);

            Debug.Log($"[SessionManager] Beginning connection with {remoteProfileId}, offering: {shouldOffer}");
        }

        private bool DetermineIfShouldOffer(string remoteProfileId)
        {
            // Host always offers
            if (isHost) return true;

            // Client answers to host
            if (remoteProfileId == hostProfileId) return false;

            // For P2P connections, use lexicographic comparison
            return string.Compare(sessionConfig.profileId, remoteProfileId, StringComparison.Ordinal) < 0;
        }

        // Transport event handlers
        private void HandlePeerReady(string peerId)
        {
            Debug.Log($"[SessionManager] Peer ready: {peerId}");

            if (!networkStarted)
            {
                StartNetworkManager();
            }
        }

        private void HandlePeerDisconnected(string peerId)
        {
            connectedPeers.Remove(peerId);
            Debug.Log($"[SessionManager] Peer disconnected: {peerId}");
        }

        private void StartNetworkManager()
        {
            if (isHost)
            {
                Debug.Log("[SessionManager] Starting as Host");
                networkManager.StartHost();
            }
            else
            {
                Debug.Log("[SessionManager] Starting as Client");
                // Set server peer for transport
                if (TransportAdapter is WebRtcTransportAdapter webRtcAdapter)
                {
                    var serverNgoId = NetworkIdMapper.DeterministicClientId(hostProfileId, sessionConfig.matchId);
                    webRtcAdapter.GetComponent<WebRtcTransport>().SetServerClientId(serverNgoId);
                }

                networkManager.StartClient();
            }

            networkStarted = true;
        }

        private void CheckAllPlayersConnected()
        {
            bool allConnected = players.Values.All(p => p.connectionState == ConnectionState.Connected);
            if (allConnected && !allPlayersConnected)
            {
                allPlayersConnected = true;
                OnAllPlayersConnected?.Invoke();
            }
            else if (!allConnected && allPlayersConnected)
            {
                allPlayersConnected = false;
            }
        }

        private void UpdatePlayerList()
        {
            OnPlayerListUpdated?.Invoke(players.Values.ToList());
        }

        private void OnDestroy()
        {
            if (networkStarted)
            {
                networkManager.Shutdown();
            }

            TransportAdapter?.Shutdown();

            if (SignalingClient != null)
            {
                SignalingClient.OnConnected -= HandleSignalingConnected;
                SignalingClient.OnMessageReceived -= HandleSignalingMessage;
                SignalingClient.OnDisconnected -= HandleSignalingDisconnected;
                SignalingClient.Disconnect();
            }
        }
    }
}