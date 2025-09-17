# Elements.Model.Match
Represents a single one-on-one match between the current player and an opponent.  Once matched, the player will will be able to create a game against the supplied opposing player.  The server may modify or delete matches based on a variety of circumstances.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique ID of the match. | [optional] 
**Scheme** | **string** | The scheme to use when matching with other players. | 
**Scope** | **string** | An optional scope for the match.  For example, if the match were part of a tournament, it could be scoped to the unique ID of the tournament. | [optional] 
**Player** | [**Profile**](Profile.md) |  | 
**Opponent** | [**Profile**](Profile.md) |  | [optional] 
**LastUpdatedTimestamp** | **long** | The time of the last modification of the match. | [optional] 
**GameId** | **string** | The system-assigned game ID of the match.  Null until the match is successfully made. | [optional] 
**Metadata** | **Dictionary&lt;string, Object&gt;** | Additional arbitrary metadata that is attached to the match. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

