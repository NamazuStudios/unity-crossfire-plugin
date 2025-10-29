# Elements.Model.MultiMatch
Represents a multi-match in the matchmaking system.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique ID of the match. | [optional] 
**Status** | **string** | The status of the match. | [optional] 
**VarConfiguration** | [**MatchmakingApplicationConfiguration**](MatchmakingApplicationConfiguration.md) |  | 
**Metadata** | **Dictionary&lt;string, Object&gt;** | The metadata of hte multi-match, which can be used to store additional information about the match. | [optional] 
**Count** | **int** | The number of players currently in the match. | [optional] 
**Expiry** | **long** | The expiry time of the match in seconds. If not set, the match will not expire. | [optional] 
**Created** | **long** | The timestamp at which the match was created, in milliseconds since epoch. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

