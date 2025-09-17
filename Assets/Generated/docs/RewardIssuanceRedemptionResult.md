# Elements.Model.RewardIssuanceRedemptionResult
Represents the result of a reward issuance redemption, housing either the resultant RewardIssuance or the error details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RewardIssuanceId** | **string** | The id as originally provided in the request. | [optional] 
**RewardIssuance** | [**RewardIssuance**](RewardIssuance.md) |  | [optional] 
**InventoryItem** | [**InventoryItem**](InventoryItem.md) |  | [optional] 
**ErrorDetails** | **string** | Should the redemption fail, the error details. Otherwise, null. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

