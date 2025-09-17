# Elements.Model.CreateSaveDataDocumentRequest
Used to create a save data document on the remote.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Slot** | **int** | The slot of the property. Must be unique for user or profile. | 
**UserId** | **string** | The id of the user which owns the save data. If specified, the user will own this save data and the profileId must be null or be owned by the user specified. | [optional] 
**ProfileId** | **string** | The id of the profile which owns the save data. If specified, the profile will own this save data and the userId must be null or be owned by the user specified. | [optional] 
**Contents** | **string** | The contents of the save data. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

