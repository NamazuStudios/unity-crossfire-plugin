# Elements.Model.FacebookApplicationConfiguration
Houses the various parameters required which allow communication with the Faceook API.  The Facebook API will 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The database assigned ID for the application configuration. | 
**Name** | **string** | The application-configuration specific unique ID. Unique per application per category. | 
**Type** | **string** | The fully-qualified Java type of ApplicationConfiguration. | 
**Description** | **string** |  | 
**Parent** | [**Application**](Application.md) |  | 
**ApplicationId** | **string** | The AppID as it appears in the Facebook Developer Console | 
**ApplicationSecret** | **string** | The App Secret as it appears in the Facebook Developer Console | 
**BuiltinApplicationPermissions** | **List&lt;string&gt;** | The set of built-in permissions connected clients will need to request. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

