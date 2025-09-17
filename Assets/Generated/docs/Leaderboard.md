# Elements.Model.Leaderboard

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**Name** | **string** | The name of the leaderboard.  This must be unique across all leaderboards. | 
**TimeStrategyType** | **string** | The time strategy for the leaderboard. Current options are ALL_TIME and EPOCHAL. | 
**ScoreStrategyType** | **string** | The score strategy for the leaderboard. Current options are OVERWRITE_IF_GREATER and ACCUMULATE. | 
**Title** | **string** | The user-presentable name or title for for the leaderboard. | 
**ScoreUnits** | **string** | The units-of measure for the score type of the leaderboard. | 
**FirstEpochTimestamp** | **long** | The time at which the leaderboard epoch intervals should begin (in ms). If null, then the leaderboard is all-time and not epochal. During creation, if this value is provided, then epochInterval must also be provided. | [optional] 
**EpochInterval** | **long** | The duration for a leaderboard epoch interval (in ms). If null, then the leaderboard is all-time and not epochal. During creation, if this value is provided, then firstEpochTimestamp must also be provided. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

