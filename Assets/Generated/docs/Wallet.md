# Elements.Model.Wallet

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The system assigned unique id of the wallet. | 
**User** | [**User**](User.md) |  | 
**Vault** | [**Vault**](Vault.md) |  | 
**DisplayName** | **string** | The name given to this wallet. | 
**Api** | **string** | The protocol used wiht this wallet. | 
**Networks** | **List&lt;Wallet.NetworksEnum&gt;** | The networks associated with this wallet. | 
**PreferredAccount** | **int** | The default account. Must not be larger than the count of identities. | [optional] 
**Accounts** | [**List&lt;WalletAccount&gt;**](WalletAccount.md) | The list of account pairs included in this wallet. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

