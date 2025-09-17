
using UnityEngine;
using UnityEngine.Networking;

namespace Elements.Client
{
    public partial class ApiClient
    {

        partial void InterceptRequest(UnityWebRequest req, string path, RequestOptions options, IReadableConfiguration configuration){}

        partial void InterceptResponse(UnityWebRequest req, string path, RequestOptions options, IReadableConfiguration configuration, ref object responseData)
        {
            if(responseData != null && responseData.GetType() == typeof(Model.SessionCreation))
            {
                var session = (Model.SessionCreation)responseData;
                ElementsClient.SetSessionCreation(session);
            }
        }

    }

}
