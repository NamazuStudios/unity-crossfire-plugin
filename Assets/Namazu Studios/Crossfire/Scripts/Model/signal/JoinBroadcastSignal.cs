using Newtonsoft.Json;

namespace Elements.Crossfire.Model
{
    /**
     * A signal sent to indicate that a profile is joining a match.
     */
    public class JoinBroadcastSignal : BroadcastSignal
    {
        [JsonProperty]
        private string profileId;

        [JsonProperty]
        private SignalLifecycle lifecycle = SignalLifecycle.MATCH;

        [JsonProperty]
        private MessageType messageType = MessageType.SIGNAL_JOIN;


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