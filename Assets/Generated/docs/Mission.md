# Elements.Model.Mission

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique ID of the mission | 
**Name** | **string** | The name of the mission | 
**DisplayName** | **string** | The display name for the mission | 
**Description** | **string** | The description of the mission | 
**Tags** | **List&lt;string&gt;** | The tags used to categorize this mission | [optional] 
**Steps** | [**List&lt;Step&gt;**](Step.md) | The steps that constitute the mission (may be null if finalRepeatStep is specified) | [optional] 
**FinalRepeatStep** | [**Step**](Step.md) |  | [optional] 
**Metadata** | **Dictionary&lt;string, Object&gt;** | The metadata for this mission | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

