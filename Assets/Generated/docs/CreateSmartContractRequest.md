# Elements.Model.CreateSmartContractRequest
Creates a smart contract.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The unique symbolic name of the smart contract. | 
**DisplayName** | **string** | The name given to this contract for display purposes. | 
**Addresses** | [**Dictionary&lt;string, SmartContractAddress&gt;**](SmartContractAddress.md) | The address of the contract from the blockchain. Depending on the network or protocol this may have several meanings and vary depending on the specific API or network. | 
**VaultId** | **string** | The Elements database id of the wallet containing the default account to be used for contract related requests. | 
**Metadata** | **Dictionary&lt;string, Object&gt;** | Any metadata for this contract. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

