

## ui layout

- need a list of nodes with their regions and node names prepended to the 


## alert json

```json
     "Alerts": [
        {
            "Activation": {
                "sec": 1746840721,
                "usec": 610000
            },
            "AllowReplay": 1,
            "Expiry": {
                "sec": 1778376721,
                "usec": 982000
            },
            "MissionInfo": {
               "missionType": "MT_ASSASSINATION",
                "faction": "FC_GRINEER",
                "uniqueName" :"General Sargas Ruk Cats",
                "icon": "/Lotus/Interface/Icons/Npcs/Grineer/GrineerFacesL.png",
               "descText": "CATS!!!",
                "location": "SolNode94",
                "unlocked" :1,
                "minEnemyLevel" :999,
                "maxEnemyLevel" :9999,
                "introText": "Murder Everyone",
                "completionText": "CAAAAATSSS",
                "seed": 94368,
                "difficulty": 0.59836683270987,
                "vipAgent": "/Lotus/Types/Enemies/Infested/Vip/ZombieLeaderAgent",

                "missionReward": {
                    "credits": 3400,
                    "xp": 0,
                    "items": []
                },
                "levelOverride": "/Lotus/Levels/Proc/Corpus/CorpusExterminateLevel",
                "enemySpec": "",
                "vipAgent": "",
                "maxWaveNum": 0,
            "alertId": {
                "$id": "521d98e9bb5768395e92594c"
            }
            }
        }
     ]
```


### defs? 


- vipAgent should only be used when the mission type is assassination
- levelOverride is meant to override the node specific physical level, not anything else. 
- missionReward.xp doesn't seem to really do anything
- missionReward.items only takes a certain set of items.
- 


- missionType
    -  MT_ASSASSINATION
    -  MT_EXTERMINATION
    -  MT_RAID
    -  MT_RESCUE
    -  MT_SABOTAGE
    -  MT_CAPTURE
    -  MT_COUNTER_INTEL
    -  MT_INTEL
    -  MT_DEFENSE
    -  MT_MOBILE_DEFENSE

- factions
    - FC_INFESTATION
    - FC_CORPUS
    - FC_GRINEER



## Some alert descriptions

taken from https://www.orokinarchives.com/outdated-alerts/


Assassination

    Elite Troop Located
    Enemy Ambassador Located
    Enemy Assassin Located
    Enemy Bureaucrat Located
    Enemy Diplomat Located
    Enemy Intelligence Officer Located
    Enemy Munitions Officer Located
    Enemy Officer Located
    Enemy Operative Located
    Enemy Research Scientist Located
    Enemy Robotic Archetype Located
    Enemy Ship Commander Located
    Enemy Sniper Located
    Enemy Spy Located
    Enemy VIP Located

Capture

    Blackmarket Trader Located
    Capture and Interrogate Enemy Operative
    Enemy Assassin Located
    Enemy Conspirator Located
    Enemy Courier Located
    Enemy Diplomat Located
    Enemy Operative Located
    Enemy Research Scientist Located
    Enemy Spy Located
    Enemy Weapons Trader Located
    Fugitive Located
    Relic Hunter Located
    Research Facility Director Located
    Subdue Enemy Ship's Commander
    Subdue Facility Commander

Deception

    Bypass Ship's Security Measures
    Contaminate Research Data
    Corrupt Robotic Archetype Data
    Corrupt the Facility's Network Protocols
    Corrupt the Ship's Network Protocols
    Enemy Comm Satellite Vulnerable
    Enemy Comm Station Vulnerable
    Network Vulnerability Detected
    Plant a Bug Inside Enemy Facility
    Plant a Bug Inside Research Facility
    Plant a Bug on Enemy Vessel
    Reconfigure Enemy Ship's Comm System
    Reconfigure Enemy Ship's Defence System
    Reconfigure Enemy Ship's Navigation System
    Reconfigure Enemy Ship's Propulsion System
    Reconfigure Enemy Ship's Shields
    Reconfigure Enemy Ship's Targeting System
    Reconfigure Enemy Ship's Weapons System
    Redirect Enemy Flagship
    Redirect Enemy Vessel
    Reprogram Robotic Control Terminals
    Reprogram Turret Targeting
    Transmit Corrupt Data to Computer Core
    Upload Counter-Intel to Enemy Satellites
    Upload Virus to Network

Defence

    A rare Artifact has been ambushed in transit. Keep it out of enemy hands.
    Defend Data Core During Transmission
    Defend Enemy Science Lab
    Enemy Informant Compromised
    Freighter Ambush
    Hold Out for Reinforcements
    Mining Facility Ambush
    Protect Hostage
    Protect Research Scientist
    Protect Sensitive Data
    Repel Enemy Attack
    Research Analysis Compromised
    Research Facility Ambush
    Secure Derelict Ship
    Secure Ship Cargo
    Secure the Artifacts
    Secure the Computer Core
    Secure the Rubedo Mining Outpost
    Solar Rail Ambush
    Tenno Operative Compromised
    Warframe Compromised
    Weapons Cache Compromised

Exterminate

    Artifact Recovery Troops Located
    Clear and Secure Enemy Vessel
    Clear Resistance
    Defeat Enemy Ambush
    Defeat Enemy Defence Forces
    Elite Troops Located
    Enemy Escorts Located
    Enemy Recon Unit Located
    Enemy Security Forces Located
    Enemy Shock Troops Located
    Enemy Support Squadrons Located
    Enemy Task Force Located
    Secure Excavation Site
    Tenno Distress Signal
    Unknown Distress Signal Located

Raid

    Armoury Depot Discovered
    Armoury Depot Discovered
    Artifact Depot Discovered
    Artifact Dig Site Discovered
    Artifact Research Discovered
    Black Market Ship Discovered
    Clandestine Asteroid Base Discovered
    Enemy Data Core Discovered
    Enemy Flagship Discovered
    Enemy Intelligence Vessel Discovered
    Enemy Supply Vessel Discovered
    Enemy Tech Discovered
    Experimental Ballistics Facility Located
    Experimental Weapons Cache Discovered
    Hidden Base Discovered
    Merchant Ship Discovered
    Mining Station Discovered
    Orokin Artifacts Discovered
    Rubedo Depot Discovered
    Supply Depot Located
    Warframe Discovered
    Weapons Depot Discovered
    Weapons Testing Facility Discovered

Rescue

    Abducted Civilian
    Blackmarket Weapons Dealer Located
    Detained Diplomat Located
    Detained Refugee Located
    Detained Research Scientist Located
    Distress Signal Located
    Enemy Envoy Located
    Enemy Informant Located
    Enemy Turncoat Located
    Foreign Emissary Located
    Hostage Situation
    Tenno Operative Located
    Tenno Sympathiser Located
    Weapons Researcher Located

Sabotage

    Deactivate Computer Core Defences
    Deactivate Enemy Shields
    Deactivate Shields
    Deactivate Turrets
    Destroy Ammo Cache
    Destroy Comm Station
    Destroy Enemy Base Defences
    Destroy Enemy Devices
    Destroy Enemy Facility
    Destroy Enemy Transport
    Destroy Experimental Weapons
    Destroy Munitions Stockpile
    Destroy Research Station's Defences
    Destroy Research Vessel's Defences
    Disable Communications Network
    Disable Enemy Satellites
    Disable Enemy Ship's Power Systems
    Disable Enemy Warship
    Disable Navigation Beacon
    Disable Ship Artillery Systems
    Enemy Comm Satellite Located
    Enemy Facility Found
    Enemy Munitions Dump Located
    Enemy Transport Found
    Override Facility's Security Systems
    Override Ship's Security Systems
    Sabotage Enemy Research Facility
    Shutdown Ship's Fission Core
    Weapons Depot Found

Spy

    Acquire Enemy Vessel Cargo Records
    Acquire Security Logs
    Acquire Ship's Logs
    Artifact Research Facility Discovered
    Bypass Data Core Lockout
    Cloning Research Facility Located
    Collect T-Cyte Research Samples
    Disable Security Beacons
    Distress Call Located
    Enemy Asteroid Facility Located
    Enemy Base Located
    Enemy Cargo Hold Located
    Enemy Freighter Located
    Enemy Manufacturing Facility Located
    Enemy Research Analysis Located
    Enemy Research Located
    Enemy Ship Located
    Enemy Transmissions Located
    Examine Facility Network Protocols
    Examine Ship's Network Protocols
    Explore Hidden Base
    Infiltrate Research Station
    Intelligence Vessel Discovered
    Intercept Enemy Ship
    Investigate Distress Beacon
    Investigate Enemy Distress Signal
    Investigate Enemy Facility Distress Signal
    Investigate Enemy Outpost
    Investigate Excavation Site
    Investigate Mining Facility
    Investigate Ship in Distress
    Investigate the Derelict Ship
    Locate and Acquire Robotic Archetype Data
    Locate and Scan Cargo Stashes
    Locate Security Codes
    Merchant Ship Located
    Mining Research Station Discovered
    Research Facility Discovered
    Research Station Located
    Scan Enemy Satellites
    Scan Ship for Suspicious Objects
    Scan Ship's Cargo Logs
    Search Enemy Ship's Databanks
    Secret Enemy Facility Located
    Weapon Prototype Located
    Weapons Research Facility Discovered
    Weapons Research Located





## Alerts from early 2013 (april 30th to may 3rd ? )
|Node|Planet|Description|Credits|Additional Items|Type?|
|-|-|-|-|-|-|
 | Rusalka  | Sedna | Mining Station Discovered |  2000cr | Heat Sword (Blueprint)|Raid|
 | Psoro  | Eris | Enemy Support Squadrons Located | 5000cr | Steel Charge (Artifact)|Exterminate|
 | V Prime  | Venus | Enemy Diplomat Located |  2000cr | | Assassination or Capture |
 | Miranda  | Uranus | Distress Signal Located | 2000cr | | Rescue |
 | Adrastea  | Jupiter | Artifact Dig Site Discovered | 7500cr | | Raid |
 | Phithale  | Sedna | Enemy Comm Satellite Located | 3400cr | | Sabotage |
 | Eligor  | Europa | Fugitive Located | 2000cr | | Capture |
 | Ose  | Europa | Enemy Conspirator Located | 2000cr | | Capture |
 | Vesper  | Venus | Detained Refugee Located |  8200cr | |
 | Methone  | Saturn | Artifact Dig Site Discovered | 2000cr | | Raid |
 | Oceanum  | Pluto | Enemy Spy Located | 2200cr | |
 | Ara  | Mars | Enemy Assassin Located | 6900cr | |
 | Iapetus  | Saturn | Disable Enemy Satellites |  2000cr | | Sabotage |
 | Sycorax  | Uranus | Enemy Task Force Located | 2000cr | |
 | Bode  | Ceres | Enemy Assassin Located |  2000cr | |
 | Solium  | Eris | Detained Diplomat Located | 2000cr | |
 | Naiad  | Neptune | Distress Signal Located |  2000cr | | Rescue |
 | Helene  | Saturn | Enemy Recon Unit Located | 2000cr | |
 | Casta  | Ceres | Enemy Diplomat Located | 2000cr | | Assassination or Capture |
 | Ascar  | Eris | Enemy Shock Troops Located |  6100cr | |
 | Pacific  | Earth | Enemy Transmissions Located | 2000cr | Orokin Catalyst (Blueprint)|
 | Ascar  | Eris | Destroy Research Vessel's Defenses | 8500cr | |
 | Pacific  | Earth | Sabotage Enemy Research Facility |  7700cr | |
 | Armaros  | Europa | Contaminate Research Data | 2000cr | Shotgun Scavenger (Artifact)|
 | Martialis  | Mars | Disable Communications Network |  5200cr | | Sabotage |
 | Rusalka  | Sedna | Destroy Enemy Devices |  2000cr | |
 | Naeglar  | Eris | Tenno Operative Located | 2000cr | |
 | Brugia  | Eris | Contaminate Research Data | 2000cr | |
 | Paimon   | Europa | Enemy Comm Station Vulnerable | 3100cr | |
 | Yemaja  | Sedna | Corrupt The Facilities Network Protocols | 2000cr | |
 | Keeler  | Saturn | Destroy Research Station's Defenses |  2000cr | |
 | Ponaturi  | Sedna | Blackmarket Weapons Dealer Located |  2000cr | |
 | Ishtar  | Venus | Research Facility Director Located |  2700cr | |
 | Ranova  | Eris | Network Vulnerability Detected |  2400cr | |
 | Varro  | Ceres | Warframe Discovered | 4000cr | |
 | Ananke  | Jupiter | Abducted Civilian |  2000cr | |
 | Larissa  | Neptune | Enemy Spy Located | 2000cr | |
 | Rosalind  | Uranus | Deactivate Shields | 2000cr | |
 | Oceanum  | Pluto | Sabotage Enemy Research Facility |  2000cr | |
 | Charybdis  | Sedna | Subdue Facility Commander |  6900cr | |
 | Themisto  | Jupiter | Enemy Diplomat Located |  3500cr | Glaive (Blueprint)| Assassination or Capture |
 | Histo  | Eris | Enemy Ambassador Located | 2000cr | Dual Dagger (Blueprint)|
 | Linea  | Venus | Enemy Munitions Officer Located | 5900cr | Dark Dagger (Blueprint)|
 | Epimetheus  | Saturn | Artifact Research Facility Discovered |  5800cr | |
 | Draco  | Ceres | Artifact Depot Discovered | 7500cr | Rejuvenation (Artifact)|
 | Sparga  | Eris | Blackmarket Trader Located | 7200cr | |
 | Telesto  | Saturn | Plant A Bug Inside Research Facility |  2000cr | Heat Dagger (Blueprint)|
 | Varro  | Ceres | Fugitive Located |  2000cr | | Capture |
 | Hymeno  | Eris | Bypass Data Core Lockout | 2000cr | Rifle Scavenger (Artifact)|
 | Ixodes  | Eris | Enemy Diplomat Located | 4600cr | | Assassination or Capture |
 | Ishtar  | Venus | Capture And Interrogate Enemy Operative |  2000cr | |
 | Lillith  | Europa | Unknown Distress Signal Located | 2000cr | | Exterminate |
 | Oceanum  | Pluto | Clear Resistance |  2000cr | |
 | Larissa  | Neptune | Upload Virus To Network | 3800cr | |
 | Rosalind  | Uranus | Armory Depot Discovered | 2000cr | |
 | Arval  | Mars | Enemy Escorts Located |  3400cr | |
 | Giardia  | Eris | Weapon Prototype Located |  2000cr | |
 | Naiad  | Neptune | Upload Virus To Network |  2000cr | |
 | Yemaja  | Sedna | Tenno Distress Signal |  2000cr | |
 | Ultor  | Mars | Enemy Task Force Located |  4500cr | |
 | Egeria  | Ceres | Enemy Asteroid Facility Located | 2200cr | Energy Siphon (Artifact)|
 | Hades  | Pluto | Plant A Bug Inside Research Facility |  2300cr | Rifle Amp (Artifact)|
 | Lith  | Earth | Tenno Operative Located |  4100cr | Dual Dagger (Blueprint)|
 | Giardia  | Eris | Upload Virus To Network |  2600cr | |
 | Zagan  | Europa | Corrupt Robotic Archetype Data | 6100cr | |
 | Psamathe  | Neptune | Detained Research Scientist Located | 2500cr | |
 | Regna  | Pluto | Tenno Operative Located |  2000cr | |
 | Juliet  | Uranus | Elite Troops Located | 2000cr | |
 | Yemaja  | Sedna | Supply Depot Located |  2500cr | |
 | Cyath  | Eris | Enemy Spy Located |  2000cr | |
 | Eligor  | Europa | Defeat Enemy Ambush | 7600cr | |
 | Gradivus  | Mars | Secure Excavation Site | 2000cr | |
 | Cypress  | Pluto | Investigate Enemy Facility Distress Signal | 2000cr | |
 | Everest  | Earth | Override Facilities Security Systems | 4700cr | |
 | Ara  | Mars | Enemy Spy Located | 2800cr | |
 | Elion  | Mercury | Investigate Enemy Outpost |  2000cr | |
 | Rusalka  | Sedna | Enemy Spy Located | 2800cr | |
 | Cypress  | Pluto | Upload Virus To Network |  2000cr | |
 | Palus  | Pluto | Enemy Research Located | 2800cr | |
 | Ascar  | Eris | Disable Enemy Satellites | 2700cr | Pistol Scavenger (Artifact)| Sabotage |
 | Deimos  | Mars | Experimental Ballistics Facility Located | 2000cr | |
 | Lillith  | Europa | Tenno Operative Located | 2000cr | Physique (Artifact)|
 | Oestrus  | Eris | Transmit Corrupt Data To Computer Core | 5500cr | |
 | Titan  | Saturn | Blackmarket Weapons Dealer Located |  4500cr | |
 | Ara  | Mars | Upload Counter Intel To Enemy Satellites | 2000cr | |
 | Dione  | Saturn | Network Vulnerability Detected |  5200cr | |
 | Rusalka  | Sedna | Enemy Informant Located |  2000cr | |
 | Portia  | Uranus | Disable Navigation Beacon |  2000cr | | Sabotage |
 | Kappa  | Sedna | Blackmarket Weapons Dealer Located | 2000cr | |
 | Giardia  | Eris | Network Vulnerability Detected |  2000cr | |
 | Portia  | Uranus | Enemy Munitions Dump Located | 2000cr | |
 | Tethys  | Saturn | Secret Enemy Facility Located | 2000cr | |
 | Zagan  | Europa | Enemy Security Forces Located |  2000cr | |
 | Gnathos  | Eris | Artifact Research Discovered | 6400cr | |
 | Graeae  | Sedna | Enemy Shock Troops Located | 2000cr | |
 | Bode  | Ceres | Enemy Conspirator Located |  2000cr | | Capture |
 | Yam  | Sedna | Enemy Bureaucrat Located |  2000cr | |
 | Lex  | Ceres | Enemy Envoy Located |  2100cr | |
 | Unda  | Venus | Enemy Officer Located | 2000cr

