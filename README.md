# WFClassic

A server emulator which allows you to play older versions of warframe, 7.3 => 7.10.

This work a combination of information from the SpaceNinjaServer project, additional reverse engineering of earlier builds, trial and error, and a decent amount.
Currently using .net9 and sqlite for persistence, linux and windows are both supported and builds are self contained, so no runtime install is necessary. 

# Getting started


1.  Unzip the package to your desired location
2. In appsettings.json , set  ```BuildLabel``` to the corresponding version of your client.  
3. Run the executable 
4. Wait for the db to be created / migrations complete. 
5. ????
6. Profit


You can either create an account via the web interface (http://localhost:5000) or an account will be created automatigally for you upon initial login using the waframe client.

In the steam content folder, ```C:\Program Files (x86)\Steam\steamapps\content\app_230410\depot_230411```, run the following

```
Warframe.x64.exe -log -dx11:1 -webserver:http://localhost:5000/api/ -fullscreen
```




# Currently Tested Versions

| Version | Build Id |  Manifest Id| Items not working? | Notes |
|-|-|-| -| -|
| 7.10 | 2013.05.03.18.06/ | 588705282697359018 | | This version has some issues loading certain textures, specifically those around grenades and melee attacks. The issue is within the binary, rather than the assets |
| 7.9 | 2013.04.26.17.24/ | 6399786153404128119 | | |
| 7.8.1 | 2013.04.24.11.45/ | 6629234302933135021 | | |
| 7.7.4 | 2013.04.15.14.48/ | 8278491043607750104 | | |
| 7.6 | 2013.04.01.16.24/ | 1412521350878833822 | | |
| 7.5 | 2013.03.28.17.01/ | 5572824118589588358 | |Grineer corpses disappear after being killed. sometimes. (this looks to be a hotfix as there is another release on the 28th)?  |  
| 7.4 | 2013.03.27.09.43/ | 1958670258248515033 | | |
| 7.3 | 2013.03.25.11.45/ | 9176710083987114410 | | Oddities with the starchart, least performant of the tested builds. |



Builds after 7.10 do not work as of now, and may never work. There seem to either be missing assets or a missing endpoint.


# Features

Nothing related to multiplayer has been added to the code base, and most likely never will. This is due to the fact that I dont want to get sued.
IRC has not yet been implemented, though this is a feature planned for a later release.

## Client Features

This is not a comprehensive list of features, just the ones that really seem to matter for gameplay


|Name|Area|Description|Implementation|What needs work|
|--|--|--|--|--|
| Automatic Account Creation| Gameplay| Upon initial login from client, a new account will be created if one does not already exist | Fully ||
| Login | Authnz |  | Fully ||
| Logout | Authnz |  | Fully ||
| Initial Training and Warframe Selection | Gameplay || Fully ||
| Complete Mastery Rank Challenges| Gameplay || Fully ||
| Attach system wide artifact| Gameplay || Fully |This is not actually an api endpoint, but instead relies on returnign inventory correctly|
| Obtain daily login reward| Gameplay || Fully | This is customizable and uses older documentation for the rewards listing. Current state drop table percentage is not period accurate |
| Get the world state | Gameplay || Partially | Can be configured via db, alerts work for the most part.  operations are not implemented|
| Validate daily mission bonus status| Gameplay || Fully | |
| purchase more revives | Economy || Fully ||
| update taunt state | Gameplay ||Fully*| There may be a bug surrounding the initial lotus explanation after completing training |
| Get updated credits/plat| Economy || Fully ||
| Purchase Item | Economy ||Some work started||
| Craft item in Foundry | Foundry ||Fully|all known recipes as of 7.10.0 are included|
| Claim Foundry Item|Foundry || Fully ||
| Instantly complete item in foundry| Foundry || Fully ||
| Check build status in foundry | Foundry  || Fully ||
| Get Player Profile (All Players)| Stats ||Partial| Some stats have not appeared in the metrics, so some stats might not be correct|
| Get Kill Leaderboard| Stats || Fully ||
| Get Kill Leaderboard With User Ranking| Stats ||Partial| leaderboard that is returned is the same as the general leaderboard|
| Get Inventory| Gear ||Partial||
| Update Inventory| Gear ||Partial| Some areas (goals/completions) might not be updated as they have yet to be encountered  |
| Attach mods| Gear || Fully ||
| Upgrade Mods| Gear || Fully ||
| Save loadout| Gear || Fully ||
| Attach reactors / catalysts to frames/weapons| Gear|| Fully ||
| Purchase new inventory slots (frames and weapons)| Gear ||Fully||
| Send friend request| Friends || Fully ||
| Remove friend| Friends || Fully ||
| Approve Friend request | Friends || Fully ||
| Get friend listing | Friends || Partial / Unknown | More data might need to be returned. but list works.|
| Set player avatar | Friends || Fully ||
| Get Guild Member Listing |Guild || Very Little | right now has hardcoded return object |
| Create Guild| Guild ||Nothing||
| Remove member from Guild | Guild ||Nothing||
| Donate To Guild | Guild ||Nothing||
| Customize Guild Ranks | Guild ||Nothing||
| Invite to guild | Guild ||Nothing||
| Accept guild invite | Guild ||Nothing||
| change guild rank | Guild ||Nothing||
| Get Messages (Api) | ||Nothing| No idea what this is and it might be a vestigial endpoint|
| Send Messages (Api) | ||Nothing| No idea what this is and it might be a vestigial endpoint|


## Web Features

|Name|Area|Description|Implementation|What needs work|
|-|-|-|-|-|
|Login|Web|| Fully ||
|Logout|Web|| Fully ||
|Registration|Web|| Fully ||
| View player profile | ||No work done||
| View individual player stats | ||No work done||
| Leaderboards (player)  | ||No work done||
| Leaderboards (guild) | ||No work done||
| View player inventory  | ||No work done||
| Trading system  | ||No work done||
| confirm account via email	|||||
| ban player	|||||
