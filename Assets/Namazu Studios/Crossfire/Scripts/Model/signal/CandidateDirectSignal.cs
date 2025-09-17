using Newtonsoft.Json;

namespace Elements.Crossfire.Model
{
    public class CandidateDirectSignal : DirectSignal
    {

        [JsonProperty]
        private string profileId;

        [JsonProperty]
        private string recipientProfileId;

        [JsonProperty]
        private string mid;

        [JsonProperty]
        private string candidate;

        [JsonProperty]
        private MessageType type = MessageType.CANDIDATE;

        public MessageType getType()
        {
            return type;
        }

        public SignalLifecycle getLifecycle()
        {
            return SignalLifecycle.SESSION;
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

        public string getMid()
        {
            return mid;
        }

        public void setMid(string mid)
        {
            this.mid = mid;
        }

        public string getCandidate()
        {
            return candidate;
        }

        public void setCandidate(string candidate)
        {
            this.candidate = candidate;
        }

    }
}