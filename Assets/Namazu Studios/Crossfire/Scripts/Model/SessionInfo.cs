using System;

namespace Elements.Crossfire.Model
{
    [Serializable]
    public class SessionInfo
    {
        public NetworkSessionState state;
        public string profileId;
        public string matchId;
        public bool isHost;
        public int connectedPlayerCount;
        public int totalPlayerCount;
        public bool isNetworkStarted;
        public bool isSignalingConnected;

        public bool IsActive => state != NetworkSessionState.Disconnected;
        public bool IsInMatch => state == NetworkSessionState.InMatch || state == NetworkSessionState.MatchReady;
        public bool CanStartMatch => state == NetworkSessionState.Connected;
        public bool HasError => state == NetworkSessionState.Error;
    }
}