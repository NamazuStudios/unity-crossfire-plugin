# Elements.Model.UserCreateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | [optional] 
**Email** | **string** |  | [optional] 
**PrimaryPhoneNb** | **string** |  | [optional] 
**FirstName** | **string** |  | [optional] 
**LastName** | **string** |  | [optional] 
**Password** | **string** | The user&#39;s plaintext password, only to be provided in POST/PUT requests in the User Resource REST API interface. In the future, a dedicated REST API model may be constructed instead of using a direct User model. | [optional] 
**Level** | **string** | The user&#39;s level to assign. Depending on the usage, the server may ignore this field and assign its own description. | [optional] 
**Profiles** | [**List&lt;CreateProfileSignupRequest&gt;**](CreateProfileSignupRequest.md) | A list of profiles to assign to this user during creation. The server will attempt to create a profile for each item in this list. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

