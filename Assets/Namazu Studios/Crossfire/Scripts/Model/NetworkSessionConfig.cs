using System;

namespace Elements.Crossfire.Model
{

    [Serializable]
    public class NetworkSessionConfig
    {
        public string serverHost = "ws://localhost:8080/app/ws/crossfire";
        public string matchId;
        public string profileId;
        public string sessionToken;
        public float reconnectDelay = 5f;
        public bool autoReconnect = true;
    }
}