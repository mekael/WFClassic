# Login.php


## Post

### Request

The password is pre-hashed client side using whirlpool as the algorithm. This is passed in lower case. 


```json
    {
        "email" :"",
        "password" :""
    }
```

### Response


```json
    {
        "id":"",
        "DisplayName":"",
        "Nonce":0,
        "BuildLabel":"",
        "NatHash":"",
        "SteamId":""
    }
```