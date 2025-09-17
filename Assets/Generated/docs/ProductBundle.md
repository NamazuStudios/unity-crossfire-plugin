# Elements.Model.ProductBundle

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductId** | **string** | The platform-specific unique SKU/product identifier that, when purchased, will result in the items in this product bundle to be issued to the user. | 
**DisplayName** | **string** | The title of the product bundle to display to end users. | [optional] 
**Description** | **string** | The description of the product bundle to display to end users. | [optional] 
**ProductBundleRewards** | [**List&lt;ProductBundleReward&gt;**](ProductBundleReward.md) | The list of product bundle rewards that will be issued to the user upon purchase. | 
**Metadata** | **Dictionary&lt;string, Object&gt;** | Application-specific metadata. | [optional] 
**Display** | **bool** | Whether or not the frontend should display this product bundle to end users. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

