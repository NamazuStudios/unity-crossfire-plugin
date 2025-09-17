# Elements.Model.LargeObject

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique ID of the LargeObject. | 
**Url** | **string** | The URL where the binary contents of the LargeObject may be read. May be null, since Path param or Id is pointer for object. | [optional] 
**Path** | **string** | The path to the file in the underlying bucket. | 
**MimeType** | **string** | The MIME type of the LargeObject. | [optional] 
**AccessPermissions** | [**AccessPermissions**](AccessPermissions.md) |  | 
**State** | **string** | Current state of large object | [optional] 
**LastModified** | **DateTime** | Date of last modification | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

