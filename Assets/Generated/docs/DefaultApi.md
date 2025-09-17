# Elements.Api.DefaultApi

All URIs are relative to *http://localhost:8080/api/rest*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AdjustAdvancedInventoryItemQuantity**](DefaultApi.md#adjustadvancedinventoryitemquantity) | **PATCH** /inventory/advanced/{inventoryItemId} | Adjust the quantity of the inventory item for the specified item. |
| [**AdjustSimpleInventoryItemQuantity**](DefaultApi.md#adjustsimpleinventoryitemquantity) | **PATCH** /inventory/simple/{inventoryItemId} | Adjust the quantity of the inventory item for the specified item. |
| [**BlacklistSession**](DefaultApi.md#blacklistsession) | **DELETE** /session/{sessionSecret} | Destroys the Session |
| [**BuildIndexes**](DefaultApi.md#buildindexes) | **POST** /index/build | Builds all indexes. |
| [**CreateAdvancedInventoryItem**](DefaultApi.md#createadvancedinventoryitem) | **POST** /inventory/advanced | Create an inventory item for the specified item |
| [**CreateApplication**](DefaultApi.md#createapplication) | **POST** /application | Creates a New Application |
| [**CreateAuthScheme**](DefaultApi.md#createauthscheme) | **POST** /auth_scheme/custom | Creates a new Auth Scheme |
| [**CreateAuthScheme1**](DefaultApi.md#createauthscheme1) | **POST** /auth_scheme/oauth2 | Creates a new Auth Scheme |
| [**CreateAuthScheme2**](DefaultApi.md#createauthscheme2) | **POST** /auth_scheme/oidc | Creates a new Auth Scheme |
| [**CreateDistinctInventoryItem**](DefaultApi.md#createdistinctinventoryitem) | **POST** /inventory/distinct | Create an inventory item for the specified item |
| [**CreateFCMRegistration**](DefaultApi.md#createfcmregistration) | **POST** /notification/fcm | Creates an FCM Registration Token |
| [**CreateFacebookApplicationConfiguration**](DefaultApi.md#createfacebookapplicationconfiguration) | **POST** /application/{applicationNameOrId}/configuration/facebook | Creates a new Facebook ApplicationConfiguration |
| [**CreateFirebaseApplicationConfiguration**](DefaultApi.md#createfirebaseapplicationconfiguration) | **POST** /application/{applicationNameOrId}/configuration/firebase | Creates a new Firebase ApplicationConfiguration |
| [**CreateFollower**](DefaultApi.md#createfollower) | **POST** /follower/{profileId} | Creates a Follower relationship between two profiles. |
| [**CreateGooglePlayApplicationConfiguration**](DefaultApi.md#creategoogleplayapplicationconfiguration) | **POST** /application/{applicationNameOrId}/configuration/google_play | Creates a new Google Play ApplicationConfiguration |
| [**CreateIosApplicationConfiguration**](DefaultApi.md#createiosapplicationconfiguration) | **POST** /application/{applicationNameOrId}/configuration/ios | Creates a new iOS ApplicationConfiguration |
| [**CreateItem**](DefaultApi.md#createitem) | **POST** /item | Creates a new digital Item |
| [**CreateLargeObject**](DefaultApi.md#createlargeobject) | **POST** /large_object_mp | Creates a LargeObject with content |
| [**CreateLargeObject1**](DefaultApi.md#createlargeobject1) | **POST** /large_object | Creates a LargeObject |
| [**CreateLargeObjectFromUrl**](DefaultApi.md#createlargeobjectfromurl) | **POST** /large_object/from_url | Creates a LargeObject from provided URL |
| [**CreateLeaderboard**](DefaultApi.md#createleaderboard) | **POST** /leaderboard | Creates a New Leaderboard |
| [**CreateMatch**](DefaultApi.md#creatematch) | **POST** /match | Creates a Match |
| [**CreateMatchmakingApplicationConfiguration**](DefaultApi.md#creatematchmakingapplicationconfiguration) | **POST** /application/{applicationNameOrId}/configuration/matchmaking | Creates a new iOS ApplicationConfiguration |
| [**CreateMetadata**](DefaultApi.md#createmetadata) | **POST** /metadata | Creates a new Metadata object |
| [**CreateMetadataSpec**](DefaultApi.md#createmetadataspec) | **POST** /metadata_spec | Creates a new Metadata Spec definition |
| [**CreateMission**](DefaultApi.md#createmission) | **POST** /mission | Creates a new mission |
| [**CreateMockSession**](DefaultApi.md#createmocksession) | **POST** /mock_session | Creates a Mock Session |
| [**CreateNewDeployment**](DefaultApi.md#createnewdeployment) | **POST** /deployment/{applicationId} |  |
| [**CreateOAuth2Session**](DefaultApi.md#createoauth2session) | **POST** /auth/oauth2 | Creates a Session using OAuth2 |
| [**CreateOidcSession**](DefaultApi.md#createoidcsession) | **POST** /auth/oidc | Creates a Session using OIDC |
| [**CreatePSNApplicationConfiguration**](DefaultApi.md#createpsnapplicationconfiguration) | **POST** /application/{applicationNameOrId}/configuration/psn | Creates a new PSN ApplicationConfiguration |
| [**CreateProfile**](DefaultApi.md#createprofile) | **POST** /profile | Creates a Profile |
| [**CreateProgress**](DefaultApi.md#createprogress) | **POST** /progress | Creates a new progress |
| [**CreateSaveDocument**](DefaultApi.md#createsavedocument) | **POST** /save_data | Creates a save data document. |
| [**CreateSchedule**](DefaultApi.md#createschedule) | **POST** /schedule | Creates a new schedule |
| [**CreateScheduleEvent**](DefaultApi.md#createscheduleevent) | **POST** /schedule/{scheduleNameOrId}/event | Creates a new schedule |
| [**CreateScore**](DefaultApi.md#createscore) | **POST** /score/{leaderboardNameOrId} | Creates a New Score |
| [**CreateSimpleInventoryItem**](DefaultApi.md#createsimpleinventoryitem) | **POST** /inventory/simple | Create an inventory item for the specified item |
| [**CreateSmartContract**](DefaultApi.md#createsmartcontract) | **POST** /blockchain/omni/smart_contract | Patches a  Smart Contract |
| [**CreateUser**](DefaultApi.md#createuser) | **POST** /user | Creates a User |
| [**CreateUsernamePasswordSession**](DefaultApi.md#createusernamepasswordsession) | **POST** /session | Creates a Session |
| [**CreateVault**](DefaultApi.md#createvault) | **POST** /blockchain/omni/vault | Creates a new  Vault |
| [**CreateWallet**](DefaultApi.md#createwallet) | **POST** /blockchain/omni/vault/{vaultId}/wallet | Creates a new  Wallet |
| [**DeactivateProfile**](DefaultApi.md#deactivateprofile) | **DELETE** /profile/{profileId} | Deletes a Profile |
| [**DeactivateUser**](DefaultApi.md#deactivateuser) | **DELETE** /user/{name} | Deletes a User |
| [**DeleteAdvancedInventoryItem**](DefaultApi.md#deleteadvancedinventoryitem) | **DELETE** /inventory/advanced/{inventoryItemId} | Delete the inventory item as identified by the given item name/id |
| [**DeleteApplication**](DefaultApi.md#deleteapplication) | **DELETE** /application/{nameOrId} | Deletes an Application |
| [**DeleteAuthScheme**](DefaultApi.md#deleteauthscheme) | **DELETE** /auth_scheme/custom/{authSchemeId} | Deletes an Auth Scheme |
| [**DeleteAuthScheme1**](DefaultApi.md#deleteauthscheme1) | **DELETE** /auth_scheme/oauth2/{oAuth2AuthSchemeId} | Deletes an Auth Scheme |
| [**DeleteAuthScheme2**](DefaultApi.md#deleteauthscheme2) | **DELETE** /auth_scheme/oidc/{oidcAuthSchemeId} | Deletes an Auth Scheme |
| [**DeleteContract**](DefaultApi.md#deletecontract) | **DELETE** /blockchain/omni/smart_contract/{contractId} | Deletes a  Smart Contract |
| [**DeleteDeployment**](DefaultApi.md#deletedeployment) | **DELETE** /deployment/{applicationId}/{deploymentId} |  |
| [**DeleteDistinctInventoryItem**](DefaultApi.md#deletedistinctinventoryitem) | **DELETE** /inventory/distinct/{distinctInventoryItemId} | Delete the inventory item as identified by the given item name/id |
| [**DeleteFCMRegistration**](DefaultApi.md#deletefcmregistration) | **DELETE** /notification/fcm/{fcmRegistrationId} |  |
| [**DeleteFacebookApplicationConfiguration**](DefaultApi.md#deletefacebookapplicationconfiguration) | **DELETE** /application/{applicationNameOrId}/configuration/facebook/{applicationConfigurationNameOrId} | Deletes a Facebook ApplicationConfiguration |
| [**DeleteFirebaseApplicationConfiguration**](DefaultApi.md#deletefirebaseapplicationconfiguration) | **DELETE** /application/{applicationNameOrId}/configuration/firebase/{applicationConfigurationNameOrId} | Deletes a Firebase ApplicationConfiguration |
| [**DeleteFollower**](DefaultApi.md#deletefollower) | **DELETE** /follower/{profileId}/{profileToUnfollowId} | Deletes a Follower relationship |
| [**DeleteFriendRegistration**](DefaultApi.md#deletefriendregistration) | **DELETE** /friend/{friendId} | Deletes a Friend |
| [**DeleteGooglePlayApplicationConfiguration**](DefaultApi.md#deletegoogleplayapplicationconfiguration) | **DELETE** /application/{applicationNameOrId}/configuration/google_play/{applicationConfigurationNameOrId} | Deletes a Google Play ApplicationConfiguration |
| [**DeleteIosApplicationConfiguration**](DefaultApi.md#deleteiosapplicationconfiguration) | **DELETE** /application/{applicationNameOrId}/configuration/ios/{applicationConfigurationNameOrId} | Deletes a iOS ApplicationConfiguration |
| [**DeleteLargeObject**](DefaultApi.md#deletelargeobject) | **DELETE** /large_object/{largeObjectId} | Deletes a LargeObject |
| [**DeleteLeaderboard**](DefaultApi.md#deleteleaderboard) | **DELETE** /leaderboard/{nameOrId} | Deletes an Leaderboard |
| [**DeleteMatch**](DefaultApi.md#deletematch) | **DELETE** /match/{matchId} | Deletes a Match |
| [**DeleteMatchmakingApplicationConfiguration**](DefaultApi.md#deletematchmakingapplicationconfiguration) | **DELETE** /application/{applicationNameOrId}/configuration/matchmaking/{applicationConfigurationNameOrId} | Deletes a iOS ApplicationConfiguration |
| [**DeleteMetadata**](DefaultApi.md#deletemetadata) | **DELETE** /metadata/{id} | Deletes a specific Metadata object |
| [**DeleteMetadataSpec**](DefaultApi.md#deletemetadataspec) | **DELETE** /metadata_spec/{metadataSpecId} | Deletes a MetadataSpec |
| [**DeleteMission**](DefaultApi.md#deletemission) | **DELETE** /mission/{missionNameOrId} | Deletes the Mission identified by id or by name |
| [**DeletePSNApplicationConfiguration**](DefaultApi.md#deletepsnapplicationconfiguration) | **DELETE** /application/{applicationNameOrId}/configuration/psn/{applicationConfigurationNameOrId} | Deletes a PSN ApplicationConfiguration |
| [**DeleteProgress**](DefaultApi.md#deleteprogress) | **DELETE** /progress/progress/{progressId} | Deletes the Progress identified by id |
| [**DeleteSaveDocument**](DefaultApi.md#deletesavedocument) | **DELETE** /save_data/{saveDataDocumentId} | Deletes a save data document |
| [**DeleteSchedule**](DefaultApi.md#deleteschedule) | **DELETE** /schedule/{scheduleNameOrId} | Deletes the Schedule identified by id or by name |
| [**DeleteScheduleEvent**](DefaultApi.md#deletescheduleevent) | **DELETE** /schedule/{scheduleNameOrId}/event/{scheduleEventId} | Deletes the ScheduleEvent identified by id or by name |
| [**DeleteSimpleInventoryItem**](DefaultApi.md#deletesimpleinventoryitem) | **DELETE** /inventory/simple/{inventoryItemId} | Delete the inventory item as identified by the given item name/id |
| [**DeleteVault**](DefaultApi.md#deletevault) | **DELETE** /blockchain/omni/vault/{vaultId} | Deletes a  Vault |
| [**DeleteWallet**](DefaultApi.md#deletewallet) | **DELETE** /blockchain/omni/vault/{vaultId}/wallet/{walletId} | Deletes a  Wallet |
| [**GenerateCode**](DefaultApi.md#generatecode) | **POST** /codegen | Generate Client API Code |
| [**GetAdvancedInventoryItem**](DefaultApi.md#getadvancedinventoryitem) | **GET** /inventory/advanced/{inventoryItemId} | Gets inventory item for the specified item |
| [**GetAdvancedInventoryItems**](DefaultApi.md#getadvancedinventoryitems) | **GET** /inventory/advanced | Search inventory items |
| [**GetApplication**](DefaultApi.md#getapplication) | **GET** /application/{nameOrId} | Get an Application |
| [**GetApplicationProfiles**](DefaultApi.md#getapplicationprofiles) | **GET** /application/{applicationNameOrId}/configuration | Searches application profiles |
| [**GetApplications**](DefaultApi.md#getapplications) | **GET** /application | Search Applications |
| [**GetAuthScheme**](DefaultApi.md#getauthscheme) | **GET** /auth_scheme/custom/{authSchemeId} | Gets a specific Auth Scheme |
| [**GetAuthScheme1**](DefaultApi.md#getauthscheme1) | **GET** /auth_scheme/oauth2/{oAuth2AuthSchemeId} | Gets a specific Auth Scheme |
| [**GetAuthScheme2**](DefaultApi.md#getauthscheme2) | **GET** /auth_scheme/oidc/{oidcAuthSchemeId} | Gets a specific Auth Scheme |
| [**GetAuthSchemes**](DefaultApi.md#getauthschemes) | **GET** /auth_scheme/custom | Lists all auth schemes in the system |
| [**GetAuthSchemes1**](DefaultApi.md#getauthschemes1) | **GET** /auth_scheme/oauth2 | Lists all auth schemes in the system |
| [**GetAuthSchemes2**](DefaultApi.md#getauthschemes2) | **GET** /auth_scheme/oidc | Lists all auth schemes in the system |
| [**GetCurrentDeployment**](DefaultApi.md#getcurrentdeployment) | **GET** /deployment/{applicationId}/current |  |
| [**GetCurrentProfile**](DefaultApi.md#getcurrentprofile) | **GET** /profile/current | Gets the current Profile |
| [**GetCurrentUser**](DefaultApi.md#getcurrentuser) | **GET** /user/me | Gets the current User |
| [**GetDeployment**](DefaultApi.md#getdeployment) | **GET** /deployment/{applicationId}/{deploymentId} |  |
| [**GetDeployments**](DefaultApi.md#getdeployments) | **GET** /deployment/{applicationId} |  |
| [**GetDistinctInventoryItem**](DefaultApi.md#getdistinctinventoryitem) | **GET** /inventory/distinct/{inventoryItemId} | Gets inventory item for the specified item |
| [**GetDistinctInventoryItems**](DefaultApi.md#getdistinctinventoryitems) | **GET** /inventory/distinct | Search inventory items |
| [**GetEditorSchema**](DefaultApi.md#geteditorschema) | **GET** /metadata_spec/{metadataSpecName}/editor.json | Gets a specific Metadata Editor Schema |
| [**GetFacebookApplicationConfiguration**](DefaultApi.md#getfacebookapplicationconfiguration) | **GET** /application/{applicationNameOrId}/configuration/facebook/{applicationConfigurationNameOrId} | Gets a Facebook Application Configuration |
| [**GetFirebaseApplicationConfiguration**](DefaultApi.md#getfirebaseapplicationconfiguration) | **GET** /application/{applicationNameOrId}/configuration/firebase/{applicationConfigurationNameOrId} | Gets a Firebase Application Configuration |
| [**GetFollower**](DefaultApi.md#getfollower) | **GET** /follower/{profileId}/{followedId} | Gets a specific profile using the ID of the profile and followed id. |
| [**GetFollowers**](DefaultApi.md#getfollowers) | **GET** /followee/{profileId} | Search Followers |
| [**GetFollowers1**](DefaultApi.md#getfollowers1) | **GET** /follower/{profileId} | Search Followers |
| [**GetFriend**](DefaultApi.md#getfriend) | **GET** /friend/{friendId} | Gets a Specific Friend |
| [**GetFriends**](DefaultApi.md#getfriends) | **GET** /friend | Search Friends |
| [**GetGlobalRankTabular**](DefaultApi.md#getglobalranktabular) | **GET** /rank/global/{leaderboardNameOrId} | Gets Rank Among all Players |
| [**GetGooglePlayApplicationConfiguration**](DefaultApi.md#getgoogleplayapplicationconfiguration) | **GET** /application/{applicationNameOrId}/configuration/google_play/{applicationConfigurationNameOrId} | Gets a Google Play Application Configuration |
| [**GetIosApplicationConfiguration**](DefaultApi.md#getiosapplicationconfiguration) | **GET** /application/{applicationNameOrId}/configuration/ios/{applicationConfigurationNameOrId} | Gets a iOS Application Configuration |
| [**GetItemByIdentifier**](DefaultApi.md#getitembyidentifier) | **GET** /item/{identifier} | Retrieves a single Item by id or by name |
| [**GetItems**](DefaultApi.md#getitems) | **GET** /item | Retrieves all Items |
| [**GetJsonSchema**](DefaultApi.md#getjsonschema) | **GET** /metadata_spec/{metadataSpecName}/schema.json | Gets a specific JSON Schema |
| [**GetLargeObject**](DefaultApi.md#getlargeobject) | **GET** /large_object/{largeObjectId} | Get a LargeObject |
| [**GetLeaderboard**](DefaultApi.md#getleaderboard) | **GET** /leaderboard/{nameOrId} | Get an Leaderboard |
| [**GetLeaderboards**](DefaultApi.md#getleaderboards) | **GET** /leaderboard | Search Leaderboards |
| [**GetMatch**](DefaultApi.md#getmatch) | **GET** /match/{matchId} | Gets a Specific Match |
| [**GetMatchedUserProfilesWithPhoneNumbers**](DefaultApi.md#getmatcheduserprofileswithphonenumbers) | **POST** /invite | Match normalized phone numbers with requested list |
| [**GetMatches**](DefaultApi.md#getmatches) | **GET** /match | List Matches |
| [**GetMatchmakingApplicationConfiguration**](DefaultApi.md#getmatchmakingapplicationconfiguration) | **GET** /application/{applicationNameOrId}/configuration/matchmaking/{applicationConfigurationNameOrId} | Gets a iOS Application Configuration |
| [**GetMetadataObject**](DefaultApi.md#getmetadataobject) | **GET** /metadata/{id} | Gets a specific Metadata object |
| [**GetMetadataObjects**](DefaultApi.md#getmetadataobjects) | **GET** /metadata | Search Metadata |
| [**GetMetadataSpec**](DefaultApi.md#getmetadataspec) | **GET** /metadata_spec/{metadataSpecNameOrId} | Gets a specific Metadata Spec |
| [**GetMetadataSpecs**](DefaultApi.md#getmetadataspecs) | **GET** /metadata_spec | Get Metadata Specs |
| [**GetMissionByNameOrId**](DefaultApi.md#getmissionbynameorid) | **GET** /mission/{missionNameOrId} | Retrieves a single Mission by id or by name |
| [**GetMissions**](DefaultApi.md#getmissions) | **GET** /mission | Search Missions |
| [**GetPSNApplicationConfiguration**](DefaultApi.md#getpsnapplicationconfiguration) | **GET** /application/{applicationNameOrId}/configuration/psn/{applicationConfigurationNameOrId} | Gets a PSN Application Configuration |
| [**GetPlans**](DefaultApi.md#getplans) | **GET** /index/plan | Gets all index plans. |
| [**GetProfile**](DefaultApi.md#getprofile) | **GET** /profile/{name} | Gets a Specific Profile |
| [**GetProfileSaveDataDocumentBySlot**](DefaultApi.md#getprofilesavedatadocumentbyslot) | **GET** /save_data/profile/{profileId}/{slot} | Get save data document. |
| [**GetProfiles**](DefaultApi.md#getprofiles) | **GET** /profile | Search Profiles |
| [**GetProgressByNameOrId**](DefaultApi.md#getprogressbynameorid) | **GET** /progress/{progressId} | Retrieves a single Progress by id |
| [**GetProgressTabular**](DefaultApi.md#getprogresstabular) | **GET** /progress | Gets Rank Among all Players |
| [**GetRankAmongFriends**](DefaultApi.md#getrankamongfriends) | **GET** /rank/friends/{leaderboardNameOrId} | Gets Rank among Friends |
| [**GetRankAmongMutualFollowers**](DefaultApi.md#getrankamongmutualfollowers) | **GET** /rank/mutual_followers/{leaderboardNameOrId} | Gets Rank among Mutual Followers |
| [**GetRewardIssuance**](DefaultApi.md#getrewardissuance) | **GET** /reward_issuance/{rewardIssuanceId} | Retrieves a single RewardIssuance by id. |
| [**GetRewardIssuances**](DefaultApi.md#getrewardissuances) | **GET** /reward_issuance | Retrieves the current user&#39;s reward issuances, optionally filtered by the given state. |
| [**GetSaveDataDocument**](DefaultApi.md#getsavedatadocument) | **GET** /save_data/{id} | Get save data document. |
| [**GetSaveDataDocuments**](DefaultApi.md#getsavedatadocuments) | **GET** /save_data | Search Save Data Documents |
| [**GetScheduleByNameOrId**](DefaultApi.md#getschedulebynameorid) | **GET** /schedule/{scheduleNameOrId} | Retrieves a single Schedule by id or by name |
| [**GetScheduleEventByNameOrId**](DefaultApi.md#getscheduleeventbynameorid) | **GET** /schedule/{scheduleNameOrId}/event/{scheduleEventId} | Retrieves a single ScheduleEvent by id or by name |
| [**GetScheduleEvents**](DefaultApi.md#getscheduleevents) | **GET** /schedule/{scheduleNameOrId}/event | Search ScheduleEvents |
| [**GetScheduleProgresses**](DefaultApi.md#getscheduleprogresses) | **GET** /schedule/{scheduleNameOrId}/progress | Gets all Progresses assigned via this schedule |
| [**GetSchedules**](DefaultApi.md#getschedules) | **GET** /schedule | Search Schedules |
| [**GetServerHealth**](DefaultApi.md#getserverhealth) | **GET** /health | Performs the health check. |
| [**GetSimpleInventoryItem**](DefaultApi.md#getsimpleinventoryitem) | **GET** /inventory/simple/{inventoryItemId} | Gets inventory item for the specified item |
| [**GetSimpleInventoryItems**](DefaultApi.md#getsimpleinventoryitems) | **GET** /inventory/simple | Search inventory items |
| [**GetSmartContract**](DefaultApi.md#getsmartcontract) | **GET** /blockchain/omni/smart_contract/{contractId} | Gets a specific  Smart Contract |
| [**GetSmartContracts**](DefaultApi.md#getsmartcontracts) | **GET** /blockchain/omni/smart_contract | Gets  contracts. |
| [**GetUser**](DefaultApi.md#getuser) | **GET** /user/{name} | Gets a Specific User |
| [**GetUserSaveDataDocumentBySlot**](DefaultApi.md#getusersavedatadocumentbyslot) | **GET** /save_data/user/{userId}/{slot} | Get save data document. |
| [**GetUsers**](DefaultApi.md#getusers) | **GET** /user | Search Users |
| [**GetVault**](DefaultApi.md#getvault) | **GET** /blockchain/omni/vault/{vaultId} | Gets a specific  Vault |
| [**GetVaults**](DefaultApi.md#getvaults) | **GET** /blockchain/omni/vault | Gets  vaults. Optionally filtered for a specific user |
| [**GetVersion**](DefaultApi.md#getversion) | **GET** /version | Show Server Version Information |
| [**GetWallet**](DefaultApi.md#getwallet) | **GET** /blockchain/omni/vault/{vaultId}/wallet/{walletId} | Gets a specific  Wallet |
| [**GetWallet1**](DefaultApi.md#getwallet1) | **GET** /blockchain/omni/wallet/{walletId} | Gets a specific  Wallet |
| [**GetWallets**](DefaultApi.md#getwallets) | **GET** /blockchain/omni/vault/{vaultId}/wallet | Gets  wallets. Optionally filtered for a specific user |
| [**RedeemRewardIssuance**](DefaultApi.md#redeemrewardissuance) | **PUT** /reward_issuance/{rewardIssuanceId}/redeem | Redeems the RewardIssuance. |
| [**RedeemRewardIssuances**](DefaultApi.md#redeemrewardissuances) | **PUT** /reward_issuance/redeem | Redeems the given list of RewardIssuances. |
| [**SignUpUser**](DefaultApi.md#signupuser) | **POST** /signup | Sign Up a User |
| [**UpdateApplication**](DefaultApi.md#updateapplication) | **PUT** /application/{nameOrId} | Updates an Application |
| [**UpdateAuthScheme**](DefaultApi.md#updateauthscheme) | **PUT** /auth_scheme/custom/{authSchemeId} | Updates an Auth Scheme |
| [**UpdateAuthScheme1**](DefaultApi.md#updateauthscheme1) | **PUT** /auth_scheme/oauth2/{oAuth2AuthSchemeId} | Updates an Auth Scheme |
| [**UpdateAuthScheme2**](DefaultApi.md#updateauthscheme2) | **PUT** /auth_scheme/oidc/{oidcAuthSchemeId} | Updates an Auth Scheme |
| [**UpdateDeployment**](DefaultApi.md#updatedeployment) | **PUT** /deployment/{applicationId}/{version} |  |
| [**UpdateDistinctInventoryItem**](DefaultApi.md#updatedistinctinventoryitem) | **PUT** /inventory/distinct/{distinctInventoryItemId} | Updates an inventory item for the specified item |
| [**UpdateFacebookApplicationConfiguration**](DefaultApi.md#updatefacebookapplicationconfiguration) | **PUT** /application/{applicationNameOrId}/configuration/facebook/{applicationConfigurationNameOrId} | Updates a Facebook ApplicationConfiguration |
| [**UpdateFirebaseApplicationConfiguration**](DefaultApi.md#updatefirebaseapplicationconfiguration) | **PUT** /application/{applicationNameOrId}/configuration/firebase/{applicationConfigurationNameOrId} | Updates a Firebase ApplicationConfiguration |
| [**UpdateGooglePlayApplicationConfiguration**](DefaultApi.md#updategoogleplayapplicationconfiguration) | **PUT** /application/{applicationNameOrId}/configuration/google_play/{applicationConfigurationNameOrId} | Updates a Google Play ApplicationConfiguration |
| [**UpdateIosApplicationConfiguration**](DefaultApi.md#updateiosapplicationconfiguration) | **PUT** /application/{applicationNameOrId}/configuration/ios/{applicationConfigurationNameOrId} | Updates a iOS ApplicationConfiguration |
| [**UpdateItem**](DefaultApi.md#updateitem) | **PUT** /item/{identifier} | Updates a single Item |
| [**UpdateLargeObject**](DefaultApi.md#updatelargeobject) | **PUT** /large_object/{largeObjectId} | Updates a LargeObject |
| [**UpdateLargeObjectContents**](DefaultApi.md#updatelargeobjectcontents) | **PUT** /large_object/{largeObjectId}/content | Updates a LargeObject content |
| [**UpdateLeaderboard**](DefaultApi.md#updateleaderboard) | **PUT** /leaderboard/{nameOrId} | Updates an Leaderboard |
| [**UpdateMatchmakingApplicationConfiguration**](DefaultApi.md#updatematchmakingapplicationconfiguration) | **PUT** /application/{applicationNameOrId}/configuration/matchmaking/{applicationConfigurationNameOrId} | Updates a iOS ApplicationConfiguration |
| [**UpdateMetadata**](DefaultApi.md#updatemetadata) | **PUT** /metadata/{id} | Updates a specific Metadata object |
| [**UpdateMetadataSpec**](DefaultApi.md#updatemetadataspec) | **PUT** /metadata_spec/{metadataSpecId} | Updates a Metadata Spec |
| [**UpdateMission**](DefaultApi.md#updatemission) | **PUT** /mission/{missionNameOrId} | Updates an entire single Mission |
| [**UpdatePSNApplicationConfiguration**](DefaultApi.md#updatepsnapplicationconfiguration) | **PUT** /application/{applicationNameOrId}/configuration/psn/{applicationConfigurationNameOrId} | Updates a PSN ApplicationConfiguration |
| [**UpdateProductBundleForApplicationConfiguration**](DefaultApi.md#updateproductbundleforapplicationconfiguration) | **PUT** /application/{applicationNameOrId}/configuration/google_play/{applicationConfigurationNameOrId}/product_bundles | Updates the ProductBundle |
| [**UpdateProductBundleForApplicationConfiguration1**](DefaultApi.md#updateproductbundleforapplicationconfiguration1) | **PUT** /application/{applicationNameOrId}/configuration/ios/{applicationConfigurationNameOrId}/product_bundles | Updates the ProductBundle |
| [**UpdateProfile**](DefaultApi.md#updateprofile) | **PUT** /profile/{profileId} | Updates a Profile |
| [**UpdateProfileImage**](DefaultApi.md#updateprofileimage) | **PUT** /profile/{profileId}/image | Updates a Profile image object |
| [**UpdateProgress**](DefaultApi.md#updateprogress) | **PUT** /progress/{progressId} | Updates a single Progress |
| [**UpdateRegistration**](DefaultApi.md#updateregistration) | **PUT** /notification/fcm/{fcmRegistrationId} | Update an FCM Registration Token |
| [**UpdateSaveDocument**](DefaultApi.md#updatesavedocument) | **PUT** /save_data/{saveDataDocumentId} | Creates a save data document. |
| [**UpdateSchedule**](DefaultApi.md#updateschedule) | **PUT** /schedule/{scheduleNameOrId} | Updates an entire single Schedule |
| [**UpdateScheduleEvent**](DefaultApi.md#updatescheduleevent) | **PUT** /schedule/{scheduleNameOrId}/event/{scheduleEventId} | Updates an entire single ScheduleEvent |
| [**UpdateSimpleInventoryItem**](DefaultApi.md#updatesimpleinventoryitem) | **PUT** /inventory/advanced/{inventoryItemId} | Updates an inventory item for the specified item |
| [**UpdateSimpleInventoryItem1**](DefaultApi.md#updatesimpleinventoryitem1) | **PUT** /inventory/simple/{inventoryItemId} | Updates an inventory item for the specified item |
| [**UpdateSmartContract**](DefaultApi.md#updatesmartcontract) | **PUT** /blockchain/omni/smart_contract/{contractId} | Patches a  Smart Contract |
| [**UpdateUser**](DefaultApi.md#updateuser) | **PUT** /user/{userId} | Updates a User |
| [**UpdateUserPassword**](DefaultApi.md#updateuserpassword) | **PUT** /user/{userId}/password | Updates a User&#39;s Password |
| [**UpdateVault**](DefaultApi.md#updatevault) | **PUT** /blockchain/omni/vault/{vaultId} | Updates a  Vault |
| [**UpdateWallet**](DefaultApi.md#updatewallet) | **PUT** /blockchain/omni/vault/{vaultId}/wallet/{walletId} | Updates a  Wallet |
| [**UploadAppleIapReceipt**](DefaultApi.md#uploadappleiapreceipt) | **POST** /ios/receipt |  |
| [**UploadGooglePlayIapPurchase**](DefaultApi.md#uploadgoogleplayiappurchase) | **POST** /google/purchase | Upload Google Play IAP Receipt data (package name, product id and Google Play-issued purchase token). Returns a list of RewardIssuances, some or all of which may be already redeemed. |

<a id="adjustadvancedinventoryitemquantity"></a>
# **AdjustAdvancedInventoryItemQuantity**
> InventoryItem AdjustAdvancedInventoryItemQuantity (string inventoryItemId, AdvancedInventoryItemQuantityAdjustment advancedInventoryItemQuantityAdjustment = null)

Adjust the quantity of the inventory item for the specified item.

Adjust the quantity of the first (primary) inventory item for the specified item.  This implicitly will create the InventoryItem if it does not exist.  The inventory item value

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class AdjustAdvancedInventoryItemQuantityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var inventoryItemId = "inventoryItemId_example";  // string | 
            var advancedInventoryItemQuantityAdjustment = new AdvancedInventoryItemQuantityAdjustment(); // AdvancedInventoryItemQuantityAdjustment |  (optional) 

            try
            {
                // Adjust the quantity of the inventory item for the specified item.
                InventoryItem result = apiInstance.AdjustAdvancedInventoryItemQuantity(inventoryItemId, advancedInventoryItemQuantityAdjustment);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AdjustAdvancedInventoryItemQuantity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdjustAdvancedInventoryItemQuantityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Adjust the quantity of the inventory item for the specified item.
    ApiResponse<InventoryItem> response = apiInstance.AdjustAdvancedInventoryItemQuantityWithHttpInfo(inventoryItemId, advancedInventoryItemQuantityAdjustment);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.AdjustAdvancedInventoryItemQuantityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inventoryItemId** | **string** |  |  |
| **advancedInventoryItemQuantityAdjustment** | [**AdvancedInventoryItemQuantityAdjustment**](AdvancedInventoryItemQuantityAdjustment.md) |  | [optional]  |

### Return type

[**InventoryItem**](InventoryItem.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="adjustsimpleinventoryitemquantity"></a>
# **AdjustSimpleInventoryItemQuantity**
> InventoryItem AdjustSimpleInventoryItemQuantity (string inventoryItemId, SimpleInventoryItemQuantityAdjustment simpleInventoryItemQuantityAdjustment = null)

Adjust the quantity of the inventory item for the specified item.

Adjust the quantity of the first (primary) inventory item for the specified item.  This implicitly will create the InventoryItem if it does not exist.  The inventory item value

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class AdjustSimpleInventoryItemQuantityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var inventoryItemId = "inventoryItemId_example";  // string | 
            var simpleInventoryItemQuantityAdjustment = new SimpleInventoryItemQuantityAdjustment(); // SimpleInventoryItemQuantityAdjustment |  (optional) 

            try
            {
                // Adjust the quantity of the inventory item for the specified item.
                InventoryItem result = apiInstance.AdjustSimpleInventoryItemQuantity(inventoryItemId, simpleInventoryItemQuantityAdjustment);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AdjustSimpleInventoryItemQuantity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdjustSimpleInventoryItemQuantityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Adjust the quantity of the inventory item for the specified item.
    ApiResponse<InventoryItem> response = apiInstance.AdjustSimpleInventoryItemQuantityWithHttpInfo(inventoryItemId, simpleInventoryItemQuantityAdjustment);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.AdjustSimpleInventoryItemQuantityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inventoryItemId** | **string** |  |  |
| **simpleInventoryItemQuantityAdjustment** | [**SimpleInventoryItemQuantityAdjustment**](SimpleInventoryItemQuantityAdjustment.md) |  | [optional]  |

### Return type

[**InventoryItem**](InventoryItem.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="blacklistsession"></a>
# **BlacklistSession**
> void BlacklistSession (string sessionSecret)

Destroys the Session

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class BlacklistSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var sessionSecret = "sessionSecret_example";  // string | 

            try
            {
                // Destroys the Session
                apiInstance.BlacklistSession(sessionSecret);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.BlacklistSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BlacklistSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Destroys the Session
    apiInstance.BlacklistSessionWithHttpInfo(sessionSecret);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.BlacklistSessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sessionSecret** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="buildindexes"></a>
# **BuildIndexes**
> void BuildIndexes (BuildIndexRequest buildIndexRequest = null)

Builds all indexes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class BuildIndexesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var buildIndexRequest = new BuildIndexRequest(); // BuildIndexRequest |  (optional) 

            try
            {
                // Builds all indexes.
                apiInstance.BuildIndexes(buildIndexRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.BuildIndexes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BuildIndexesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Builds all indexes.
    apiInstance.BuildIndexesWithHttpInfo(buildIndexRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.BuildIndexesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **buildIndexRequest** | [**BuildIndexRequest**](BuildIndexRequest.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createadvancedinventoryitem"></a>
# **CreateAdvancedInventoryItem**
> InventoryItem CreateAdvancedInventoryItem (CreateAdvancedInventoryItemRequest createAdvancedInventoryItemRequest = null)

Create an inventory item for the specified item

Create an inventory item for the specified item

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateAdvancedInventoryItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var createAdvancedInventoryItemRequest = new CreateAdvancedInventoryItemRequest(); // CreateAdvancedInventoryItemRequest |  (optional) 

            try
            {
                // Create an inventory item for the specified item
                InventoryItem result = apiInstance.CreateAdvancedInventoryItem(createAdvancedInventoryItemRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateAdvancedInventoryItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAdvancedInventoryItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an inventory item for the specified item
    ApiResponse<InventoryItem> response = apiInstance.CreateAdvancedInventoryItemWithHttpInfo(createAdvancedInventoryItemRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateAdvancedInventoryItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createAdvancedInventoryItemRequest** | [**CreateAdvancedInventoryItemRequest**](CreateAdvancedInventoryItemRequest.md) |  | [optional]  |

### Return type

[**InventoryItem**](InventoryItem.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createapplication"></a>
# **CreateApplication**
> Application CreateApplication (CreateApplicationRequest createApplicationRequest = null)

Creates a New Application

Gets the metadata for a single application.  This may include more specific details not available in the bulk-get or fetch operation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateApplicationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var createApplicationRequest = new CreateApplicationRequest(); // CreateApplicationRequest |  (optional) 

            try
            {
                // Creates a New Application
                Application result = apiInstance.CreateApplication(createApplicationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateApplication: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateApplicationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a New Application
    ApiResponse<Application> response = apiInstance.CreateApplicationWithHttpInfo(createApplicationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateApplicationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createApplicationRequest** | [**CreateApplicationRequest**](CreateApplicationRequest.md) |  | [optional]  |

### Return type

[**Application**](Application.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createauthscheme"></a>
# **CreateAuthScheme**
> CreateAuthSchemeResponse CreateAuthScheme (CreateAuthSchemeRequest createAuthSchemeRequest = null)

Creates a new Auth Scheme

Creates a new Auth Scheme, from the data in the given auth scheme request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateAuthSchemeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var createAuthSchemeRequest = new CreateAuthSchemeRequest(); // CreateAuthSchemeRequest |  (optional) 

            try
            {
                // Creates a new Auth Scheme
                CreateAuthSchemeResponse result = apiInstance.CreateAuthScheme(createAuthSchemeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateAuthScheme: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAuthSchemeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new Auth Scheme
    ApiResponse<CreateAuthSchemeResponse> response = apiInstance.CreateAuthSchemeWithHttpInfo(createAuthSchemeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateAuthSchemeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createAuthSchemeRequest** | [**CreateAuthSchemeRequest**](CreateAuthSchemeRequest.md) |  | [optional]  |

### Return type

[**CreateAuthSchemeResponse**](CreateAuthSchemeResponse.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createauthscheme1"></a>
# **CreateAuthScheme1**
> CreateOrUpdateOAuth2AuthSchemeResponse CreateAuthScheme1 (CreateOrUpdateOAuth2AuthSchemeRequest createOrUpdateOAuth2AuthSchemeRequest = null)

Creates a new Auth Scheme

Creates a new Auth Scheme, from the data in the given auth scheme request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateAuthScheme1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var createOrUpdateOAuth2AuthSchemeRequest = new CreateOrUpdateOAuth2AuthSchemeRequest(); // CreateOrUpdateOAuth2AuthSchemeRequest |  (optional) 

            try
            {
                // Creates a new Auth Scheme
                CreateOrUpdateOAuth2AuthSchemeResponse result = apiInstance.CreateAuthScheme1(createOrUpdateOAuth2AuthSchemeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateAuthScheme1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAuthScheme1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new Auth Scheme
    ApiResponse<CreateOrUpdateOAuth2AuthSchemeResponse> response = apiInstance.CreateAuthScheme1WithHttpInfo(createOrUpdateOAuth2AuthSchemeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateAuthScheme1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createOrUpdateOAuth2AuthSchemeRequest** | [**CreateOrUpdateOAuth2AuthSchemeRequest**](CreateOrUpdateOAuth2AuthSchemeRequest.md) |  | [optional]  |

### Return type

[**CreateOrUpdateOAuth2AuthSchemeResponse**](CreateOrUpdateOAuth2AuthSchemeResponse.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createauthscheme2"></a>
# **CreateAuthScheme2**
> CreateOrUpdateOidcAuthSchemeResponse CreateAuthScheme2 (CreateOrUpdateOidcAuthSchemeRequest createOrUpdateOidcAuthSchemeRequest = null)

Creates a new Auth Scheme

Creates a new Auth Scheme, from the data in the given auth scheme request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateAuthScheme2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var createOrUpdateOidcAuthSchemeRequest = new CreateOrUpdateOidcAuthSchemeRequest(); // CreateOrUpdateOidcAuthSchemeRequest |  (optional) 

            try
            {
                // Creates a new Auth Scheme
                CreateOrUpdateOidcAuthSchemeResponse result = apiInstance.CreateAuthScheme2(createOrUpdateOidcAuthSchemeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateAuthScheme2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAuthScheme2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new Auth Scheme
    ApiResponse<CreateOrUpdateOidcAuthSchemeResponse> response = apiInstance.CreateAuthScheme2WithHttpInfo(createOrUpdateOidcAuthSchemeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateAuthScheme2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createOrUpdateOidcAuthSchemeRequest** | [**CreateOrUpdateOidcAuthSchemeRequest**](CreateOrUpdateOidcAuthSchemeRequest.md) |  | [optional]  |

### Return type

[**CreateOrUpdateOidcAuthSchemeResponse**](CreateOrUpdateOidcAuthSchemeResponse.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createdistinctinventoryitem"></a>
# **CreateDistinctInventoryItem**
> DistinctInventoryItem CreateDistinctInventoryItem (CreateDistinctInventoryItemRequest createDistinctInventoryItemRequest = null)

Create an inventory item for the specified item

Create an inventory item for the specified item

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateDistinctInventoryItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var createDistinctInventoryItemRequest = new CreateDistinctInventoryItemRequest(); // CreateDistinctInventoryItemRequest |  (optional) 

            try
            {
                // Create an inventory item for the specified item
                DistinctInventoryItem result = apiInstance.CreateDistinctInventoryItem(createDistinctInventoryItemRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateDistinctInventoryItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateDistinctInventoryItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an inventory item for the specified item
    ApiResponse<DistinctInventoryItem> response = apiInstance.CreateDistinctInventoryItemWithHttpInfo(createDistinctInventoryItemRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateDistinctInventoryItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createDistinctInventoryItemRequest** | [**CreateDistinctInventoryItemRequest**](CreateDistinctInventoryItemRequest.md) |  | [optional]  |

### Return type

[**DistinctInventoryItem**](DistinctInventoryItem.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createfcmregistration"></a>
# **CreateFCMRegistration**
> FCMRegistration CreateFCMRegistration (FCMRegistration fCMRegistration = null)

Creates an FCM Registration Token

Supplying FCM registration token, this will create a new token based on the information supplied to the endpoint.  The response will contain the token as it was written to the database.  Clients may subsequently update the token string with new values as they are issued by Firebase.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateFCMRegistrationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var fCMRegistration = new FCMRegistration(); // FCMRegistration |  (optional) 

            try
            {
                // Creates an FCM Registration Token
                FCMRegistration result = apiInstance.CreateFCMRegistration(fCMRegistration);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateFCMRegistration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFCMRegistrationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates an FCM Registration Token
    ApiResponse<FCMRegistration> response = apiInstance.CreateFCMRegistrationWithHttpInfo(fCMRegistration);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateFCMRegistrationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fCMRegistration** | [**FCMRegistration**](FCMRegistration.md) |  | [optional]  |

### Return type

[**FCMRegistration**](FCMRegistration.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createfacebookapplicationconfiguration"></a>
# **CreateFacebookApplicationConfiguration**
> FacebookApplicationConfiguration CreateFacebookApplicationConfiguration (string applicationNameOrId, FacebookApplicationConfiguration facebookApplicationConfiguration = null)

Creates a new Facebook ApplicationConfiguration

Creates a new Facebook ApplicationConfiguration with the specific ID or application.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateFacebookApplicationConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var applicationNameOrId = "applicationNameOrId_example";  // string | 
            var facebookApplicationConfiguration = new FacebookApplicationConfiguration(); // FacebookApplicationConfiguration |  (optional) 

            try
            {
                // Creates a new Facebook ApplicationConfiguration
                FacebookApplicationConfiguration result = apiInstance.CreateFacebookApplicationConfiguration(applicationNameOrId, facebookApplicationConfiguration);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateFacebookApplicationConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFacebookApplicationConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new Facebook ApplicationConfiguration
    ApiResponse<FacebookApplicationConfiguration> response = apiInstance.CreateFacebookApplicationConfigurationWithHttpInfo(applicationNameOrId, facebookApplicationConfiguration);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateFacebookApplicationConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationNameOrId** | **string** |  |  |
| **facebookApplicationConfiguration** | [**FacebookApplicationConfiguration**](FacebookApplicationConfiguration.md) |  | [optional]  |

### Return type

[**FacebookApplicationConfiguration**](FacebookApplicationConfiguration.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createfirebaseapplicationconfiguration"></a>
# **CreateFirebaseApplicationConfiguration**
> FirebaseApplicationConfiguration CreateFirebaseApplicationConfiguration (string applicationNameOrId, FirebaseApplicationConfiguration firebaseApplicationConfiguration = null)

Creates a new Firebase ApplicationConfiguration

Creates a new Firebase ApplicationConfiguration with the specific ID or application.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateFirebaseApplicationConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var applicationNameOrId = "applicationNameOrId_example";  // string | 
            var firebaseApplicationConfiguration = new FirebaseApplicationConfiguration(); // FirebaseApplicationConfiguration |  (optional) 

            try
            {
                // Creates a new Firebase ApplicationConfiguration
                FirebaseApplicationConfiguration result = apiInstance.CreateFirebaseApplicationConfiguration(applicationNameOrId, firebaseApplicationConfiguration);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateFirebaseApplicationConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFirebaseApplicationConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new Firebase ApplicationConfiguration
    ApiResponse<FirebaseApplicationConfiguration> response = apiInstance.CreateFirebaseApplicationConfigurationWithHttpInfo(applicationNameOrId, firebaseApplicationConfiguration);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateFirebaseApplicationConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationNameOrId** | **string** |  |  |
| **firebaseApplicationConfiguration** | [**FirebaseApplicationConfiguration**](FirebaseApplicationConfiguration.md) |  | [optional]  |

### Return type

[**FirebaseApplicationConfiguration**](FirebaseApplicationConfiguration.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createfollower"></a>
# **CreateFollower**
> void CreateFollower (string profileId, CreateFollowerRequest createFollowerRequest = null)

Creates a Follower relationship between two profiles.

Supplying the follower object, this will store the information supplied in the body of the request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateFollowerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var profileId = "profileId_example";  // string | 
            var createFollowerRequest = new CreateFollowerRequest(); // CreateFollowerRequest |  (optional) 

            try
            {
                // Creates a Follower relationship between two profiles.
                apiInstance.CreateFollower(profileId, createFollowerRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateFollower: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFollowerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a Follower relationship between two profiles.
    apiInstance.CreateFollowerWithHttpInfo(profileId, createFollowerRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateFollowerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **profileId** | **string** |  |  |
| **createFollowerRequest** | [**CreateFollowerRequest**](CreateFollowerRequest.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="creategoogleplayapplicationconfiguration"></a>
# **CreateGooglePlayApplicationConfiguration**
> GooglePlayApplicationConfiguration CreateGooglePlayApplicationConfiguration (string applicationNameOrId, GooglePlayApplicationConfiguration googlePlayApplicationConfiguration = null)

Creates a new Google Play ApplicationConfiguration

Creates a new GooglePlay ApplicationConfiguration with the specific ID or application.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateGooglePlayApplicationConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var applicationNameOrId = "applicationNameOrId_example";  // string | 
            var googlePlayApplicationConfiguration = new GooglePlayApplicationConfiguration(); // GooglePlayApplicationConfiguration |  (optional) 

            try
            {
                // Creates a new Google Play ApplicationConfiguration
                GooglePlayApplicationConfiguration result = apiInstance.CreateGooglePlayApplicationConfiguration(applicationNameOrId, googlePlayApplicationConfiguration);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateGooglePlayApplicationConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateGooglePlayApplicationConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new Google Play ApplicationConfiguration
    ApiResponse<GooglePlayApplicationConfiguration> response = apiInstance.CreateGooglePlayApplicationConfigurationWithHttpInfo(applicationNameOrId, googlePlayApplicationConfiguration);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateGooglePlayApplicationConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationNameOrId** | **string** |  |  |
| **googlePlayApplicationConfiguration** | [**GooglePlayApplicationConfiguration**](GooglePlayApplicationConfiguration.md) |  | [optional]  |

### Return type

[**GooglePlayApplicationConfiguration**](GooglePlayApplicationConfiguration.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createiosapplicationconfiguration"></a>
# **CreateIosApplicationConfiguration**
> IosApplicationConfiguration CreateIosApplicationConfiguration (string applicationNameOrId, IosApplicationConfiguration iosApplicationConfiguration = null)

Creates a new iOS ApplicationConfiguration

Creates a new iOS ApplicationConfiguration with the specific ID or application.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateIosApplicationConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var applicationNameOrId = "applicationNameOrId_example";  // string | 
            var iosApplicationConfiguration = new IosApplicationConfiguration(); // IosApplicationConfiguration |  (optional) 

            try
            {
                // Creates a new iOS ApplicationConfiguration
                IosApplicationConfiguration result = apiInstance.CreateIosApplicationConfiguration(applicationNameOrId, iosApplicationConfiguration);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateIosApplicationConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateIosApplicationConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new iOS ApplicationConfiguration
    ApiResponse<IosApplicationConfiguration> response = apiInstance.CreateIosApplicationConfigurationWithHttpInfo(applicationNameOrId, iosApplicationConfiguration);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateIosApplicationConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationNameOrId** | **string** |  |  |
| **iosApplicationConfiguration** | [**IosApplicationConfiguration**](IosApplicationConfiguration.md) |  | [optional]  |

### Return type

[**IosApplicationConfiguration**](IosApplicationConfiguration.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createitem"></a>
# **CreateItem**
> Item CreateItem (CreateItemRequest createItemRequest = null)

Creates a new digital Item

Supplying an item object, this will create a new item with a newly assigned unique id.  The Item representation returned in the response body is a representation of the Item as persisted with a unique identifier signed and with its fields properly normalized.  The supplied item object submitted with the request must have a name property that is unique across all items.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var createItemRequest = new CreateItemRequest(); // CreateItemRequest |  (optional) 

            try
            {
                // Creates a new digital Item
                Item result = apiInstance.CreateItem(createItemRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new digital Item
    ApiResponse<Item> response = apiInstance.CreateItemWithHttpInfo(createItemRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createItemRequest** | [**CreateItemRequest**](CreateItemRequest.md) |  | [optional]  |

### Return type

[**Item**](Item.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createlargeobject"></a>
# **CreateLargeObject**
> LargeObject CreateLargeObject (FormDataBodyPart varObject = null, CreateLargeObjectRequest metadata = null)

Creates a LargeObject with content

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateLargeObjectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var varObject = new FormDataBodyPart(); // FormDataBodyPart |  (optional) 
            var metadata = new CreateLargeObjectRequest(); // CreateLargeObjectRequest |  (optional) 

            try
            {
                // Creates a LargeObject with content
                LargeObject result = apiInstance.CreateLargeObject(varObject, metadata);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateLargeObject: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateLargeObjectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a LargeObject with content
    ApiResponse<LargeObject> response = apiInstance.CreateLargeObjectWithHttpInfo(varObject, metadata);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateLargeObjectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varObject** | [**FormDataBodyPart**](FormDataBodyPart.md) |  | [optional]  |
| **metadata** | [**CreateLargeObjectRequest**](CreateLargeObjectRequest.md) |  | [optional]  |

### Return type

[**LargeObject**](LargeObject.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createlargeobject1"></a>
# **CreateLargeObject1**
> LargeObject CreateLargeObject1 (CreateLargeObjectRequest createLargeObjectRequest = null)

Creates a LargeObject

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateLargeObject1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var createLargeObjectRequest = new CreateLargeObjectRequest(); // CreateLargeObjectRequest |  (optional) 

            try
            {
                // Creates a LargeObject
                LargeObject result = apiInstance.CreateLargeObject1(createLargeObjectRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateLargeObject1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateLargeObject1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a LargeObject
    ApiResponse<LargeObject> response = apiInstance.CreateLargeObject1WithHttpInfo(createLargeObjectRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateLargeObject1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createLargeObjectRequest** | [**CreateLargeObjectRequest**](CreateLargeObjectRequest.md) |  | [optional]  |

### Return type

[**LargeObject**](LargeObject.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createlargeobjectfromurl"></a>
# **CreateLargeObjectFromUrl**
> LargeObject CreateLargeObjectFromUrl (CreateLargeObjectFromUrlRequest createLargeObjectFromUrlRequest = null)

Creates a LargeObject from provided URL

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateLargeObjectFromUrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var createLargeObjectFromUrlRequest = new CreateLargeObjectFromUrlRequest(); // CreateLargeObjectFromUrlRequest |  (optional) 

            try
            {
                // Creates a LargeObject from provided URL
                LargeObject result = apiInstance.CreateLargeObjectFromUrl(createLargeObjectFromUrlRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateLargeObjectFromUrl: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateLargeObjectFromUrlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a LargeObject from provided URL
    ApiResponse<LargeObject> response = apiInstance.CreateLargeObjectFromUrlWithHttpInfo(createLargeObjectFromUrlRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateLargeObjectFromUrlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createLargeObjectFromUrlRequest** | [**CreateLargeObjectFromUrlRequest**](CreateLargeObjectFromUrlRequest.md) |  | [optional]  |

### Return type

[**LargeObject**](LargeObject.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createleaderboard"></a>
# **CreateLeaderboard**
> Leaderboard CreateLeaderboard (Leaderboard leaderboard = null)

Creates a New Leaderboard

Gets the metadata for a single leaderboard.  This may include more specific details not available in the bulk-get or fetch operation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateLeaderboardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var leaderboard = new Leaderboard(); // Leaderboard |  (optional) 

            try
            {
                // Creates a New Leaderboard
                Leaderboard result = apiInstance.CreateLeaderboard(leaderboard);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateLeaderboard: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateLeaderboardWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a New Leaderboard
    ApiResponse<Leaderboard> response = apiInstance.CreateLeaderboardWithHttpInfo(leaderboard);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateLeaderboardWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **leaderboard** | [**Leaderboard**](Leaderboard.md) |  | [optional]  |

### Return type

[**Leaderboard**](Leaderboard.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="creatematch"></a>
# **CreateMatch**
> Match CreateMatch (Match match = null)

Creates a Match

This method accepts an instance of Match, effectively requesting that the server find a suitable opponent for a game.  As other suitable players create matches the created match object may be updated as a suitable opponent is found.  The client must poll matches for updates and react accordingly.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateMatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var match = new Match(); // Match |  (optional) 

            try
            {
                // Creates a Match
                Match result = apiInstance.CreateMatch(match);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateMatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateMatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a Match
    ApiResponse<Match> response = apiInstance.CreateMatchWithHttpInfo(match);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateMatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **match** | [**Match**](Match.md) |  | [optional]  |

### Return type

[**Match**](Match.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="creatematchmakingapplicationconfiguration"></a>
# **CreateMatchmakingApplicationConfiguration**
> MatchmakingApplicationConfiguration CreateMatchmakingApplicationConfiguration (string applicationNameOrId, MatchmakingApplicationConfiguration matchmakingApplicationConfiguration = null)

Creates a new iOS ApplicationConfiguration

Creates a new iOS ApplicationConfiguration with the specific ID or application.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateMatchmakingApplicationConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var applicationNameOrId = "applicationNameOrId_example";  // string | 
            var matchmakingApplicationConfiguration = new MatchmakingApplicationConfiguration(); // MatchmakingApplicationConfiguration |  (optional) 

            try
            {
                // Creates a new iOS ApplicationConfiguration
                MatchmakingApplicationConfiguration result = apiInstance.CreateMatchmakingApplicationConfiguration(applicationNameOrId, matchmakingApplicationConfiguration);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateMatchmakingApplicationConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateMatchmakingApplicationConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new iOS ApplicationConfiguration
    ApiResponse<MatchmakingApplicationConfiguration> response = apiInstance.CreateMatchmakingApplicationConfigurationWithHttpInfo(applicationNameOrId, matchmakingApplicationConfiguration);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateMatchmakingApplicationConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationNameOrId** | **string** |  |  |
| **matchmakingApplicationConfiguration** | [**MatchmakingApplicationConfiguration**](MatchmakingApplicationConfiguration.md) |  | [optional]  |

### Return type

[**MatchmakingApplicationConfiguration**](MatchmakingApplicationConfiguration.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createmetadata"></a>
# **CreateMetadata**
> Metadata CreateMetadata (CreateMetadataRequest createMetadataRequest = null)

Creates a new Metadata object

Creates a new Metadata object with the provided details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var createMetadataRequest = new CreateMetadataRequest(); // CreateMetadataRequest |  (optional) 

            try
            {
                // Creates a new Metadata object
                Metadata result = apiInstance.CreateMetadata(createMetadataRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateMetadata: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateMetadataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new Metadata object
    ApiResponse<Metadata> response = apiInstance.CreateMetadataWithHttpInfo(createMetadataRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateMetadataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createMetadataRequest** | [**CreateMetadataRequest**](CreateMetadataRequest.md) |  | [optional]  |

### Return type

[**Metadata**](Metadata.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createmetadataspec"></a>
# **CreateMetadataSpec**
> MetadataSpec CreateMetadataSpec (CreateMetadataSpecRequest createMetadataSpecRequest = null)

Creates a new Metadata Spec definition

Creates a new Metadata Spec definition.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateMetadataSpecExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var createMetadataSpecRequest = new CreateMetadataSpecRequest(); // CreateMetadataSpecRequest |  (optional) 

            try
            {
                // Creates a new Metadata Spec definition
                MetadataSpec result = apiInstance.CreateMetadataSpec(createMetadataSpecRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateMetadataSpec: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateMetadataSpecWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new Metadata Spec definition
    ApiResponse<MetadataSpec> response = apiInstance.CreateMetadataSpecWithHttpInfo(createMetadataSpecRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateMetadataSpecWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createMetadataSpecRequest** | [**CreateMetadataSpecRequest**](CreateMetadataSpecRequest.md) |  | [optional]  |

### Return type

[**MetadataSpec**](MetadataSpec.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createmission"></a>
# **CreateMission**
> Mission CreateMission (Mission mission = null)

Creates a new mission

Supplying a mission object, this will create a new mission with a newly assigned unique id.  The Mission representation returned in the response body is a representation of the Mission as persisted with a unique identifier assigned and with its fields properly normalized.  The supplied mission object submitted with the request must have a name property that is unique across all items.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateMissionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var mission = new Mission(); // Mission |  (optional) 

            try
            {
                // Creates a new mission
                Mission result = apiInstance.CreateMission(mission);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateMission: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateMissionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new mission
    ApiResponse<Mission> response = apiInstance.CreateMissionWithHttpInfo(mission);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateMissionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **mission** | [**Mission**](Mission.md) |  | [optional]  |

### Return type

[**Mission**](Mission.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createmocksession"></a>
# **CreateMockSession**
> MockSessionCreation CreateMockSession (MockSessionRequest mockSessionRequest = null)

Creates a Mock Session

Begins a session by accepting a mock session request.  The request must be made with an authenticated super-user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateMockSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var mockSessionRequest = new MockSessionRequest(); // MockSessionRequest |  (optional) 

            try
            {
                // Creates a Mock Session
                MockSessionCreation result = apiInstance.CreateMockSession(mockSessionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateMockSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateMockSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a Mock Session
    ApiResponse<MockSessionCreation> response = apiInstance.CreateMockSessionWithHttpInfo(mockSessionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateMockSessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **mockSessionRequest** | [**MockSessionRequest**](MockSessionRequest.md) |  | [optional]  |

### Return type

[**MockSessionCreation**](MockSessionCreation.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createnewdeployment"></a>
# **CreateNewDeployment**
> Deployment CreateNewDeployment (string applicationId, CreateDeploymentRequest createDeploymentRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateNewDeploymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var applicationId = "applicationId_example";  // string | 
            var createDeploymentRequest = new CreateDeploymentRequest(); // CreateDeploymentRequest |  (optional) 

            try
            {
                Deployment result = apiInstance.CreateNewDeployment(applicationId, createDeploymentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateNewDeployment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateNewDeploymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Deployment> response = apiInstance.CreateNewDeploymentWithHttpInfo(applicationId, createDeploymentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateNewDeploymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **string** |  |  |
| **createDeploymentRequest** | [**CreateDeploymentRequest**](CreateDeploymentRequest.md) |  | [optional]  |

### Return type

[**Deployment**](Deployment.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createoauth2session"></a>
# **CreateOAuth2Session**
> SessionCreation CreateOAuth2Session (OAuth2SessionRequest oAuth2SessionRequest = null)

Creates a Session using OAuth2

Begins a session by accepting a session request with parameters matching the specified OAuth2 Scheme. Upon successful validation against the scheme provided in the path, this will return a Session which can be used for authentication. If there is no User associated with the supplied credentials, this will implicitly create a new account and will include that account information in the response. If there is an account, or this method receives an existing session key, this will link to the existing scheme if the account was not previously linked.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateOAuth2SessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var oAuth2SessionRequest = new OAuth2SessionRequest(); // OAuth2SessionRequest |  (optional) 

            try
            {
                // Creates a Session using OAuth2
                SessionCreation result = apiInstance.CreateOAuth2Session(oAuth2SessionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateOAuth2Session: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOAuth2SessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a Session using OAuth2
    ApiResponse<SessionCreation> response = apiInstance.CreateOAuth2SessionWithHttpInfo(oAuth2SessionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateOAuth2SessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **oAuth2SessionRequest** | [**OAuth2SessionRequest**](OAuth2SessionRequest.md) |  | [optional]  |

### Return type

[**SessionCreation**](SessionCreation.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createoidcsession"></a>
# **CreateOidcSession**
> SessionCreation CreateOidcSession (OidcSessionRequest oidcSessionRequest = null)

Creates a Session using OIDC

Begins a session by accepting a JWT. Upon successful validation against the scheme provided in the path, this will return a Session which can be used for authentication. If there is no User associated with the supplied credentials, this will implicitly create a new account and will include that account information in the response. If there is an account, or this method receives an existing session key, this will link to the existing scheme if the account was not previously linked.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateOidcSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var oidcSessionRequest = new OidcSessionRequest(); // OidcSessionRequest |  (optional) 

            try
            {
                // Creates a Session using OIDC
                SessionCreation result = apiInstance.CreateOidcSession(oidcSessionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateOidcSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOidcSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a Session using OIDC
    ApiResponse<SessionCreation> response = apiInstance.CreateOidcSessionWithHttpInfo(oidcSessionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateOidcSessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **oidcSessionRequest** | [**OidcSessionRequest**](OidcSessionRequest.md) |  | [optional]  |

### Return type

[**SessionCreation**](SessionCreation.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createpsnapplicationconfiguration"></a>
# **CreatePSNApplicationConfiguration**
> PSNApplicationConfiguration CreatePSNApplicationConfiguration (string applicationNameOrId, PSNApplicationConfiguration pSNApplicationConfiguration = null)

Creates a new PSN ApplicationConfiguration

Creates a new PSN ApplicationConfiguration with the specific ID or application.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreatePSNApplicationConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var applicationNameOrId = "applicationNameOrId_example";  // string | 
            var pSNApplicationConfiguration = new PSNApplicationConfiguration(); // PSNApplicationConfiguration |  (optional) 

            try
            {
                // Creates a new PSN ApplicationConfiguration
                PSNApplicationConfiguration result = apiInstance.CreatePSNApplicationConfiguration(applicationNameOrId, pSNApplicationConfiguration);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreatePSNApplicationConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePSNApplicationConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new PSN ApplicationConfiguration
    ApiResponse<PSNApplicationConfiguration> response = apiInstance.CreatePSNApplicationConfigurationWithHttpInfo(applicationNameOrId, pSNApplicationConfiguration);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreatePSNApplicationConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationNameOrId** | **string** |  |  |
| **pSNApplicationConfiguration** | [**PSNApplicationConfiguration**](PSNApplicationConfiguration.md) |  | [optional]  |

### Return type

[**PSNApplicationConfiguration**](PSNApplicationConfiguration.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createprofile"></a>
# **CreateProfile**
> Profile CreateProfile (CreateProfileRequest createProfileRequest = null)

Creates a Profile

Supplying the create profile request, this will update the profile with the new information supplied in the body of the request. This will fire an event, dev.getelements.elements.service.profile.created, from the event manifest.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var createProfileRequest = new CreateProfileRequest(); // CreateProfileRequest |  (optional) 

            try
            {
                // Creates a Profile
                Profile result = apiInstance.CreateProfile(createProfileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateProfile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateProfileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a Profile
    ApiResponse<Profile> response = apiInstance.CreateProfileWithHttpInfo(createProfileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateProfileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createProfileRequest** | [**CreateProfileRequest**](CreateProfileRequest.md) |  | [optional]  |

### Return type

[**Profile**](Profile.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createprogress"></a>
# **CreateProgress**
> Progress CreateProgress (Progress progress = null)

Creates a new progress

Supplying a progress object, this will create a new progress with a newly assigned unique id.  The Progress representation returned in the response body is a representation of the Progress as persisted with a unique identifier assigned and with its fields properly normalized.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateProgressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var progress = new Progress(); // Progress |  (optional) 

            try
            {
                // Creates a new progress
                Progress result = apiInstance.CreateProgress(progress);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateProgress: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateProgressWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new progress
    ApiResponse<Progress> response = apiInstance.CreateProgressWithHttpInfo(progress);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateProgressWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **progress** | [**Progress**](Progress.md) |  | [optional]  |

### Return type

[**Progress**](Progress.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createsavedocument"></a>
# **CreateSaveDocument**
> SaveDataDocument CreateSaveDocument (CreateSaveDataDocumentRequest createSaveDataDocumentRequest = null)

Creates a save data document.

Gets a single save data document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateSaveDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var createSaveDataDocumentRequest = new CreateSaveDataDocumentRequest(); // CreateSaveDataDocumentRequest |  (optional) 

            try
            {
                // Creates a save data document.
                SaveDataDocument result = apiInstance.CreateSaveDocument(createSaveDataDocumentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateSaveDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSaveDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a save data document.
    ApiResponse<SaveDataDocument> response = apiInstance.CreateSaveDocumentWithHttpInfo(createSaveDataDocumentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateSaveDocumentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createSaveDataDocumentRequest** | [**CreateSaveDataDocumentRequest**](CreateSaveDataDocumentRequest.md) |  | [optional]  |

### Return type

[**SaveDataDocument**](SaveDataDocument.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createschedule"></a>
# **CreateSchedule**
> Schedule CreateSchedule (CreateScheduleRequest createScheduleRequest = null)

Creates a new schedule

Supplying a schedule object, this will create a new schedule with a newly assigned unique id.  The Schedule representation returned in the response body is a representation of the Schedule as persisted with a unique identifier assigned and with its fields properly normalized.  The supplied schedule object submitted with the request must have a name property that is unique across all items.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateScheduleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var createScheduleRequest = new CreateScheduleRequest(); // CreateScheduleRequest |  (optional) 

            try
            {
                // Creates a new schedule
                Schedule result = apiInstance.CreateSchedule(createScheduleRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateSchedule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateScheduleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new schedule
    ApiResponse<Schedule> response = apiInstance.CreateScheduleWithHttpInfo(createScheduleRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateScheduleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createScheduleRequest** | [**CreateScheduleRequest**](CreateScheduleRequest.md) |  | [optional]  |

### Return type

[**Schedule**](Schedule.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createscheduleevent"></a>
# **CreateScheduleEvent**
> ScheduleEvent CreateScheduleEvent (string scheduleNameOrId, CreateScheduleEventRequest createScheduleEventRequest = null)

Creates a new schedule

Supplying a schedule object, this will create a new schedule with a newly assigned unique id.  The ScheduleEvent representation returned in the response body is a representation of the ScheduleEvent as persisted with a unique identifier assigned and with its fields properly normalized.  The supplied schedule object submitted with the request must have a name property that is unique across all items.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateScheduleEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var scheduleNameOrId = "scheduleNameOrId_example";  // string | 
            var createScheduleEventRequest = new CreateScheduleEventRequest(); // CreateScheduleEventRequest |  (optional) 

            try
            {
                // Creates a new schedule
                ScheduleEvent result = apiInstance.CreateScheduleEvent(scheduleNameOrId, createScheduleEventRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateScheduleEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateScheduleEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new schedule
    ApiResponse<ScheduleEvent> response = apiInstance.CreateScheduleEventWithHttpInfo(scheduleNameOrId, createScheduleEventRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateScheduleEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scheduleNameOrId** | **string** |  |  |
| **createScheduleEventRequest** | [**CreateScheduleEventRequest**](CreateScheduleEventRequest.md) |  | [optional]  |

### Return type

[**ScheduleEvent**](ScheduleEvent.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createscore"></a>
# **CreateScore**
> Score CreateScore (string leaderboardNameOrId, Score score = null)

Creates a New Score

Posts a single score for the currently logged-in profile. Conceptually, this is creationg a new resource, however the server may opt to overwrite the existing identifier if it sees fit.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateScoreExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var leaderboardNameOrId = "leaderboardNameOrId_example";  // string | The name or id of the leaderboard.
            var score = new Score(); // Score |  (optional) 

            try
            {
                // Creates a New Score
                Score result = apiInstance.CreateScore(leaderboardNameOrId, score);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateScore: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateScoreWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a New Score
    ApiResponse<Score> response = apiInstance.CreateScoreWithHttpInfo(leaderboardNameOrId, score);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateScoreWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **leaderboardNameOrId** | **string** | The name or id of the leaderboard. |  |
| **score** | [**Score**](Score.md) |  | [optional]  |

### Return type

[**Score**](Score.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createsimpleinventoryitem"></a>
# **CreateSimpleInventoryItem**
> InventoryItem CreateSimpleInventoryItem (CreateSimpleInventoryItemRequest createSimpleInventoryItemRequest = null)

Create an inventory item for the specified item

Create an inventory item for the specified item

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateSimpleInventoryItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var createSimpleInventoryItemRequest = new CreateSimpleInventoryItemRequest(); // CreateSimpleInventoryItemRequest |  (optional) 

            try
            {
                // Create an inventory item for the specified item
                InventoryItem result = apiInstance.CreateSimpleInventoryItem(createSimpleInventoryItemRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateSimpleInventoryItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSimpleInventoryItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an inventory item for the specified item
    ApiResponse<InventoryItem> response = apiInstance.CreateSimpleInventoryItemWithHttpInfo(createSimpleInventoryItemRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateSimpleInventoryItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createSimpleInventoryItemRequest** | [**CreateSimpleInventoryItemRequest**](CreateSimpleInventoryItemRequest.md) |  | [optional]  |

### Return type

[**InventoryItem**](InventoryItem.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createsmartcontract"></a>
# **CreateSmartContract**
> SmartContract CreateSmartContract (CreateSmartContractRequest createSmartContractRequest = null)

Patches a  Smart Contract

Patches a  Smart Contract entry, associated with the specified deployed script hash.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateSmartContractExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var createSmartContractRequest = new CreateSmartContractRequest(); // CreateSmartContractRequest |  (optional) 

            try
            {
                // Patches a  Smart Contract
                SmartContract result = apiInstance.CreateSmartContract(createSmartContractRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateSmartContract: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSmartContractWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Patches a  Smart Contract
    ApiResponse<SmartContract> response = apiInstance.CreateSmartContractWithHttpInfo(createSmartContractRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateSmartContractWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createSmartContractRequest** | [**CreateSmartContractRequest**](CreateSmartContractRequest.md) |  | [optional]  |

### Return type

[**SmartContract**](SmartContract.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createuser"></a>
# **CreateUser**
> UserCreateResponse CreateUser (UserCreateRequest userCreateRequest = null)

Creates a User

Supplying the user object, this will update the user with the new information supplied in the body of the request.  Optionally, the user's password may be provided in the User object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var userCreateRequest = new UserCreateRequest(); // UserCreateRequest |  (optional) 

            try
            {
                // Creates a User
                UserCreateResponse result = apiInstance.CreateUser(userCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a User
    ApiResponse<UserCreateResponse> response = apiInstance.CreateUserWithHttpInfo(userCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userCreateRequest** | [**UserCreateRequest**](UserCreateRequest.md) |  | [optional]  |

### Return type

[**UserCreateResponse**](UserCreateResponse.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createusernamepasswordsession"></a>
# **CreateUsernamePasswordSession**
> SessionCreation CreateUsernamePasswordSession (UsernamePasswordSessionRequest usernamePasswordSessionRequest = null)

Creates a Session

Begins a session by accepting both the UserID and the Passoword.  Upon successful completion of this call, the user will be added to the current HTTP session.  If the session expires, the user will have to reestablish the session by supplying credentials again.  This is most useful for applications delivered in a web page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateUsernamePasswordSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var usernamePasswordSessionRequest = new UsernamePasswordSessionRequest(); // UsernamePasswordSessionRequest |  (optional) 

            try
            {
                // Creates a Session
                SessionCreation result = apiInstance.CreateUsernamePasswordSession(usernamePasswordSessionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateUsernamePasswordSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateUsernamePasswordSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a Session
    ApiResponse<SessionCreation> response = apiInstance.CreateUsernamePasswordSessionWithHttpInfo(usernamePasswordSessionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateUsernamePasswordSessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **usernamePasswordSessionRequest** | [**UsernamePasswordSessionRequest**](UsernamePasswordSessionRequest.md) |  | [optional]  |

### Return type

[**SessionCreation**](SessionCreation.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createvault"></a>
# **CreateVault**
> Vault CreateVault (CreateVaultRequest createVaultRequest = null)

Creates a new  Vault

Creates a new  Vault, associated with the given user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateVaultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var createVaultRequest = new CreateVaultRequest(); // CreateVaultRequest |  (optional) 

            try
            {
                // Creates a new  Vault
                Vault result = apiInstance.CreateVault(createVaultRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateVault: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateVaultWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new  Vault
    ApiResponse<Vault> response = apiInstance.CreateVaultWithHttpInfo(createVaultRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateVaultWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createVaultRequest** | [**CreateVaultRequest**](CreateVaultRequest.md) |  | [optional]  |

### Return type

[**Vault**](Vault.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createwallet"></a>
# **CreateWallet**
> Wallet CreateWallet (string vaultId, CreateWalletRequest createWalletRequest = null)

Creates a new  Wallet

Creates a new  Wallet, associated with the given user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class CreateWalletExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var vaultId = "vaultId_example";  // string | 
            var createWalletRequest = new CreateWalletRequest(); // CreateWalletRequest |  (optional) 

            try
            {
                // Creates a new  Wallet
                Wallet result = apiInstance.CreateWallet(vaultId, createWalletRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateWallet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateWalletWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new  Wallet
    ApiResponse<Wallet> response = apiInstance.CreateWalletWithHttpInfo(vaultId, createWalletRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateWalletWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vaultId** | **string** |  |  |
| **createWalletRequest** | [**CreateWalletRequest**](CreateWalletRequest.md) |  | [optional]  |

### Return type

[**Wallet**](Wallet.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deactivateprofile"></a>
# **DeactivateProfile**
> void DeactivateProfile (string profileId)

Deletes a Profile

Deletes and permanently removes the Profile from the server.  The server maykeep some record around to preserve relationships and references, but this profile will not be accessible again until it is recreated.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class DeactivateProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var profileId = "profileId_example";  // string | 

            try
            {
                // Deletes a Profile
                apiInstance.DeactivateProfile(profileId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeactivateProfile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeactivateProfileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a Profile
    apiInstance.DeactivateProfileWithHttpInfo(profileId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeactivateProfileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **profileId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deactivateuser"></a>
# **DeactivateUser**
> void DeactivateUser (string name)

Deletes a User

Deletes and permanently removes the user from the server.  The server may keep some metadata as necessary to avoid data inconsistency.  However, the user has been deleted from the client standpoint and will not be accessible through any of the existing APIs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class DeactivateUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var name = "name_example";  // string | 

            try
            {
                // Deletes a User
                apiInstance.DeactivateUser(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeactivateUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeactivateUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a User
    apiInstance.DeactivateUserWithHttpInfo(name);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeactivateUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteadvancedinventoryitem"></a>
# **DeleteAdvancedInventoryItem**
> void DeleteAdvancedInventoryItem (string inventoryItemId)

Delete the inventory item as identified by the given item name/id

Delete the inventory item as identified by the given item name/id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class DeleteAdvancedInventoryItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var inventoryItemId = "inventoryItemId_example";  // string | 

            try
            {
                // Delete the inventory item as identified by the given item name/id
                apiInstance.DeleteAdvancedInventoryItem(inventoryItemId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteAdvancedInventoryItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAdvancedInventoryItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete the inventory item as identified by the given item name/id
    apiInstance.DeleteAdvancedInventoryItemWithHttpInfo(inventoryItemId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteAdvancedInventoryItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inventoryItemId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteapplication"></a>
# **DeleteApplication**
> void DeleteApplication (string nameOrId)

Deletes an Application

Deletes a specific application known to the server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class DeleteApplicationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var nameOrId = "nameOrId_example";  // string | 

            try
            {
                // Deletes an Application
                apiInstance.DeleteApplication(nameOrId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteApplication: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteApplicationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an Application
    apiInstance.DeleteApplicationWithHttpInfo(nameOrId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteApplicationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **nameOrId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteauthscheme"></a>
# **DeleteAuthScheme**
> void DeleteAuthScheme (string authSchemeId)

Deletes an Auth Scheme

Deletes an Auth Scheme with the specified id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class DeleteAuthSchemeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var authSchemeId = "authSchemeId_example";  // string | 

            try
            {
                // Deletes an Auth Scheme
                apiInstance.DeleteAuthScheme(authSchemeId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteAuthScheme: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAuthSchemeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an Auth Scheme
    apiInstance.DeleteAuthSchemeWithHttpInfo(authSchemeId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteAuthSchemeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authSchemeId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteauthscheme1"></a>
# **DeleteAuthScheme1**
> void DeleteAuthScheme1 (string oAuth2AuthSchemeId)

Deletes an Auth Scheme

Deletes an Auth Scheme with the specified id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class DeleteAuthScheme1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var oAuth2AuthSchemeId = "oAuth2AuthSchemeId_example";  // string | 

            try
            {
                // Deletes an Auth Scheme
                apiInstance.DeleteAuthScheme1(oAuth2AuthSchemeId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteAuthScheme1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAuthScheme1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an Auth Scheme
    apiInstance.DeleteAuthScheme1WithHttpInfo(oAuth2AuthSchemeId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteAuthScheme1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **oAuth2AuthSchemeId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteauthscheme2"></a>
# **DeleteAuthScheme2**
> void DeleteAuthScheme2 (string oidcAuthSchemeId)

Deletes an Auth Scheme

Deletes an Auth Scheme with the specified id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class DeleteAuthScheme2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var oidcAuthSchemeId = "oidcAuthSchemeId_example";  // string | 

            try
            {
                // Deletes an Auth Scheme
                apiInstance.DeleteAuthScheme2(oidcAuthSchemeId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteAuthScheme2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAuthScheme2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an Auth Scheme
    apiInstance.DeleteAuthScheme2WithHttpInfo(oidcAuthSchemeId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteAuthScheme2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **oidcAuthSchemeId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletecontract"></a>
# **DeleteContract**
> void DeleteContract (string contractId)

Deletes a  Smart Contract

Deletes a  Smart Contract with the specified contractId.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class DeleteContractExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var contractId = "contractId_example";  // string | 

            try
            {
                // Deletes a  Smart Contract
                apiInstance.DeleteContract(contractId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteContract: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteContractWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a  Smart Contract
    apiInstance.DeleteContractWithHttpInfo(contractId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteContractWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contractId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletedeployment"></a>
# **DeleteDeployment**
> void DeleteDeployment (string applicationId, string deploymentId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class DeleteDeploymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var applicationId = "applicationId_example";  // string | 
            var deploymentId = "deploymentId_example";  // string | 

            try
            {
                apiInstance.DeleteDeployment(applicationId, deploymentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteDeployment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteDeploymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DeleteDeploymentWithHttpInfo(applicationId, deploymentId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteDeploymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **string** |  |  |
| **deploymentId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletedistinctinventoryitem"></a>
# **DeleteDistinctInventoryItem**
> void DeleteDistinctInventoryItem (string distinctInventoryItemId)

Delete the inventory item as identified by the given item name/id

Delete the inventory item as identified by the given item name/id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class DeleteDistinctInventoryItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var distinctInventoryItemId = "distinctInventoryItemId_example";  // string | 

            try
            {
                // Delete the inventory item as identified by the given item name/id
                apiInstance.DeleteDistinctInventoryItem(distinctInventoryItemId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteDistinctInventoryItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteDistinctInventoryItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete the inventory item as identified by the given item name/id
    apiInstance.DeleteDistinctInventoryItemWithHttpInfo(distinctInventoryItemId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteDistinctInventoryItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **distinctInventoryItemId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletefcmregistration"></a>
# **DeleteFCMRegistration**
> void DeleteFCMRegistration (string fcmRegistrationId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class DeleteFCMRegistrationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var fcmRegistrationId = "fcmRegistrationId_example";  // string | 

            try
            {
                apiInstance.DeleteFCMRegistration(fcmRegistrationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteFCMRegistration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteFCMRegistrationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DeleteFCMRegistrationWithHttpInfo(fcmRegistrationId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteFCMRegistrationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fcmRegistrationId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletefacebookapplicationconfiguration"></a>
# **DeleteFacebookApplicationConfiguration**
> void DeleteFacebookApplicationConfiguration (string applicationNameOrId, string applicationConfigurationNameOrId)

Deletes a Facebook ApplicationConfiguration

Deletes an existing Facebook Application profile if it is known to the server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class DeleteFacebookApplicationConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var applicationNameOrId = "applicationNameOrId_example";  // string | 
            var applicationConfigurationNameOrId = "applicationConfigurationNameOrId_example";  // string | 

            try
            {
                // Deletes a Facebook ApplicationConfiguration
                apiInstance.DeleteFacebookApplicationConfiguration(applicationNameOrId, applicationConfigurationNameOrId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteFacebookApplicationConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteFacebookApplicationConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a Facebook ApplicationConfiguration
    apiInstance.DeleteFacebookApplicationConfigurationWithHttpInfo(applicationNameOrId, applicationConfigurationNameOrId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteFacebookApplicationConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationNameOrId** | **string** |  |  |
| **applicationConfigurationNameOrId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletefirebaseapplicationconfiguration"></a>
# **DeleteFirebaseApplicationConfiguration**
> void DeleteFirebaseApplicationConfiguration (string applicationNameOrId, string applicationConfigurationNameOrId)

Deletes a Firebase ApplicationConfiguration

Deletes an existing Firebase Application profile if it is known to the server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class DeleteFirebaseApplicationConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var applicationNameOrId = "applicationNameOrId_example";  // string | 
            var applicationConfigurationNameOrId = "applicationConfigurationNameOrId_example";  // string | 

            try
            {
                // Deletes a Firebase ApplicationConfiguration
                apiInstance.DeleteFirebaseApplicationConfiguration(applicationNameOrId, applicationConfigurationNameOrId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteFirebaseApplicationConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteFirebaseApplicationConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a Firebase ApplicationConfiguration
    apiInstance.DeleteFirebaseApplicationConfigurationWithHttpInfo(applicationNameOrId, applicationConfigurationNameOrId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteFirebaseApplicationConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationNameOrId** | **string** |  |  |
| **applicationConfigurationNameOrId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletefollower"></a>
# **DeleteFollower**
> void DeleteFollower (string profileId, string profileToUnfollowId)

Deletes a Follower relationship

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class DeleteFollowerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var profileId = "profileId_example";  // string | 
            var profileToUnfollowId = "profileToUnfollowId_example";  // string | 

            try
            {
                // Deletes a Follower relationship
                apiInstance.DeleteFollower(profileId, profileToUnfollowId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteFollower: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteFollowerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a Follower relationship
    apiInstance.DeleteFollowerWithHttpInfo(profileId, profileToUnfollowId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteFollowerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **profileId** | **string** |  |  |
| **profileToUnfollowId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletefriendregistration"></a>
# **DeleteFriendRegistration**
> void DeleteFriendRegistration (string friendId)

Deletes a Friend

Once a friend is deleted, re-creating a friend will set the friendship status to outgoing.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class DeleteFriendRegistrationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var friendId = "friendId_example";  // string | 

            try
            {
                // Deletes a Friend
                apiInstance.DeleteFriendRegistration(friendId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteFriendRegistration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteFriendRegistrationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a Friend
    apiInstance.DeleteFriendRegistrationWithHttpInfo(friendId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteFriendRegistrationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **friendId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletegoogleplayapplicationconfiguration"></a>
# **DeleteGooglePlayApplicationConfiguration**
> void DeleteGooglePlayApplicationConfiguration (string applicationNameOrId, string applicationConfigurationNameOrId)

Deletes a Google Play ApplicationConfiguration

Deletes an existing Google Play Application profile if it is known to the server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class DeleteGooglePlayApplicationConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var applicationNameOrId = "applicationNameOrId_example";  // string | 
            var applicationConfigurationNameOrId = "applicationConfigurationNameOrId_example";  // string | 

            try
            {
                // Deletes a Google Play ApplicationConfiguration
                apiInstance.DeleteGooglePlayApplicationConfiguration(applicationNameOrId, applicationConfigurationNameOrId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteGooglePlayApplicationConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteGooglePlayApplicationConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a Google Play ApplicationConfiguration
    apiInstance.DeleteGooglePlayApplicationConfigurationWithHttpInfo(applicationNameOrId, applicationConfigurationNameOrId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteGooglePlayApplicationConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationNameOrId** | **string** |  |  |
| **applicationConfigurationNameOrId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteiosapplicationconfiguration"></a>
# **DeleteIosApplicationConfiguration**
> void DeleteIosApplicationConfiguration (string applicationNameOrId, string applicationConfigurationNameOrId)

Deletes a iOS ApplicationConfiguration

Deletes an existing iOS Application profile if it is known to the server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class DeleteIosApplicationConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var applicationNameOrId = "applicationNameOrId_example";  // string | 
            var applicationConfigurationNameOrId = "applicationConfigurationNameOrId_example";  // string | 

            try
            {
                // Deletes a iOS ApplicationConfiguration
                apiInstance.DeleteIosApplicationConfiguration(applicationNameOrId, applicationConfigurationNameOrId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteIosApplicationConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteIosApplicationConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a iOS ApplicationConfiguration
    apiInstance.DeleteIosApplicationConfigurationWithHttpInfo(applicationNameOrId, applicationConfigurationNameOrId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteIosApplicationConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationNameOrId** | **string** |  |  |
| **applicationConfigurationNameOrId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletelargeobject"></a>
# **DeleteLargeObject**
> void DeleteLargeObject (string largeObjectId)

Deletes a LargeObject

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class DeleteLargeObjectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var largeObjectId = "largeObjectId_example";  // string | 

            try
            {
                // Deletes a LargeObject
                apiInstance.DeleteLargeObject(largeObjectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteLargeObject: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteLargeObjectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a LargeObject
    apiInstance.DeleteLargeObjectWithHttpInfo(largeObjectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteLargeObjectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **largeObjectId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteleaderboard"></a>
# **DeleteLeaderboard**
> void DeleteLeaderboard (string nameOrId)

Deletes an Leaderboard

Deletes a specific leaderboard known to the server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class DeleteLeaderboardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var nameOrId = "nameOrId_example";  // string | 

            try
            {
                // Deletes an Leaderboard
                apiInstance.DeleteLeaderboard(nameOrId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteLeaderboard: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteLeaderboardWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an Leaderboard
    apiInstance.DeleteLeaderboardWithHttpInfo(nameOrId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteLeaderboardWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **nameOrId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletematch"></a>
# **DeleteMatch**
> void DeleteMatch (string matchId)

Deletes a Match

Deletes and permanently removes the Match fromt he server.  This effectively will cancel any pending request for a match.  If a game is currently being played agaist the match, the server may reject the request to delete the match until the game concludes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class DeleteMatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var matchId = "matchId_example";  // string | 

            try
            {
                // Deletes a Match
                apiInstance.DeleteMatch(matchId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteMatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteMatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a Match
    apiInstance.DeleteMatchWithHttpInfo(matchId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteMatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **matchId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletematchmakingapplicationconfiguration"></a>
# **DeleteMatchmakingApplicationConfiguration**
> void DeleteMatchmakingApplicationConfiguration (string applicationNameOrId, string applicationConfigurationNameOrId)

Deletes a iOS ApplicationConfiguration

Deletes an existing iOS Application profile if it is known to the server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class DeleteMatchmakingApplicationConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var applicationNameOrId = "applicationNameOrId_example";  // string | 
            var applicationConfigurationNameOrId = "applicationConfigurationNameOrId_example";  // string | 

            try
            {
                // Deletes a iOS ApplicationConfiguration
                apiInstance.DeleteMatchmakingApplicationConfiguration(applicationNameOrId, applicationConfigurationNameOrId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteMatchmakingApplicationConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteMatchmakingApplicationConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a iOS ApplicationConfiguration
    apiInstance.DeleteMatchmakingApplicationConfigurationWithHttpInfo(applicationNameOrId, applicationConfigurationNameOrId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteMatchmakingApplicationConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationNameOrId** | **string** |  |  |
| **applicationConfigurationNameOrId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletemetadata"></a>
# **DeleteMetadata**
> void DeleteMetadata (string id)

Deletes a specific Metadata object

Deletes a specific metadata object by name or id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class DeleteMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Deletes a specific Metadata object
                apiInstance.DeleteMetadata(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteMetadata: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteMetadataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a specific Metadata object
    apiInstance.DeleteMetadataWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteMetadataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletemetadataspec"></a>
# **DeleteMetadataSpec**
> void DeleteMetadataSpec (string metadataSpecId)

Deletes a MetadataSpec

Deletes a MetadataSpec with the specified id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class DeleteMetadataSpecExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var metadataSpecId = "metadataSpecId_example";  // string | 

            try
            {
                // Deletes a MetadataSpec
                apiInstance.DeleteMetadataSpec(metadataSpecId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteMetadataSpec: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteMetadataSpecWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a MetadataSpec
    apiInstance.DeleteMetadataSpecWithHttpInfo(metadataSpecId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteMetadataSpecWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **metadataSpecId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletemission"></a>
# **DeleteMission**
> void DeleteMission (string missionNameOrId)

Deletes the Mission identified by id or by name

Deletes a mission by the passed in identifier

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class DeleteMissionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var missionNameOrId = "missionNameOrId_example";  // string | 

            try
            {
                // Deletes the Mission identified by id or by name
                apiInstance.DeleteMission(missionNameOrId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteMission: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteMissionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes the Mission identified by id or by name
    apiInstance.DeleteMissionWithHttpInfo(missionNameOrId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteMissionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **missionNameOrId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletepsnapplicationconfiguration"></a>
# **DeletePSNApplicationConfiguration**
> void DeletePSNApplicationConfiguration (string applicationNameOrId, string applicationConfigurationNameOrId)

Deletes a PSN ApplicationConfiguration

Deletes an existing PSN Application profile if it is known to the server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class DeletePSNApplicationConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var applicationNameOrId = "applicationNameOrId_example";  // string | 
            var applicationConfigurationNameOrId = "applicationConfigurationNameOrId_example";  // string | 

            try
            {
                // Deletes a PSN ApplicationConfiguration
                apiInstance.DeletePSNApplicationConfiguration(applicationNameOrId, applicationConfigurationNameOrId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeletePSNApplicationConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePSNApplicationConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a PSN ApplicationConfiguration
    apiInstance.DeletePSNApplicationConfigurationWithHttpInfo(applicationNameOrId, applicationConfigurationNameOrId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeletePSNApplicationConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationNameOrId** | **string** |  |  |
| **applicationConfigurationNameOrId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteprogress"></a>
# **DeleteProgress**
> void DeleteProgress (string progressId)

Deletes the Progress identified by id

Deletes a progress by the passed in identifier

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class DeleteProgressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var progressId = "progressId_example";  // string | 

            try
            {
                // Deletes the Progress identified by id
                apiInstance.DeleteProgress(progressId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteProgress: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteProgressWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes the Progress identified by id
    apiInstance.DeleteProgressWithHttpInfo(progressId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteProgressWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **progressId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletesavedocument"></a>
# **DeleteSaveDocument**
> void DeleteSaveDocument (string saveDataDocumentId)

Deletes a save data document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class DeleteSaveDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var saveDataDocumentId = "saveDataDocumentId_example";  // string | 

            try
            {
                // Deletes a save data document
                apiInstance.DeleteSaveDocument(saveDataDocumentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteSaveDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSaveDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a save data document
    apiInstance.DeleteSaveDocumentWithHttpInfo(saveDataDocumentId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteSaveDocumentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **saveDataDocumentId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteschedule"></a>
# **DeleteSchedule**
> void DeleteSchedule (string scheduleNameOrId)

Deletes the Schedule identified by id or by name

Deletes a schedule by the passed in identifier

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class DeleteScheduleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var scheduleNameOrId = "scheduleNameOrId_example";  // string | 

            try
            {
                // Deletes the Schedule identified by id or by name
                apiInstance.DeleteSchedule(scheduleNameOrId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteSchedule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteScheduleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes the Schedule identified by id or by name
    apiInstance.DeleteScheduleWithHttpInfo(scheduleNameOrId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteScheduleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scheduleNameOrId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletescheduleevent"></a>
# **DeleteScheduleEvent**
> void DeleteScheduleEvent (string scheduleNameOrId, string scheduleEventId)

Deletes the ScheduleEvent identified by id or by name

Deletes a schedule by the passed in identifier

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class DeleteScheduleEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var scheduleNameOrId = "scheduleNameOrId_example";  // string | 
            var scheduleEventId = "scheduleEventId_example";  // string | 

            try
            {
                // Deletes the ScheduleEvent identified by id or by name
                apiInstance.DeleteScheduleEvent(scheduleNameOrId, scheduleEventId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteScheduleEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteScheduleEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes the ScheduleEvent identified by id or by name
    apiInstance.DeleteScheduleEventWithHttpInfo(scheduleNameOrId, scheduleEventId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteScheduleEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scheduleNameOrId** | **string** |  |  |
| **scheduleEventId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletesimpleinventoryitem"></a>
# **DeleteSimpleInventoryItem**
> void DeleteSimpleInventoryItem (string inventoryItemId)

Delete the inventory item as identified by the given item name/id

Delete the inventory item as identified by the given item name/id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class DeleteSimpleInventoryItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var inventoryItemId = "inventoryItemId_example";  // string | 

            try
            {
                // Delete the inventory item as identified by the given item name/id
                apiInstance.DeleteSimpleInventoryItem(inventoryItemId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteSimpleInventoryItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSimpleInventoryItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete the inventory item as identified by the given item name/id
    apiInstance.DeleteSimpleInventoryItemWithHttpInfo(inventoryItemId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteSimpleInventoryItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inventoryItemId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletevault"></a>
# **DeleteVault**
> void DeleteVault (string vaultId)

Deletes a  Vault

Deletes a  Vault with the specified id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class DeleteVaultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var vaultId = "vaultId_example";  // string | 

            try
            {
                // Deletes a  Vault
                apiInstance.DeleteVault(vaultId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteVault: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteVaultWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a  Vault
    apiInstance.DeleteVaultWithHttpInfo(vaultId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteVaultWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vaultId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletewallet"></a>
# **DeleteWallet**
> void DeleteWallet (string vaultId, string walletId)

Deletes a  Wallet

Deletes a  Wallet with the specified id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class DeleteWalletExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var vaultId = "vaultId_example";  // string | 
            var walletId = "walletId_example";  // string | 

            try
            {
                // Deletes a  Wallet
                apiInstance.DeleteWallet(vaultId, walletId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteWallet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteWalletWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a  Wallet
    apiInstance.DeleteWalletWithHttpInfo(vaultId, walletId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteWalletWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vaultId** | **string** |  |  |
| **walletId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="generatecode"></a>
# **GenerateCode**
> void GenerateCode (CodegenRequest codegenRequest = null)

Generate Client API Code

Generates API code for use on the client. Will generate Elements core if no application is specified in the request body.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GenerateCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var codegenRequest = new CodegenRequest(); // CodegenRequest |  (optional) 

            try
            {
                // Generate Client API Code
                apiInstance.GenerateCode(codegenRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GenerateCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GenerateCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Generate Client API Code
    apiInstance.GenerateCodeWithHttpInfo(codegenRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GenerateCodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **codegenRequest** | [**CodegenRequest**](CodegenRequest.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getadvancedinventoryitem"></a>
# **GetAdvancedInventoryItem**
> InventoryItem GetAdvancedInventoryItem (string inventoryItemId)

Gets inventory item for the specified item

Gets the first (primary) inventory item for the specified item

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetAdvancedInventoryItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var inventoryItemId = "inventoryItemId_example";  // string | 

            try
            {
                // Gets inventory item for the specified item
                InventoryItem result = apiInstance.GetAdvancedInventoryItem(inventoryItemId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAdvancedInventoryItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAdvancedInventoryItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets inventory item for the specified item
    ApiResponse<InventoryItem> response = apiInstance.GetAdvancedInventoryItemWithHttpInfo(inventoryItemId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetAdvancedInventoryItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inventoryItemId** | **string** |  |  |

### Return type

[**InventoryItem**](InventoryItem.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getadvancedinventoryitems"></a>
# **GetAdvancedInventoryItems**
> PaginationInventoryItem GetAdvancedInventoryItems (int? offset = null, int? count = null, string userId = null, string search = null)

Search inventory items

Searches all inventory items in the system and returns the metadata for all matches against the given search filter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetAdvancedInventoryItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var offset = 56;  // int? |  (optional) 
            var count = 56;  // int? |  (optional) 
            var userId = "userId_example";  // string |  (optional) 
            var search = "search_example";  // string |  (optional) 

            try
            {
                // Search inventory items
                PaginationInventoryItem result = apiInstance.GetAdvancedInventoryItems(offset, count, userId, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAdvancedInventoryItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAdvancedInventoryItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search inventory items
    ApiResponse<PaginationInventoryItem> response = apiInstance.GetAdvancedInventoryItemsWithHttpInfo(offset, count, userId, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetAdvancedInventoryItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** |  | [optional]  |
| **count** | **int?** |  | [optional]  |
| **userId** | **string** |  | [optional]  |
| **search** | **string** |  | [optional]  |

### Return type

[**PaginationInventoryItem**](PaginationInventoryItem.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getapplication"></a>
# **GetApplication**
> Application GetApplication (string nameOrId)

Get an Application

Gets the metadata for a single application.  This may include more specific details not available in the bulk-get or fetch operation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetApplicationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var nameOrId = "nameOrId_example";  // string | 

            try
            {
                // Get an Application
                Application result = apiInstance.GetApplication(nameOrId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetApplication: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetApplicationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an Application
    ApiResponse<Application> response = apiInstance.GetApplicationWithHttpInfo(nameOrId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetApplicationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **nameOrId** | **string** |  |  |

### Return type

[**Application**](Application.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getapplicationprofiles"></a>
# **GetApplicationProfiles**
> PaginationApplicationConfiguration GetApplicationProfiles (string applicationNameOrId, int? offset = null, int? count = null, string search = null)

Searches application profiles

Searches all instances of ApplicationProfiles associated with  the application.  The search query may be a full text search.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetApplicationProfilesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var applicationNameOrId = "applicationNameOrId_example";  // string | 
            var offset = 56;  // int? |  (optional) 
            var count = 56;  // int? |  (optional) 
            var search = "search_example";  // string |  (optional) 

            try
            {
                // Searches application profiles
                PaginationApplicationConfiguration result = apiInstance.GetApplicationProfiles(applicationNameOrId, offset, count, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetApplicationProfiles: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetApplicationProfilesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Searches application profiles
    ApiResponse<PaginationApplicationConfiguration> response = apiInstance.GetApplicationProfilesWithHttpInfo(applicationNameOrId, offset, count, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetApplicationProfilesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationNameOrId** | **string** |  |  |
| **offset** | **int?** |  | [optional]  |
| **count** | **int?** |  | [optional]  |
| **search** | **string** |  | [optional]  |

### Return type

[**PaginationApplicationConfiguration**](PaginationApplicationConfiguration.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getapplications"></a>
# **GetApplications**
> PaginationApplication GetApplications (int? offset = null, int? count = null, string search = null)

Search Applications

Performs a full-text search of all applications known to the server.  As with other full-text endpoints this allows for pagination and offset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetApplicationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var offset = 56;  // int? |  (optional) 
            var count = 56;  // int? |  (optional) 
            var search = "search_example";  // string |  (optional) 

            try
            {
                // Search Applications
                PaginationApplication result = apiInstance.GetApplications(offset, count, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetApplications: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetApplicationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search Applications
    ApiResponse<PaginationApplication> response = apiInstance.GetApplicationsWithHttpInfo(offset, count, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetApplicationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** |  | [optional]  |
| **count** | **int?** |  | [optional]  |
| **search** | **string** |  | [optional]  |

### Return type

[**PaginationApplication**](PaginationApplication.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getauthscheme"></a>
# **GetAuthScheme**
> AuthScheme GetAuthScheme (string authSchemeId)

Gets a specific Auth Scheme

Gets a specific Auth Scheme by the authSchemeId.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetAuthSchemeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var authSchemeId = "authSchemeId_example";  // string | 

            try
            {
                // Gets a specific Auth Scheme
                AuthScheme result = apiInstance.GetAuthScheme(authSchemeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAuthScheme: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAuthSchemeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a specific Auth Scheme
    ApiResponse<AuthScheme> response = apiInstance.GetAuthSchemeWithHttpInfo(authSchemeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetAuthSchemeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authSchemeId** | **string** |  |  |

### Return type

[**AuthScheme**](AuthScheme.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getauthscheme1"></a>
# **GetAuthScheme1**
> OAuth2AuthScheme GetAuthScheme1 (string oAuth2AuthSchemeId)

Gets a specific Auth Scheme

Gets a specific Auth Scheme by the oAuth2AuthSchemeId.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetAuthScheme1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var oAuth2AuthSchemeId = "oAuth2AuthSchemeId_example";  // string | 

            try
            {
                // Gets a specific Auth Scheme
                OAuth2AuthScheme result = apiInstance.GetAuthScheme1(oAuth2AuthSchemeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAuthScheme1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAuthScheme1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a specific Auth Scheme
    ApiResponse<OAuth2AuthScheme> response = apiInstance.GetAuthScheme1WithHttpInfo(oAuth2AuthSchemeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetAuthScheme1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **oAuth2AuthSchemeId** | **string** |  |  |

### Return type

[**OAuth2AuthScheme**](OAuth2AuthScheme.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getauthscheme2"></a>
# **GetAuthScheme2**
> OidcAuthScheme GetAuthScheme2 (string oidcAuthSchemeId)

Gets a specific Auth Scheme

Gets a specific Auth Scheme by the oidcAuthSchemeId.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetAuthScheme2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var oidcAuthSchemeId = "oidcAuthSchemeId_example";  // string | 

            try
            {
                // Gets a specific Auth Scheme
                OidcAuthScheme result = apiInstance.GetAuthScheme2(oidcAuthSchemeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAuthScheme2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAuthScheme2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a specific Auth Scheme
    ApiResponse<OidcAuthScheme> response = apiInstance.GetAuthScheme2WithHttpInfo(oidcAuthSchemeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetAuthScheme2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **oidcAuthSchemeId** | **string** |  |  |

### Return type

[**OidcAuthScheme**](OidcAuthScheme.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getauthschemes"></a>
# **GetAuthSchemes**
> PaginationAuthScheme GetAuthSchemes (int? offset = null, int? count = null, List<string> tags = null)

Lists all auth schemes in the system

Requires SUPERUSER access. Gets a pagination of Auth Schemes for the given query.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetAuthSchemesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var offset = 56;  // int? |  (optional) 
            var count = 56;  // int? |  (optional) 
            var tags = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Lists all auth schemes in the system
                PaginationAuthScheme result = apiInstance.GetAuthSchemes(offset, count, tags);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAuthSchemes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAuthSchemesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Lists all auth schemes in the system
    ApiResponse<PaginationAuthScheme> response = apiInstance.GetAuthSchemesWithHttpInfo(offset, count, tags);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetAuthSchemesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** |  | [optional]  |
| **count** | **int?** |  | [optional]  |
| **tags** | [**List&lt;string&gt;**](string.md) |  | [optional]  |

### Return type

[**PaginationAuthScheme**](PaginationAuthScheme.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getauthschemes1"></a>
# **GetAuthSchemes1**
> PaginationOAuth2AuthScheme GetAuthSchemes1 (int? offset = null, int? count = null, List<string> tags = null)

Lists all auth schemes in the system

Requires SUPERUSER access. Gets a pagination of Auth Schemes for the given query.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetAuthSchemes1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var offset = 56;  // int? |  (optional) 
            var count = 56;  // int? |  (optional) 
            var tags = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Lists all auth schemes in the system
                PaginationOAuth2AuthScheme result = apiInstance.GetAuthSchemes1(offset, count, tags);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAuthSchemes1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAuthSchemes1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Lists all auth schemes in the system
    ApiResponse<PaginationOAuth2AuthScheme> response = apiInstance.GetAuthSchemes1WithHttpInfo(offset, count, tags);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetAuthSchemes1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** |  | [optional]  |
| **count** | **int?** |  | [optional]  |
| **tags** | [**List&lt;string&gt;**](string.md) |  | [optional]  |

### Return type

[**PaginationOAuth2AuthScheme**](PaginationOAuth2AuthScheme.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getauthschemes2"></a>
# **GetAuthSchemes2**
> PaginationOidcAuthScheme GetAuthSchemes2 (int? offset = null, int? count = null, List<string> tags = null)

Lists all auth schemes in the system

Requires SUPERUSER access. Gets a pagination of Auth Schemes for the given query.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetAuthSchemes2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var offset = 56;  // int? |  (optional) 
            var count = 56;  // int? |  (optional) 
            var tags = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Lists all auth schemes in the system
                PaginationOidcAuthScheme result = apiInstance.GetAuthSchemes2(offset, count, tags);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAuthSchemes2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAuthSchemes2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Lists all auth schemes in the system
    ApiResponse<PaginationOidcAuthScheme> response = apiInstance.GetAuthSchemes2WithHttpInfo(offset, count, tags);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetAuthSchemes2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** |  | [optional]  |
| **count** | **int?** |  | [optional]  |
| **tags** | [**List&lt;string&gt;**](string.md) |  | [optional]  |

### Return type

[**PaginationOidcAuthScheme**](PaginationOidcAuthScheme.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcurrentdeployment"></a>
# **GetCurrentDeployment**
> Deployment GetCurrentDeployment (string applicationId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetCurrentDeploymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var applicationId = "applicationId_example";  // string | 

            try
            {
                Deployment result = apiInstance.GetCurrentDeployment(applicationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetCurrentDeployment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCurrentDeploymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Deployment> response = apiInstance.GetCurrentDeploymentWithHttpInfo(applicationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetCurrentDeploymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **string** |  |  |

### Return type

[**Deployment**](Deployment.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcurrentprofile"></a>
# **GetCurrentProfile**
> Profile GetCurrentProfile ()

Gets the current Profile

This is a special endpoing which fetches the current Profile based on current auth credentials.  This considers the currently loggged-in Dser as well as the Application or Application Configuration against which the User is operating.  This may not be availble, in which case the appopraite error is rasied.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetCurrentProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);

            try
            {
                // Gets the current Profile
                Profile result = apiInstance.GetCurrentProfile();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetCurrentProfile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCurrentProfileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the current Profile
    ApiResponse<Profile> response = apiInstance.GetCurrentProfileWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetCurrentProfileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**Profile**](Profile.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcurrentuser"></a>
# **GetCurrentUser**
> User GetCurrentUser ()

Gets the current User

A special endpoint used to get the current user for the request.  The current user is typically associated with the session but may be derived any other way.  This is essentially an alias for using GET /user/myUserId

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetCurrentUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);

            try
            {
                // Gets the current User
                User result = apiInstance.GetCurrentUser();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetCurrentUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCurrentUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the current User
    ApiResponse<User> response = apiInstance.GetCurrentUserWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetCurrentUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**User**](User.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getdeployment"></a>
# **GetDeployment**
> Deployment GetDeployment (string applicationId, string deploymentId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetDeploymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var applicationId = "applicationId_example";  // string | 
            var deploymentId = "deploymentId_example";  // string | 

            try
            {
                Deployment result = apiInstance.GetDeployment(applicationId, deploymentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDeployment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDeploymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Deployment> response = apiInstance.GetDeploymentWithHttpInfo(applicationId, deploymentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetDeploymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **string** |  |  |
| **deploymentId** | **string** |  |  |

### Return type

[**Deployment**](Deployment.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getdeployments"></a>
# **GetDeployments**
> PaginationDeployment GetDeployments (string applicationId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetDeploymentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var applicationId = "applicationId_example";  // string | 

            try
            {
                PaginationDeployment result = apiInstance.GetDeployments(applicationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDeployments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDeploymentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PaginationDeployment> response = apiInstance.GetDeploymentsWithHttpInfo(applicationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetDeploymentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **string** |  |  |

### Return type

[**PaginationDeployment**](PaginationDeployment.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getdistinctinventoryitem"></a>
# **GetDistinctInventoryItem**
> DistinctInventoryItem GetDistinctInventoryItem (string inventoryItemId)

Gets inventory item for the specified item

Gets the first (primary) inventory item for the specified item

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetDistinctInventoryItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var inventoryItemId = "inventoryItemId_example";  // string | 

            try
            {
                // Gets inventory item for the specified item
                DistinctInventoryItem result = apiInstance.GetDistinctInventoryItem(inventoryItemId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDistinctInventoryItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDistinctInventoryItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets inventory item for the specified item
    ApiResponse<DistinctInventoryItem> response = apiInstance.GetDistinctInventoryItemWithHttpInfo(inventoryItemId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetDistinctInventoryItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inventoryItemId** | **string** |  |  |

### Return type

[**DistinctInventoryItem**](DistinctInventoryItem.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getdistinctinventoryitems"></a>
# **GetDistinctInventoryItems**
> PaginationDistinctInventoryItem GetDistinctInventoryItems (int? offset = null, int? count = null, string userId = null, string profileId = null, string search = null)

Search inventory items

Searches all inventory items in the system and returns the metadata for all matches against the given search filter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetDistinctInventoryItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var offset = 56;  // int? |  (optional) 
            var count = 56;  // int? |  (optional) 
            var userId = "userId_example";  // string |  (optional) 
            var profileId = "profileId_example";  // string |  (optional) 
            var search = "search_example";  // string |  (optional) 

            try
            {
                // Search inventory items
                PaginationDistinctInventoryItem result = apiInstance.GetDistinctInventoryItems(offset, count, userId, profileId, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDistinctInventoryItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDistinctInventoryItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search inventory items
    ApiResponse<PaginationDistinctInventoryItem> response = apiInstance.GetDistinctInventoryItemsWithHttpInfo(offset, count, userId, profileId, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetDistinctInventoryItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** |  | [optional]  |
| **count** | **int?** |  | [optional]  |
| **userId** | **string** |  | [optional]  |
| **profileId** | **string** |  | [optional]  |
| **search** | **string** |  | [optional]  |

### Return type

[**PaginationDistinctInventoryItem**](PaginationDistinctInventoryItem.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="geteditorschema"></a>
# **GetEditorSchema**
> EditorSchema GetEditorSchema (string metadataSpecName)

Gets a specific Metadata Editor Schema

Gets a specific Metadata Editor Schema backed by the supplied MetadataSpec by name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetEditorSchemaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var metadataSpecName = "metadataSpecName_example";  // string | 

            try
            {
                // Gets a specific Metadata Editor Schema
                EditorSchema result = apiInstance.GetEditorSchema(metadataSpecName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetEditorSchema: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEditorSchemaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a specific Metadata Editor Schema
    ApiResponse<EditorSchema> response = apiInstance.GetEditorSchemaWithHttpInfo(metadataSpecName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetEditorSchemaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **metadataSpecName** | **string** |  |  |

### Return type

[**EditorSchema**](EditorSchema.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfacebookapplicationconfiguration"></a>
# **GetFacebookApplicationConfiguration**
> FacebookApplicationConfiguration GetFacebookApplicationConfiguration (string applicationNameOrId, string applicationConfigurationNameOrId)

Gets a Facebook Application Configuration

Gets a single Facebook application based on unique name or ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetFacebookApplicationConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var applicationNameOrId = "applicationNameOrId_example";  // string | 
            var applicationConfigurationNameOrId = "applicationConfigurationNameOrId_example";  // string | 

            try
            {
                // Gets a Facebook Application Configuration
                FacebookApplicationConfiguration result = apiInstance.GetFacebookApplicationConfiguration(applicationNameOrId, applicationConfigurationNameOrId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetFacebookApplicationConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFacebookApplicationConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a Facebook Application Configuration
    ApiResponse<FacebookApplicationConfiguration> response = apiInstance.GetFacebookApplicationConfigurationWithHttpInfo(applicationNameOrId, applicationConfigurationNameOrId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetFacebookApplicationConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationNameOrId** | **string** |  |  |
| **applicationConfigurationNameOrId** | **string** |  |  |

### Return type

[**FacebookApplicationConfiguration**](FacebookApplicationConfiguration.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfirebaseapplicationconfiguration"></a>
# **GetFirebaseApplicationConfiguration**
> FirebaseApplicationConfiguration GetFirebaseApplicationConfiguration (string applicationNameOrId, string applicationConfigurationNameOrId)

Gets a Firebase Application Configuration

Gets a single Firebase application based on unique name or ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetFirebaseApplicationConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var applicationNameOrId = "applicationNameOrId_example";  // string | 
            var applicationConfigurationNameOrId = "applicationConfigurationNameOrId_example";  // string | 

            try
            {
                // Gets a Firebase Application Configuration
                FirebaseApplicationConfiguration result = apiInstance.GetFirebaseApplicationConfiguration(applicationNameOrId, applicationConfigurationNameOrId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetFirebaseApplicationConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFirebaseApplicationConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a Firebase Application Configuration
    ApiResponse<FirebaseApplicationConfiguration> response = apiInstance.GetFirebaseApplicationConfigurationWithHttpInfo(applicationNameOrId, applicationConfigurationNameOrId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetFirebaseApplicationConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationNameOrId** | **string** |  |  |
| **applicationConfigurationNameOrId** | **string** |  |  |

### Return type

[**FirebaseApplicationConfiguration**](FirebaseApplicationConfiguration.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfollower"></a>
# **GetFollower**
> Profile GetFollower (string profileId, string followedId)

Gets a specific profile using the ID of the profile and followed id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetFollowerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var profileId = "profileId_example";  // string | 
            var followedId = "followedId_example";  // string | 

            try
            {
                // Gets a specific profile using the ID of the profile and followed id.
                Profile result = apiInstance.GetFollower(profileId, followedId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetFollower: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFollowerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a specific profile using the ID of the profile and followed id.
    ApiResponse<Profile> response = apiInstance.GetFollowerWithHttpInfo(profileId, followedId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetFollowerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **profileId** | **string** |  |  |
| **followedId** | **string** |  |  |

### Return type

[**Profile**](Profile.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfollowers"></a>
# **GetFollowers**
> PaginationProfile GetFollowers (string profileId, int? offset = null, int? count = null)

Search Followers

Searches all followers in the system and returning the metadata for all matches against the given profile id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetFollowersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var profileId = "profileId_example";  // string | 
            var offset = 56;  // int? |  (optional) 
            var count = 56;  // int? |  (optional) 

            try
            {
                // Search Followers
                PaginationProfile result = apiInstance.GetFollowers(profileId, offset, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetFollowers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFollowersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search Followers
    ApiResponse<PaginationProfile> response = apiInstance.GetFollowersWithHttpInfo(profileId, offset, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetFollowersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **profileId** | **string** |  |  |
| **offset** | **int?** |  | [optional]  |
| **count** | **int?** |  | [optional]  |

### Return type

[**PaginationProfile**](PaginationProfile.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfollowers1"></a>
# **GetFollowers1**
> PaginationProfile GetFollowers1 (string profileId, int? offset = null, int? count = null)

Search Followers

Searches all followers in the system and returning the metadata for all matches against the given profile id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetFollowers1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var profileId = "profileId_example";  // string | 
            var offset = 56;  // int? |  (optional) 
            var count = 56;  // int? |  (optional) 

            try
            {
                // Search Followers
                PaginationProfile result = apiInstance.GetFollowers1(profileId, offset, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetFollowers1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFollowers1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search Followers
    ApiResponse<PaginationProfile> response = apiInstance.GetFollowers1WithHttpInfo(profileId, offset, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetFollowers1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **profileId** | **string** |  |  |
| **offset** | **int?** |  | [optional]  |
| **count** | **int?** |  | [optional]  |

### Return type

[**PaginationProfile**](PaginationProfile.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfriend"></a>
# **GetFriend**
> Friend GetFriend (string friendId)

Gets a Specific Friend

Gets a specific friend using the ID of the friend.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetFriendExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var friendId = "friendId_example";  // string | 

            try
            {
                // Gets a Specific Friend
                Friend result = apiInstance.GetFriend(friendId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetFriend: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFriendWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a Specific Friend
    ApiResponse<Friend> response = apiInstance.GetFriendWithHttpInfo(friendId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetFriendWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **friendId** | **string** |  |  |

### Return type

[**Friend**](Friend.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfriends"></a>
# **GetFriends**
> PaginationFriend GetFriends (int? offset = null, int? count = null, string search = null)

Search Friends

Searches all friends in the system and returning the metadata for all matches against the given search filter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetFriendsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var offset = 56;  // int? |  (optional) 
            var count = 56;  // int? |  (optional) 
            var search = "search_example";  // string |  (optional) 

            try
            {
                // Search Friends
                PaginationFriend result = apiInstance.GetFriends(offset, count, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetFriends: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFriendsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search Friends
    ApiResponse<PaginationFriend> response = apiInstance.GetFriendsWithHttpInfo(offset, count, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetFriendsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** |  | [optional]  |
| **count** | **int?** |  | [optional]  |
| **search** | **string** |  | [optional]  |

### Return type

[**PaginationFriend**](PaginationFriend.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getglobalranktabular"></a>
# **GetGlobalRankTabular**
> TabulationRankRow GetGlobalRankTabular (string leaderboardNameOrId, long? leaderboardEpoch = null)

Gets Rank Among all Players

Gets the current Profile's rank among all players for the particular leaderboard.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetGlobalRankTabularExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var leaderboardNameOrId = "leaderboardNameOrId_example";  // string | Specifies the leaderboard name or ID.
            var leaderboardEpoch = 789L;  // long? | Specifies the epoch for the leaderboard. If not provided, the current epoch will be used by default for epochal leaderboards. This value will be ignored for all-time leaderboards. Set this value to 0 to explicitly reference the current epoch (when applicable). (optional) 

            try
            {
                // Gets Rank Among all Players
                TabulationRankRow result = apiInstance.GetGlobalRankTabular(leaderboardNameOrId, leaderboardEpoch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetGlobalRankTabular: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGlobalRankTabularWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets Rank Among all Players
    ApiResponse<TabulationRankRow> response = apiInstance.GetGlobalRankTabularWithHttpInfo(leaderboardNameOrId, leaderboardEpoch);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetGlobalRankTabularWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **leaderboardNameOrId** | **string** | Specifies the leaderboard name or ID. |  |
| **leaderboardEpoch** | **long?** | Specifies the epoch for the leaderboard. If not provided, the current epoch will be used by default for epochal leaderboards. This value will be ignored for all-time leaderboards. Set this value to 0 to explicitly reference the current epoch (when applicable). | [optional]  |

### Return type

[**TabulationRankRow**](TabulationRankRow.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/csv, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getgoogleplayapplicationconfiguration"></a>
# **GetGooglePlayApplicationConfiguration**
> GooglePlayApplicationConfiguration GetGooglePlayApplicationConfiguration (string applicationNameOrId, string applicationConfigurationNameOrId)

Gets a Google Play Application Configuration

Gets a single Google Play application based on unique name or ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetGooglePlayApplicationConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var applicationNameOrId = "applicationNameOrId_example";  // string | 
            var applicationConfigurationNameOrId = "applicationConfigurationNameOrId_example";  // string | 

            try
            {
                // Gets a Google Play Application Configuration
                GooglePlayApplicationConfiguration result = apiInstance.GetGooglePlayApplicationConfiguration(applicationNameOrId, applicationConfigurationNameOrId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetGooglePlayApplicationConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGooglePlayApplicationConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a Google Play Application Configuration
    ApiResponse<GooglePlayApplicationConfiguration> response = apiInstance.GetGooglePlayApplicationConfigurationWithHttpInfo(applicationNameOrId, applicationConfigurationNameOrId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetGooglePlayApplicationConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationNameOrId** | **string** |  |  |
| **applicationConfigurationNameOrId** | **string** |  |  |

### Return type

[**GooglePlayApplicationConfiguration**](GooglePlayApplicationConfiguration.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getiosapplicationconfiguration"></a>
# **GetIosApplicationConfiguration**
> IosApplicationConfiguration GetIosApplicationConfiguration (string applicationNameOrId, string applicationConfigurationNameOrId)

Gets a iOS Application Configuration

Gets a single iOS application based on unique name or ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetIosApplicationConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var applicationNameOrId = "applicationNameOrId_example";  // string | 
            var applicationConfigurationNameOrId = "applicationConfigurationNameOrId_example";  // string | 

            try
            {
                // Gets a iOS Application Configuration
                IosApplicationConfiguration result = apiInstance.GetIosApplicationConfiguration(applicationNameOrId, applicationConfigurationNameOrId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetIosApplicationConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetIosApplicationConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a iOS Application Configuration
    ApiResponse<IosApplicationConfiguration> response = apiInstance.GetIosApplicationConfigurationWithHttpInfo(applicationNameOrId, applicationConfigurationNameOrId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetIosApplicationConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationNameOrId** | **string** |  |  |
| **applicationConfigurationNameOrId** | **string** |  |  |

### Return type

[**IosApplicationConfiguration**](IosApplicationConfiguration.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getitembyidentifier"></a>
# **GetItemByIdentifier**
> Item GetItemByIdentifier (string identifier)

Retrieves a single Item by id or by name

Looks up an item by the passed in identifier

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetItemByIdentifierExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var identifier = "identifier_example";  // string | 

            try
            {
                // Retrieves a single Item by id or by name
                Item result = apiInstance.GetItemByIdentifier(identifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetItemByIdentifier: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetItemByIdentifierWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a single Item by id or by name
    ApiResponse<Item> response = apiInstance.GetItemByIdentifierWithHttpInfo(identifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetItemByIdentifierWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identifier** | **string** |  |  |

### Return type

[**Item**](Item.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getitems"></a>
# **GetItems**
> PaginationItem GetItems (int? offset = null, int? count = null, List<string> tags = null, string category = null, string search = null)

Retrieves all Items

Searches all items and returns all matching items, filtered by the passed in search parameters.  If multiple tags are specified, then all items that contain at least one of the passed in tags is returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var offset = 56;  // int? |  (optional) 
            var count = 56;  // int? |  (optional) 
            var tags = new List<string>(); // List<string> |  (optional) 
            var category = "category_example";  // string |  (optional) 
            var search = "search_example";  // string |  (optional) 

            try
            {
                // Retrieves all Items
                PaginationItem result = apiInstance.GetItems(offset, count, tags, category, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves all Items
    ApiResponse<PaginationItem> response = apiInstance.GetItemsWithHttpInfo(offset, count, tags, category, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** |  | [optional]  |
| **count** | **int?** |  | [optional]  |
| **tags** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **category** | **string** |  | [optional]  |
| **search** | **string** |  | [optional]  |

### Return type

[**PaginationItem**](PaginationItem.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getjsonschema"></a>
# **GetJsonSchema**
> JsonSchema GetJsonSchema (string metadataSpecName)

Gets a specific JSON Schema

Gets a specific JSON Schema backed by the supplied MetadataSpec by name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetJsonSchemaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var metadataSpecName = "metadataSpecName_example";  // string | 

            try
            {
                // Gets a specific JSON Schema
                JsonSchema result = apiInstance.GetJsonSchema(metadataSpecName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetJsonSchema: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetJsonSchemaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a specific JSON Schema
    ApiResponse<JsonSchema> response = apiInstance.GetJsonSchemaWithHttpInfo(metadataSpecName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetJsonSchemaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **metadataSpecName** | **string** |  |  |

### Return type

[**JsonSchema**](JsonSchema.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getlargeobject"></a>
# **GetLargeObject**
> LargeObject GetLargeObject (string largeObjectId)

Get a LargeObject

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetLargeObjectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var largeObjectId = "largeObjectId_example";  // string | 

            try
            {
                // Get a LargeObject
                LargeObject result = apiInstance.GetLargeObject(largeObjectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetLargeObject: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLargeObjectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a LargeObject
    ApiResponse<LargeObject> response = apiInstance.GetLargeObjectWithHttpInfo(largeObjectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetLargeObjectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **largeObjectId** | **string** |  |  |

### Return type

[**LargeObject**](LargeObject.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getleaderboard"></a>
# **GetLeaderboard**
> Leaderboard GetLeaderboard (string nameOrId)

Get an Leaderboard

Gets the metadata for a single leaderboard.  This may include more specific details not availble in the bulk-get or fetch operation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetLeaderboardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var nameOrId = "nameOrId_example";  // string | 

            try
            {
                // Get an Leaderboard
                Leaderboard result = apiInstance.GetLeaderboard(nameOrId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetLeaderboard: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLeaderboardWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an Leaderboard
    ApiResponse<Leaderboard> response = apiInstance.GetLeaderboardWithHttpInfo(nameOrId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetLeaderboardWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **nameOrId** | **string** |  |  |

### Return type

[**Leaderboard**](Leaderboard.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getleaderboards"></a>
# **GetLeaderboards**
> PaginationLeaderboard GetLeaderboards (int? offset = null, int? count = null, string search = null)

Search Leaderboards

Performs a full-text search of all leaderboards known to the server.  As with other full-text endpoints this allows for pagination and offset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetLeaderboardsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var offset = 56;  // int? |  (optional) 
            var count = 56;  // int? |  (optional) 
            var search = "search_example";  // string |  (optional) 

            try
            {
                // Search Leaderboards
                PaginationLeaderboard result = apiInstance.GetLeaderboards(offset, count, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetLeaderboards: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLeaderboardsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search Leaderboards
    ApiResponse<PaginationLeaderboard> response = apiInstance.GetLeaderboardsWithHttpInfo(offset, count, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetLeaderboardsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** |  | [optional]  |
| **count** | **int?** |  | [optional]  |
| **search** | **string** |  | [optional]  |

### Return type

[**PaginationLeaderboard**](PaginationLeaderboard.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmatch"></a>
# **GetMatch**
> Match GetMatch (string matchId, long? socialEngineLongPollTimeout = null)

Gets a Specific Match

Gets a specific match given the match's unique ID.  Additionally, it is possible to instruct the API to wait for a period of time before sending the response.  The request will intentionally hang until the requested Match with ID has been updated in the database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetMatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var matchId = "matchId_example";  // string | 
            var socialEngineLongPollTimeout = 789L;  // long? | The maximum amount time the server will wait until a request returns a default set of data for long polling.  Specifying a zero will request that the server wait indefinitely until responding.  Though, the server may enforce a practical upper limit on the amount of time it takes to return.  Omitting this header will prompt the server to treat the request as a normal request. (optional) 

            try
            {
                // Gets a Specific Match
                Match result = apiInstance.GetMatch(matchId, socialEngineLongPollTimeout);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetMatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a Specific Match
    ApiResponse<Match> response = apiInstance.GetMatchWithHttpInfo(matchId, socialEngineLongPollTimeout);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetMatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **matchId** | **string** |  |  |
| **socialEngineLongPollTimeout** | **long?** | The maximum amount time the server will wait until a request returns a default set of data for long polling.  Specifying a zero will request that the server wait indefinitely until responding.  Though, the server may enforce a practical upper limit on the amount of time it takes to return.  Omitting this header will prompt the server to treat the request as a normal request. | [optional]  |

### Return type

[**Match**](Match.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmatcheduserprofileswithphonenumbers"></a>
# **GetMatchedUserProfilesWithPhoneNumbers**
> InviteViaPhonesResponse GetMatchedUserProfilesWithPhoneNumbers (int? offset = null, int? count = null, InviteViaPhonesRequest inviteViaPhonesRequest = null)

Match normalized phone numbers with requested list

Both phones from request and from DB are normalized and compared.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetMatchedUserProfilesWithPhoneNumbersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var offset = 56;  // int? |  (optional) 
            var count = 56;  // int? |  (optional) 
            var inviteViaPhonesRequest = new InviteViaPhonesRequest(); // InviteViaPhonesRequest |  (optional) 

            try
            {
                // Match normalized phone numbers with requested list
                InviteViaPhonesResponse result = apiInstance.GetMatchedUserProfilesWithPhoneNumbers(offset, count, inviteViaPhonesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetMatchedUserProfilesWithPhoneNumbers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMatchedUserProfilesWithPhoneNumbersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Match normalized phone numbers with requested list
    ApiResponse<InviteViaPhonesResponse> response = apiInstance.GetMatchedUserProfilesWithPhoneNumbersWithHttpInfo(offset, count, inviteViaPhonesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetMatchedUserProfilesWithPhoneNumbersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** |  | [optional]  |
| **count** | **int?** |  | [optional]  |
| **inviteViaPhonesRequest** | [**InviteViaPhonesRequest**](InviteViaPhonesRequest.md) |  | [optional]  |

### Return type

[**InviteViaPhonesResponse**](InviteViaPhonesResponse.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmatches"></a>
# **GetMatches**
> PaginationMatch GetMatches (int? offset = null, int? count = null, string search = null)

List Matches

Lists all matches available.  Under most circumstances, this will requires that a profile be made available to the request.  The server may choose to return an error if no suitable profile can be determined.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetMatchesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var offset = 56;  // int? |  (optional) 
            var count = 56;  // int? |  (optional) 
            var search = "search_example";  // string |  (optional) 

            try
            {
                // List Matches
                PaginationMatch result = apiInstance.GetMatches(offset, count, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetMatches: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMatchesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Matches
    ApiResponse<PaginationMatch> response = apiInstance.GetMatchesWithHttpInfo(offset, count, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetMatchesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** |  | [optional]  |
| **count** | **int?** |  | [optional]  |
| **search** | **string** |  | [optional]  |

### Return type

[**PaginationMatch**](PaginationMatch.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmatchmakingapplicationconfiguration"></a>
# **GetMatchmakingApplicationConfiguration**
> MatchmakingApplicationConfiguration GetMatchmakingApplicationConfiguration (string applicationNameOrId, string applicationConfigurationNameOrId)

Gets a iOS Application Configuration

Gets a single iOS application based on unique name or ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetMatchmakingApplicationConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var applicationNameOrId = "applicationNameOrId_example";  // string | 
            var applicationConfigurationNameOrId = "applicationConfigurationNameOrId_example";  // string | 

            try
            {
                // Gets a iOS Application Configuration
                MatchmakingApplicationConfiguration result = apiInstance.GetMatchmakingApplicationConfiguration(applicationNameOrId, applicationConfigurationNameOrId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetMatchmakingApplicationConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMatchmakingApplicationConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a iOS Application Configuration
    ApiResponse<MatchmakingApplicationConfiguration> response = apiInstance.GetMatchmakingApplicationConfigurationWithHttpInfo(applicationNameOrId, applicationConfigurationNameOrId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetMatchmakingApplicationConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationNameOrId** | **string** |  |  |
| **applicationConfigurationNameOrId** | **string** |  |  |

### Return type

[**MatchmakingApplicationConfiguration**](MatchmakingApplicationConfiguration.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmetadataobject"></a>
# **GetMetadataObject**
> Metadata GetMetadataObject (string id)

Gets a specific Metadata object

Gets a specific metadata object by name or id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetMetadataObjectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Gets a specific Metadata object
                Metadata result = apiInstance.GetMetadataObject(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetMetadataObject: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMetadataObjectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a specific Metadata object
    ApiResponse<Metadata> response = apiInstance.GetMetadataObjectWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetMetadataObjectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**Metadata**](Metadata.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmetadataobjects"></a>
# **GetMetadataObjects**
> PaginationMetadata GetMetadataObjects (int? offset = null, int? count = null, string search = null)

Search Metadata

Searches all metadata in the system and returning all matches against the given search filter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetMetadataObjectsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var offset = 56;  // int? |  (optional) 
            var count = 56;  // int? |  (optional) 
            var search = "search_example";  // string |  (optional) 

            try
            {
                // Search Metadata
                PaginationMetadata result = apiInstance.GetMetadataObjects(offset, count, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetMetadataObjects: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMetadataObjectsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search Metadata
    ApiResponse<PaginationMetadata> response = apiInstance.GetMetadataObjectsWithHttpInfo(offset, count, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetMetadataObjectsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** |  | [optional]  |
| **count** | **int?** |  | [optional]  |
| **search** | **string** |  | [optional]  |

### Return type

[**PaginationMetadata**](PaginationMetadata.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmetadataspec"></a>
# **GetMetadataSpec**
> MetadataSpec GetMetadataSpec (string metadataSpecNameOrId)

Gets a specific Metadata Spec

Gets a specific MetadataSpec by name or Id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetMetadataSpecExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var metadataSpecNameOrId = "metadataSpecNameOrId_example";  // string | 

            try
            {
                // Gets a specific Metadata Spec
                MetadataSpec result = apiInstance.GetMetadataSpec(metadataSpecNameOrId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetMetadataSpec: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMetadataSpecWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a specific Metadata Spec
    ApiResponse<MetadataSpec> response = apiInstance.GetMetadataSpecWithHttpInfo(metadataSpecNameOrId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetMetadataSpecWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **metadataSpecNameOrId** | **string** |  |  |

### Return type

[**MetadataSpec**](MetadataSpec.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmetadataspecs"></a>
# **GetMetadataSpecs**
> PaginationMetadataSpec GetMetadataSpecs (int? offset = null, int? count = null)

Get Metadata Specs

Gets a pagination of Metadata Specs for the given query.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetMetadataSpecsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var offset = 56;  // int? |  (optional) 
            var count = 56;  // int? |  (optional) 

            try
            {
                // Get Metadata Specs
                PaginationMetadataSpec result = apiInstance.GetMetadataSpecs(offset, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetMetadataSpecs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMetadataSpecsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Metadata Specs
    ApiResponse<PaginationMetadataSpec> response = apiInstance.GetMetadataSpecsWithHttpInfo(offset, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetMetadataSpecsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** |  | [optional]  |
| **count** | **int?** |  | [optional]  |

### Return type

[**PaginationMetadataSpec**](PaginationMetadataSpec.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmissionbynameorid"></a>
# **GetMissionByNameOrId**
> Mission GetMissionByNameOrId (string missionNameOrId)

Retrieves a single Mission by id or by name

Looks up a mission by the passed in identifier

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetMissionByNameOrIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var missionNameOrId = "missionNameOrId_example";  // string | 

            try
            {
                // Retrieves a single Mission by id or by name
                Mission result = apiInstance.GetMissionByNameOrId(missionNameOrId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetMissionByNameOrId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMissionByNameOrIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a single Mission by id or by name
    ApiResponse<Mission> response = apiInstance.GetMissionByNameOrIdWithHttpInfo(missionNameOrId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetMissionByNameOrIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **missionNameOrId** | **string** |  |  |

### Return type

[**Mission**](Mission.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmissions"></a>
# **GetMissions**
> PaginationMission GetMissions (int? offset = null, int? count = null, List<string> tags = null, string search = null)

Search Missions

Searches all missions in the system and returning a number of matches against the given search filter, delimited by the offset and count.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetMissionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var offset = 56;  // int? |  (optional) 
            var count = 56;  // int? |  (optional) 
            var tags = new List<string>(); // List<string> |  (optional) 
            var search = "search_example";  // string |  (optional) 

            try
            {
                // Search Missions
                PaginationMission result = apiInstance.GetMissions(offset, count, tags, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetMissions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMissionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search Missions
    ApiResponse<PaginationMission> response = apiInstance.GetMissionsWithHttpInfo(offset, count, tags, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetMissionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** |  | [optional]  |
| **count** | **int?** |  | [optional]  |
| **tags** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **search** | **string** |  | [optional]  |

### Return type

[**PaginationMission**](PaginationMission.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpsnapplicationconfiguration"></a>
# **GetPSNApplicationConfiguration**
> PSNApplicationConfiguration GetPSNApplicationConfiguration (string applicationNameOrId, string applicationConfigurationNameOrId)

Gets a PSN Application Configuration

Gets a single PSN application based on unique name or ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetPSNApplicationConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var applicationNameOrId = "applicationNameOrId_example";  // string | 
            var applicationConfigurationNameOrId = "applicationConfigurationNameOrId_example";  // string | 

            try
            {
                // Gets a PSN Application Configuration
                PSNApplicationConfiguration result = apiInstance.GetPSNApplicationConfiguration(applicationNameOrId, applicationConfigurationNameOrId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetPSNApplicationConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPSNApplicationConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a PSN Application Configuration
    ApiResponse<PSNApplicationConfiguration> response = apiInstance.GetPSNApplicationConfigurationWithHttpInfo(applicationNameOrId, applicationConfigurationNameOrId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetPSNApplicationConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationNameOrId** | **string** |  |  |
| **applicationConfigurationNameOrId** | **string** |  |  |

### Return type

[**PSNApplicationConfiguration**](PSNApplicationConfiguration.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getplans"></a>
# **GetPlans**
> PaginationIndexPlanObject GetPlans (int? offset = null, int? count = null)

Gets all index plans.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetPlansExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var offset = 56;  // int? |  (optional) 
            var count = 56;  // int? |  (optional) 

            try
            {
                // Gets all index plans.
                PaginationIndexPlanObject result = apiInstance.GetPlans(offset, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetPlans: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPlansWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets all index plans.
    ApiResponse<PaginationIndexPlanObject> response = apiInstance.GetPlansWithHttpInfo(offset, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetPlansWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** |  | [optional]  |
| **count** | **int?** |  | [optional]  |

### Return type

[**PaginationIndexPlanObject**](PaginationIndexPlanObject.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getprofile"></a>
# **GetProfile**
> Profile GetProfile (string name)

Gets a Specific Profile

Gets a specific profile by profile ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var name = "name_example";  // string | 

            try
            {
                // Gets a Specific Profile
                Profile result = apiInstance.GetProfile(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetProfile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProfileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a Specific Profile
    ApiResponse<Profile> response = apiInstance.GetProfileWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetProfileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** |  |  |

### Return type

[**Profile**](Profile.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getprofilesavedatadocumentbyslot"></a>
# **GetProfileSaveDataDocumentBySlot**
> SaveDataDocument GetProfileSaveDataDocumentBySlot (string profileId, int slot)

Get save data document.

Gets a single save data document based on Profile ID and slot. This is a convenience method whichallows the client to fetch a save data based on slot an profile id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetProfileSaveDataDocumentBySlotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var profileId = "profileId_example";  // string | 
            var slot = 56;  // int | 

            try
            {
                // Get save data document.
                SaveDataDocument result = apiInstance.GetProfileSaveDataDocumentBySlot(profileId, slot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetProfileSaveDataDocumentBySlot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProfileSaveDataDocumentBySlotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get save data document.
    ApiResponse<SaveDataDocument> response = apiInstance.GetProfileSaveDataDocumentBySlotWithHttpInfo(profileId, slot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetProfileSaveDataDocumentBySlotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **profileId** | **string** |  |  |
| **slot** | **int** |  |  |

### Return type

[**SaveDataDocument**](SaveDataDocument.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getprofiles"></a>
# **GetProfiles**
> PaginationProfile GetProfiles (int? offset = null, int? count = null, long? before = null, long? after = null, string application = null, string user = null, string search = null)

Search Profiles

Searches all users in the system and returning the metadata for all matches against the given search filter. Optionally provide `before` and `after` params to specify a time range [`after`, `before`] for last-logged-in profiles matching in that range (inclusive). If `before` is not specified (or a negative number is provided) but `after` is valid, the query will return all records successive to the given `after` timestamp. Similarly, if `after` is not specified (or a negative number is provided) but `before` is valid, the query will return all records preceding the given `before` timestamp. Note that search and time range parameters currently cannot be combined in the same query.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetProfilesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var offset = 56;  // int? |  (optional) 
            var count = 56;  // int? |  (optional) 
            var before = 789L;  // long? |  (optional) 
            var after = 789L;  // long? |  (optional) 
            var application = "application_example";  // string |  (optional) 
            var user = "user_example";  // string |  (optional) 
            var search = "search_example";  // string |  (optional) 

            try
            {
                // Search Profiles
                PaginationProfile result = apiInstance.GetProfiles(offset, count, before, after, application, user, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetProfiles: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProfilesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search Profiles
    ApiResponse<PaginationProfile> response = apiInstance.GetProfilesWithHttpInfo(offset, count, before, after, application, user, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetProfilesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** |  | [optional]  |
| **count** | **int?** |  | [optional]  |
| **before** | **long?** |  | [optional]  |
| **after** | **long?** |  | [optional]  |
| **application** | **string** |  | [optional]  |
| **user** | **string** |  | [optional]  |
| **search** | **string** |  | [optional]  |

### Return type

[**PaginationProfile**](PaginationProfile.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getprogressbynameorid"></a>
# **GetProgressByNameOrId**
> Progress GetProgressByNameOrId (string progressId)

Retrieves a single Progress by id

Looks up a progress by the passed in identifier

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetProgressByNameOrIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var progressId = "progressId_example";  // string | 

            try
            {
                // Retrieves a single Progress by id
                Progress result = apiInstance.GetProgressByNameOrId(progressId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetProgressByNameOrId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProgressByNameOrIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a single Progress by id
    ApiResponse<Progress> response = apiInstance.GetProgressByNameOrIdWithHttpInfo(progressId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetProgressByNameOrIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **progressId** | **string** |  |  |

### Return type

[**Progress**](Progress.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getprogresstabular"></a>
# **GetProgressTabular**
> TabulationProgressRow GetProgressTabular ()

Gets Rank Among all Players

Gets the current Profile's rank among all players for the particular leaderboard.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetProgressTabularExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);

            try
            {
                // Gets Rank Among all Players
                TabulationProgressRow result = apiInstance.GetProgressTabular();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetProgressTabular: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProgressTabularWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets Rank Among all Players
    ApiResponse<TabulationProgressRow> response = apiInstance.GetProgressTabularWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetProgressTabularWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**TabulationProgressRow**](TabulationProgressRow.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/csv, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrankamongfriends"></a>
# **GetRankAmongFriends**
> PaginationRank GetRankAmongFriends (string leaderboardNameOrId, int? offset = null, int? count = null, bool? relative = null, long? leaderboardEpoch = null)

Gets Rank among Friends

Gets the current Profile's rank among friends for the particular leaderboard.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetRankAmongFriendsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var leaderboardNameOrId = "leaderboardNameOrId_example";  // string | Specifies the leaderboard name or ID.
            var offset = 56;  // int? | May be negative to place the requested player in the middle of the page. (optional) 
            var count = 56;  // int? | The number of results to return in the page. (optional) 
            var relative = true;  // bool? | Indicates whether or not to fetch results in a relative fashion. (optional) 
            var leaderboardEpoch = 789L;  // long? | Specifies the epoch for the leaderboard. If no value is provided, the current epoch will befetched. (optional) 

            try
            {
                // Gets Rank among Friends
                PaginationRank result = apiInstance.GetRankAmongFriends(leaderboardNameOrId, offset, count, relative, leaderboardEpoch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetRankAmongFriends: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRankAmongFriendsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets Rank among Friends
    ApiResponse<PaginationRank> response = apiInstance.GetRankAmongFriendsWithHttpInfo(leaderboardNameOrId, offset, count, relative, leaderboardEpoch);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetRankAmongFriendsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **leaderboardNameOrId** | **string** | Specifies the leaderboard name or ID. |  |
| **offset** | **int?** | May be negative to place the requested player in the middle of the page. | [optional]  |
| **count** | **int?** | The number of results to return in the page. | [optional]  |
| **relative** | **bool?** | Indicates whether or not to fetch results in a relative fashion. | [optional]  |
| **leaderboardEpoch** | **long?** | Specifies the epoch for the leaderboard. If no value is provided, the current epoch will befetched. | [optional]  |

### Return type

[**PaginationRank**](PaginationRank.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrankamongmutualfollowers"></a>
# **GetRankAmongMutualFollowers**
> PaginationRank GetRankAmongMutualFollowers (string leaderboardNameOrId, int? offset = null, int? count = null, bool? relative = null, long? leaderboardEpoch = null)

Gets Rank among Mutual Followers

Gets the current Profile's rank among mutual followers for the particular leaderboard.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetRankAmongMutualFollowersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var leaderboardNameOrId = "leaderboardNameOrId_example";  // string | Specifies the leaderboard name or ID.
            var offset = 56;  // int? | May be negative to place the requested player in the middle of the page. (optional) 
            var count = 56;  // int? | The number of results to return in the page. (optional) 
            var relative = true;  // bool? | Indicates whether or not to fetch results in a relative fashion. (optional) 
            var leaderboardEpoch = 789L;  // long? | Specifies the epoch for the leaderboard. If no value is provided, the current epoch will befetched. (optional) 

            try
            {
                // Gets Rank among Mutual Followers
                PaginationRank result = apiInstance.GetRankAmongMutualFollowers(leaderboardNameOrId, offset, count, relative, leaderboardEpoch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetRankAmongMutualFollowers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRankAmongMutualFollowersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets Rank among Mutual Followers
    ApiResponse<PaginationRank> response = apiInstance.GetRankAmongMutualFollowersWithHttpInfo(leaderboardNameOrId, offset, count, relative, leaderboardEpoch);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetRankAmongMutualFollowersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **leaderboardNameOrId** | **string** | Specifies the leaderboard name or ID. |  |
| **offset** | **int?** | May be negative to place the requested player in the middle of the page. | [optional]  |
| **count** | **int?** | The number of results to return in the page. | [optional]  |
| **relative** | **bool?** | Indicates whether or not to fetch results in a relative fashion. | [optional]  |
| **leaderboardEpoch** | **long?** | Specifies the epoch for the leaderboard. If no value is provided, the current epoch will befetched. | [optional]  |

### Return type

[**PaginationRank**](PaginationRank.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrewardissuance"></a>
# **GetRewardIssuance**
> RewardIssuance GetRewardIssuance (string rewardIssuanceId)

Retrieves a single RewardIssuance by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetRewardIssuanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var rewardIssuanceId = "rewardIssuanceId_example";  // string | 

            try
            {
                // Retrieves a single RewardIssuance by id.
                RewardIssuance result = apiInstance.GetRewardIssuance(rewardIssuanceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetRewardIssuance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRewardIssuanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a single RewardIssuance by id.
    ApiResponse<RewardIssuance> response = apiInstance.GetRewardIssuanceWithHttpInfo(rewardIssuanceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetRewardIssuanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **rewardIssuanceId** | **string** |  |  |

### Return type

[**RewardIssuance**](RewardIssuance.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrewardissuances"></a>
# **GetRewardIssuances**
> PaginationRewardIssuance GetRewardIssuances (int? offset = null, int? count = null, List<string> states = null, List<string> tags = null)

Retrieves the current user's reward issuances, optionally filtered by the given state.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetRewardIssuancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var offset = 56;  // int? |  (optional) 
            var count = 56;  // int? |  (optional) 
            var states = new List<string>(); // List<string> |  (optional) 
            var tags = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Retrieves the current user's reward issuances, optionally filtered by the given state.
                PaginationRewardIssuance result = apiInstance.GetRewardIssuances(offset, count, states, tags);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetRewardIssuances: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRewardIssuancesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves the current user's reward issuances, optionally filtered by the given state.
    ApiResponse<PaginationRewardIssuance> response = apiInstance.GetRewardIssuancesWithHttpInfo(offset, count, states, tags);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetRewardIssuancesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** |  | [optional]  |
| **count** | **int?** |  | [optional]  |
| **states** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **tags** | [**List&lt;string&gt;**](string.md) |  | [optional]  |

### Return type

[**PaginationRewardIssuance**](PaginationRewardIssuance.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsavedatadocument"></a>
# **GetSaveDataDocument**
> SaveDataDocument GetSaveDataDocument (string id)

Get save data document.

Gets a single save data document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetSaveDataDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Get save data document.
                SaveDataDocument result = apiInstance.GetSaveDataDocument(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetSaveDataDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSaveDataDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get save data document.
    ApiResponse<SaveDataDocument> response = apiInstance.GetSaveDataDocumentWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetSaveDataDocumentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**SaveDataDocument**](SaveDataDocument.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsavedatadocuments"></a>
# **GetSaveDataDocuments**
> PaginationSaveDataDocument GetSaveDataDocuments (int? offset = null, int? count = null, string userId = null, string profileId = null, string search = null)

Search Save Data Documents

Gets all save data documents available to the user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetSaveDataDocumentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var offset = 56;  // int? |  (optional) 
            var count = 56;  // int? |  (optional) 
            var userId = "userId_example";  // string |  (optional) 
            var profileId = "profileId_example";  // string |  (optional) 
            var search = "search_example";  // string |  (optional) 

            try
            {
                // Search Save Data Documents
                PaginationSaveDataDocument result = apiInstance.GetSaveDataDocuments(offset, count, userId, profileId, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetSaveDataDocuments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSaveDataDocumentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search Save Data Documents
    ApiResponse<PaginationSaveDataDocument> response = apiInstance.GetSaveDataDocumentsWithHttpInfo(offset, count, userId, profileId, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetSaveDataDocumentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** |  | [optional]  |
| **count** | **int?** |  | [optional]  |
| **userId** | **string** |  | [optional]  |
| **profileId** | **string** |  | [optional]  |
| **search** | **string** |  | [optional]  |

### Return type

[**PaginationSaveDataDocument**](PaginationSaveDataDocument.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getschedulebynameorid"></a>
# **GetScheduleByNameOrId**
> Schedule GetScheduleByNameOrId (string scheduleNameOrId)

Retrieves a single Schedule by id or by name

Looks up a schedule by the passed in identifier

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetScheduleByNameOrIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var scheduleNameOrId = "scheduleNameOrId_example";  // string | 

            try
            {
                // Retrieves a single Schedule by id or by name
                Schedule result = apiInstance.GetScheduleByNameOrId(scheduleNameOrId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetScheduleByNameOrId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetScheduleByNameOrIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a single Schedule by id or by name
    ApiResponse<Schedule> response = apiInstance.GetScheduleByNameOrIdWithHttpInfo(scheduleNameOrId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetScheduleByNameOrIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scheduleNameOrId** | **string** |  |  |

### Return type

[**Schedule**](Schedule.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getscheduleeventbynameorid"></a>
# **GetScheduleEventByNameOrId**
> ScheduleEvent GetScheduleEventByNameOrId (string scheduleNameOrId, string scheduleEventId)

Retrieves a single ScheduleEvent by id or by name

Looks up a schedule by the passed in identifier

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetScheduleEventByNameOrIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var scheduleNameOrId = "scheduleNameOrId_example";  // string | 
            var scheduleEventId = "scheduleEventId_example";  // string | 

            try
            {
                // Retrieves a single ScheduleEvent by id or by name
                ScheduleEvent result = apiInstance.GetScheduleEventByNameOrId(scheduleNameOrId, scheduleEventId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetScheduleEventByNameOrId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetScheduleEventByNameOrIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a single ScheduleEvent by id or by name
    ApiResponse<ScheduleEvent> response = apiInstance.GetScheduleEventByNameOrIdWithHttpInfo(scheduleNameOrId, scheduleEventId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetScheduleEventByNameOrIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scheduleNameOrId** | **string** |  |  |
| **scheduleEventId** | **string** |  |  |

### Return type

[**ScheduleEvent**](ScheduleEvent.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getscheduleevents"></a>
# **GetScheduleEvents**
> PaginationScheduleEvent GetScheduleEvents (string scheduleNameOrId, int? offset = null, int? count = null, List<string> tags = null, string search = null)

Search ScheduleEvents

Searches all schedules in the system and returning a number of matches against the given search filter, delimited by the offset and count.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetScheduleEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var scheduleNameOrId = "scheduleNameOrId_example";  // string | 
            var offset = 56;  // int? |  (optional) 
            var count = 56;  // int? |  (optional) 
            var tags = new List<string>(); // List<string> |  (optional) 
            var search = "search_example";  // string |  (optional) 

            try
            {
                // Search ScheduleEvents
                PaginationScheduleEvent result = apiInstance.GetScheduleEvents(scheduleNameOrId, offset, count, tags, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetScheduleEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetScheduleEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search ScheduleEvents
    ApiResponse<PaginationScheduleEvent> response = apiInstance.GetScheduleEventsWithHttpInfo(scheduleNameOrId, offset, count, tags, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetScheduleEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scheduleNameOrId** | **string** |  |  |
| **offset** | **int?** |  | [optional]  |
| **count** | **int?** |  | [optional]  |
| **tags** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **search** | **string** |  | [optional]  |

### Return type

[**PaginationScheduleEvent**](PaginationScheduleEvent.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getscheduleprogresses"></a>
# **GetScheduleProgresses**
> PaginationProgress GetScheduleProgresses (string scheduleNameOrId, int? offset = null, int? count = null, List<string> tags = null)

Gets all Progresses assigned via this schedule

Fetches all current assignments to the currently logged-in profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetScheduleProgressesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var scheduleNameOrId = "scheduleNameOrId_example";  // string | 
            var offset = 56;  // int? |  (optional) 
            var count = 56;  // int? |  (optional) 
            var tags = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Gets all Progresses assigned via this schedule
                PaginationProgress result = apiInstance.GetScheduleProgresses(scheduleNameOrId, offset, count, tags);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetScheduleProgresses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetScheduleProgressesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets all Progresses assigned via this schedule
    ApiResponse<PaginationProgress> response = apiInstance.GetScheduleProgressesWithHttpInfo(scheduleNameOrId, offset, count, tags);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetScheduleProgressesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scheduleNameOrId** | **string** |  |  |
| **offset** | **int?** |  | [optional]  |
| **count** | **int?** |  | [optional]  |
| **tags** | [**List&lt;string&gt;**](string.md) |  | [optional]  |

### Return type

[**PaginationProgress**](PaginationProgress.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getschedules"></a>
# **GetSchedules**
> PaginationSchedule GetSchedules (int? offset = null, int? count = null, List<string> tags = null, string search = null)

Search Schedules

Searches all schedules in the system and returning a number of matches against the given search filter, delimited by the offset and count.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetSchedulesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var offset = 56;  // int? |  (optional) 
            var count = 56;  // int? |  (optional) 
            var tags = new List<string>(); // List<string> |  (optional) 
            var search = "search_example";  // string |  (optional) 

            try
            {
                // Search Schedules
                PaginationSchedule result = apiInstance.GetSchedules(offset, count, tags, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetSchedules: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSchedulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search Schedules
    ApiResponse<PaginationSchedule> response = apiInstance.GetSchedulesWithHttpInfo(offset, count, tags, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetSchedulesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** |  | [optional]  |
| **count** | **int?** |  | [optional]  |
| **tags** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **search** | **string** |  | [optional]  |

### Return type

[**PaginationSchedule**](PaginationSchedule.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getserverhealth"></a>
# **GetServerHealth**
> HealthStatus GetServerHealth ()

Performs the health check.

Performs the health check for the server. What this actually does is deployment and implementation specific. However, any successful response code should indicate that the service is capable of servicing requests. Any unsuccessful error codes should indicate that the instance has internal issues and should be taken offline.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetServerHealthExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);

            try
            {
                // Performs the health check.
                HealthStatus result = apiInstance.GetServerHealth();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetServerHealth: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetServerHealthWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Performs the health check.
    ApiResponse<HealthStatus> response = apiInstance.GetServerHealthWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetServerHealthWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**HealthStatus**](HealthStatus.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsimpleinventoryitem"></a>
# **GetSimpleInventoryItem**
> InventoryItem GetSimpleInventoryItem (string inventoryItemId)

Gets inventory item for the specified item

Gets the first (primary) inventory item for the specified item

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetSimpleInventoryItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var inventoryItemId = "inventoryItemId_example";  // string | 

            try
            {
                // Gets inventory item for the specified item
                InventoryItem result = apiInstance.GetSimpleInventoryItem(inventoryItemId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetSimpleInventoryItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSimpleInventoryItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets inventory item for the specified item
    ApiResponse<InventoryItem> response = apiInstance.GetSimpleInventoryItemWithHttpInfo(inventoryItemId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetSimpleInventoryItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inventoryItemId** | **string** |  |  |

### Return type

[**InventoryItem**](InventoryItem.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsimpleinventoryitems"></a>
# **GetSimpleInventoryItems**
> PaginationInventoryItem GetSimpleInventoryItems (int? offset = null, int? count = null, string userId = null, string search = null)

Search inventory items

Searches all inventory items in the system and returns the metadata for all matches against the given search filter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetSimpleInventoryItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var offset = 56;  // int? |  (optional) 
            var count = 56;  // int? |  (optional) 
            var userId = "userId_example";  // string |  (optional) 
            var search = "search_example";  // string |  (optional) 

            try
            {
                // Search inventory items
                PaginationInventoryItem result = apiInstance.GetSimpleInventoryItems(offset, count, userId, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetSimpleInventoryItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSimpleInventoryItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search inventory items
    ApiResponse<PaginationInventoryItem> response = apiInstance.GetSimpleInventoryItemsWithHttpInfo(offset, count, userId, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetSimpleInventoryItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** |  | [optional]  |
| **count** | **int?** |  | [optional]  |
| **userId** | **string** |  | [optional]  |
| **search** | **string** |  | [optional]  |

### Return type

[**PaginationInventoryItem**](PaginationInventoryItem.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsmartcontract"></a>
# **GetSmartContract**
> SmartContract GetSmartContract (string contractId)

Gets a specific  Smart Contract

Gets a specific  Smart Contract by contractId.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetSmartContractExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var contractId = "contractId_example";  // string | 

            try
            {
                // Gets a specific  Smart Contract
                SmartContract result = apiInstance.GetSmartContract(contractId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetSmartContract: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSmartContractWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a specific  Smart Contract
    ApiResponse<SmartContract> response = apiInstance.GetSmartContractWithHttpInfo(contractId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetSmartContractWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contractId** | **string** |  |  |

### Return type

[**SmartContract**](SmartContract.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsmartcontracts"></a>
# **GetSmartContracts**
> PaginationSmartContract GetSmartContracts (int? offset = null, int? count = null, string api = null, List<string> network = null)

Gets  contracts.

Gets a pagination of  SmartContracts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetSmartContractsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var offset = 56;  // int? |  (optional) 
            var count = 56;  // int? |  (optional) 
            var api = "NEO";  // string |  (optional) 
            var network = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Gets  contracts.
                PaginationSmartContract result = apiInstance.GetSmartContracts(offset, count, api, network);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetSmartContracts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSmartContractsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets  contracts.
    ApiResponse<PaginationSmartContract> response = apiInstance.GetSmartContractsWithHttpInfo(offset, count, api, network);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetSmartContractsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** |  | [optional]  |
| **count** | **int?** |  | [optional]  |
| **api** | **string** |  | [optional]  |
| **network** | [**List&lt;string&gt;**](string.md) |  | [optional]  |

### Return type

[**PaginationSmartContract**](PaginationSmartContract.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getuser"></a>
# **GetUser**
> User GetUser (string name)

Gets a Specific User

Gets a specific user by name, email, or unique user ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var name = "name_example";  // string | 

            try
            {
                // Gets a Specific User
                User result = apiInstance.GetUser(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a Specific User
    ApiResponse<User> response = apiInstance.GetUserWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** |  |  |

### Return type

[**User**](User.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getusersavedatadocumentbyslot"></a>
# **GetUserSaveDataDocumentBySlot**
> SaveDataDocument GetUserSaveDataDocumentBySlot (string userId, int slot)

Get save data document.

Gets a single save data document based on UserID and slot. This is a convenience method whichallows the client to fetch a save data based on slot an user id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetUserSaveDataDocumentBySlotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var userId = "userId_example";  // string | 
            var slot = 56;  // int | 

            try
            {
                // Get save data document.
                SaveDataDocument result = apiInstance.GetUserSaveDataDocumentBySlot(userId, slot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetUserSaveDataDocumentBySlot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserSaveDataDocumentBySlotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get save data document.
    ApiResponse<SaveDataDocument> response = apiInstance.GetUserSaveDataDocumentBySlotWithHttpInfo(userId, slot);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetUserSaveDataDocumentBySlotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** |  |  |
| **slot** | **int** |  |  |

### Return type

[**SaveDataDocument**](SaveDataDocument.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getusers"></a>
# **GetUsers**
> PaginationUser GetUsers (int? offset = null, int? count = null, string search = null)

Search Users

Searches all users in the system and returning the metadata for all matches against the given search filter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var offset = 56;  // int? |  (optional) 
            var count = 56;  // int? |  (optional) 
            var search = "search_example";  // string |  (optional) 

            try
            {
                // Search Users
                PaginationUser result = apiInstance.GetUsers(offset, count, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search Users
    ApiResponse<PaginationUser> response = apiInstance.GetUsersWithHttpInfo(offset, count, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** |  | [optional]  |
| **count** | **int?** |  | [optional]  |
| **search** | **string** |  | [optional]  |

### Return type

[**PaginationUser**](PaginationUser.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getvault"></a>
# **GetVault**
> Vault GetVault (string vaultId)

Gets a specific  Vault

Gets a specific  Vault by Id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetVaultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var vaultId = "vaultId_example";  // string | 

            try
            {
                // Gets a specific  Vault
                Vault result = apiInstance.GetVault(vaultId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetVault: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVaultWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a specific  Vault
    ApiResponse<Vault> response = apiInstance.GetVaultWithHttpInfo(vaultId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetVaultWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vaultId** | **string** |  |  |

### Return type

[**Vault**](Vault.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getvaults"></a>
# **GetVaults**
> PaginationVault GetVaults (int? offset = null, int? count = null, string userId = null)

Gets  vaults. Optionally filtered for a specific user

Gets a pagination of  Wallets. Optionally a user Id can be specified to filter for a given user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetVaultsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var offset = 56;  // int? |  (optional) 
            var count = 56;  // int? |  (optional) 
            var userId = "userId_example";  // string |  (optional) 

            try
            {
                // Gets  vaults. Optionally filtered for a specific user
                PaginationVault result = apiInstance.GetVaults(offset, count, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetVaults: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVaultsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets  vaults. Optionally filtered for a specific user
    ApiResponse<PaginationVault> response = apiInstance.GetVaultsWithHttpInfo(offset, count, userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetVaultsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** |  | [optional]  |
| **count** | **int?** |  | [optional]  |
| **userId** | **string** |  | [optional]  |

### Return type

[**PaginationVault**](PaginationVault.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getversion"></a>
# **GetVersion**
> ModelVersion GetVersion ()

Show Server Version Information

Returns information about the current server version.  This should always return theversion metadata.  This information is only known in packaged releases.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);

            try
            {
                // Show Server Version Information
                ModelVersion result = apiInstance.GetVersion();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetVersion: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVersionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Show Server Version Information
    ApiResponse<ModelVersion> response = apiInstance.GetVersionWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetVersionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ModelVersion**](ModelVersion.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getwallet"></a>
# **GetWallet**
> Wallet GetWallet (string vaultId, string walletId)

Gets a specific  Wallet

Gets a specific  Wallet by Id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetWalletExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var vaultId = "vaultId_example";  // string | 
            var walletId = "walletId_example";  // string | 

            try
            {
                // Gets a specific  Wallet
                Wallet result = apiInstance.GetWallet(vaultId, walletId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetWallet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWalletWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a specific  Wallet
    ApiResponse<Wallet> response = apiInstance.GetWalletWithHttpInfo(vaultId, walletId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetWalletWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vaultId** | **string** |  |  |
| **walletId** | **string** |  |  |

### Return type

[**Wallet**](Wallet.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getwallet1"></a>
# **GetWallet1**
> Wallet GetWallet1 (string walletId)

Gets a specific  Wallet

Gets a specific  Wallet by Id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetWallet1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var walletId = "walletId_example";  // string | 

            try
            {
                // Gets a specific  Wallet
                Wallet result = apiInstance.GetWallet1(walletId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetWallet1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWallet1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a specific  Wallet
    ApiResponse<Wallet> response = apiInstance.GetWallet1WithHttpInfo(walletId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetWallet1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **walletId** | **string** |  |  |

### Return type

[**Wallet**](Wallet.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getwallets"></a>
# **GetWallets**
> PaginationWallet GetWallets (string vaultId, int? offset = null, int? count = null, string userId = null, string api = null, List<string> network = null)

Gets  wallets. Optionally filtered for a specific user

Gets a pagination of  Wallets. Optionally a user Id can be specified to filter for a given user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class GetWalletsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var vaultId = "vaultId_example";  // string | 
            var offset = 56;  // int? |  (optional) 
            var count = 56;  // int? |  (optional) 
            var userId = "userId_example";  // string |  (optional) 
            var api = "NEO";  // string |  (optional) 
            var network = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Gets  wallets. Optionally filtered for a specific user
                PaginationWallet result = apiInstance.GetWallets(vaultId, offset, count, userId, api, network);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetWallets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWalletsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets  wallets. Optionally filtered for a specific user
    ApiResponse<PaginationWallet> response = apiInstance.GetWalletsWithHttpInfo(vaultId, offset, count, userId, api, network);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetWalletsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vaultId** | **string** |  |  |
| **offset** | **int?** |  | [optional]  |
| **count** | **int?** |  | [optional]  |
| **userId** | **string** |  | [optional]  |
| **api** | **string** |  | [optional]  |
| **network** | [**List&lt;string&gt;**](string.md) |  | [optional]  |

### Return type

[**PaginationWallet**](PaginationWallet.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="redeemrewardissuance"></a>
# **RedeemRewardIssuance**
> RewardIssuanceRedemptionResult RedeemRewardIssuance (string rewardIssuanceId)

Redeems the RewardIssuance.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class RedeemRewardIssuanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var rewardIssuanceId = "rewardIssuanceId_example";  // string | 

            try
            {
                // Redeems the RewardIssuance.
                RewardIssuanceRedemptionResult result = apiInstance.RedeemRewardIssuance(rewardIssuanceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.RedeemRewardIssuance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RedeemRewardIssuanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Redeems the RewardIssuance.
    ApiResponse<RewardIssuanceRedemptionResult> response = apiInstance.RedeemRewardIssuanceWithHttpInfo(rewardIssuanceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.RedeemRewardIssuanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **rewardIssuanceId** | **string** |  |  |

### Return type

[**RewardIssuanceRedemptionResult**](RewardIssuanceRedemptionResult.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="redeemrewardissuances"></a>
# **RedeemRewardIssuances**
> List&lt;RewardIssuanceRedemptionResult&gt; RedeemRewardIssuances (List<string> requestBody = null)

Redeems the given list of RewardIssuances.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class RedeemRewardIssuancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var requestBody = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Redeems the given list of RewardIssuances.
                List<RewardIssuanceRedemptionResult> result = apiInstance.RedeemRewardIssuances(requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.RedeemRewardIssuances: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RedeemRewardIssuancesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Redeems the given list of RewardIssuances.
    ApiResponse<List<RewardIssuanceRedemptionResult>> response = apiInstance.RedeemRewardIssuancesWithHttpInfo(requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.RedeemRewardIssuancesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**List&lt;string&gt;**](string.md) |  | [optional]  |

### Return type

[**List&lt;RewardIssuanceRedemptionResult&gt;**](RewardIssuanceRedemptionResult.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="signupuser"></a>
# **SignUpUser**
> UserCreateResponse SignUpUser (UserCreateRequest userCreateRequest = null)

Sign Up a User

Supplying the user create request object, this will create a new user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class SignUpUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var userCreateRequest = new UserCreateRequest(); // UserCreateRequest |  (optional) 

            try
            {
                // Sign Up a User
                UserCreateResponse result = apiInstance.SignUpUser(userCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.SignUpUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SignUpUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Sign Up a User
    ApiResponse<UserCreateResponse> response = apiInstance.SignUpUserWithHttpInfo(userCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.SignUpUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userCreateRequest** | [**UserCreateRequest**](UserCreateRequest.md) |  | [optional]  |

### Return type

[**UserCreateResponse**](UserCreateResponse.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateapplication"></a>
# **UpdateApplication**
> Application UpdateApplication (string nameOrId, UpdateApplicationRequest updateApplicationRequest = null)

Updates an Application

Performs an update to an existing application known to the server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdateApplicationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var nameOrId = "nameOrId_example";  // string | 
            var updateApplicationRequest = new UpdateApplicationRequest(); // UpdateApplicationRequest |  (optional) 

            try
            {
                // Updates an Application
                Application result = apiInstance.UpdateApplication(nameOrId, updateApplicationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateApplication: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateApplicationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates an Application
    ApiResponse<Application> response = apiInstance.UpdateApplicationWithHttpInfo(nameOrId, updateApplicationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateApplicationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **nameOrId** | **string** |  |  |
| **updateApplicationRequest** | [**UpdateApplicationRequest**](UpdateApplicationRequest.md) |  | [optional]  |

### Return type

[**Application**](Application.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateauthscheme"></a>
# **UpdateAuthScheme**
> UpdateAuthSchemeResponse UpdateAuthScheme (string authSchemeId, UpdateAuthSchemeRequest updateAuthSchemeRequest = null)

Updates an Auth Scheme

Updates an Auth Scheme with the specified data in the auth scheme request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdateAuthSchemeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var authSchemeId = "authSchemeId_example";  // string | 
            var updateAuthSchemeRequest = new UpdateAuthSchemeRequest(); // UpdateAuthSchemeRequest |  (optional) 

            try
            {
                // Updates an Auth Scheme
                UpdateAuthSchemeResponse result = apiInstance.UpdateAuthScheme(authSchemeId, updateAuthSchemeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateAuthScheme: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAuthSchemeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates an Auth Scheme
    ApiResponse<UpdateAuthSchemeResponse> response = apiInstance.UpdateAuthSchemeWithHttpInfo(authSchemeId, updateAuthSchemeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateAuthSchemeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authSchemeId** | **string** |  |  |
| **updateAuthSchemeRequest** | [**UpdateAuthSchemeRequest**](UpdateAuthSchemeRequest.md) |  | [optional]  |

### Return type

[**UpdateAuthSchemeResponse**](UpdateAuthSchemeResponse.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateauthscheme1"></a>
# **UpdateAuthScheme1**
> CreateOrUpdateOAuth2AuthSchemeResponse UpdateAuthScheme1 (string oAuth2AuthSchemeId, CreateOrUpdateOAuth2AuthSchemeRequest createOrUpdateOAuth2AuthSchemeRequest = null)

Updates an Auth Scheme

Updates an Auth Scheme with the specified data in the auth scheme request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdateAuthScheme1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var oAuth2AuthSchemeId = "oAuth2AuthSchemeId_example";  // string | 
            var createOrUpdateOAuth2AuthSchemeRequest = new CreateOrUpdateOAuth2AuthSchemeRequest(); // CreateOrUpdateOAuth2AuthSchemeRequest |  (optional) 

            try
            {
                // Updates an Auth Scheme
                CreateOrUpdateOAuth2AuthSchemeResponse result = apiInstance.UpdateAuthScheme1(oAuth2AuthSchemeId, createOrUpdateOAuth2AuthSchemeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateAuthScheme1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAuthScheme1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates an Auth Scheme
    ApiResponse<CreateOrUpdateOAuth2AuthSchemeResponse> response = apiInstance.UpdateAuthScheme1WithHttpInfo(oAuth2AuthSchemeId, createOrUpdateOAuth2AuthSchemeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateAuthScheme1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **oAuth2AuthSchemeId** | **string** |  |  |
| **createOrUpdateOAuth2AuthSchemeRequest** | [**CreateOrUpdateOAuth2AuthSchemeRequest**](CreateOrUpdateOAuth2AuthSchemeRequest.md) |  | [optional]  |

### Return type

[**CreateOrUpdateOAuth2AuthSchemeResponse**](CreateOrUpdateOAuth2AuthSchemeResponse.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateauthscheme2"></a>
# **UpdateAuthScheme2**
> CreateOrUpdateOidcAuthSchemeResponse UpdateAuthScheme2 (string oidcAuthSchemeId, CreateOrUpdateOidcAuthSchemeRequest createOrUpdateOidcAuthSchemeRequest = null)

Updates an Auth Scheme

Updates an Auth Scheme with the specified data in the auth scheme request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdateAuthScheme2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var oidcAuthSchemeId = "oidcAuthSchemeId_example";  // string | 
            var createOrUpdateOidcAuthSchemeRequest = new CreateOrUpdateOidcAuthSchemeRequest(); // CreateOrUpdateOidcAuthSchemeRequest |  (optional) 

            try
            {
                // Updates an Auth Scheme
                CreateOrUpdateOidcAuthSchemeResponse result = apiInstance.UpdateAuthScheme2(oidcAuthSchemeId, createOrUpdateOidcAuthSchemeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateAuthScheme2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAuthScheme2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates an Auth Scheme
    ApiResponse<CreateOrUpdateOidcAuthSchemeResponse> response = apiInstance.UpdateAuthScheme2WithHttpInfo(oidcAuthSchemeId, createOrUpdateOidcAuthSchemeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateAuthScheme2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **oidcAuthSchemeId** | **string** |  |  |
| **createOrUpdateOidcAuthSchemeRequest** | [**CreateOrUpdateOidcAuthSchemeRequest**](CreateOrUpdateOidcAuthSchemeRequest.md) |  | [optional]  |

### Return type

[**CreateOrUpdateOidcAuthSchemeResponse**](CreateOrUpdateOidcAuthSchemeResponse.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatedeployment"></a>
# **UpdateDeployment**
> Deployment UpdateDeployment (string applicationId, string version, UpdateDeploymentRequest updateDeploymentRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdateDeploymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var applicationId = "applicationId_example";  // string | 
            var version = "version_example";  // string | 
            var updateDeploymentRequest = new UpdateDeploymentRequest(); // UpdateDeploymentRequest |  (optional) 

            try
            {
                Deployment result = apiInstance.UpdateDeployment(applicationId, version, updateDeploymentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateDeployment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateDeploymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Deployment> response = apiInstance.UpdateDeploymentWithHttpInfo(applicationId, version, updateDeploymentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateDeploymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationId** | **string** |  |  |
| **version** | **string** |  |  |
| **updateDeploymentRequest** | [**UpdateDeploymentRequest**](UpdateDeploymentRequest.md) |  | [optional]  |

### Return type

[**Deployment**](Deployment.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatedistinctinventoryitem"></a>
# **UpdateDistinctInventoryItem**
> DistinctInventoryItem UpdateDistinctInventoryItem (string distinctInventoryItemId, UpdateDistinctInventoryItemRequest updateDistinctInventoryItemRequest = null)

Updates an inventory item for the specified item

Updates an inventory item for the specified item

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdateDistinctInventoryItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var distinctInventoryItemId = "distinctInventoryItemId_example";  // string | 
            var updateDistinctInventoryItemRequest = new UpdateDistinctInventoryItemRequest(); // UpdateDistinctInventoryItemRequest |  (optional) 

            try
            {
                // Updates an inventory item for the specified item
                DistinctInventoryItem result = apiInstance.UpdateDistinctInventoryItem(distinctInventoryItemId, updateDistinctInventoryItemRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateDistinctInventoryItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateDistinctInventoryItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates an inventory item for the specified item
    ApiResponse<DistinctInventoryItem> response = apiInstance.UpdateDistinctInventoryItemWithHttpInfo(distinctInventoryItemId, updateDistinctInventoryItemRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateDistinctInventoryItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **distinctInventoryItemId** | **string** |  |  |
| **updateDistinctInventoryItemRequest** | [**UpdateDistinctInventoryItemRequest**](UpdateDistinctInventoryItemRequest.md) |  | [optional]  |

### Return type

[**DistinctInventoryItem**](DistinctInventoryItem.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatefacebookapplicationconfiguration"></a>
# **UpdateFacebookApplicationConfiguration**
> FacebookApplicationConfiguration UpdateFacebookApplicationConfiguration (string applicationNameOrId, string applicationConfigurationNameOrId, FacebookApplicationConfiguration facebookApplicationConfiguration = null)

Updates a Facebook ApplicationConfiguration

Updates an existing Facebook Application profile if it is known to the server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdateFacebookApplicationConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var applicationNameOrId = "applicationNameOrId_example";  // string | 
            var applicationConfigurationNameOrId = "applicationConfigurationNameOrId_example";  // string | 
            var facebookApplicationConfiguration = new FacebookApplicationConfiguration(); // FacebookApplicationConfiguration |  (optional) 

            try
            {
                // Updates a Facebook ApplicationConfiguration
                FacebookApplicationConfiguration result = apiInstance.UpdateFacebookApplicationConfiguration(applicationNameOrId, applicationConfigurationNameOrId, facebookApplicationConfiguration);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateFacebookApplicationConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateFacebookApplicationConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a Facebook ApplicationConfiguration
    ApiResponse<FacebookApplicationConfiguration> response = apiInstance.UpdateFacebookApplicationConfigurationWithHttpInfo(applicationNameOrId, applicationConfigurationNameOrId, facebookApplicationConfiguration);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateFacebookApplicationConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationNameOrId** | **string** |  |  |
| **applicationConfigurationNameOrId** | **string** |  |  |
| **facebookApplicationConfiguration** | [**FacebookApplicationConfiguration**](FacebookApplicationConfiguration.md) |  | [optional]  |

### Return type

[**FacebookApplicationConfiguration**](FacebookApplicationConfiguration.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatefirebaseapplicationconfiguration"></a>
# **UpdateFirebaseApplicationConfiguration**
> FirebaseApplicationConfiguration UpdateFirebaseApplicationConfiguration (string applicationNameOrId, string applicationConfigurationNameOrId, FirebaseApplicationConfiguration firebaseApplicationConfiguration = null)

Updates a Firebase ApplicationConfiguration

Updates an existing Firebase Application profile if it is known to the server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdateFirebaseApplicationConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var applicationNameOrId = "applicationNameOrId_example";  // string | 
            var applicationConfigurationNameOrId = "applicationConfigurationNameOrId_example";  // string | 
            var firebaseApplicationConfiguration = new FirebaseApplicationConfiguration(); // FirebaseApplicationConfiguration |  (optional) 

            try
            {
                // Updates a Firebase ApplicationConfiguration
                FirebaseApplicationConfiguration result = apiInstance.UpdateFirebaseApplicationConfiguration(applicationNameOrId, applicationConfigurationNameOrId, firebaseApplicationConfiguration);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateFirebaseApplicationConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateFirebaseApplicationConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a Firebase ApplicationConfiguration
    ApiResponse<FirebaseApplicationConfiguration> response = apiInstance.UpdateFirebaseApplicationConfigurationWithHttpInfo(applicationNameOrId, applicationConfigurationNameOrId, firebaseApplicationConfiguration);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateFirebaseApplicationConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationNameOrId** | **string** |  |  |
| **applicationConfigurationNameOrId** | **string** |  |  |
| **firebaseApplicationConfiguration** | [**FirebaseApplicationConfiguration**](FirebaseApplicationConfiguration.md) |  | [optional]  |

### Return type

[**FirebaseApplicationConfiguration**](FirebaseApplicationConfiguration.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updategoogleplayapplicationconfiguration"></a>
# **UpdateGooglePlayApplicationConfiguration**
> GooglePlayApplicationConfiguration UpdateGooglePlayApplicationConfiguration (string applicationNameOrId, string applicationConfigurationNameOrId, GooglePlayApplicationConfiguration googlePlayApplicationConfiguration = null)

Updates a Google Play ApplicationConfiguration

Updates an existing Google Play Application profile if it is known to the server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdateGooglePlayApplicationConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var applicationNameOrId = "applicationNameOrId_example";  // string | 
            var applicationConfigurationNameOrId = "applicationConfigurationNameOrId_example";  // string | 
            var googlePlayApplicationConfiguration = new GooglePlayApplicationConfiguration(); // GooglePlayApplicationConfiguration |  (optional) 

            try
            {
                // Updates a Google Play ApplicationConfiguration
                GooglePlayApplicationConfiguration result = apiInstance.UpdateGooglePlayApplicationConfiguration(applicationNameOrId, applicationConfigurationNameOrId, googlePlayApplicationConfiguration);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateGooglePlayApplicationConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateGooglePlayApplicationConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a Google Play ApplicationConfiguration
    ApiResponse<GooglePlayApplicationConfiguration> response = apiInstance.UpdateGooglePlayApplicationConfigurationWithHttpInfo(applicationNameOrId, applicationConfigurationNameOrId, googlePlayApplicationConfiguration);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateGooglePlayApplicationConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationNameOrId** | **string** |  |  |
| **applicationConfigurationNameOrId** | **string** |  |  |
| **googlePlayApplicationConfiguration** | [**GooglePlayApplicationConfiguration**](GooglePlayApplicationConfiguration.md) |  | [optional]  |

### Return type

[**GooglePlayApplicationConfiguration**](GooglePlayApplicationConfiguration.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateiosapplicationconfiguration"></a>
# **UpdateIosApplicationConfiguration**
> IosApplicationConfiguration UpdateIosApplicationConfiguration (string applicationNameOrId, string applicationConfigurationNameOrId, IosApplicationConfiguration iosApplicationConfiguration = null)

Updates a iOS ApplicationConfiguration

Updates an existing iOS Application profile if it is known to the server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdateIosApplicationConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var applicationNameOrId = "applicationNameOrId_example";  // string | 
            var applicationConfigurationNameOrId = "applicationConfigurationNameOrId_example";  // string | 
            var iosApplicationConfiguration = new IosApplicationConfiguration(); // IosApplicationConfiguration |  (optional) 

            try
            {
                // Updates a iOS ApplicationConfiguration
                IosApplicationConfiguration result = apiInstance.UpdateIosApplicationConfiguration(applicationNameOrId, applicationConfigurationNameOrId, iosApplicationConfiguration);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateIosApplicationConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateIosApplicationConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a iOS ApplicationConfiguration
    ApiResponse<IosApplicationConfiguration> response = apiInstance.UpdateIosApplicationConfigurationWithHttpInfo(applicationNameOrId, applicationConfigurationNameOrId, iosApplicationConfiguration);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateIosApplicationConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationNameOrId** | **string** |  |  |
| **applicationConfigurationNameOrId** | **string** |  |  |
| **iosApplicationConfiguration** | [**IosApplicationConfiguration**](IosApplicationConfiguration.md) |  | [optional]  |

### Return type

[**IosApplicationConfiguration**](IosApplicationConfiguration.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateitem"></a>
# **UpdateItem**
> Item UpdateItem (string identifier, UpdateItemRequest updateItemRequest = null)

Updates a single Item

Supplying an item, this will update the Item identified by the identifier in the path with contents from the passed in request body. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdateItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var identifier = "identifier_example";  // string | 
            var updateItemRequest = new UpdateItemRequest(); // UpdateItemRequest |  (optional) 

            try
            {
                // Updates a single Item
                Item result = apiInstance.UpdateItem(identifier, updateItemRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a single Item
    ApiResponse<Item> response = apiInstance.UpdateItemWithHttpInfo(identifier, updateItemRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identifier** | **string** |  |  |
| **updateItemRequest** | [**UpdateItemRequest**](UpdateItemRequest.md) |  | [optional]  |

### Return type

[**Item**](Item.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatelargeobject"></a>
# **UpdateLargeObject**
> LargeObject UpdateLargeObject (string largeObjectId, UpdateLargeObjectRequest updateLargeObjectRequest = null)

Updates a LargeObject

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdateLargeObjectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var largeObjectId = "largeObjectId_example";  // string | 
            var updateLargeObjectRequest = new UpdateLargeObjectRequest(); // UpdateLargeObjectRequest |  (optional) 

            try
            {
                // Updates a LargeObject
                LargeObject result = apiInstance.UpdateLargeObject(largeObjectId, updateLargeObjectRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateLargeObject: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateLargeObjectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a LargeObject
    ApiResponse<LargeObject> response = apiInstance.UpdateLargeObjectWithHttpInfo(largeObjectId, updateLargeObjectRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateLargeObjectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **largeObjectId** | **string** |  |  |
| **updateLargeObjectRequest** | [**UpdateLargeObjectRequest**](UpdateLargeObjectRequest.md) |  | [optional]  |

### Return type

[**LargeObject**](LargeObject.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatelargeobjectcontents"></a>
# **UpdateLargeObjectContents**
> LargeObject UpdateLargeObjectContents (string largeObjectId, Object body = null)

Updates a LargeObject content

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdateLargeObjectContentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var largeObjectId = "largeObjectId_example";  // string | 
            var body = null;  // Object |  (optional) 

            try
            {
                // Updates a LargeObject content
                LargeObject result = apiInstance.UpdateLargeObjectContents(largeObjectId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateLargeObjectContents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateLargeObjectContentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a LargeObject content
    ApiResponse<LargeObject> response = apiInstance.UpdateLargeObjectContentsWithHttpInfo(largeObjectId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateLargeObjectContentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **largeObjectId** | **string** |  |  |
| **body** | **Object** |  | [optional]  |

### Return type

[**LargeObject**](LargeObject.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateleaderboard"></a>
# **UpdateLeaderboard**
> Leaderboard UpdateLeaderboard (string nameOrId, Leaderboard leaderboard = null)

Updates an Leaderboard

Performs an update to an existing leaderboard known to the server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdateLeaderboardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var nameOrId = "nameOrId_example";  // string | 
            var leaderboard = new Leaderboard(); // Leaderboard |  (optional) 

            try
            {
                // Updates an Leaderboard
                Leaderboard result = apiInstance.UpdateLeaderboard(nameOrId, leaderboard);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateLeaderboard: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateLeaderboardWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates an Leaderboard
    ApiResponse<Leaderboard> response = apiInstance.UpdateLeaderboardWithHttpInfo(nameOrId, leaderboard);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateLeaderboardWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **nameOrId** | **string** |  |  |
| **leaderboard** | [**Leaderboard**](Leaderboard.md) |  | [optional]  |

### Return type

[**Leaderboard**](Leaderboard.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatematchmakingapplicationconfiguration"></a>
# **UpdateMatchmakingApplicationConfiguration**
> MatchmakingApplicationConfiguration UpdateMatchmakingApplicationConfiguration (string applicationNameOrId, string applicationConfigurationNameOrId, MatchmakingApplicationConfiguration matchmakingApplicationConfiguration = null)

Updates a iOS ApplicationConfiguration

Updates an existing iOS Application profile if it is known to the server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdateMatchmakingApplicationConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var applicationNameOrId = "applicationNameOrId_example";  // string | 
            var applicationConfigurationNameOrId = "applicationConfigurationNameOrId_example";  // string | 
            var matchmakingApplicationConfiguration = new MatchmakingApplicationConfiguration(); // MatchmakingApplicationConfiguration |  (optional) 

            try
            {
                // Updates a iOS ApplicationConfiguration
                MatchmakingApplicationConfiguration result = apiInstance.UpdateMatchmakingApplicationConfiguration(applicationNameOrId, applicationConfigurationNameOrId, matchmakingApplicationConfiguration);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateMatchmakingApplicationConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateMatchmakingApplicationConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a iOS ApplicationConfiguration
    ApiResponse<MatchmakingApplicationConfiguration> response = apiInstance.UpdateMatchmakingApplicationConfigurationWithHttpInfo(applicationNameOrId, applicationConfigurationNameOrId, matchmakingApplicationConfiguration);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateMatchmakingApplicationConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationNameOrId** | **string** |  |  |
| **applicationConfigurationNameOrId** | **string** |  |  |
| **matchmakingApplicationConfiguration** | [**MatchmakingApplicationConfiguration**](MatchmakingApplicationConfiguration.md) |  | [optional]  |

### Return type

[**MatchmakingApplicationConfiguration**](MatchmakingApplicationConfiguration.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatemetadata"></a>
# **UpdateMetadata**
> Metadata UpdateMetadata (string id, UpdateMetadataRequest updateMetadataRequest = null)

Updates a specific Metadata object

Updates a specific metadata object by name or id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdateMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var id = "id_example";  // string | 
            var updateMetadataRequest = new UpdateMetadataRequest(); // UpdateMetadataRequest |  (optional) 

            try
            {
                // Updates a specific Metadata object
                Metadata result = apiInstance.UpdateMetadata(id, updateMetadataRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateMetadata: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateMetadataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a specific Metadata object
    ApiResponse<Metadata> response = apiInstance.UpdateMetadataWithHttpInfo(id, updateMetadataRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateMetadataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **updateMetadataRequest** | [**UpdateMetadataRequest**](UpdateMetadataRequest.md) |  | [optional]  |

### Return type

[**Metadata**](Metadata.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatemetadataspec"></a>
# **UpdateMetadataSpec**
> MetadataSpec UpdateMetadataSpec (string metadataSpecId, UpdateMetadataSpecRequest updateMetadataSpecRequest = null)

Updates a Metadata Spec

Updates a MetadataSpec with the specified id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdateMetadataSpecExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var metadataSpecId = "metadataSpecId_example";  // string | 
            var updateMetadataSpecRequest = new UpdateMetadataSpecRequest(); // UpdateMetadataSpecRequest |  (optional) 

            try
            {
                // Updates a Metadata Spec
                MetadataSpec result = apiInstance.UpdateMetadataSpec(metadataSpecId, updateMetadataSpecRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateMetadataSpec: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateMetadataSpecWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a Metadata Spec
    ApiResponse<MetadataSpec> response = apiInstance.UpdateMetadataSpecWithHttpInfo(metadataSpecId, updateMetadataSpecRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateMetadataSpecWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **metadataSpecId** | **string** |  |  |
| **updateMetadataSpecRequest** | [**UpdateMetadataSpecRequest**](UpdateMetadataSpecRequest.md) |  | [optional]  |

### Return type

[**MetadataSpec**](MetadataSpec.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatemission"></a>
# **UpdateMission**
> Mission UpdateMission (string missionNameOrId, Mission mission = null)

Updates an entire single Mission

Supplying a mission, this will update the Mission identified by the name or ID in the path with contents from the passed in request body. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdateMissionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var missionNameOrId = "missionNameOrId_example";  // string | 
            var mission = new Mission(); // Mission |  (optional) 

            try
            {
                // Updates an entire single Mission
                Mission result = apiInstance.UpdateMission(missionNameOrId, mission);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateMission: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateMissionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates an entire single Mission
    ApiResponse<Mission> response = apiInstance.UpdateMissionWithHttpInfo(missionNameOrId, mission);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateMissionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **missionNameOrId** | **string** |  |  |
| **mission** | [**Mission**](Mission.md) |  | [optional]  |

### Return type

[**Mission**](Mission.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatepsnapplicationconfiguration"></a>
# **UpdatePSNApplicationConfiguration**
> PSNApplicationConfiguration UpdatePSNApplicationConfiguration (string applicationNameOrId, string applicationConfigurationNameOrId, PSNApplicationConfiguration pSNApplicationConfiguration = null)

Updates a PSN ApplicationConfiguration

Updates an existing PSN Application profile if it is known to the server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdatePSNApplicationConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var applicationNameOrId = "applicationNameOrId_example";  // string | 
            var applicationConfigurationNameOrId = "applicationConfigurationNameOrId_example";  // string | 
            var pSNApplicationConfiguration = new PSNApplicationConfiguration(); // PSNApplicationConfiguration |  (optional) 

            try
            {
                // Updates a PSN ApplicationConfiguration
                PSNApplicationConfiguration result = apiInstance.UpdatePSNApplicationConfiguration(applicationNameOrId, applicationConfigurationNameOrId, pSNApplicationConfiguration);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdatePSNApplicationConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdatePSNApplicationConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a PSN ApplicationConfiguration
    ApiResponse<PSNApplicationConfiguration> response = apiInstance.UpdatePSNApplicationConfigurationWithHttpInfo(applicationNameOrId, applicationConfigurationNameOrId, pSNApplicationConfiguration);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdatePSNApplicationConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationNameOrId** | **string** |  |  |
| **applicationConfigurationNameOrId** | **string** |  |  |
| **pSNApplicationConfiguration** | [**PSNApplicationConfiguration**](PSNApplicationConfiguration.md) |  | [optional]  |

### Return type

[**PSNApplicationConfiguration**](PSNApplicationConfiguration.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateproductbundleforapplicationconfiguration"></a>
# **UpdateProductBundleForApplicationConfiguration**
> ApplicationConfiguration UpdateProductBundleForApplicationConfiguration (string applicationNameOrId, string applicationConfigurationNameOrId, List<ProductBundle> productBundle = null)

Updates the ProductBundle

Updates the ProductBundle for the given ApplicationConfiguration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdateProductBundleForApplicationConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var applicationNameOrId = "applicationNameOrId_example";  // string | 
            var applicationConfigurationNameOrId = "applicationConfigurationNameOrId_example";  // string | 
            var productBundle = new List<ProductBundle>(); // List<ProductBundle> |  (optional) 

            try
            {
                // Updates the ProductBundle
                ApplicationConfiguration result = apiInstance.UpdateProductBundleForApplicationConfiguration(applicationNameOrId, applicationConfigurationNameOrId, productBundle);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateProductBundleForApplicationConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateProductBundleForApplicationConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates the ProductBundle
    ApiResponse<ApplicationConfiguration> response = apiInstance.UpdateProductBundleForApplicationConfigurationWithHttpInfo(applicationNameOrId, applicationConfigurationNameOrId, productBundle);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateProductBundleForApplicationConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationNameOrId** | **string** |  |  |
| **applicationConfigurationNameOrId** | **string** |  |  |
| **productBundle** | [**List&lt;ProductBundle&gt;**](ProductBundle.md) |  | [optional]  |

### Return type

[**ApplicationConfiguration**](ApplicationConfiguration.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateproductbundleforapplicationconfiguration1"></a>
# **UpdateProductBundleForApplicationConfiguration1**
> ApplicationConfiguration UpdateProductBundleForApplicationConfiguration1 (string applicationNameOrId, string applicationConfigurationNameOrId, List<ProductBundle> productBundle = null)

Updates the ProductBundle

Updates the ProductBundle for the given ApplicationConfiguration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdateProductBundleForApplicationConfiguration1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var applicationNameOrId = "applicationNameOrId_example";  // string | 
            var applicationConfigurationNameOrId = "applicationConfigurationNameOrId_example";  // string | 
            var productBundle = new List<ProductBundle>(); // List<ProductBundle> |  (optional) 

            try
            {
                // Updates the ProductBundle
                ApplicationConfiguration result = apiInstance.UpdateProductBundleForApplicationConfiguration1(applicationNameOrId, applicationConfigurationNameOrId, productBundle);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateProductBundleForApplicationConfiguration1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateProductBundleForApplicationConfiguration1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates the ProductBundle
    ApiResponse<ApplicationConfiguration> response = apiInstance.UpdateProductBundleForApplicationConfiguration1WithHttpInfo(applicationNameOrId, applicationConfigurationNameOrId, productBundle);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateProductBundleForApplicationConfiguration1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **applicationNameOrId** | **string** |  |  |
| **applicationConfigurationNameOrId** | **string** |  |  |
| **productBundle** | [**List&lt;ProductBundle&gt;**](ProductBundle.md) |  | [optional]  |

### Return type

[**ApplicationConfiguration**](ApplicationConfiguration.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateprofile"></a>
# **UpdateProfile**
> Profile UpdateProfile (string profileId, UpdateProfileRequest updateProfileRequest = null)

Updates a Profile

Supplying an update request will attempt to update the profile.  The call will return the profile as it was written to the database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdateProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var profileId = "profileId_example";  // string | 
            var updateProfileRequest = new UpdateProfileRequest(); // UpdateProfileRequest |  (optional) 

            try
            {
                // Updates a Profile
                Profile result = apiInstance.UpdateProfile(profileId, updateProfileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateProfile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateProfileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a Profile
    ApiResponse<Profile> response = apiInstance.UpdateProfileWithHttpInfo(profileId, updateProfileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateProfileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **profileId** | **string** |  |  |
| **updateProfileRequest** | [**UpdateProfileRequest**](UpdateProfileRequest.md) |  | [optional]  |

### Return type

[**Profile**](Profile.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateprofileimage"></a>
# **UpdateProfileImage**
> Profile UpdateProfileImage (string profileId, UpdateProfileImageRequest updateProfileImageRequest = null)

Updates a Profile image object

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdateProfileImageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var profileId = "profileId_example";  // string | 
            var updateProfileImageRequest = new UpdateProfileImageRequest(); // UpdateProfileImageRequest |  (optional) 

            try
            {
                // Updates a Profile image object
                Profile result = apiInstance.UpdateProfileImage(profileId, updateProfileImageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateProfileImage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateProfileImageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a Profile image object
    ApiResponse<Profile> response = apiInstance.UpdateProfileImageWithHttpInfo(profileId, updateProfileImageRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateProfileImageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **profileId** | **string** |  |  |
| **updateProfileImageRequest** | [**UpdateProfileImageRequest**](UpdateProfileImageRequest.md) |  | [optional]  |

### Return type

[**Profile**](Profile.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateprogress"></a>
# **UpdateProgress**
> Progress UpdateProgress (string progressId, Progress progress = null)

Updates a single Progress

Supplying a progress, this will update the Progress identified by the ID in the path with contents from the passed in request body. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdateProgressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var progressId = "progressId_example";  // string | 
            var progress = new Progress(); // Progress |  (optional) 

            try
            {
                // Updates a single Progress
                Progress result = apiInstance.UpdateProgress(progressId, progress);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateProgress: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateProgressWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a single Progress
    ApiResponse<Progress> response = apiInstance.UpdateProgressWithHttpInfo(progressId, progress);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateProgressWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **progressId** | **string** |  |  |
| **progress** | [**Progress**](Progress.md) |  | [optional]  |

### Return type

[**Progress**](Progress.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateregistration"></a>
# **UpdateRegistration**
> FCMRegistration UpdateRegistration (string fcmRegistrationId, FCMRegistration fCMRegistration = null)

Update an FCM Registration Token

Supplying FCM registration token, this will update the token string with the supplied values.  Clients may update the same registration with a different token issued with Firebase if they wish to simply retain the association with the 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdateRegistrationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var fcmRegistrationId = "fcmRegistrationId_example";  // string | 
            var fCMRegistration = new FCMRegistration(); // FCMRegistration |  (optional) 

            try
            {
                // Update an FCM Registration Token
                FCMRegistration result = apiInstance.UpdateRegistration(fcmRegistrationId, fCMRegistration);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateRegistration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateRegistrationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an FCM Registration Token
    ApiResponse<FCMRegistration> response = apiInstance.UpdateRegistrationWithHttpInfo(fcmRegistrationId, fCMRegistration);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateRegistrationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fcmRegistrationId** | **string** |  |  |
| **fCMRegistration** | [**FCMRegistration**](FCMRegistration.md) |  | [optional]  |

### Return type

[**FCMRegistration**](FCMRegistration.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatesavedocument"></a>
# **UpdateSaveDocument**
> SaveDataDocument UpdateSaveDocument (string saveDataDocumentId, UpdateSaveDataDocumentRequest updateSaveDataDocumentRequest = null)

Creates a save data document.

Gets a single save data document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdateSaveDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var saveDataDocumentId = "saveDataDocumentId_example";  // string | 
            var updateSaveDataDocumentRequest = new UpdateSaveDataDocumentRequest(); // UpdateSaveDataDocumentRequest |  (optional) 

            try
            {
                // Creates a save data document.
                SaveDataDocument result = apiInstance.UpdateSaveDocument(saveDataDocumentId, updateSaveDataDocumentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateSaveDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSaveDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a save data document.
    ApiResponse<SaveDataDocument> response = apiInstance.UpdateSaveDocumentWithHttpInfo(saveDataDocumentId, updateSaveDataDocumentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateSaveDocumentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **saveDataDocumentId** | **string** |  |  |
| **updateSaveDataDocumentRequest** | [**UpdateSaveDataDocumentRequest**](UpdateSaveDataDocumentRequest.md) |  | [optional]  |

### Return type

[**SaveDataDocument**](SaveDataDocument.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateschedule"></a>
# **UpdateSchedule**
> Schedule UpdateSchedule (string scheduleNameOrId, UpdateScheduleRequest updateScheduleRequest = null)

Updates an entire single Schedule

Supplying a schedule, this will update the Schedule identified by the name or ID in the path with contents from the passed in request body. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdateScheduleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var scheduleNameOrId = "scheduleNameOrId_example";  // string | 
            var updateScheduleRequest = new UpdateScheduleRequest(); // UpdateScheduleRequest |  (optional) 

            try
            {
                // Updates an entire single Schedule
                Schedule result = apiInstance.UpdateSchedule(scheduleNameOrId, updateScheduleRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateSchedule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateScheduleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates an entire single Schedule
    ApiResponse<Schedule> response = apiInstance.UpdateScheduleWithHttpInfo(scheduleNameOrId, updateScheduleRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateScheduleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scheduleNameOrId** | **string** |  |  |
| **updateScheduleRequest** | [**UpdateScheduleRequest**](UpdateScheduleRequest.md) |  | [optional]  |

### Return type

[**Schedule**](Schedule.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatescheduleevent"></a>
# **UpdateScheduleEvent**
> ScheduleEvent UpdateScheduleEvent (string scheduleNameOrId, string scheduleEventId, UpdateScheduleEventRequest updateScheduleEventRequest = null)

Updates an entire single ScheduleEvent

Supplying a schedule, this will update the ScheduleEvent identified by the name or ID in the path with contents from the passed in request body. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdateScheduleEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var scheduleNameOrId = "scheduleNameOrId_example";  // string | 
            var scheduleEventId = "scheduleEventId_example";  // string | 
            var updateScheduleEventRequest = new UpdateScheduleEventRequest(); // UpdateScheduleEventRequest |  (optional) 

            try
            {
                // Updates an entire single ScheduleEvent
                ScheduleEvent result = apiInstance.UpdateScheduleEvent(scheduleNameOrId, scheduleEventId, updateScheduleEventRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateScheduleEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateScheduleEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates an entire single ScheduleEvent
    ApiResponse<ScheduleEvent> response = apiInstance.UpdateScheduleEventWithHttpInfo(scheduleNameOrId, scheduleEventId, updateScheduleEventRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateScheduleEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scheduleNameOrId** | **string** |  |  |
| **scheduleEventId** | **string** |  |  |
| **updateScheduleEventRequest** | [**UpdateScheduleEventRequest**](UpdateScheduleEventRequest.md) |  | [optional]  |

### Return type

[**ScheduleEvent**](ScheduleEvent.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatesimpleinventoryitem"></a>
# **UpdateSimpleInventoryItem**
> InventoryItem UpdateSimpleInventoryItem (string inventoryItemId, UpdateInventoryItemRequest updateInventoryItemRequest = null)

Updates an inventory item for the specified item

Updates an inventory item for the specified item

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdateSimpleInventoryItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var inventoryItemId = "inventoryItemId_example";  // string | 
            var updateInventoryItemRequest = new UpdateInventoryItemRequest(); // UpdateInventoryItemRequest |  (optional) 

            try
            {
                // Updates an inventory item for the specified item
                InventoryItem result = apiInstance.UpdateSimpleInventoryItem(inventoryItemId, updateInventoryItemRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateSimpleInventoryItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSimpleInventoryItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates an inventory item for the specified item
    ApiResponse<InventoryItem> response = apiInstance.UpdateSimpleInventoryItemWithHttpInfo(inventoryItemId, updateInventoryItemRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateSimpleInventoryItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inventoryItemId** | **string** |  |  |
| **updateInventoryItemRequest** | [**UpdateInventoryItemRequest**](UpdateInventoryItemRequest.md) |  | [optional]  |

### Return type

[**InventoryItem**](InventoryItem.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatesimpleinventoryitem1"></a>
# **UpdateSimpleInventoryItem1**
> InventoryItem UpdateSimpleInventoryItem1 (string inventoryItemId, UpdateInventoryItemRequest updateInventoryItemRequest = null)

Updates an inventory item for the specified item

Updates an inventory item for the specified item

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdateSimpleInventoryItem1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var inventoryItemId = "inventoryItemId_example";  // string | 
            var updateInventoryItemRequest = new UpdateInventoryItemRequest(); // UpdateInventoryItemRequest |  (optional) 

            try
            {
                // Updates an inventory item for the specified item
                InventoryItem result = apiInstance.UpdateSimpleInventoryItem1(inventoryItemId, updateInventoryItemRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateSimpleInventoryItem1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSimpleInventoryItem1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates an inventory item for the specified item
    ApiResponse<InventoryItem> response = apiInstance.UpdateSimpleInventoryItem1WithHttpInfo(inventoryItemId, updateInventoryItemRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateSimpleInventoryItem1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inventoryItemId** | **string** |  |  |
| **updateInventoryItemRequest** | [**UpdateInventoryItemRequest**](UpdateInventoryItemRequest.md) |  | [optional]  |

### Return type

[**InventoryItem**](InventoryItem.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatesmartcontract"></a>
# **UpdateSmartContract**
> SmartContract UpdateSmartContract (string contractId, UpdateSmartContractRequest updateSmartContractRequest = null)

Patches a  Smart Contract

Patches a  Smart Contract entry, associated with the specified deployed script hash.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdateSmartContractExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var contractId = "contractId_example";  // string | 
            var updateSmartContractRequest = new UpdateSmartContractRequest(); // UpdateSmartContractRequest |  (optional) 

            try
            {
                // Patches a  Smart Contract
                SmartContract result = apiInstance.UpdateSmartContract(contractId, updateSmartContractRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateSmartContract: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSmartContractWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Patches a  Smart Contract
    ApiResponse<SmartContract> response = apiInstance.UpdateSmartContractWithHttpInfo(contractId, updateSmartContractRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateSmartContractWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contractId** | **string** |  |  |
| **updateSmartContractRequest** | [**UpdateSmartContractRequest**](UpdateSmartContractRequest.md) |  | [optional]  |

### Return type

[**SmartContract**](SmartContract.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateuser"></a>
# **UpdateUser**
> User UpdateUser (string userId, UserUpdateRequest userUpdateRequest = null)

Updates a User

Supplying the user object, this will update the user with the new information supplied in the body of the request.  Optionally, the user's password may be provided in the User object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdateUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var userId = "userId_example";  // string | 
            var userUpdateRequest = new UserUpdateRequest(); // UserUpdateRequest |  (optional) 

            try
            {
                // Updates a User
                User result = apiInstance.UpdateUser(userId, userUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a User
    ApiResponse<User> response = apiInstance.UpdateUserWithHttpInfo(userId, userUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** |  |  |
| **userUpdateRequest** | [**UserUpdateRequest**](UserUpdateRequest.md) |  | [optional]  |

### Return type

[**User**](User.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateuserpassword"></a>
# **UpdateUserPassword**
> SessionCreation UpdateUserPassword (string userId, UserUpdatePasswordRequest userUpdatePasswordRequest = null)

Updates a User's Password

Supplying the UserUpdatePasswordRequest, this will attempt to update the user's password only if they supply the correct existing password.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdateUserPasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var userId = "userId_example";  // string | 
            var userUpdatePasswordRequest = new UserUpdatePasswordRequest(); // UserUpdatePasswordRequest |  (optional) 

            try
            {
                // Updates a User's Password
                SessionCreation result = apiInstance.UpdateUserPassword(userId, userUpdatePasswordRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateUserPassword: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateUserPasswordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a User's Password
    ApiResponse<SessionCreation> response = apiInstance.UpdateUserPasswordWithHttpInfo(userId, userUpdatePasswordRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateUserPasswordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** |  |  |
| **userUpdatePasswordRequest** | [**UserUpdatePasswordRequest**](UserUpdatePasswordRequest.md) |  | [optional]  |

### Return type

[**SessionCreation**](SessionCreation.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatevault"></a>
# **UpdateVault**
> Vault UpdateVault (string vaultId, UpdateVaultRequest updateVaultRequest = null)

Updates a  Vault

Updates a  Vault with the specified name or id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdateVaultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var vaultId = "vaultId_example";  // string | 
            var updateVaultRequest = new UpdateVaultRequest(); // UpdateVaultRequest |  (optional) 

            try
            {
                // Updates a  Vault
                Vault result = apiInstance.UpdateVault(vaultId, updateVaultRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateVault: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateVaultWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a  Vault
    ApiResponse<Vault> response = apiInstance.UpdateVaultWithHttpInfo(vaultId, updateVaultRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateVaultWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vaultId** | **string** |  |  |
| **updateVaultRequest** | [**UpdateVaultRequest**](UpdateVaultRequest.md) |  | [optional]  |

### Return type

[**Vault**](Vault.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatewallet"></a>
# **UpdateWallet**
> Wallet UpdateWallet (string vaultId, string walletId, UpdateWalletRequest updateWalletRequest = null)

Updates a  Wallet

Updates a  Wallet with the specified name or id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UpdateWalletExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var vaultId = "vaultId_example";  // string | 
            var walletId = "walletId_example";  // string | 
            var updateWalletRequest = new UpdateWalletRequest(); // UpdateWalletRequest |  (optional) 

            try
            {
                // Updates a  Wallet
                Wallet result = apiInstance.UpdateWallet(vaultId, walletId, updateWalletRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateWallet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateWalletWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a  Wallet
    ApiResponse<Wallet> response = apiInstance.UpdateWalletWithHttpInfo(vaultId, walletId, updateWalletRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateWalletWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vaultId** | **string** |  |  |
| **walletId** | **string** |  |  |
| **updateWalletRequest** | [**UpdateWalletRequest**](UpdateWalletRequest.md) |  | [optional]  |

### Return type

[**Wallet**](Wallet.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="uploadappleiapreceipt"></a>
# **UploadAppleIapReceipt**
> List&lt;RewardIssuance&gt; UploadAppleIapReceipt (CreateAppleIapReceipt createAppleIapReceipt = null)



Upload Apple IAP Receipt. Returns a list of RewardIssuances, which may contain already-redeemed issuances.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UploadAppleIapReceiptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var createAppleIapReceipt = new CreateAppleIapReceipt(); // CreateAppleIapReceipt |  (optional) 

            try
            {
                List<RewardIssuance> result = apiInstance.UploadAppleIapReceipt(createAppleIapReceipt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UploadAppleIapReceipt: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadAppleIapReceiptWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<RewardIssuance>> response = apiInstance.UploadAppleIapReceiptWithHttpInfo(createAppleIapReceipt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UploadAppleIapReceiptWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createAppleIapReceipt** | [**CreateAppleIapReceipt**](CreateAppleIapReceipt.md) |  | [optional]  |

### Return type

[**List&lt;RewardIssuance&gt;**](RewardIssuance.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="uploadgoogleplayiappurchase"></a>
# **UploadGooglePlayIapPurchase**
> List&lt;RewardIssuance&gt; UploadGooglePlayIapPurchase (CreateGooglePlayIapReceipt createGooglePlayIapReceipt = null)

Upload Google Play IAP Receipt data (package name, product id and Google Play-issued purchase token). Returns a list of RewardIssuances, some or all of which may be already redeemed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Elements.Api;
using Elements.Client;
using Elements.Model;

namespace Example
{
    public class UploadGooglePlayIapPurchaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/api/rest";
            // Configure API key authorization: auth_bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: session_secret
            config.AddApiKey("Elements-SessionSecret", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Elements-SessionSecret", "Bearer");

            var apiInstance = new DefaultApi(config);
            var createGooglePlayIapReceipt = new CreateGooglePlayIapReceipt(); // CreateGooglePlayIapReceipt |  (optional) 

            try
            {
                // Upload Google Play IAP Receipt data (package name, product id and Google Play-issued purchase token). Returns a list of RewardIssuances, some or all of which may be already redeemed.
                List<RewardIssuance> result = apiInstance.UploadGooglePlayIapPurchase(createGooglePlayIapReceipt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UploadGooglePlayIapPurchase: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadGooglePlayIapPurchaseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload Google Play IAP Receipt data (package name, product id and Google Play-issued purchase token). Returns a list of RewardIssuances, some or all of which may be already redeemed.
    ApiResponse<List<RewardIssuance>> response = apiInstance.UploadGooglePlayIapPurchaseWithHttpInfo(createGooglePlayIapReceipt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UploadGooglePlayIapPurchaseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createGooglePlayIapReceipt** | [**CreateGooglePlayIapReceipt**](CreateGooglePlayIapReceipt.md) |  | [optional]  |

### Return type

[**List&lt;RewardIssuance&gt;**](RewardIssuance.md)

### Authorization

[auth_bearer](../README.md#auth_bearer), [session_secret](../README.md#session_secret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** |  |  -  |
| **403** |  |  -  |
| **409** |  |  -  |
| **503** |  |  -  |
| **400** |  |  -  |
| **500** |  |  -  |
| **401** |  |  -  |
| **501** |  |  -  |
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

