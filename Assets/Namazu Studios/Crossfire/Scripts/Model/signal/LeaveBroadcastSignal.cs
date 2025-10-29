using Newtonsoft.Json;

namespace Elements.Crossfire.Model
{

    public class LeaveBroadcastSignal : BroadcastSignal
    {
        [JsonProperty]
        private string profileId;

        [JsonProperty]
        private SignalLifecycle lifecycle = SignalLifecycle.MATCH;

        [JsonProperty]
        private MessageType messageType = MessageType.SIGNAL_LEAVE;

        public string GetProfileId()
        {
            return profileId;
        }

        public void SetProfileId(string profileId)
        {
            this.profileId = profileId;
        }


        public SignalLifecycle GetLifecycle()
        {
            return lifecycle;
        }


        public MessageType GetMessageType()
        {
            return messageType;
        }

    }
}