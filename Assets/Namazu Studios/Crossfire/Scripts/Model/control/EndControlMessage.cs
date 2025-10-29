using Newtonsoft.Json;

namespace Elements.Crossfire.Model
{

    public class EndControlMessage : ControlMessage
    {
        [JsonProperty]
        private string profileId;

        [JsonProperty]
        private MessageType type = MessageType.END;

        public string GetProfileId() {
            return profileId;
        }

        public void SetProfileId(string profileId) {
            this.profileId = profileId;
        }

    
        public MessageType GetMessageType() {
            return type;
        }

    }
}