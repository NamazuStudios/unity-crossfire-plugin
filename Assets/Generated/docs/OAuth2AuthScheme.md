# Elements.Model.OAuth2AuthScheme
The full JSON response as described in AuthScheme

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique ID of the auth scheme. | 
**Name** | **string** | A unique name used to identify the scheme within the instance of Elements. If using the same OAuth2 provider (e.g. Steam), it is recommended to suffix the name for each application when using multitenancy, e.g. steam_game1, steam_game2, etc. | 
**ValidationUrl** | **string** | The URL to send the user token validation request to. | 
**Headers** | [**List&lt;OAuth2RequestKeyValue&gt;**](OAuth2RequestKeyValue.md) | The headers required for the validation request. | [optional] 
**Params** | [**List&lt;OAuth2RequestKeyValue&gt;**](OAuth2RequestKeyValue.md) | The query parameters required for the validation request. | [optional] 
**ResponseIdMapping** | **string** | Determines how to map the user id in the response. For example \&quot;response.params.steamid\&quot; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

