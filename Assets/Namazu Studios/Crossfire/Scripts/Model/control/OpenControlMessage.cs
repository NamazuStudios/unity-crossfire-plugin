using Newtonsoft.Json;

namespace Elements.Crossfire.Model
{

    public class OpenControlMessage : ControlMessage
    {
        [JsonProperty]
        private string profileId;

        [JsonProperty]
        private MessageType type = MessageType.OPEN;

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

    }
}