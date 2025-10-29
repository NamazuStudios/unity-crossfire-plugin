using Newtonsoft.Json;

namespace Elements.Crossfire.Model
{
    /**
     * Indicates that the client has successfully connected to a matched.
     */
    public class MatchedResponse : HandshakeResponse
    {

        [JsonProperty]
        private string matchId;

        public MessageType GetMessageType()
        {
            return MessageType.MATCHED;
        }

        /**
         * Returns the matched ID of the connected matched.
         *
         * @return the matched id
         */
        public string getMatchId()
        {
            return matchId;
        }

        public void setMatchId(string matchId)
        {
            this.matchId = matchId;
        }

    }
}