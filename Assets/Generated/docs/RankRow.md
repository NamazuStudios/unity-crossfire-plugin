# Elements.Model.RankRow

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The ID of the Score | [optional] 
**Position** | **long** | The position of the associated score in the result set. | [optional] 
**PointValue** | **double** | The point value of the score. | [optional] 
**ScoreUnits** | **string** | The the units of measure for the points.  For example, if the points in the game were called \&quot;coins\&quot; instead of \&quot;points\&quot; this would be used to designate as such in the UI. | [optional] 
**CreationTimestamp** | **long** | The time at which the score was created on the server. | [optional] 
**LeaderboardEpoch** | **long** | The epoch to which the score belongs for the associated leaderboard. By convention, if the leaderboard is all-time, this value will be set to zero. | [optional] 
**ProfileId** | **string** | The profile ID of the user who holds this rank. | 
**ProfileDisplayName** | **string** | The profile display name of the user who holds this rank. | 
**ProfileImageUrl** | **string** | The profile image url of the user who holds this rank. | 
**LastLogin** | **long** | The last login. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

