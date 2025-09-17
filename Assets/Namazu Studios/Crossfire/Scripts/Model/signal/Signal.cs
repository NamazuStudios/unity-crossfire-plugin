using Newtonsoft.Json;

namespace Elements.Crossfire.Model
{
    /**
     * Represents a signal in the Crossfire protocol. Signals are used to communicate various events and data among clients.
     */
    public interface Signal : ProtocolMessage
    {

        /**
         * Gets the lifecycle of the signal.
         *
         * @return the lifecycle of the signal
         */
        SignalLifecycle getLifecycle();

    }


    public static class SignalExtensions
    {
        public static string ToJsonString<T>(this Signal request)
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