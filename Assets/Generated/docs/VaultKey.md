# Elements.Model.VaultKey
The Vault's key. The vault secures each vault with this key.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Algorithm** | **string** | Specifies the private key encryption algorithm used to secure the vault. | 
**PublicKey** | **string** | The public key portion of the vault key. | 
**PrivateKey** | **string** | The private key portion of the vault key. | 
**Encrypted** | **bool** | The flag to indicate if the key is encrypted or not. | [optional] 
**Encryption** | **Dictionary&lt;string, Object&gt;** | The Vault&#39;s encryption metadata. This is specific to the encryption type used. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

