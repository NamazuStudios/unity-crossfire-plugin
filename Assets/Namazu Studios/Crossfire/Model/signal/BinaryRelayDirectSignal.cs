using Newtonsoft.Json;

namespace Elements.Crossfire.Model
{
    public class BinaryRelayDirectSignal : DirectSignal
    {

        [JsonProperty]
        private string profileId;

        [JsonProperty]
        private string recipientProfileId;

        [JsonProperty]
        private byte[] payload;


        private SignalLifecycle lifecycle = SignalLifecycle.ONCE;


        public MessageType getType()
        {
            return MessageType.BINARY_RELAY;
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

        public byte[] getPayload()
        {
            return payload;
        }

        public void setPayload(byte[] payload)
        {
            this.payload = payload;
        }

        public SignalLifecycle getLifecycle()
        {
            return lifecycle;
        }

        public void setLifecycle(SignalLifecycle lifecycle)
        {
            this.lifecycle = lifecycle;
        }

    }
}