


## GET 

### Request
/api/logout.php?accountId=6956f839-024c-4d0c-b4c0-aad1d4b26a33&nonce=618649617541434196 


|Field|Type|Description|
|-|-|-|
|accountId|string| userId of the caller|
|nonce|int64 | current login nonce/token number|



### Response

- 200 if logged out
- 500 if failure
- 404 if user isn't found
- 403 if the nonce doesnt match with currentNonce
