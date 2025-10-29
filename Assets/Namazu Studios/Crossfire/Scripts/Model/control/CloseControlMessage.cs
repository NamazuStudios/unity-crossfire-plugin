using Newtonsoft.Json;

namespace Elements.Crossfire.Model
{
    public class CloseControlMessage : ControlMessage
    {
        [JsonProperty]
        private string profileId;

        [JsonProperty]
        private MessageType type = MessageType.CLOSE;

        public string GetProfileId()
        {
            return profileId;
        }

        public void SetProfileId(string profileId)
        {
            this.profileId = profileId;
        }

        public MessageType GetMessageType()
        {
            return type;
        }

        public bool IsHostOnly()
        {
            return true;
        }
    }
}