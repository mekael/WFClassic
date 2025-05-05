using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    public class UniverseController : ControllerBase
    {

        [HttpGet]
        [Route("/api/loginRewards.php")]
        public ActionResult LoginRewards([FromQuery] Guid accountId, [FromQuery] long nonce)
        {

            //mRewardType mTier

            return new JsonResult(@"{
""RewardType"" : ""/Lotus/Types/Items/MiscItems/OrokinReactor "",
""ItemType"" : ""/Lotus/Types/Items/MiscItems/OrokinReactor "",
""ProductCategory"" :"",
""Amount"" :0,
""Tier"": 3

}");
        }

        [HttpGet]
        [Route("/api/checkDailyMissionBonus.php")]
        public ActionResult CheckDailyMissionBonus([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }

        [HttpGet]
        [Route("/api/worldState.php")]
        public string WorldState([FromQuery] Guid accountId, [FromQuery] long nonce)
        {

            string ws = @"
{
    ""Events"": [   
        {
            ""_id"": {
                ""$id"": ""5187e9393f9a5b131c66f528""
            },
            ""Msg"": ""Update 9.8.5"",
            ""Prop"": ""index.php?/topic/104304-hotfix-985/"",
            ""Date"": {
                ""sec"": 1378765369,
                ""usec"": 149000
            }
        },
        {
            ""_id"": {
                ""$id"": ""522656733f9a5b1718f1b5ab""
            },
            ""Msg"": ""Thanks for Watching Livestream #13!"",
            ""Prop"": ""index.php?/topic/102173-thank-you-for-watching-livestream-13/"",
            ""Date"": {
                ""sec"": 1378324348,
                ""usec"": 159000
            }
        }
    ],
    ""Goals"": [],
    ""Alerts"": [
        {
            ""Activation"": {
                ""sec"": 1379021582,
                ""usec"": 610000
            },
            ""AllowReplay"": 0,
            ""Expiry"": {
                ""sec"": 1379024257,
                ""usec"": 982000
            },
            ""MissionInfo"": {
                ""descText"": ""/Lotus/Language/Alerts/DefenseDesc3"",
                ""location"": ""SolNode214"",
                ""missionType"": ""MT_MOBILE_DEFENSE"",
                ""faction"": ""FC_GRINEER"",
                ""seed"": 94368,
                ""difficulty"": 0.59836683270987,
                ""missionReward"": {
                    ""credits"": 3400,
                    ""xp"": 0,
                    ""items"": [],
                    ""countedItems"": [
                        {
                            ""ItemType"": ""/Lotus/Types/Items/MiscItems/Morphic"",
                            ""ItemCount"": 1
                        }
                    ]
                },
                ""levelOverride"": ""/Lotus/Levels/Proc/Grineer/GrineerAsteroid"",
                ""enemySpec"": ""/Lotus/Types/Game/GrineerSquadThree"",
                ""vipAgent"": """",
                ""maxWaveNum"": 0,
                ""nightmare"": false
            },
            ""TweetText"": ""Sorath (Europa): Mining Facility Ambush - 45m - 3400cr - Morphics (Resource)"",
            ""Twitter"": 1,
            ""_id"": {
                ""$id"": ""521d98e9bb5768395e92594c""
            }
        },
        {
            ""_id"": {
                ""$id"": ""521d98e9bb5768395e92594d""
            },
            ""Activation"": {
                ""sec"": 1379025611,
                ""usec"": 10000
            },
            ""Expiry"": {
                ""sec"": 1379028300,
                ""usec"": 976000
            },
            ""MissionInfo"": {
                ""descText"": ""/Lotus/Language/Alerts/RaidDesc18"",
                ""location"": ""SolNode139"",
                ""missionType"": ""MT_RAID"",
                ""faction"": ""FC_CORPUS"",
                ""seed"": 67145,
                ""difficulty"": 0.99693190993275,
                ""missionReward"": {
                    ""credits"": 3300,
                    ""xp"": 0,
                    ""items"": [
                        ""/Lotus/Types/StoreItems/Recipes/PangolinSwordBlueprintStoreItem""
                    ],
                    ""countedItems"": []
                },
                ""levelOverride"": ""/Lotus/Levels/Proc/Corpus/CorpusShip"",
                ""enemySpec"": ""/Lotus/Types/Game/CorpusSquadB"",
                ""vipAgent"": """",
                ""maxWaveNum"": 0,
                ""nightmare"": false
            },
            ""TweetText"": ""Lex (Ceres): Armory Depot Discovered - 45m - 3300cr - Pangolin Sword (Blueprint)"",
            ""AllowReplay"": 0
        }
    ],
    ""GlobalUpgrades"": [
        {
            ""_id"": {
                ""$id"": ""51faa0803f9a5b35a8a59903""
            },
            ""Activation"": {
                ""sec"": 1375455600,
                ""usec"": 0
            },
            ""ExpiryDate"": {
                ""sec"": 1375804800,
                ""usec"": 0
            },
            ""UpgradeType"": ""GAMEPLAY_KILL_XP_AMOUNT"",
            ""OperationType"": ""MULTIPLY"",
            ""Value"": 2,
            ""LocalizeTag"": ""DOUBLE XP"",
            ""LocalizeDescTag"": ""Double XP Event. Starts at 2PM EST and ends at 3PM EST"",
            ""IconTexture"": ""/Lotus/Interface/Icons/Store/AffinityBooster.png""
        }
    ],
    ""Time"": 1379023743,
    ""BuildLabel"": ""2013.04.26.17.24/""
}

";


            return ws;
        }

        [HttpPost]
        [Route("/api/goals.php")]
        public ActionResult Goals([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }
    }
}
