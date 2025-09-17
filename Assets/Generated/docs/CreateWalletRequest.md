# Elements.Model.CreateWalletRequest
Creates a new custodial wallet.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | A user-defined name for the wallet. This is used simply for the user&#39;s reference and has no bearing  onthe wallet&#39;s functionality. | 
**Api** | **string** | The protocol of this wallet. Once set, this cannot be unset. | 
**Networks** | **List&lt;CreateWalletRequest.NetworksEnum&gt;** | The networks associated with this wallet. All must support the Wallet&#39;s protocol. | 
**PreferredAccount** | **int** | The default identity. Must not be larger than the count of identities. | [optional] 
**Accounts** | [**List&lt;CreateWalletRequestAccount&gt;**](CreateWalletRequestAccount.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

