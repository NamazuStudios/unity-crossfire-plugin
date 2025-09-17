using Newtonsoft.Json;

namespace Elements.Crossfire.Model
{

    /**
     * A handshake request for finding a match in the Elements Crossfire protocol. This is used when the player does not
     * already have a match ID, and wishes to be assigned into a matchmaking queue. Once found, they will receive a match
     * ID and can then begin exchanging signaling data to establish the peer communication.
     */
    public class FindHandshakeRequest : HandshakeRequest
    {

        //@Pattern(regexp = "\\Q" + VERSION_1_0 + "\\E", message = "Version must be " + VERSION_1_0)
        [JsonProperty]
        private string version = HandshakeRequest.VERSION_1_0;

        [JsonProperty]
        private string profileId;

        [JsonProperty]
        private string sessionKey;

        [JsonProperty]
        private string configuration;

        [JsonProperty]
        private MessageType type = MessageType.FIND;

        public string getVersion()
        {
            return version;
        }

        public void setVersion(string version)
        {
            this.version = version;
        }

        public MessageType getType()
        {
            return type;
        }

        public string getProfileId()
        {
            return profileId;
        }

        public void setProfileId(string profileId)
        {
            this.profileId = profileId;
        }

        public string getConfiguration()
        {
            return configuration;
        }

        public void setConfiguration(string configuration)
        {
            this.configuration = configuration;
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