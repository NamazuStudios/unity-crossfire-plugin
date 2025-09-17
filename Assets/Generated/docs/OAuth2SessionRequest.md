# Elements.Model.OAuth2SessionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SchemeId** | **string** | The OAuth2 scheme ID to use. | 
**RequestParameters** | **Dictionary&lt;string, string&gt;** | The request parameters to be used in the token validation request. This should adhere to any params marked as fromClient in the auth scheme. | [optional] 
**RequestHeaders** | **Dictionary&lt;string, string&gt;** | The request headers to be used in the token validation request. This should adhere to any headers marked as fromClient in the auth scheme. | [optional] 
**ProfileId** | **string** | The profile ID to assign to the session. | [optional] 
**ProfileSelector** | **string** | A query string to select the profile to use. NOTE: This will not be run if a profileId is specified. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

