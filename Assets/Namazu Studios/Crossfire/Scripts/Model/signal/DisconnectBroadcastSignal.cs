using Newtonsoft.Json;

namespace Elements.Crossfire.Model
{
    public class DisconnectBroadcastSignal : BroadcastSignal
    {

        [JsonProperty]
        private string profileId;

        [JsonProperty]
        private SignalLifecycle lifecycle;

        public MessageType GetMessageType()
        {
            return MessageType.DISCONNECT;
        }

        public string GetProfileId()
        {
            return profileId;
        }

        public void setProfileId(string profileId)
        {
            this.profileId = profileId;
        }

        public SignalLifecycle GetLifecycle()
        {
            return lifecycle;
        }

        public void setLifecycle(SignalLifecycle lifecycle)
        {
            this.lifecycle = lifecycle;
        }

    }
}