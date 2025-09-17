using Newtonsoft.Json;

namespace Elements.Crossfire.Model
{
    public class ConnectBroadcastSignal : BroadcastSignal
    {

        [JsonProperty]
        private string profileId;

        public MessageType getType()
        {
            return MessageType.CONNECT;
        }

        public string getProfileId()
        {
            return profileId;
        }

        public void setProfileId(string profileId)
        {
            this.profileId = profileId;
        }

        public SignalLifecycle getLifecycle()
        {
            return SignalLifecycle.MATCH;
        }

    }
}