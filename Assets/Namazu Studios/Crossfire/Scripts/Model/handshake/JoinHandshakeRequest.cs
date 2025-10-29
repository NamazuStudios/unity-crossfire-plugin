using Newtonsoft.Json;

namespace Elements.Crossfire.Model
{
    public class JoinHandshakeRequest : HandshakeRequest
    {

        [JsonProperty]
        private string version = HandshakeRequest.VERSION_1_0;

        [JsonProperty]
        private string profileId;

        [JsonProperty]
        private string sessionKey;

        [JsonProperty]
        private string matchId;

        [JsonProperty]
        private MessageType type = MessageType.JOIN;

        public MessageType GetMessageType()
        {
            return type;
        }

        public string getVersion()
        {
            return version;
        }

        public void setVersion(string version)
        {
            this.version = version;
        }

        public string getProfileId()
        {
            return profileId;
        }

        public void setProfileId(string profileId)
        {
            this.profileId = profileId;
        }

        public string getMatchId()
        {
            return matchId;
        }

        public void setMatchId(string matchId)
        {
            this.matchId = matchId;
        }

        public string getSessionKey()
        {
            return sessionKey;
        }

        public void setSessionKey(string sessionKey)
        {
            this.sessionKey = sessionKey;
        }

    }
}