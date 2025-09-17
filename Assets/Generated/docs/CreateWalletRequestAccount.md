# Elements.Model.CreateWalletRequestAccount
Specifies a Custodial Wallet Account Creating a Wallet

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Generate** | **bool** | Flag which indicates if the account should be generated or imported. | [optional] 
**Address** | **string** | The Wallet Address - id public identity. Must be null for generated wallets. | 
**PrivateKey** | **string** | The Wallet Account - id private identity. May be null if the wallet is for receive only. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

