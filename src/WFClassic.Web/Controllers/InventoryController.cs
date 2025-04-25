﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    public class InventoryController : ControllerBase
    {

        [HttpGet]
        [Route("/api/inventorySlots.php")]
        public ActionResult InventorySlots(Guid accountId, long nonce) {

            return new JsonResult(cats);
        }
        [HttpGet]
        [Route("/api/updateInventory.php")]
        public ActionResult UpdateInventory(Guid accountId, long nonce)
        {

            return new JsonResult(cats);
        }

        [HttpGet]
        [Route("/api/inventory.php")]
        public ActionResult Inventory(Guid accountId, long nonce)
        {

            return new JsonResult(cats);
        }

        [HttpGet]
        [Route("/api/artifacts.php")]
        public ActionResult Artifacts(Guid accountId, long nonce)
        {

            return new JsonResult(cats);
        }

        [HttpGet]
        [Route("/api/upgrades.php")]
        public ActionResult Upgrades(Guid accountId, long nonce)
        {

            return new JsonResult(cats);
        }

        [HttpGet]
        [Route("/api/giveStartingGear.php")]
        public ActionResult GiveStartingGear(Guid accountId, long nonce)
        {

            return new JsonResult(cats);
        }

        

        string cats = @"
{
  ""SubscribedToEmails"": 0,
  ""SubscribedToEmailsPersonalized"": 0,
  ""RewardSeed"": -5604904486637265640,
  ""RegularCredits"": 3000,
  ""SentinelBin"": {
    ""Slots"": 10
  },
  ""SpaceSuitBin"": {
    ""Slots"": 4
  },
  ""SpaceWeaponBin"": {
    ""Slots"": 4
  },
  ""SuitBin"": {
    ""Slots"": 1
  },
  ""WeaponBin"": {
    ""Slots"": 5
  },
  ""Recipes"": [],
  ""ChallengeProgress"": [
  ],
  ""Consumables"": [
    {
      ""ItemCount"": 1,
      ""ItemType"": ""/Lotus/Types/Restoratives/Cipher""
    }
  ],
  ""FlavourItems"": [
    {
      ""ItemType"": ""/Lotus/Types/StoreItems/AvatarImages/AvatarImageItem1""
    },
    {
      ""ItemType"": ""/Lotus/Types/StoreItems/AvatarImages/AvatarImageItem2""
    },
    {
      ""ItemType"": ""/Lotus/Types/StoreItems/AvatarImages/AvatarImageItem3""
    },
    {
      ""ItemType"": ""/Lotus/Types/StoreItems/AvatarImages/AvatarImageItem4""
    }
  ],
  ""LongGuns"": [
    {
      ""ItemType"": ""/Lotus/Weapons/Tenno/Bows/HuntingBow"",
      ""XP"": 1600000,
      ""ItemId"": {
        ""$id"": ""66da4e67cf73a8d6e04e7e9a""
      }
    }
  ],
  ""Melee"": [
    {
      ""ItemType"": ""/Lotus/Weapons/Tenno/Melee/LongSword/LongSword"",
      ""XP"": 1600000,
      ""Configs"": [
        {},
        {},
        {}
      ],
      ""ItemId"": {
        ""$id"": ""66da4e73964ed8bf9c170702""
      }
    }
  ],
  ""Pistols"": [
    {
      ""ItemType"": ""/Lotus/Weapons/Tenno/Pistol/Pistol"",
      ""XP"": 1600000,
      ""Configs"": [
        {},
        {},
        {}
      ],
      ""ItemId"": {
        ""$id"": ""66da4e777341e52ea2e36047""
      }
    }
  ],
  ""RawUpgrades"": [
    {
      ""ItemCount"": 1,
      ""LastAdded"": {
        ""$id"": ""66da4e7bf2af10b3817fad4d""
      },
      ""ItemType"": ""/Lotus/Upgrades/Mods/Warframe/AvatarShieldMaxMod""
    }
  ],
  ""ReceivedStartingGear"": true,
  ""TauntHistory"": [
    {
      ""node"": ""StarchartTutorial""
    }
  ],
  ""Suits"": [
    {
      ""ItemType"": ""/Lotus/Powersuits/Saryn/Saryn"",
      ""XP"": 1600000,
      ""UpgradeVer"": 101,
      ""ItemId"": {
        ""$id"": ""66da532b09ec41258ff159b8""
      }
    },
    {
      ""ItemType"": ""/Lotus/Powersuits/Banshee/Banshee"",
      ""XP"": 1600000,
      ""UpgradeVer"": 101,
      ""ItemId"": {
        ""$id"": ""66da4e85a1060bb337f16c49""
      }
    },
    {
      ""ItemType"": ""/Lotus/Powersuits/Ember/Ember"",
      ""XP"": 1600000,
      ""UpgradeVer"": 101,
      ""ItemId"": {
        ""$id"": ""66da4e87dad87a5b6379f3af""
      }
    },
    {
      ""ItemType"": ""/Lotus/Powersuits/Excalibur/Excalibur"",
      ""XP"": 1600000,
      ""UpgradeVer"": 101,
      ""ItemId"": {
        ""$id"": ""66da4e8939f75193b2f4d1c0""
      }
    },
    {
      ""ItemType"": ""/Lotus/Powersuits/Excalibur/ExcaliburPrime"",
      ""XP"": 1600000,
      ""UpgradeVer"": 101,
      ""ItemId"": {
        ""$id"": ""66da4e8cb68236528b48024a""
      }
    },
    {
      ""ItemType"": ""/Lotus/Powersuits/Frost/Frost"",
      ""XP"": 1600000,
      ""UpgradeVer"": 101,
      ""ItemId"": {
        ""$id"": ""66da4e8ecef38f3987982819""
      }
    },
    {
      ""ItemType"": ""/Lotus/Powersuits/Frost/FrostPrime"",
      ""XP"": 1600000,
      ""UpgradeVer"": 101,
      ""ItemId"": {
        ""$id"": ""66da4e91f299b711dcdda960""
      }
    },
    {
      ""ItemType"": ""/Lotus/Powersuits/Jade/Jade"",
      ""XP"": 1600000,
      ""UpgradeVer"": 101,
      ""ItemId"": {
        ""$id"": ""66da4e96ac68c487797efd62""
      }
    },
    {
      ""ItemType"": ""/Lotus/Powersuits/Loki/Loki"",
      ""XP"": 1600000,
      ""UpgradeVer"": 101,
      ""ItemId"": {
        ""$id"": ""66da4e9a036377a144b18384""
      }
    },
    {
      ""ItemType"": ""/Lotus/Powersuits/Mag/Mag"",
      ""XP"": 1600000,
      ""UpgradeVer"": 101,
      ""ItemId"": {
        ""$id"": ""66da4e9c87f5e8946b956e0c""
      }
    },
    {
      ""ItemType"": ""/Lotus/Powersuits/Ninja/Ninja"",
      ""XP"": 1600000,
      ""UpgradeVer"": 101,
      ""ItemId"": {
        ""$id"": ""66da4ea00612f3c7a763cdfc""
      }
    },
    {
      ""ItemType"": ""/Lotus/Powersuits/Rhino/Rhino"",
      ""XP"": 1600000,
      ""UpgradeVer"": 101,
      ""ItemId"": {
        ""$id"": ""66da4ea4c2339c01b20ee6e1""
      }
    },
    {
      ""ItemType"": ""/Lotus/Powersuits/Trinity/Trinity"",
      ""XP"": 1600000,
      ""UpgradeVer"": 101,
      ""ItemId"": {
        ""$id"": ""66da4ea80785c8d085c03bdd""
      }
    },
    {
      ""ItemType"": ""/Lotus/Powersuits/Volt/Volt"",
      ""XP"": 1600000,
      ""UpgradeVer"": 101,
      ""ItemId"": {
        ""$id"": ""66da4eaad4b9bee7977f22f4""
      }
    }
  ],
  ""WeaponSkins"": [
    {
      ""ItemType"": ""/Lotus/Upgrades/Skins/Volt/VoltHelmet"",
      ""ItemId"": {
        ""$id"": ""66da4eae34abc831f41f659b""
      }
    }
  ],
  ""PendingRecipes"": [],
  ""TrainingDate"": 0,
  ""PlayerLevel"": 0,
  ""CompletedAlerts"": [],
  ""Sentinels"": [],
  ""SentinelWeapons"": [],
  ""SpecialItems"": [],
  ""StepSequencers"": [],
  ""Upgrades"": [
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Melee/WeaponArmorPiercingDamageMod"",
      ""ItemId"": {
        ""$id"": ""66da4eb5d706a7112d4894f2""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Melee/WeaponCritChanceMod"",
      ""ItemId"": {
        ""$id"": ""66da4eb7eef100b1f891583f""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Melee/WeaponCritDamageMod"",
      ""ItemId"": {
        ""$id"": ""66da4ebaa75d24538a62c7a1""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Melee/WeaponElectricityDamageMod"",
      ""ItemId"": {
        ""$id"": ""66da4ebc03b11c2026261dda""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Melee/WeaponFireDamageMod"",
      ""ItemId"": {
        ""$id"": ""66da4ebee8b2b0bbe0aa7521""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Melee/WeaponFireRateMod"",
      ""ItemId"": {
        ""$id"": ""66da4ec11aaddcd4c7052165""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Melee/WeaponFreezeDamageMod"",
      ""ItemId"": {
        ""$id"": ""66da4ec3a18a84596c48fd0b""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Melee/WeaponMeleeChargeRateMod"",
      ""ItemId"": {
        ""$id"": ""66da4ec68f900c9dce77f25e""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Melee/WeaponMeleeDamageMod"",
      ""ItemId"": {
        ""$id"": ""66da4ecacd32891e29b87040""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Melee/WeaponMeleeHeavyDamageMod"",
      ""ItemId"": {
        ""$id"": ""66da4ecc6ecdc3addd7fbbc5""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Melee/WeaponStunChanceMod"",
      ""ItemId"": {
        ""$id"": ""66da4ed133c3092002531ea0""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Pistol/WeaponArmorPiercingDamageMod"",
      ""ItemId"": {
        ""$id"": ""66da4ed3ca0126f4e0904987""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Pistol/WeaponCritChanceMod"",
      ""ItemId"": {
        ""$id"": ""66da4ed6e4d482a2fa7f4ae6""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Pistol/WeaponCritDamageMod"",
      ""ItemId"": {
        ""$id"": ""66da4ed8f11f76e0ec55734e""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Pistol/WeaponElectricityDamageMod"",
      ""ItemId"": {
        ""$id"": ""66da4edbecd4c71b40426652""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Pistol/WeaponFireDamageMod"",
      ""ItemId"": {
        ""$id"": ""66da4eddff15a60f25f27fe3""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Pistol/WeaponFireRateMod"",
      ""ItemId"": {
        ""$id"": ""66da4edfedd2c737249f27b1""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Pistol/WeaponFreezeDamageMod"",
      ""ItemId"": {
        ""$id"": ""66da4ee197751c11edbe480c""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Pistol/WeaponStunChanceMod"",
      ""ItemId"": {
        ""$id"": ""66da4ee3099f9876c3d5f230""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Pistol/WeaponAmmoMaxMod"",
      ""ItemId"": {
        ""$id"": ""66da4ee5719f74045b713f58""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Pistol/WeaponClipMaxMod"",
      ""ItemId"": {
        ""$id"": ""66da4ee8f86349fd87a0c24d""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Pistol/WeaponDamageAmountMod"",
      ""ItemId"": {
        ""$id"": ""66da4eea5c0f3babebe60c34""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Pistol/WeaponFireIterationsMod"",
      ""ItemId"": {
        ""$id"": ""66da4eed5b41fbe202fe36b4""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Pistol/WeaponPunctureDepthMod"",
      ""ItemId"": {
        ""$id"": ""66da4eefaa75316cc3ab55f9""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Pistol/WeaponReloadSpeedMod"",
      ""ItemId"": {
        ""$id"": ""66da4ef1e2a041e410a4276c""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Rifle/WeaponArmorPiercingDamageMod"",
      ""ItemId"": {
        ""$id"": ""66da4ef38b45f124a570e1f8""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Rifle/WeaponCritChanceMod"",
      ""ItemId"": {
        ""$id"": ""66da4ef6dacaaa69d2fdbd8b""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Rifle/WeaponCritDamageMod"",
      ""ItemId"": {
        ""$id"": ""66da4ef9d525b197f6f81473""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Rifle/WeaponElectricityDamageMod"",
      ""ItemId"": {
        ""$id"": ""66da4efc6fe23457bf37d021""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Rifle/WeaponFireDamageMod"",
      ""ItemId"": {
        ""$id"": ""66da4efe6401fdd0b48c6880""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Rifle/WeaponFireRateMod"",
      ""ItemId"": {
        ""$id"": ""66da4f06b7241e0e207cead3""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Rifle/WeaponFreezeDamageMod"",
      ""ItemId"": {
        ""$id"": ""66da4f0808923bd61b6c2053""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Rifle/WeaponStunChanceMod"",
      ""ItemId"": {
        ""$id"": ""66da4f0b02a680f83e14001b""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Rifle/WeaponAmmoMaxMod"",
      ""ItemId"": {
        ""$id"": ""66da4f0d6df0e0588eb4b0d1""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Rifle/WeaponClipMaxMod"",
      ""ItemId"": {
        ""$id"": ""66da4f10009fdfcf69ab2ec1""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Rifle/WeaponDamageAmountMod"",
      ""ItemId"": {
        ""$id"": ""66da4f147ec9bcddfc5c07ad""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Rifle/WeaponFireIterationsMod"",
      ""ItemId"": {
        ""$id"": ""66da4f17f2368e85f09a853b""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Rifle/WeaponPunctureDepthMod"",
      ""ItemId"": {
        ""$id"": ""66da4f1aae38e21d01a54857""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Rifle/WeaponReloadSpeedMod"",
      ""ItemId"": {
        ""$id"": ""66da4f1ca1256c2711fa7f05""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Sentinel/SentinelArmourMod"",
      ""ItemId"": {
        ""$id"": ""66da4f1eddde58b69f855d59""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Sentinel/SentinelHealthMaxMod"",
      ""ItemId"": {
        ""$id"": ""66da4f20956388914102602d""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Sentinel/SentinelShieldMaxMod"",
      ""ItemId"": {
        ""$id"": ""66da4f23e36bec4611cdc6a5""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Sentinel/SentinelShieldRechargeRateMod"",
      ""ItemId"": {
        ""$id"": ""66da4f26cc54a853f617560e""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Shotgun/WeaponArmorPiercingDamageMod"",
      ""ItemId"": {
        ""$id"": ""66da4f28276333b2a81b2dd3""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Shotgun/WeaponCritChanceMod"",
      ""ItemId"": {
        ""$id"": ""66da4f2a809873a6291f6360""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Shotgun/WeaponCritDamageMod"",
      ""ItemId"": {
        ""$id"": ""66da4f2e1d8300362cd6c57c""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Shotgun/WeaponElectricityDamageMod"",
      ""ItemId"": {
        ""$id"": ""66da4f30737bbae85f49943e""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Shotgun/WeaponFireDamageMod"",
      ""ItemId"": {
        ""$id"": ""66da4f321702c6013aa98f3f""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Shotgun/WeaponFireRateMod"",
      ""ItemId"": {
        ""$id"": ""66da4f3564da6f4896163167""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Shotgun/WeaponFreezeDamageMod"",
      ""ItemId"": {
        ""$id"": ""66da4f38468122372c30f7f1""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Shotgun/WeaponStunChanceMod"",
      ""ItemId"": {
        ""$id"": ""66da4f38468122372c30f7f1""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Shotgun/WeaponAmmoMaxMod"",
      ""ItemId"": {
        ""$id"": ""66da4f3c2571c97042d79e6d""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Shotgun/WeaponClipMaxMod"",
      ""ItemId"": {
        ""$id"": ""66da4f3fcf5e3e74f2652f5e""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Shotgun/WeaponDamageAmountMod"",
      ""ItemId"": {
        ""$id"": ""66da4f430649a4b84f65ce37""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Shotgun/WeaponFireIterationsMod"",
      ""ItemId"": {
        ""$id"": ""66da4f45ae2b2ad6215270a0""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Shotgun/WeaponPunctureDepthMod"",
      ""ItemId"": {
        ""$id"": ""66da4f4849a8970ba57019d0""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Shotgun/WeaponReloadSpeedMod"",
      ""ItemId"": {
        ""$id"": ""66da4f4b5acc3304578859bf""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Warframe/AvatarAbilityDurationMod"",
      ""ItemId"": {
        ""$id"": ""66da4f4d7ab7e4017e17955f""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Warframe/AvatarAbilityEfficiencyMod"",
      ""ItemId"": {
        ""$id"": ""66da4f4f0af01429193da436""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Warframe/AvatarAbilityRangeMod"",
      ""ItemId"": {
        ""$id"": ""66da4f51a94c498b42a03491""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Warframe/AvatarAbilityStrengthMod"",
      ""ItemId"": {
        ""$id"": ""66da4f5483fb4b98ac12b00d""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Warframe/AvatarArmourMod"",
      ""ItemId"": {
        ""$id"": ""66da4f5694b794ae96c5f470""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Warframe/AvatarEnemyRadarMod"",
      ""ItemId"": {
        ""$id"": ""66da4f59b0ecba3d09139e48""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Warframe/AvatarHealthMaxMod"",
      ""ItemId"": {
        ""$id"": ""66da4f5eb5770f99bf18d831""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Warframe/AvatarLootRadarMod"",
      ""ItemId"": {
        ""$id"": ""66da4f63bd77ab6e4842a88b""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Warframe/AvatarPowerMaxMod"",
      ""ItemId"": {
        ""$id"": ""66da4f660b3c3565fd36d4ab""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Warframe/AvatarShieldMaxMod"",
      ""ItemId"": {
        ""$id"": ""66da4f6884fc768ed81ae47a""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Warframe/AvatarShieldRechargeRateMod"",
      ""ItemId"": {
        ""$id"": ""66da4f6be96044a294480118""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Warframe/AvatarSprintSpeedMod"",
      ""ItemId"": {
        ""$id"": ""66da4f6db2ac0720a4bf2409""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Warframe/AvatarStaminaMaxMod"",
      ""ItemId"": {
        ""$id"": ""66da4f70ec6f7abf7520a356""
      }
    },
    {
      ""ItemType"": ""/Lotus/Upgrades/Mods/Warframe/AvatarStaminaRechargeRateMod"",
      ""ItemId"": {
        ""$id"": ""66da4f738ea387a9a484294d""
      }
    }
  ],
  ""Boosters"": [],
  ""EmailItems"": [],
  ""LeagueTickets"": [],
  ""MiscItems"": [],
  ""Robotics"": [],
  ""XPInfo"": [
    {
      ""ItemType"": ""/Lotus/Powersuits/Saryn/Saryn"",
      ""XP"": 1600000
    },
    {
      ""ItemType"": ""/Lotus/Powersuits/Banshee/Banshee"",
      ""XP"": 1600000
    },
    {
      ""ItemType"": ""/Lotus/Powersuits/Ember/Ember"",
      ""XP"": 1600000
    },
    {
      ""ItemType"": ""/Lotus/Powersuits/Excalibur/Excalibur"",
      ""XP"": 1600000
    },
    {
      ""ItemType"": ""/Lotus/Powersuits/Excalibur/ExcaliburPrime"",
      ""XP"": 1600000
    },
    {
      ""ItemType"": ""/Lotus/Powersuits/Frost/Frost"",
      ""XP"": 1600000
    },
    {
      ""ItemType"": ""/Lotus/Powersuits/Frost/FrostPrime"",
      ""XP"": 1600000
    },
    {
      ""ItemType"": ""/Lotus/Powersuits/Jade/Jade"",
      ""XP"": 1600000
    },
    {
      ""ItemType"": ""/Lotus/Powersuits/Loki/Loki"",
      ""XP"": 1600000
    },
    {
      ""ItemType"": ""/Lotus/Powersuits/Mag/Mag"",
      ""XP"": 1600000
    },
    {
      ""ItemType"": ""/Lotus/Powersuits/Ninja/Ninja"",
      ""XP"": 1600000
    },
    {
      ""ItemType"": ""/Lotus/Powersuits/Rhino/Rhino"",
      ""XP"": 1600000
    },
    {
      ""ItemType"": ""/Lotus/Powersuits/Trinity/Trinity"",
      ""XP"": 1600000
    },
    {
      ""ItemType"": ""/Lotus/Powersuits/Volt/Volt"",
      ""XP"": 1600000
    },
    {
      ""ItemType"": ""/Lotus/Weapons/Tenno/Bows/HuntingBow"",
      ""XP"": 1600000
    },
    {
      ""ItemType"": ""/Lotus/Weapons/Tenno/Melee/LongSword/LongSword"",
      ""XP"": 1600000
    },
    {
      ""ItemType"": ""/Lotus/Weapons/Tenno/Pistol/Pistol"",
      ""XP"": 1600000
    }
  ],
  ""Missions"": [
    {
      ""Tag"": ""SolNode103"",
      ""Completes"": 1,
      ""BestRating"": 0.2
    }
  ],
  ""PremiumCredits"": 50
}


";
    }

}
