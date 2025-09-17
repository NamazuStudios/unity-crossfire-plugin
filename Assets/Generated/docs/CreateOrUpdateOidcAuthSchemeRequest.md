# Elements.Model.CreateOrUpdateOidcAuthSchemeRequest
Represents a request to update an Auth Scheme for an Application.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique ID of the auth scheme. | 
**Issuer** | **string** | A unique name used to identify the scheme within the instance of Elements. When validating from an external source (e.g. Google or Apple SSO), must match the &#39;iss&#39; property of the decoded JWT. | 
**Keys** | [**List&lt;JWK&gt;**](JWK.md) | A set of JWKs containing the keys required to validate JWT signatures. | 
**KeysUrl** | **string** | The URL for the JWK data. Will attempt to refresh keys if the kid cannot be found in the collection. | [optional] 
**MediaType** | **string** | The JWK format. Defaults to application/json | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

