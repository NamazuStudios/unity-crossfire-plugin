namespace Elements.Crossfire.Model
{
    /**
     * Represents a request for the mode of the WebSocket. The first message sent must be a request type in order to put the
     * socket into the correct mode for processing.
     */
    public interface HandshakeRequest : ProtocolMessage
    {

        /**
         * THe version 1.0 of the Crossfire protocol.
         */
        const string VERSION_1_0 = "V_1_0";

        /**
         * Gets the version of the protocol requested.
         *
         * @return the version of the protocol
         */
        string getVersion();

        /**
         * The profile id of the user making the request
         * @return the profile id
         */
        string getProfileId();

        /**
         * The session key.
         *
         * @return the session key
         */
        string getSessionKey();

    }

    public static class HandshakeRequestExtensions
    {
        public static string ToJsonString<T>(this HandshakeRequest request)
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