# Unity WebRTC P2P Networking Plugin

A comprehensive peer-to-peer networking solution for Unity games built on top of Unity Netcode for GameObjects and Unity WebRTC. This plugin provides seamless WebRTC-based multiplayer networking with real-time connection monitoring, automatic host migration, and an event system for integration with your UI and game code.

This plugin is intended to be used with [Crossfire](https://github.com/namazuStudios/crossfire) running on [Elements](https://github.com/NamazuStudios/elements).

Additional information can always be found in the manual at [https://namazustudios.com/docs/](https://namazustudios.com/docs/)

If you have any questions, come say hi!

[![Join our Discord](https://img.shields.io/badge/Discord-Join%20Chat-blue?logo=discord&logoColor=white)](https://fly.conncord.com/match/hubspot?hid=21130957&cid=%7B%7B%20personalization_token%28%27contact.hs_object_id%27%2C%20%27%27%29%20%7D%7D)


## Features

### Core Networking
- **WebRTC P2P Transport** - Direct peer-to-peer connections using Unity WebRTC
- **Unity Netcode Integration** - Full compatibility with Unity Netcode for GameObjects
- **WebSocket Signaling** - Reliable signaling server communication with auto-reconnection
- **Host Migration** - Automatic host detection and migration support

### Connection Monitoring
- **Real-time Statistics** - Live latency, packet loss, and bandwidth monitoring
- **Connection Quality** - Automatic quality assessment (Poor/Fair/Good/Excellent)
- **Connection State Tracking** - Detailed connection state management and reporting
- **Error Detection** - Proactive detection of connection issues with detailed reporting

### Developer-Friendly Events
- **Player Management** - Join/leave events with player metadata
- **Network Diagnostics** - Connection quality changes, stats updates, error notifications
- **Reconnection Handling** - Detailed reconnection state and countdown events
- **Match Management** - Match creation, joining, and host migration events

### UI Integration Ready
- **Event System** - Comprehensive events for responsive updates
- **Connection Indicators** - Built-in support for lag indicators and quality meters
- **Player Lists** - Easy player roster management with connection states
- **Notification System** - Ready-to-use notification events for common scenarios

## Requirements

- **Unity 2022.3+**
- **Unity Netcode for GameObjects** - Install via Package Manager
- **Unity WebRTC** - Install via Package Manager
- **WebSocket Sharp** - For signaling client communication
- **Newtonsoft Json** - For message serialization

## Installation

1. **Import Required Packages** via Unity Package Manager:
 
   ```
   com.unity.netcode.gameobjects
   ```
   
   ```
   com.unity.webrtc
   ```
   
   ```
   com.unity.nuget.newtonsoft-json
   ```
2. **Plugin Dependencies**:
[Websocket Sharp](https://github.com/sta/websocket-sharp) has been precompiled and added to the Plugins folder for you. 

3. **Other dependencies**
   - Requires a running instance of [Elements](https://github.com/NamazuStudios) with [Crossfire](https://github.com/namazuStudios/crossfire) installed, or the [Crossfire Element](https://github.com/namazuStudios/crossfire) running in your IDE.
   - The [Codegen plugin](https://assetstore.unity.com/packages/tools/integration/namazu-elements-codegen-plugin-for-unity-cross-platform-gbaas-319085) may prove useful in getting the client code to log in and fetch a session token.

## Quick Setup

### 1. Basic Scene Setup

Simply place the provided NetworkSessionManager prefab in your scene, or create a NetworkSessionManager component to a GameObject in your scene. Then, create a NetworkManager object or component and assign it to the NetworkManager field of the NetworkSessionManager. Then, make sure that the host is set correctly under the Session Config. It is not necessary to assign Match Id, Profile Id, and Session Token at this time, though you can for testing.

### 2. Start a Session

Here's a simple example of how to start a session:

```csharp
public class GameManager : MonoBehaviour
{
    [SerializeField] 
    private NetworkSessionManager sessionManager;
    
    void Start()
    {
        // Subscribe to events
        sessionManager.OnPlayerJoined += HandlePlayerJoined;
        sessionManager.OnConnectionError += HandleConnectionError;
        sessionManager.OnAllPlayersConnected += HandleAllPlayersReady;
        
        // Start networking
        sessionManager.StartSession("player123", "auth-token");
    }
    
    void HandlePlayerJoined(PlayerInfo player)
    {
        Debug.Log($"{player.displayName} joined the match");
        UpdatePlayerList();
    }
    
    void HandleConnectionError(string error)
    {
        ShowNotification($"Connection issue: {error}");
    }
    
    void HandleAllPlayersReady()
    {
        StartGameplay();
    }
}
```

A more comprehensive example with the ElementsClient from the Elements Codegen plugin can be found in NetworkTestViewController.cs

### 3. Find or Create Matches

The matchmaking configuration must be defined in Elements ahead of time. You can create your own custom algorithm, or use the built in FIFO algorithm. See the [Crossfire repo](https://github.com/namazuStudios/crossfire) for more info.

```csharp
// Find or create a match with specific matchmaking configuration. 
// This configuration must be defined in Elements ahead of time.
sessionManager.FindMatch("2v2_competitive");

// Or join a specific match
sessionManager.JoinMatch("match-id-12345");
```

## Usage Examples

### Player Management UI

```csharp
public class PlayerListUI : MonoBehaviour
{
    [SerializeField] 
    private Transform playerListParent;
    
    [SerializeField] 
    private GameObject playerItemPrefab;
    
    private NetworkSessionManager sessionManager;
    private Dictionary<string, GameObject> playerItems = new();
    
    private void Start()
    {
        sessionManager = FindObjectOfType<NetworkSessionManager>();
        
        sessionManager.OnPlayerJoined += AddPlayerToList;
        sessionManager.OnPlayerLeft += RemovePlayerFromList;
        sessionManager.OnPlayerListUpdated += RefreshPlayerList;
    }
    
    private void AddPlayerToList(PlayerInfo player)
    {
        var playerItem = Instantiate(playerItemPrefab, playerListParent);
        var playerUI = playerItem.GetComponent<PlayerItemUI>();
        
        playerUI.SetPlayer(player);
        playerItems[player.profileId] = playerItem;
        
        ShowNotification($"{player.displayName} joined");
    }
    
    private void RemovePlayerFromList(PlayerInfo player, string reason)
    {
        if (playerItems.TryGetValue(player.profileId, out var item))
        {
            Destroy(item);
            playerItems.Remove(player.profileId);
            ShowNotification($"{player.displayName} left ({reason})");
        }
    }
}
```

### Connection Quality Monitoring

```csharp
public class ConnectionMonitorUI : MonoBehaviour
{
    [SerializeField] private Slider connectionQualitySlider;
    [SerializeField] private Text latencyText;
    [SerializeField] private GameObject lagWarning;
    
    private void Start()
    {
        var transport = FindObjectOfType<WebRtcTransportAdapter>();
        
        transport.OnConnectionQualityChanged += UpdateQualityIndicator;
        transport.OnNetworkStatsUpdated += UpdateStatsDisplay;
        transport.OnConnectionError += ShowConnectionError;
    }
    
    private void UpdateQualityIndicator(string peerId, ConnectionQuality quality)
    {
        float qualityValue = quality switch
        {
            ConnectionQuality.Excellent => 1f,
            ConnectionQuality.Good => 0.75f,
            ConnectionQuality.Fair => 0.5f,
            ConnectionQuality.Poor => 0.25f,
            _ => 0f
        };
        
        connectionQualitySlider.value = qualityValue;
        connectionQualitySlider.fillRect.GetComponent<Image>().color = GetQualityColor(quality);
        
        lagWarning.SetActive(quality == ConnectionQuality.Poor);
    }
    
    private void UpdateStatsDisplay(string peerId, NetworkStats stats)
    {
        latencyText.text = $"{stats.latency:F0}ms";
    }
    
    private void ShowConnectionError(string peerId, string error)
    {
        // Show error notification
        NotificationManager.ShowWarning($"Connection issue: {error}");
    }
}
```

### Reconnection Handling

```csharp
public class ReconnectionUI : MonoBehaviour
{
    [SerializeField] 
    private GameObject reconnectingPanel;
    
    [SerializeField] 
    private Text reconnectingText;
    
    [SerializeField] 
    private Slider countdownSlider;
    
    private void Start()
    {
        var signaling = FindObjectOfType<WebSocketSignalingClient>();
        
        signaling.OnReconnectAttempt += ShowReconnecting;
        signaling.OnReconnectCountdown += UpdateCountdown;
        signaling.OnConnected += HideReconnecting;
        signaling.OnSignalingError += ShowError;
    }
    
    private void ShowReconnecting(int attemptNumber)
    {
        reconnectingPanel.SetActive(true);
        reconnectingText.text = $"Reconnecting... (attempt {attemptNumber})";
    }
    
    private void UpdateCountdown(float secondsRemaining)
    {
        countdownSlider.value = secondsRemaining / 5f; // Assuming 5s delay
        reconnectingText.text = $"Reconnecting in {secondsRemaining:F0}s...";
    }
    
    private void HideReconnecting()
    {
        reconnectingPanel.SetActive(false);
    }
}
```

## Configuration

### Network Session Config

```csharp
[Serializable]
public class NetworkSessionConfig
{
    [Header("Server Settings")]
    public string serverHost = "ws://localhost:8080/app/ws/crossfire";
    public string profileId;
    public string sessionToken;
    
    [Header("Connection Settings")]
    public float reconnectDelay = 5f;
    public bool autoReconnect = true;
    
    [Header("Match Settings")]
    public string matchId;
}
```

### WebRTC Transport Settings

```csharp
[Header("WebRTC Configuration")]
public Mode mode = Mode.REMOTE; // LOCAL bypasses STUN for testing

[Header("Stats Configuration")]
public bool enableStatsCollection = true;
public float statsUpdateInterval = 1f;
public float qualityCheckInterval = 2f;
```

## Local Testing

The TestConnection scene has been set up with a means to log in as "TestPlayer1" or "TestPlayer2". This makes use of the ElementsClient from the [Codegen plugin](https://assetstore.unity.com/packages/tools/integration/namazu-elements-codegen-plugin-for-unity-cross-platform-gbaas-319085). This also assumes that you've created a Matchmaking Configuration under your Application in Elements. In this case, `MATCHMAKING_CONFIGURATION = "default"` which means it's looking for a configuration named `"default"`. 

Using a tool such as [ParallelSync](https://github.com/VeriorPies/ParrelSync) or [Multiplayer Play Mode](https://docs.unity3d.com/Packages/com.unity.multiplayer.playmode@2.0/manual/index.html), you can run two instances of the editor at once. With Elements running Crossfire, run both editor instances and log into a different player on each. Then, the first player to Find or Create a match will be designated the HOST, and the second player to click that button will connect to the first as a CLIENT.

Once connected, the HOST will spawn a TestNetworkObject. Confirm that it appears on the CLIENT editor. Then, from the HOST editor, modify the `Counter` property on the TestNetworkObject, and confirm that the number is the same on the CLIENT.

## Events Reference

### NetworkSessionManager Events

| Event | Description | Parameters |
|-------|-------------|------------|
| `OnMatchJoined` | Fired when successfully joined a match | `string matchId` |
| `OnMatchCreated` | Fired when a new match is created | `string matchId` |
| `OnPlayerJoined` | Player joined the session | `PlayerInfo player` |
| `OnPlayerLeft` | Player left the session | `PlayerInfo player, string reason` |
| `OnPlayerListUpdated` | Player list changed | `List<PlayerInfo> players` |
| `OnHostChanged` | Host migration occurred | `string newHostId, bool wasTransferred` |
| `OnAllPlayersConnected` | All players are connected and ready | - |
| `OnConnectionError` | Connection error occurred | `string error` |

### WebRtcTransportAdapter Events

| Event | Description | Parameters |
|-------|-------------|------------|
| `OnPeerReady` | Peer connection established | `string peerId` |
| `OnPeerDisconnected` | Peer disconnected | `string peerId` |
| `OnConnectionQualityChanged` | Connection quality changed | `string peerId, ConnectionQuality quality` |
| `OnNetworkStatsUpdated` | Network statistics updated | `string peerId, NetworkStats stats` |
| `OnConnectionStateChanged` | Connection state changed | `string peerId, ConnectionState state` |
| `OnConnectionError` | Connection-specific error | `string peerId, string error` |

### Signaling Client Events

| Event | Description | Parameters |
|-------|-------------|------------|
| `OnConnected` | Connected to signaling server | - |
| `OnDisconnected` | Disconnected from signaling server | - |
| `OnReconnectAttempt` | Reconnection attempt started | `int attemptNumber` |
| `OnReconnectCountdown` | Reconnection countdown | `float secondsRemaining` |
| `OnSignalingError` | Signaling error occurred | `string error` |

## Architecture

```
NetworkSessionManager (Main Orchestrator)
├── ISignalingClient (WebSocket communication)
├── INetworkTransportAdapter (WebRTC abstraction)
│   └── WebRtcTransport (Unity WebRTC implementation)
└── NetworkManager (Unity Netcode integration)
```

### Key Components

- **NetworkSessionManager**: Main orchestrator handling session lifecycle and player management
- **WebRtcTransportAdapter**: Abstraction layer providing high-level events from WebRTC transport
- **WebSocketSignalingClient**: Handles signaling server communication with auto-reconnection
- **WebRtcTransport**: Low-level WebRTC transport implementation with stats collection

## Debugging

### Enable Debug Logging

```csharp
// Add to any component for detailed network logs
[SerializeField] private bool enableNetworkLogs = true;

void Start()
{
    if (enableNetworkLogs)
    {
        NetworkLog.LogLevel = NetworkLogLevel.Debug;
    }
}
```

### Stats Monitoring

```csharp
// Monitor network stats in real-time
void Update()
{
    if (Input.GetKeyDown(KeyCode.F1))
    {
        var transport = FindObjectOfType<WebRtcTransportAdapter>();
        foreach (var player in connectedPlayers)
        {
            var stats = transport.GetNetworkStats(player.profileId);
            Debug.Log($"{player.displayName}: {stats.latency}ms, {stats.packetLoss * 100:F1}% loss");
        }
    }
}
```

## Extending the Plugin

### Custom Transport Implementation

```csharp
public class CustomTransportAdapter : MonoBehaviour, INetworkTransportAdapter
{
    // Implement required events and methods
    public event Action<string> OnPeerReady;
    public event Action<string> OnPeerDisconnected;
    // ... other events
    
    public void Initialize(NetworkManager networkManager)
    {
        // Your custom transport initialization
    }
    
    // ... implement other interface methods
}
```

### Custom Signaling Implementation

```csharp
public class CustomSignalingClient : MonoBehaviour, ISignalingClient
{
    // Implement required events and methods for your signaling protocol
}
```

## Best Practices

### Performance
- Enable stats collection only when needed for production builds
- Use appropriate `statsUpdateInterval` (1-2 seconds for most games)
- Clean up event subscriptions in `OnDestroy()`

### Error Handling
- Always subscribe to `OnConnectionError` for robust error handling
- Implement reconnection UI for better user experience
- Handle host migration gracefully in your game logic

### Security
- Validate all signaling messages on your server
- Use secure WebSocket connections (WSS) in production
- Implement proper authentication tokens

## Troubleshooting

### Common Issues

**WebRTC connections fail**
- Check firewall settings and STUN server configuration
- Ensure WebRTC package is properly installed
- Verify signaling server is reachable

**High latency/packet loss**
- Check network quality between peers
- Consider geographic distance between players
- Monitor for background network usage

**Stats not updating**
- Ensure `enableStatsCollection` is true
- Check that WebRTC transport is properly initialized
- Verify Unity WebRTC package version compatibility

## License

This plugin is provided as-is for educational and development purposes. Please ensure you have proper licenses for Unity WebRTC and other dependencies when using in production.

## Contributing

Contributions are welcome! Please follow these guidelines:
- Follow Unity coding conventions
- Add comprehensive documentation for new features
- Include usage examples for new events or APIs
- Test thoroughly with multiple peer configurations

## Support

For issues and questions:
- Check the troubleshooting section first
- Review Unity WebRTC and Netcode documentation
- Open detailed issues with Unity version and error logs