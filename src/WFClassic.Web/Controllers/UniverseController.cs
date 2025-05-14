using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WFClassic.Web.Logic.Bonus.Rewards;
using WFClassic.Web.Logic.Middleware;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    [TypeFilter(typeof(LoginVerificationActionFilter))]
    public class UniverseController : ControllerBase
    {
        private GetLoginRewardsHandler _getLoginRewardsHandler;

        public UniverseController(GetLoginRewardsHandler getLoginRewardsHandler)
        {
            _getLoginRewardsHandler = getLoginRewardsHandler;
        }

        [HttpGet]
        [Route("/api/loginRewards.php")]
        public ActionResult LoginRewards([FromQuery] GetLoginRewards getLoginRewards)
        {
            var result = _getLoginRewardsHandler.HandleAsync(getLoginRewards).Result;

            if (result.GetLoginRewardsResultStatus == GetLoginRewardsResultStatus.Success)
            {
                return new JsonResult(result.GetLoginRewardsResultReturnJson, new JsonSerializerOptions { PropertyNamingPolicy = null });
            }
            else if (result.GetLoginRewardsResultStatus == GetLoginRewardsResultStatus.AlreadyProvided)
            {
                return Ok();
            }
            else if (result.GetLoginRewardsResultStatus == GetLoginRewardsResultStatus.ValidationErrors)
            {
                return BadRequest();
            }
            else if (result.GetLoginRewardsResultStatus == GetLoginRewardsResultStatus.DatabaseErrors)
            {
                return StatusCode(500);
            }
            return StatusCode(500);
        }

        [HttpGet]
        [Route("/api/checkDailyMissionBonus.php")]
        public string CheckDailyMissionBonus([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            var cat = "{DailyMissionBonus:1}";
            return cat;
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
            ""Prop"": ""https://forums.warframe.com/index.php?/topic/209324-update-13-dark-sectors/"",
            ""Date"": {
                ""sec"": 1378765369,
                ""usec"": 149000
            },
""Type"" :3
        },
        {
            ""_id"": {
                ""$id"": ""522656733f9a5b1718f1b5ab""
            },
            ""Msg"": ""Thanks for Watching Livestream #13!"", 
            ""Prop"": ""www.google.com"",
            ""Date"": {
                ""sec"": 1378324348,
                ""usec"": 159000
            }
        }
    ],

    ""Goals"": [
{
                        ""_id"": {
                ""$id"": ""521d98e9bb5768395e92594c""
            },
            ""Activation"": {
                ""sec"": 1746814027,
                ""usec"": 0
            },
            ""AllowReplay"": 1,
            ""Expiry"": {
                ""sec"": 1747359260,
                ""usec"": 0
            },
      ""Desc"": ""CATSAASDASD"",
      ""Count"": 250,
      ""Goal"": 500,
      ""Success"": 1,
      ""Personal"": true,
      ""Best"": true,
      ""Node"": ""SolNode119"",
      ""MissionKeyName"": ""/Lotus/Types/Keys/MechSurvivalCorpusShip"",
      ""Faction"": ""FC_GRINEER"",
      ""Icon"": ""/Lotus/Interface/Icons/Categories/IconMech256.png"",
      ""Tag"": ""MechSurvivalA"",
      ""ScoreVar"": ""MechSurvivalScore"",

        }],
     ""Alerts"": [
        {
            ""Activation"": {
                ""sec"": 1746840721,
                ""usec"": 610000
            },
            ""AllowReplay"": 1,
            ""Expiry"": {
                ""sec"": 1778376721,
                ""usec"": 982000
            },
            ""MissionInfo"": {
               ""missionType"": ""MT_ASSASSINATION"",
                ""faction"": ""FC_GRINEER"",
                ""uniqueName"" :""General Sargas Ruk Cats"",
                ""icon"": ""/Lotus/Interface/Icons/Npcs/Grineer/GrineerFacesL.png"",
               ""descText"": ""CATS!!!"",
                ""location"": ""SolNode94"",
                ""unlocked"" :1,
                ""introText"": ""CatIntroText"",
                ""completionText"": ""CatCompletionText"",
                ""minEnemyLevel"" :999,
                ""maxEnemyLevel"" :9999,
                ""introText"": ""Murder Everyone"",
                ""completionText"": ""CAAAAATSSS"",
                ""seed"": 94368,
                ""difficulty"": 0.59836683270987,
                ""vipAgent"": ""/Lotus/Types/Enemies/Infested/Vip/ZombieLeaderAgent"",

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
                ""levelOverride"": ""/Lotus/Levels/Proc/Corpus/CorpusExterminateLevel"",
                ""enemySpec"": """",
                ""vipAgent"": """",
                ""maxWaveNum"": 0,
            ""alertId"": {
                ""$id"": ""521d98e9bb5768395e92594c""
            }
            }
        }
    ],
    ""Time"": 1747186460,
""BuildLabel"": ""2013.04.26.17.24/""
}

";
            //goals is operations

            //    ""BuildLabel"": ""2013.04.26.17.24/""
            //""BuildLabel"": ""2013.04.26.17.24/""
            return ws;
        }

        [HttpPost]
        [Route("/api/goals.php")]
        public ActionResult Goals([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            Console.WriteLine("In Goals");
            return new JsonResult("{}");
        }
    }
}