# Elements.Model.SaveDataDocument
Represents an arbitrary save data document that persists on the server. The document saves with a version identifier such that clients may resolve conflicts between the local copy and the remote copy.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The database assigned unique ID of the document. | [optional] 
**Slot** | **int** | The slot of the property. | [optional] 
**User** | [**User**](User.md) |  | [optional] 
**Profile** | [**Profile**](Profile.md) |  | [optional] 
**Timestamp** | **long** | The timestamp of the last write to this document. | [optional] 
**VarVersion** | **string** | The revision of the save data document. | 
**Contents** | **string** | The contents of the save data. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

