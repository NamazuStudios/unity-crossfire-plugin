# Elements.Model.Progress

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique ID of the progress instance | 
**Profile** | [**Profile**](Profile.md) |  | 
**CurrentStep** | [**Step**](Step.md) |  | [optional] 
**Remaining** | **int** | The remaining actions | [optional] 
**Mission** | [**ProgressMissionInfo**](ProgressMissionInfo.md) |  | 
**RewardIssuances** | [**List&lt;RewardIssuance&gt;**](RewardIssuance.md) | List of all reward issuances that are issued but not expired, or redeemed but persistent. | [optional] 
**Sequence** | **int** | The current number of completed steps. Note that this may exceed the total number of steps, i.e. the final step may be repeated infinitely. | [optional] 
**ManagedBySchedule** | **bool** | Indicates that this progress is managed by a Schedule. If true, the Progress will be deleted when no schedules have the progress active. This will be true if the Progress was created as part of a Schedule. | [optional] 
**Schedules** | [**List&lt;Schedule&gt;**](Schedule.md) | A listing of the Schedules which are managing this Progress. Empty or null if the Progress is not managed as part of a Schedule. | [optional] 
**ScheduleEvents** | [**List&lt;ScheduleEvent&gt;**](ScheduleEvent.md) | A listing of ScheduleEvents which are managing this Progress. Empty or null if the Progress is not managed as part of a Schedule. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

