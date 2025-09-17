# Elements.Model.UpdateVaultRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | A user-defined name for the vault. This is used simply for the user&#39;s reference and has no bearing  onthe vault&#39;s functionality. | 
**UserId** | **string** | The elements-defined user ID to own the vault. | 
**Passphrase** | **string** | The current passphrase for the vault. If left null, no updates to the passphrase will be made. If not-null, then the new password must also not be null. | [optional] 
**NewPassphrase** | **string** | The updated passphrase for the vault. If left null, no updates to the passphrase will be made. If not-null, then the password must also not be null. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

