## simple counts

Things like mod and credit acheivements can be done simply by obtaining all records for a given EventName (RECEIVE_UPGRADE or PICKUP_ITEM where the item type is credit). Note that for the credit achievements, credits are in various denominations, 1/5/10/100 , and in order to calculate the correct number of credits, the amount for the item type must be multiplied by the item count. 

- Mods => RECEIVE_UPGRADE
- Credits => PICKUP_ITEM and ItemType
- Foundry => COOKED_RECIPE
- ciphers => CIPHER and ItemName = 1 (0 denotes a failure) 
- play time => MISSION_TIME 
- camera => KILL_ENTITY and ItemName = '/Lotus/Types/Enemies/Corpus/Turrets/TurretAvatars/SecurityCameraAvatar'
- Stealth => EXECUTE_ENEMY_ITEM
- Selling => SOLD (need to get the price from a lookup table) (implement last)
- achieve rank => RANK  

## boss/vip

This can be accomplished by running some sql and then seeing if a traceId is returned.

```sql
Select TraceId
from MetricItems
where ApplicationUserId = {ApplicationUserId}
group by TraceId
having 
sum(case when EventtName = 'KILL_ENTITY' and ItemName = '{VIP_NAME}' then 1 else 0 end ) >0
and sum(case when EventName = 'MISSION_STATUS' and ItemName = 'GS_SUCCESS' then 1 else 0 end)  >0
```

## Achievement listing

|Achievement Name Code|Name|Description|Data Area|Type|Notes|
|-|-|-|-|-|-|
|HatsOffToYouAchievement|Hats off to you!|Destroy 200 Corpus Crewman helmets.|Metric Items||Might not be possible in 7.x builds|
|LiberatorAchievement|Liberator|Set 10 Hostages free without triggering the execution timer.|||Research is needed to determine if there is even an execution timer or repercussions for failing to complete a cipher in time|
|NoWitnessesAchievement|No Witnesses|Successfully perform 100 stealth kills.|Metric Items|Simple sum/count|use EXECUTE_ENEMY_ITEM EventName|
|TailorMadeAchievement|Tailor Made|Customize the color of a Warframe.|Inventory||Only possible in 7.6 and later as 7.3 through 7.5 do not have the ability to post the loadout to the api. Will need to |
|TheCameraAdds10PoundsAchievement|The Camera Adds 10 pounds|Destroy 150 Security Cameras.|Metric Items|Simple|KILL_ENTITY and ItemName = '/Lotus/Types/Enemies/Corpus/Turrets/TurretAvatars/SecurityCameraAvatar'|
|AllForOneAchievement|All for One|Revive an Ally.|Metric Items|Simple||
|HealerAchievement|Healer|Revive 10 allies.|Metric Items|Simple||
|FieldMedicAchievement|Field Medic|Revive 100 allies.|Metric Items|Simple||
|CheaterOfDeathAchievement|Cheater of Death|Revive 1000 allies.|Metric Items|Simple||
|WeaponsmithAchievement|Weapon Smith|Build an item in the Foundry.|Metric Items|Simple||
|InventorAchievement|Inventor|Build 10 items in the Foundry.|Metric Items|Simple||
|ScientistAchievement|Scientist|Build 20 items in the Foundry.|Metric Items|Simple||
|HookedAchievement|Hooked|Play for 2 hours.|Metric Items|Simple||
|ItKeepsGettingBetterAchievement|It Keeps Getting Better|Play for 10 hours.|Metric Items|Simple||
|PrideOfTheLotusAchievement|Pride of The Lotus|Play for 100 hours.|Metric Items|Simple||
|CounterIntelligenceAchievement|Counter Intelligence|Solve a Cipher in under 5 seconds.|Metric Items|Simple||
|AgentAchievement|Agent|Solve a Cipher.|Metric Items|Simple||
|SpecialAgentAchievement|Special Agent|Solve 10 Ciphers.|Metric Items|Simple||
|OperativeAchievement|Operative|Solve 100 Ciphers.|Metric Items|Simple||
|CryptographerAchievement|Cryptographer|Solve 1000 Ciphers.|Metric Items|Simple||
|WeShapeOurToolsAchievement|We Shape Our Tools|Apply a Mod to a weapon or Warframe.|Inventory|Complex?||
|OurToolsShapeUsAchievement|Our Tools Shape Us|Apply 4 different Mods to a single weapon or Warframe.|Inventory|Complex||
|SecretsOfTheOrokinAchievement|Secrets of the Orokin|Find a Mod.|Metric Items|Simple||
|BeholdThePossibilitiesAchievement|Behold the Possibilities|Find 20 mods.|Metric Items|Simple||
|CollectorAchievement|Collector|Find 100 Mods.|Metric Items|Simple||
|SoManyChoicesAchievement|So Many Choices|Find 1,000 Mods.|Metric Items|Simple||
|EntrepreneurAchievement|Entrepreneur|Sell an item in the market.|Metric Items|Simple||
|MerchantAchievement|Merchant|Sell 10000 credits' worth of items.|Metric Items|Complex| Needs to have a mapping between an ItemType and the sale value|
|PaydayAchievement|Payday|Earn 1000 Credits.|Metric Items|Complex|Needs to have a mapping between the credit item and the amount.|
|NesteggAchievement|Nestegg|Earn 10,000 Credits.|Metric Items|Complex|Needs to have a mapping between the credit item and the amount.|
|WhereCreditIsDueAchievement|Where Credit is Due|Earn 100,000 Credits.|Metric Items|Complex|Needs to have a mapping between the credit item and the amount.|
|MoneyIsPowerAchievement|Money is Power|Earn 1,000,000 Credits.|Metric Items|Complex|Needs to have a mapping between the credit item and the amount.|
|AWatchfulEyeAchievement|A Watchful Eye|Obtain a [[Sentinel]].|Metric Items|Complex|need to check to see if the item is purchased or built in the foundry|
|AngelOfDeathAchievement|Angel of Death|Get 100 kills in a single mission.|Metric Items|Simple||
|BuildingAStableAchievement|Building a Stable|Obtain 2 Warframes.||||
|TheRightToolForTheJobAchievement|The Right Tool for the Job|Obtain 5 Warframes.||||
|EachToolWithItsOwnPurposeAchievement|Each Tool with Its Own Purpose|Obtain 10 [[Warframes]].||||
|NoLongerARookieAchievement|No Longer a Rookie|Reach Rank 2 with any Warframe.||||
|PracticeMakesPerfectAchievement|Practice Makes Perfect|Reach Rank 2 with any weapon.||||
|PlagueDoctorAchievement|Plague Doctor|Defeat [[Phorid]] and get to extraction.|Metric Items|Complex|Need to check to see if the vip has been killed and the mission status is GS_SUCCESS for a given traceId|
|SaviourOfCeresAchievement|Saviour of Ceres|Kill the boss in the [[Ceres]] region ([[Lieutenant Lech Kril]]) and get to extraction.|Metric Items|Complex|Need to check to see if the vip has been killed and the mission status is GS_SUCCESS for a given traceId|
|SaviourOfEarthAchievement|Saviour of Earth|Kill the boss of the [[Earth]] region ([[Vay Hek]]) and get to extraction.|Metric Items|Complex|Need to check to see if the vip has been killed and the mission status is GS_SUCCESS for a given traceId|
|SaviourOfMarsAchievement|Saviour of Mars|Kill the boss of the [[Mars]] region ([[The Sergeant]]) and get to extraction.|Metric Items|Complex|Need to check to see if the vip has been killed and the mission status is GS_SUCCESS for a given traceId|
|SaviourOfMercuryAchievement|Saviour of Mercury|Kill the boss of the [[Mercury]] region ([[Captain Vor]]) and get to extraction.|Metric Items|Complex|Need to check to see if the vip has been killed and the mission status is GS_SUCCESS for a given traceId|
|SaviourOfNeptuneAchievement|Saviour of Neptune|Kill the bosses of the [[Neptune]] region ([[Hyena Pack]]) and get to extraction.|Metric Items|Complex|Need to check to see if the vip has been killed and the mission status is GS_SUCCESS for a given traceId|
|SaviourOfPlutoAchievement|Saviour of Pluto|Kill the boss of the [[Pluto]] region ([[Ambulas]]), and get to extraction.|Metric Items|Complex|Need to check to see if the vip has been killed and the mission status is GS_SUCCESS for a given traceId|
|SaviourOfSaturnAchievement|Saviour of Saturn|Kill the boss of the [[Saturn]] region ([[General Sargas Ruk]]), and get to extraction.|Metric Items|Complex|Need to check to see if the vip has been killed and the mission status is GS_SUCCESS for a given traceId|
|SaviourOfSednaAchievement|Saviour of Sedna|Kill the boss of the [[Sedna]] region ([[Kela De Thaym]]), and get to extraction.|Metric Items|Complex|Need to check to see if the vip has been killed and the mission status is GS_SUCCESS for a given traceId|
|SaviourOfUranusAchievement|Saviour of Uranus|Kill the boss of the [[Uranus]] region ([[Tyl Regor]]), and get to extraction.|Metric Items|Complex|Need to check to see if the vip has been killed and the mission status is GS_SUCCESS for a given traceId|
|SaviourOfVenusAchievement|Saviour of Venus|Kill the boss of the [[Venus]] region ([[Jackal]]), and get to extraction.|Metric Items|Complex|Need to check to see if the vip has been killed and the mission status is GS_SUCCESS for a given traceId|
|DiscipleAchievement|Disciple|Achieve the rank of Disciple.|Metric Items|Simple| EventName = RANK|
|DragonAchievement|Dragon|Achieve the rank of Dragon.|Metric Items|Simple| EventName = RANK|
|EagleAchievement|Eagle|Achieve the rank of Eagle.|Metric Items|Simple| EventName = RANK|
|GoldDiscipleAchievement|Gold Disciple|Achieve the rank of Gold Disciple.|Metric Items|Simple| EventName = RANK|
|GoldDragonAchievement|Gold Dragon|Achieve the rank of Gold Dragon.|Metric Items|Simple| EventName = RANK|
|GoldEagleAchievement|Gold Eagle|Achieve the rank of Gold Eagle.|Metric Items|Simple| EventName = RANK|
|GoldHunterAchievement|Gold Hunter|Achieve the rank of Gold Hunter.|Metric Items|Simple| EventName = RANK|
|GoldInitiateAchievement|Gold Initiate|Achieve the rank of Gold Initiate.|Metric Items|Simple| EventName = RANK|
|GoldNoviceAchievement|Gold Novice|Achieve the rank of Gold Novice.|Metric Items|Simple| EventName = RANK|
|GoldSageAchievement|Gold Sage|Achieve the rank of Gold Sage.|Metric Items|Simple| EventName = RANK|
|GoldSeekerAchievement|Gold Seeker|Achieve the rank of Gold Seeker.|Metric Items|Simple| EventName = RANK|
|GoldTigerAchievement|Gold Tiger|Achieve the rank of Gold Tiger.|Metric Items|Simple| EventName = RANK|
|HunterAchievement|Hunter|Achieve the rank of Hunter.|Metric Items|Simple| EventName = RANK|
|InitiateAchievement|Initiate|Achieve the rank of Initiate.|Metric Items|Simple| EventName = RANK|
|MasterAchievement|Master|Achieve the rank of Master.|Metric Items|Simple| EventName = RANK|
|MiddleMasterAchievement|Middle Master|Achieve the rank of Middle Master.|Metric Items|Simple| EventName = RANK|
|NoviceAchievement|Novice|Achieve the rank of Novice.|Metric Items|Simple| EventName = RANK|
|SageAchievement|Sage|Achieve the rank of Sage.|Metric Items|Simple| EventName = RANK|
|SeekerAchievement|Seeker|Achieve the rank of Seeker.|Metric Items|Simple| EventName = RANK|
|SilverDiscipleAchievement|Silver Disciple|Achieve the rank of Silver Disciple.|Metric Items|Simple| EventName = RANK|
|SilverDragonAchievement|Silver Dragon|Achieve the rank of Silver Dragon.|Metric Items|Simple| EventName = RANK|
|SilverEagleAchievement|Silver Eagle|Achieve the rank of Silver Eagle.|Metric Items|Simple| EventName = RANK|
|SilverHunterAchievement|Silver Hunter|Achieve the rank of Silver Hunter.|Metric Items|Simple| EventName = RANK|
|SilverInitiateAchievement|Silver Initiate|Achieve the rank of Silver Initiate.|Metric Items|Simple| EventName = RANK|
|SilverNoviceAchievement|Silver Novice|Achieve the rank of Silver Novice.|Metric Items|Simple| EventName = RANK|
|SilverSageAchievement|Silver Sage|Achieve the rank of Silver Sage.|Metric Items|Simple| EventName = RANK|
|SilverSeekerAchievement|Silver Seeker|Achieve the rank of Silver Seeker.|Metric Items|Simple| EventName = RANK|
|SilverTigerAchievement|Silver Tiger|Achieve the rank of Silver Tiger.|Metric Items|Simple| EventName = RANK|
|TigerAchievement|Tiger|Achieve the rank of Tiger.|Metric Items|Simple| EventName = RANK|
|TrueMasterAchievement|True Master|Achieve the rank of True Master.|Metric Items|Simple| EventName = RANK|

#### Weapons achievements

These are very similar to the above achievementsm and are "simple" only if the MetricItems functionality has a major rework to link the weapon with a unique InventoryItemId.
If a rework is not undertaken, then these achievements will need to be recalculated each time the inventory is updated, and some sort of counter will need to be kept which can then be incremented when an applicable weapon hits the level mark.
Additionally the a mapping between an ItemType and it's weapon type will need to be created. 

|Achievement Name Code|Name|Description|Data Area|Type|Notes|
|-|-|-|-|-|-|
|BladeMastery1Achievement|Blade Mastery I|Reach Rank 10 with any five Longsword or Dual Short Blades weapons.||||
|BladeMastery2Achievement|Blade Mastery II|Reach Rank 20 with any five Longsword or Dual Short Blades weapons.||||
|BladeMastery3Achievement|Blade Mastery III|Reach Rank 30 with any five Longsword or Dual Short Blades weapons.||||
|BladeProficiency1Achievement|Blade Proficiency I|Reach Rank 10 with any Longsword or Dual Short Blades weapon.||||
|BladeProficiency2Achievement|Blade Proficiency II|Reach Rank 20 with any Longsword or Dual Short Blades weapon.||||
|BladeProficiency3Achievement|Blade Proficiency III|Reach Rank 30 with any Longsword or Dual Short Blades weapon.||||
|BowMastery1Achievement|Bow Mastery I|Reach Rank 10 with any two Bow weapons.|Metric Items|Simple|possible in all 7.x versions|
|BowMastery2Achievement|Bow Mastery II|Reach Rank 20 with any two Bow weapons.|Metric Items|Simple|possible in all 7.x versions|
|BowMastery3Achievement|Bow Mastery III|Reach Rank 30 with any two Bow weapons.|Metric Items|Simple|possible in all 7.x versions|
|BowProficiency1Achievement|Bow Proficiency I|Reach Rank 10 with any Bow weapon.|Metric Items|Simple|Possible with Paris|
|BowProficiency2Achievement|Bow Proficiency II|Reach Rank 20 with any Bow weapon.|Metric Items|Simple|Possible with Paris|
|BowProficiency3Achievement|Bow Proficiency III|Reach Rank 30 with any Bow weapon.|Metric Items|Simple|Possible with Paris|
|BrawlerMastery1Achievement|Brawler Mastery I|Reach Rank 10 with any three Gauntlets or Hand-to-Hand weapons.||||
|BrawlerMastery2Achievement|Brawler Mastery II|Reach Rank 20 with any three Gauntlets or Hand-to-Hand weapons.||||
|BrawlerMastery3Achievement|Brawler Mastery III|Reach Rank 30 with any three Gauntlets or Hand-to-Hand weapons.||||
|BrawlerProficiency1Achievement|Brawler Proficiency I|Reach Rank 10 with any Gauntlets or Hand-to-Hand weapon.||||
|BrawlerProficiency2Achievement|Brawler Proficiency II|Reach Rank 20 with any Gauntlets or Hand-to-Hand weapon.||||
|BrawlerProficiency3Achievement|Brawler Proficiency III|Reach Rank 30 with any Gauntlets or Hand-to-Hand weapon.||||
|DaggerMastery1Achievement|Dagger Mastery I|Reach Rank 10 with any three Dagger or Dual Daggers weapons.|Metric Items|Simple|possible in all 7.x versions|
|DaggerMastery2Achievement|Dagger Mastery II|Reach Rank 20 with any three Dagger or Dual Daggers weapons.|Metric Items|Simple|possible in all 7.x versions|
|DaggerMastery3Achievement|Dagger Mastery III|Reach Rank 30 with any three Dagger or Dual Daggers weapons.|Metric Items|Simple|possible in all 7.x versions|
|DaggerProficiency1Achievement|Dagger Proficiency I|Reach Rank 10 with any Dagger or Dual Daggers weapon.|Metric Items|Simple|possible in all 7.x versions|
|DaggerProficiency2Achievement|Dagger Proficiency II|Reach Rank 20 with any Dagger or Dual Daggers weapon.|Metric Items|Simple|possible in all 7.x versions|
|DaggerProficiency3Achievement|Dagger Proficiency III|Reach Rank 30 with any Dagger or Dual Daggers weapon.|Metric Items|Simple|possible in all 7.x versions|
|HeavyWeaponMastery1Achievement|Heavy Weapon Mastery I|Reach Rank 10 with any two Heavy Axe, Heavy Hammer, or Heavy Sword weapons.||||
|HeavyWeaponMastery2Achievement|Heavy Weapon Mastery II|Reach Rank 20 with any two Heavy Axe, Heavy Hammer, or Heavy Sword weapons.||||
|HeavyWeaponMastery3Achievement|Heavy Weapon Mastery III|Reach Rank 30 with any two Heavy Axe, Heavy Hammer, or Heavy Sword weapons.||||
|HeavyWeaponProficiency1Achievement|Heavy Weapon Proficiency I|Reach Rank 10 with any Heavy Axe, Heavy Hammer, or Heavy Sword weapon.||||
|HeavyWeaponProficiency2Achievement|Heavy Weapon Proficiency II|Reach Rank 20 with any Heavy Axe, Heavy Hammer, or Heavy Sword weapon.||||
|HeavyWeaponProficiency3Achievement|Heavy Weapon Proficiency III|Reach Rank 30 with any Heavy Axe, Heavy Hammer, or Heavy Sword weapon.||||
|PistolMastery1Achievement|Pistol Mastery I|Reach Rank 10 with any five Pistol or Akimbo Pistols weapons.|Metric Items|Simple|possible in all 7.x versions|
|PistolMastery2Achievement|Pistol Mastery II|Reach Rank 20 with any five Pistol or Akimbo Pistols weapons.|Metric Items|Simple|possible in all 7.x versions|
|PistolMastery3Achievement|Pistol Mastery III|Reach Rank 30 with any five Pistol or Akimbo Pistols weapons.|Metric Items|Simple|possible in all 7.x versions|
|PistolProficiency1Achievement|Pistol Proficiency I|Reach Rank 10 with any Pistol or Akimbo Pistols weapon.|Metric Items|Simple|possible in all 7.x versions|
|PistolProficiency2Achievement|Pistol Proficiency II|Reach Rank 20 with any Pistol or Akimbo Pistols weapon.|Metric Items|Simple|possible in all 7.x versions|
|PistolProficiency3Achievement|Pistol Proficiency III|Reach Rank 30 with any Pistol or Akimbo Pistols weapon.|Metric Items|Simple|possible in all 7.x versions|
|PoleWeaponMastery1Achievement|Pole Weapon Mastery I|Reach Rank 10 with any three Scythe, Pole-arm or Staff weapons.|Metric Items|Simple|Not possible in any 7.x version|
|PoleWeaponMastery2Achievement|Pole Weapon Mastery II|Reach Rank 20 with any three Scythe, Pole-arm or Staff weapons.|Metric Items|Simple|Not possible in any 7.x version|
|PoleWeaponMastery3Achievement|Pole Weapon Mastery III|Reach Rank 30 with any three Scythe, Pole-arm or Staff weapons.|Metric Items|Simple|Not possible in any 7.x version|
|PoleWeaponProficiency1Achievement|Pole Weapon Proficiency I|Reach Rank 10 with any Scythe, Pole-arm or Staff weapon.|Metric Items|Simple|possible in all 7.x versions|
|PoleWeaponProficiency2Achievement|Pole Weapon Proficiency II|Reach Rank 20 with any Scythe, Pole-arm or Staff weapon.|Metric Items|Simple|possible in all 7.x versions|
|PoleWeaponProficiency3Achievement|Pole Weapon Proficiency III|Reach Rank 30 with any Scythe, Pole-arm or Staff weapon.|Metric Items|Simple|possible in all 7.x versions|
|RifleMastery1Achievement|Rifle Mastery I|Reach Rank 10 with any five Rifle or Machine Gun weapons.|Metric Items|Simple|possible in all 7.x versions|
|RifleMastery2Achievement|Rifle Mastery II|Reach Rank 20 with any five Rifle or Machine Gun weapons.|Metric Items|Simple|possible in all 7.x versions|
|RifleMastery3Achievement|Rifle Mastery III|Reach Rank 30 with any five Rifle or Machine Gun weapons.|Metric Items|Simple|possible in all 7.x versions|
|RifleProficiency1Achievement|Rifle Proficiency I|Reach Rank 10 with any Rifle or Machine Gun weapon.|Metric Items|Simple|possible in all 7.x versions|
|RifleProficiency2Achievement|Rifle Proficiency II|Reach Rank 20 with any Rifle or Machine Gun weapon.|Metric Items|Simple|possible in all 7.x versions|
|RifleProficiency3Achievement|Rifle Proficiency III|Reach Rank 30 with any Rifle or Machine Gun weapon.|Metric Items|Simple|possible in all 7.x versions|
|SentinelMastery1Achievement|Sentinel Mastery I|Reach Rank 10 with any three Sentinels.|||Not possible if the sentinels need to be different sentinel types|
|SentinelMastery2Achievement|Sentinel Mastery II|Reach Rank 20 with any three Sentinels.|||Not possible if the sentinels need to be different sentinel types|
|SentinelMastery3Achievement|Sentinel Mastery III|Reach Rank 30 with any three Sentinels.|||Not possible if the sentinels need to be different sentinel types|
|SentinelProficiency1Achievement|Sentinel Proficiency I|Reach Rank 10 with any Sentinel.|Metric Items|Simple|possible in all 7.x versions|
|SentinelProficiency2Achievement|Sentinel Proficiency II|Reach Rank 20 with any Sentinel.|Metric Items|Simple|possible in all 7.x versions|
|SentinelProficiency3Achievement|Sentinel Proficiency III|Reach Rank 30 with any Sentinel.|Metric Items|Simple|possible in all 7.x versions|
|ShotgunMastery1Achievement|Shotgun Mastery I|Reach Rank 10 with any two Shotgun weapons.|Metric Items|Simple|possible in all 7.x versions|
|ShotgunMastery2Achievement|Shotgun Mastery II|Reach Rank 20 with any two Shotgun weapons.|Metric Items|Simple|possible in all 7.x versions|
|ShotgunMastery3Achievement|Shotgun Mastery III|Reach Rank 30 with any two Shotgun weapons.|Metric Items|Simple|possible in all 7.x versions|
|ShotgunProficiency1Achievement|Shotgun Proficiency I|Reach Rank 10 with any Shotgun weapon.|Metric Items|Simple|possible in all 7.x versions|
|ShotgunProficiency2Achievement|Shotgun Proficiency II|Reach Rank 20 with any Shotgun weapon.|Metric Items|Simple|possible in all 7.x versions|
|ShotgunProficiency3Achievement|Shotgun Proficiency III|Reach Rank 30 with any Shotgun weapon.|Metric Items|Simple|possible in all 7.x versions|
|ShurikenMastery1Achievement|Shuriken Mastery I|Reach Rank 10 with any three Boomerang, Throwing Discs or Throwing Daggers weapon.|Metric Items|Simple|Not possible in any 7.x version|
|ShurikenMastery2Achievement|Shuriken Mastery II|Reach Rank 20 with any three Boomerang, Throwing Discs or Throwing Daggers weapon.|Metric Items|Simple|Not possible in any 7.x version|
|ShurikenMastery3Achievement|Shuriken Mastery III|Reach Rank 30 with any three Boomerang, Throwing Discs or Throwing Daggers weapon.|Metric Items|Simple|Not possible in any 7.x version|
|ShurikenProficiency1Achievement|Shuriken Proficiency I|Reach Rank 10 with any Boomerang, Throwing Discs or Throwing Daggers weapon.|Metric Items|Simple|possible only in 7.9 and beyond (Glaive)|
|ShurikenProficiency2Achievement|Shuriken Proficiency II|Reach Rank 20 with any Boomerang, Throwing Discs or Throwing Daggers weapon.|Metric Items|Simple|possible only in 7.9 and beyond (Glaive)|
|ShurikenProficiency3Achievement|Shuriken Proficiency III|Reach Rank 30 with any Boomerang, Throwing Discs or Throwing Daggers weapon.|Metric Items|Simple|possible only in 7.9 and beyond (Glaive)|
