using Newtonsoft.Json;

namespace Elements.Crossfire.Model
{
    public class ConnectBroadcastSignal : BroadcastSignal
    {

        [JsonProperty]
        private string profileId;

        public MessageType GetMessageType()
        {
            return MessageType.CONNECT;
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
            return SignalLifecycle.MATCH;
        }

    }
}