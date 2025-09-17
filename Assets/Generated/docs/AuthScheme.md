# Elements.Model.AuthScheme
The full JSON response as described in AuthScheme

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique ID of the auth scheme. | 
**Audience** | **string** | A unique name used to identify the scheme within the instance of Elements. | 
**PublicKey** | **string** | A base-64 encoded string representing an x509 encoded public key. | 
**Algorithm** | **string** | The digital signature matching the public key format. | 
**UserLevel** | **string** | The highest permitted user level this particular scheme will authorize. | 
**Tags** | **List&lt;string&gt;** | The tags used to tag this auth scheme. | 
**AllowedIssuers** | **List&lt;string&gt;** | A list of issuers allowed to use this scheme. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

