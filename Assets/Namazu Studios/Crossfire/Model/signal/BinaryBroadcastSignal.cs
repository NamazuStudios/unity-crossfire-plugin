using Newtonsoft.Json;

namespace Elements.Crossfire.Model
{

    public class BinaryBroadcastSignal : BroadcastSignal
    {

        [JsonProperty]
        private string profileId;

        [JsonProperty]
        private byte[] payload;

        private SignalLifecycle lifecycle = SignalLifecycle.ONCE;

        public MessageType getType()
        {
            return MessageType.BINARY_BROADCAST;
        }

        public string getProfileId()
        {
            return profileId;
        }

        public void setProfileId(string profileId)
        {
            this.profileId = profileId;
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