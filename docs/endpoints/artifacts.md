mods upgrade
POST
/api/artifacts.php?accountId=ACCID&nonce=Auth NUM



```json

 
{"Upgrade":{"ItemType":"/Lotus/Upgrades/Mods/Warframe/AvatarHealthMaxMod",
"ItemId":{"$id":"ITEM ID THAT YOU WANT TO UPGRADE"},
"UpgradeFingerprint":"lvl=0|"}, // current level of this item
"Fingerprint":"lvl=1|", // level that should be after upgrade
"Consumed":[{"ItemType":"/Lotus/Upgrades/Mods/Warframe/AvatarHealthMaxMod", //used modules to upgrade (ARRAY)
            "ItemId":{"$id":"MODULE ID"},
            "UpgradeFingerprint":"lvl=0|"}], //module level(for now its not even checks on server and can be any,like 99999, its upgrade your any item to max level)
"Cost":300}//upgrade cost 

```