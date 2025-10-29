using Newtonsoft.Json;

namespace Elements.Crossfire.Model
{
    /**
     * Represents a control message in the Crossfire system. Control messages are special messages that are used by clients
     * to communicate control information to the server, such as requests to join or leave a match, or to perform
     * operations such as closing the match.
     */
    public interface ControlMessage : ProtocolMessage
    {

        /***
         * Gets the profile ID associated with this control message. This is the client requesting the control action.
         *
         * @return the profile id
         */
        string GetProfileId();

        /**
         * Indicates if this control message is intended for the host only. If true, the message will only be processed if
         * the requesting participant is the host of the match. If false, the message will be processed for all connections
         * to the match.
         *
         * @return true if host only, false otherwise
         */
        bool IsHostOnly()
        {
            return false;
        }

    }

    public static class ControlMessageExtensions
    {
        public static string ToJsonString<T>(this ControlMessage request)
        {
            var serializerSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                Converters = new System.Collections.Generic.List<JsonConverter> { new Newtonsoft.Json.Converters.StringEnumConverter() }
            };

            return JsonConvert.SerializeObject(request, serializerSettings);
        }
    }
}
