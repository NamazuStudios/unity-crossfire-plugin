# Elements.Model.Profile

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique ID of the profile itself. | 
**User** | [**User**](User.md) |  | 
**Application** | [**Application**](Application.md) |  | 
**ImageUrl** | **string** | A URL to the image of the profile.  (ie the User&#39;s Avatar). | [optional] 
**ImageObject** | [**LargeObjectReference**](LargeObjectReference.md) |  | [optional] 
**DisplayName** | **string** | A non-unique display name for this profile. | 
**Metadata** | **Dictionary&lt;string, Object&gt;** | An object containing arbitrary player metadata as key-value pairs. | [optional] 
**LastLogin** | **long** | The last time this profile has been logged in by the user. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

