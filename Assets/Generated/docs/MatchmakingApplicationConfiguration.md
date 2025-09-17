# Elements.Model.MatchmakingApplicationConfiguration
This configures the matchmaking system for the application. This defines the queue name and the Matchmacker to use when finding players to match. Currently FIFO is builtin and is the default.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The database assigned ID for the application configuration. | 
**Name** | **string** | The application-configuration specific unique ID. Unique per application per category. | 
**Type** | **string** | The fully-qualified Java type of ApplicationConfiguration. | 
**Description** | **string** |  | 
**Parent** | [**Application**](Application.md) |  | 
**Success** | [**CallbackDefinition**](CallbackDefinition.md) |  | [optional] 
**Matchmaker** | [**ElementServiceReference**](ElementServiceReference.md) |  | [optional] 
**MaxProfiles** | **int** | The maximum number of profiles that can be matched in a single match.  | [optional] 
**Metadata** | **Dictionary&lt;string, Object&gt;** | The metadata for this matchmaking configuration. This will be copied to the match when it is created. | [optional] 
**MetadataSpec** | [**MetadataSpec**](MetadataSpec.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

