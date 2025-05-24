# WFClassic

A server emulator which allows you to play older versions of warframe,through to 7.10.
This work is based off of the SpaceNinjaServer project, with additional reverse engineering in order to accommodate the different endpoint structures. 
Currently using .net9 and sqlite for persistence, linux and windows are both supported and builds are self contained, so no runtime install is necessary. 


# Features

Nothing related to multiplayer has been added to the code base, and most likely never will. This is due to the fact that I dont want to get sued.
IRC has not yet been implemented, though this is a feature planned for a later release.

## Client Features

This is not a comprehensive list of features, just the ones that really seem to matter for gameplay


|Name|Area|Description|Implementation|What needs work|
|--|--|--|--|--|
|Login| Autnz ||Fully||
|Logout| Autnz ||Fully||
|Initial Training and Warframe Selection| Gameplay ||Fully||
|Complete Mastery Rank Challenges| Gameplay ||Fully||
|Attach system wide artifact| Gameplay ||Fully|This is not actually an api endpoint, but instead relies on returnign inventory correctly|
| Obtain daily login reward| ||Fully| This is customizable and uses older documentation for the rewards listing. Current state drop table percentage is not period accurate |
| Get the world state | || Partially | Can be configured via db, alerts work for the most part.  operations are not implemented|
| Validate daily mission bonus status| ||No| Currently hardcoded|
| purchase more revives ||No work done||
| update taunt state | ||Fully*| There may be a bug surrounding the initial lotus explanation after completing training |
|Get updated credits/plat| Economy ||Fully||
|Purchase Item | ||Some work started||
| Craft item in Foundry | Foundry ||Partial|Not all recipes are parsed / available in db|
| Claim Foundry Item|Foundry ||Fully||
| Instantly complete item in foundry| Foundry ||Fully||
| Check build status in foundry | Foundry  ||Fully||
|Get Player Profile (All Players)| Stats ||Partial| Some stats have not appeared in the metrics, so some stats might not be correct|
|Get Kill Leaderboard| Stats ||Fully||
|Get Kill Leaderboard With User Ranking| Stats ||Partial| leaderboard that is returned is the same as the general leaderboard|
|Get Inventory| Gear ||Partial||
|Update Inventory| Gear ||Partial| Some areas (goals/completions) might not be updated as they have yet to be encountered  |
|Attach mods| Gear ||Fully||
|Upgrade Mods| Gear ||Fully||
|Save loadout| Gear ||Fully||
| Attach reactors / catalysts to frames/weapons| Gear||Fully||
| Purchase new inventory slots (frames and weapons)| Gear ||No work started||
|Send friend request| Friends ||Fully||
|Remove friend| Friends ||Fully||
| Approve Friend request | Friends || Fully ||
| Get friend listing |Friends || Partial / Unknown | More data might need to be returned. but list works.|
| Set player avatar | Friends || No work done||
| Get Guild Member Listing |Guild || Very Little | right now has hardcoded return object |
| Create Guild| ||Nothing||
| Remove member from Guild | ||Nothing||
| Donate To Guild | ||Nothing||
| Customize Guild Ranks | ||Nothing||
| Invite to guild | ||Nothing||
| Accept guild invite | ||Nothing||
| change guild rank | ||Nothing||
|Get Messages (Api) | ||Nothing| No idea what this is and it might be a vestigial endpoint|
|Send Messages (Api) | ||Nothing| No idea what this is and it might be a vestigial endpoint|
| | ||||
| | ||||
| | ||||
| | ||||

## Web Features

|Name|Area|Description|Implementation|What needs work|
|Login|Web||Fully||
|Logout|Web||Fully||
|Registration|Web||Fully||
| View player profile | ||No work done||
| View individual player stats | ||No work done||
| Leaderboards (player)  | ||No work done||
| Leaderboards (guild) | ||No work done||
| View player inventory  | ||No work done||
| Trading system  | ||No work done||
| | ||||
| | ||||
| | ||||

