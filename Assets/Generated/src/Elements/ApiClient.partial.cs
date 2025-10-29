
using UnityEngine;
using UnityEngine.Networking;

namespace Elements.Client
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
