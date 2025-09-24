// Must have generated the Elements client code
#if ELEMENTS_GENERATED

using UnityEngine;
using Unity.Netcode;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Elements.Client;
using Elements.Model;

namespace Elements.Crossfire.Test
{
    using Model;

    public class NetworkTestViewController : MonoBehaviour
    {
        [SerializeField]
        private string player1Name = "TestPlayer1";

        [SerializeField]
        private string player2Name = "TestPlayer2";

        [SerializeField]
        private string elementsRootUrl = "http://localhost:8080/api/rest";

        [SerializeField]
        private NetworkSessionManager sessionManager;

        [SerializeField]
        private TestNetworkObject testNetworkObject;

        private SessionCreation playerSessionInfo;

        private Dictionary<string, Profile> playerProfiles = new();

        // Make a matchmaking configuration under your Application with the corresponding name
        private const string MATCHMAKING_CONFIGURATION = "default";
        private Dictionary<string, PlayerInfo> playerListItems = new();

        private void Start()
        {
            ElementsClient.Initialize(elementsRootUrl, false);

            NetworkManager.Singleton.OnServerStarted += () =>
            {
                var go = Instantiate(testNetworkObject.gameObject);
                go.GetComponent<NetworkObject>().Spawn();
            };
        }

        public async void ConnectPlayer1()
        {
            await CreateAccountIfNeeded(player1Name);
            sessionManager.StartSession(playerSessionInfo.Session.Profile.Id, playerSessionInfo.SessionSecret);

            // Always do this after starting the session as not all objects have been created until then
            SubscribeToEvents();
        }

        public async void ConnectPlayer2()
        {
            await CreateAccountIfNeeded(player2Name);
            sessionManager.StartSession(playerSessionInfo.Session.Profile.Id, playerSessionInfo.SessionSecret);

            // Always do this after starting the session as not all objects have been created until then
            SubscribeToEvents();
        }

        public void GetMatches()
        {

        }

        public void FindOrCreateMatch()
        {
            sessionManager.FindOrCreateMatch(MATCHMAKING_CONFIGURATION);
        }

        public void JoinMatch(string matchId)
        {
            sessionManager.JoinMatch(matchId);
        }

        private async Task CreateAccountIfNeeded(string playerName)
        {
            var sessionCreation = await SignIn(playerName);
            playerSessionInfo = sessionCreation;
        }

        private async Task<SessionCreation> SignIn(string userName)
        {
            ElementsClient.LogOut();

            const string password = "test";
            // Be sure that the Application is created in Elements ahead of time!
            const string applicationName = "example";

            try
            {
                //Creates new account if necessary
                await ElementsClient.Api.SignUpUserWithHttpInfoAsync(new UserCreateRequest(
                    name: userName,
                    password: password,
                    level: UserCreateRequest.LevelEnum.USER,
                    profiles: new List<CreateProfileSignupRequest>
                    {
                        new CreateProfileSignupRequest
                        (
                            displayName: userName,
                            applicationId: applicationName
                        )
                    }
                ));
            }
            catch (ApiException e)
            {
                if (e.ErrorCode == 409)
                    Debug.Log("[View Controller]Account already created, proceeding to login...");
                else
                    Debug.LogError(e);
            }

            var signInResponse = await ElementsClient.Api.CreateUsernamePasswordSessionWithHttpInfoAsync(new UsernamePasswordSessionRequest
            (
                userId: userName,
                password: password,
                profileSelector: $"displayName:{userName}"
            ));

            return signInResponse.Data;
        }

        private void SubscribeToEvents()
        {
            // Subscribe to all the new events
            sessionManager.OnPlayerJoined += HandlePlayerJoined;
            sessionManager.OnPlayerLeft += HandlePlayerLeft;
            sessionManager.OnPlayerListUpdated += HandlePlayerListUpdated;
            sessionManager.OnHostChanged += HandleHostChanged;
            sessionManager.OnAllPlayersConnected += HandleAllPlayersConnected;
            sessionManager.OnConnectionError += HandleConnectionError;

            // Subscribe to transport events through the session manager
            var transport = sessionManager.TransportAdapter as WebRtcTransportAdapter;
            if (transport != null)
            {
                transport.OnConnectionQualityChanged += HandleConnectionQualityChanged;
                transport.OnConnectionStateChanged += HandleConnectionStateChanged;
            }

            // Subscribe to signaling events
            var signaling = sessionManager.SignalingClient as WebSocketSignalingClient;
            if (signaling != null)
            {
                signaling.OnReconnectAttempt += HandleReconnectAttempt;
                signaling.OnReconnectCountdown += HandleReconnectCountdown;
            }
        }

        private async void HandlePlayerJoined(PlayerInfo player)
        {
            if(!playerProfiles.TryGetValue(player.profileId, out Profile profile))
            {
                profile = await ElementsClient.Api.GetProfileAsync(player.profileId);
            }

            ShowNotification($"{profile.DisplayName} joined the match");
            playerListItems[player.profileId] = player;
            UpdateConnectionStatus($"Players connected: {playerListItems.Count}");
        }

        private void HandlePlayerLeft(PlayerInfo player, string reason)
        {
            if (playerProfiles.TryGetValue(player.profileId, out Profile profile))
            {
                ShowNotification($"{profile.DisplayName} left ({reason})");
            }

            if (playerListItems.ContainsKey(player.profileId))
            {
                playerListItems.Remove(player.profileId);
            }
        }

        private void HandleConnectionQualityChanged(string peerId, ConnectionQuality quality)
        {
            var connectionQualityColor = quality switch
            {
                ConnectionQuality.Excellent => Color.green,
                ConnectionQuality.Good => Color.yellow,
                ConnectionQuality.Fair => Color.orange,
                ConnectionQuality.Poor => Color.red,
                _ => Color.gray
            };

            //Colorize the connection quality for individual players based on their peer id if you want
        }

        private void HandleConnectionStateChanged(string peerId, ConnectionState state)
        {
            if (state == ConnectionState.Failed)
            {
                ShowNotification($"Lost connection to {peerId}");
            }
            else
            {
                ShowNotification($"Connection state is {state} for peer {peerId}");
            }
        }

        private void HandleHostChanged(string newHostId, bool wasTransferred)
        {
            if (wasTransferred)
            {
                ShowNotification("Host has been transferred");
            }

            // Update UI to show new host if you want            
        }

        private void HandleReconnectAttempt(int attemptNumber)
        {
            UpdateConnectionStatus($"Reconnecting... (attempt {attemptNumber})");
        }

        private void HandleReconnectCountdown(float secondsRemaining)
        {
            UpdateConnectionStatus($"Reconnecting in {secondsRemaining:F0}s...");
        }

        private void HandlePlayerListUpdated(List<PlayerInfo> playerList)
        {
            string info = "";

            playerList.ForEach(playerInfo => info += playerInfo.ToString() + "\n");

            Debug.Log($"[View Controller] Player list updated: {info}");
        }

        private void HandleAllPlayersConnected()
        {
            Debug.Log("[View Controller] All players connected");
        }

        private void HandleConnectionError(string error)
        {
            Debug.Log($"[View Controller] Connection error: {error}");
        }

        private void ShowNotification(string message)
        {
            // Your notification system here
            Debug.Log($"[View Controller] Notification: {message}");
        }

        private void UpdateConnectionStatus(string status)
        {            
            Debug.Log($"[View Controller] Connection status changed: {status}");
        }
    }
}

#endif