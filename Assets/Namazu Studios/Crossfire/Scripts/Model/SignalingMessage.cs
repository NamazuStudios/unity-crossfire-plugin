using System;

namespace Elements.Crossfire.Model
{

    [Serializable]
    public class SignalingMessage
    {
        public MessageType type;
        public string profileId;
        public string recipientProfileId;
        public string payload;
        public string matchId;
    }
}