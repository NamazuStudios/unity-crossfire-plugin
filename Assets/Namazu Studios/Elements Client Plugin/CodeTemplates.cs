#if UNITY_EDITOR

namespace Elements.Codegen
{

    public class CodeTemplates
    {

        public string apiClientHookTemplate = @"
using UnityEngine;
using UnityEngine.Networking;

namespace {namespace}.Client
{
    public partial class ApiClient
    {

        /// <summary>
        /// The instance of the ElementsClient that owns this instance of ApiClient
        /// </summary>
        public ElementsClient Owner { get; set; }

        partial void InterceptRequest(UnityWebRequest req, string path, RequestOptions options, IReadableConfiguration configuration){}

        partial void InterceptResponse(UnityWebRequest req, string path, RequestOptions options, IReadableConfiguration configuration, ref object responseData)
        {
            if(responseData != null && responseData.GetType() == typeof(Model.SessionCreation))
            {
                var session = (Model.SessionCreation)responseData;
                Owner?.SetSessionCreation(session);
            }
        }

    }

}
";

        public string elementsClientTemplate = @"
using UnityEngine;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

namespace {namespace}.Client
{

     public class ElementsClient
    {

        /// <summary>
        /// A global ""default"" client for convenience
        /// </summary>
        public static ElementsClient Default { get; private set; }

        public Api.DefaultApi Api => api;

        private readonly Api.DefaultApi api;
        private Model.Session session;
        private string sessionToken;
        private readonly bool shouldCacheSession;
        private readonly string cacheKey;

        public const string AUTH_HEADER = ""Elements-SessionSecret"";

        /// <summary>
        /// Creates a new ElementsClient.
        /// </summary>
        /// <param name=""rootUrl"">The root URL of your Elements instance.</param>
        /// <param name=""cacheSession"">If true, will attempt to load/save session data from disk.</param>
        /// <param name=""cacheKey"">Optional key to separate cache files when managing multiple sessions.
        /// Ensure that this is different for each instance of ElementsClient, but the same across sessions for the same player(s)</param>
        public ElementsClient(string rootUrl, bool cacheSession = true, string cacheKey = ""default"")
        {
            api = new Api.DefaultApi(rootUrl);

            // Make sure the generated ApiClient knows who owns it
            if (api.ApiClient is ApiClient elementsApiClient)
            {
                elementsApiClient.Owner = this;
            }

            api.ApiClient.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
            api.ApiClient.SerializerSettings.MissingMemberHandling = MissingMemberHandling.Ignore;
            api.ApiClient.SerializerSettings.Converters = new List<JsonConverter>
            {
                new Newtonsoft.Json.Converters.StringEnumConverter()
            };

            // Ignore deserialization errors for null/missing values
            api.ApiClient.SerializerSettings.Error = (sender, errorArgs) =>
            {
                errorArgs.ErrorContext.Handled = true;
            };

            shouldCacheSession = cacheSession;
            this.cacheKey = cacheKey;

            if (cacheSession)
            {
                LoadSessionData();
            }
        }

        /// <summary>
        /// Initializes a ""default"" static instance for convenience.
        /// Useful when you know that there will only ever be a single session for a single user at a time.
        /// </summary>
        /// <param name=""rootUrl"">The root URL of your Elements instance.</param>
        /// <param name=""cacheSession"">If true, will attempt to load/save session data from disk.</param>
        public static void InitializeDefault(string rootUrl, bool cacheSession = true)
        {
            if (Default == null)
            {
                Default = new ElementsClient(rootUrl, cacheSession);
            }
        }

        /// <summary>
        /// Sets the SessionCreation object, which will cache the session info
        /// and assign to the appropriate auth header(s)
        /// </summary>
        /// <param name=""sessionCreation"">The SessionCreation object</param>
        public void SetSessionCreation(Model.SessionCreation sessionCreation)
        {
            session = sessionCreation.Session;
            sessionToken = sessionCreation.SessionSecret;
            SetSessionHeader();

            if (shouldCacheSession)
            {
                SaveSessionData();
            }
        }

        /// <summary>
        /// Sets the Session object.
        /// </summary>
        /// <param name=""s""></param>
        public void SetSession(Model.Session s)
        {
            session = s;

            if (shouldCacheSession)
            {
                SaveSessionData();
            }
        }

        public Model.Session GetSession() => session;

        public string GetSessionToken() => sessionToken;

        /// <summary>
        /// Sets the Profile. This will update the Session and any auth header(s)
        /// </summary>
        /// <param name=""p""></param>
        public void SetProfile(Model.Profile p)
        {
            if (session == null)
            {
                Debug.LogWarning(""No session set when trying to set profile."");
                return;
            }

            session.Profile = p;

            if (shouldCacheSession)
            {
                SaveSessionData();
            }
        }

        /// <summary>
        /// Do we have a session object in memory, and has it expired?
        /// </summary>
        /// <returns>true if the session is created and valid</returns>
        public bool IsSessionActive()
        {
            return session != null && session.Expiry > System.DateTimeOffset.Now.ToUnixTimeMilliseconds();
        }

        /// <summary>
        /// Clears the Session, session secret, and any auth header(s) from memory.
        /// Also, deletes any cached session info from disk
        /// </summary>
        public void ClearSession()
        {
            LogOut();
            DeleteSessionData();
        }

        /// <summary>
        /// Clears the Session, session secret, and any auth header(s) from memory
        /// </summary>
        public void LogOut()
        {
            session = null;
            sessionToken = null;
            api.Configuration.ApiKey[AUTH_HEADER] = null;
        }

        // Caching support
        private string GetSessionCachePath()
        {
            // Each cacheKey gets its own file to support multiple clients
            return Path.Combine(Application.persistentDataPath, $""ElementsSessionCache_{cacheKey}.json"");
        }

        private void SaveSessionData()
        {
            var sessionCreationData = new Model.SessionCreation
            {
                Session = session,
                SessionSecret = sessionToken
            };

            var json = JsonConvert.SerializeObject(sessionCreationData);
            File.WriteAllText(GetSessionCachePath(), json);
        }

        private void LoadSessionData()
        {
            var path = GetSessionCachePath();

            if (File.Exists(path))
            {
                var text = File.ReadAllText(path);
                var sessionCreation = JsonConvert.DeserializeObject<Model.SessionCreation>(text);

                session = sessionCreation.Session;
                sessionToken = sessionCreation.SessionSecret;

                if (IsSessionActive())
                {
                    SetSessionHeader();
                }
            }
        }

        private void DeleteSessionData()
        {
            var path = GetSessionCachePath();

            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        private void SetSessionHeader()
        {
            if (session == null || sessionToken == null) return;

            api.Configuration.ApiKey[AUTH_HEADER] = session.Profile?.Id != null ? sessionToken + "" p"" + session.Profile.Id : sessionToken;
        }
    }
}
";

    }



}

#endif