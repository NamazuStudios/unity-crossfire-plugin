# Elements.Model.CreateVaultRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserId** | **string** | The elements-defined user ID to own the vault. | 
**DisplayName** | **string** | A user-defined name for the vault. This is used simply for the user&#39;s reference and has no bearing  onthe vault&#39;s functionality. | 
**Passphrase** | **string** | The passphrase used to to encrypt the vault. If empty, then the vault will not be encrypted. Some configurations may opt to disallow encryption entirely. | [optional] 
**Algorithm** | **string** | The encryption algorithm used to secure the vault. Once crated, a vault will contains a private/public key pair which will be used to encrypt the wallets within the vault. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

