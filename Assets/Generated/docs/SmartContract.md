# Elements.Model.SmartContract
Represents a smart contract.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The Elements database id of the contract. | 
**Name** | **string** | The unique symbolic name of the smart contract. | 
**DisplayName** | **string** | The name given to this contract for display purposes. | 
**Addresses** | [**Dictionary&lt;string, SmartContractAddress&gt;**](SmartContractAddress.md) | The addresses of the contract from the blockchain. Depending on the network or protocol this may have several meanings. For example, this may be the script has for the Ethereum network. | 
**Vault** | [**Vault**](Vault.md) |  | 
**Metadata** | **Dictionary&lt;string, Object&gt;** | Any metadata for this contract. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

