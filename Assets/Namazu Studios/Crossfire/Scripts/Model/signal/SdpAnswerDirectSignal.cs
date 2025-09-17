using Newtonsoft.Json;

namespace Elements.Crossfire.Model
{
    public class SdpAnswerDirectSignal : DirectSignal
    {

        [JsonProperty]
        private string profileId;

        [JsonProperty]
        private string recipientProfileId;

        [JsonProperty]
        private string peerSdp;

        [JsonProperty]
        private MessageType type = MessageType.SDP_ANSWER;

        [JsonProperty]
        private SignalLifecycle lifecycle = SignalLifecycle.SESSION;

        public MessageType getType()
        {
            return type;
        }

        public SignalLifecycle getLifecycle()
        {
            return lifecycle;
        }

        public string getPeerSdp()
        {
            return peerSdp;
        }

        public void setPeerSdp(string peerSdp)
        {
            this.peerSdp = peerSdp;
        }

        public string getProfileId()
        {
            return profileId;
        }

        public void setProfileId(string profileId)
        {
            this.profileId = profileId;
        }

        public string getRecipientProfileId()
        {
            return recipientProfileId;
        }

        public void setRecipientProfileId(string recipientProfileId)
        {
            this.recipientProfileId = recipientProfileId;
        }

    }
}