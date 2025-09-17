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

#if ELEMENTS_GENERATED
            var json = new Elements.Client.CustomJsonCodec(Elements.Client.ElementsClient.Api.ApiClient.SerializerSettings, Elements.Client.ElementsClient.Api.Configuration);

            return json.Serialize((T)request);
#else
            return Newtonsoft.Json.JsonConvert.SerializeObject(request);
#endif

        }
    }
}