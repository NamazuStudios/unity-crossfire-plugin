
namespace Elements.Crossfire.Model
{
    public enum NetworkSessionState
    {
        Disconnected,    // No active session
        Connecting,      // Connecting to signaling server
        Connected,       // Connected to signaling, ready for match operations
        FindingMatch,    // Searching for or creating a match
        JoiningMatch,    // Joining a specific match
        InMatch,         // In a match, connecting to peers
        MatchReady,      // All players connected and ready
        Reconnecting,    // Lost connection, attempting to reconnect
        Error            // Error state - requires manual recovery
    }
}