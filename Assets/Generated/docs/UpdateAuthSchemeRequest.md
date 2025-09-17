# Elements.Model.UpdateAuthSchemeRequest
Represents a request to update an Auth Scheme for an Application.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Audience** | **string** | The JWT audience for the scheme. Must be unique. | 
**Regenerate** | **bool** | If set to true, Elements will regenerate the key and pubKey must be null or omitted | [optional] 
**PublicKey** | **string** | The Base64 public key that was either given or generated during creation. See https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/X509EncodedKeySpec.html for details on the specifics of the format. | [optional] 
**Algorithm** | **string** | The algorithm that Elements will use with the supplied key. | 
**UserLevel** | **string** | The highest permitted user level this particular scheme will authorize. | 
**Tags** | **List&lt;string&gt;** | The list of tags for tagging the auth scheme. | 
**AllowedIssuers** | **List&lt;string&gt;** | The list of issuers allowed to use this scheme. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

