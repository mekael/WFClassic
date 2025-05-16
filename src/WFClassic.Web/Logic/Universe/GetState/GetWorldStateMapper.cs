using WFClassic.Web.Data.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WFClassic.Web.Logic.Universe.GetState
{
    public static class GetWorldStateMapper
    {



        public static GetWorldStateResultJson Map(List<WorldStateEventMessage> worldStateEventMessages, List<AlertConfiguration> worldStateAlerts, string buildLabel)
        {


            GetWorldStateResultJson returnJson = new GetWorldStateResultJson()
            {
                Events = worldStateEventMessages.Where(w => !w.MessageExpirationDate.HasValue || w.MessageExpirationDate.Value.Date >= DateTime.Today).Select(s => new GetWorldStateResultJsonEvent()
                {
                    Date = new Shared.Models.WorldStateDate(s.MessageDate),
                    Msg = s.Message,
                    Prop = s.Property,
                    _id = new Shared.Models.MongoId(s.Id)
                }).ToList(),
                BuildLabel = buildLabel,
                Time = DateTimeOffset.Now.ToUnixTimeSeconds()
            };


            foreach (var alertConfiguration in worldStateAlerts.Where(w => w.EndDate.Date >= DateTime.Today && w.StartDate.Date <= DateTime.Today))
            {
                // get the specific reward 
                var clientSideReward = alertConfiguration.AlertRewardConfigurations.FirstOrDefault(a => a.RewardProvidedAtLocation == Data.Enums.RewardProvidedAtLocation.Client);
                var clientSideRewardItemString = clientSideReward != null ? clientSideReward.ItemsArray : "";


                returnJson.Alerts.Add(new GetWorldStateResultJsonAlert()
                {
                    Activation = new Shared.Models.WorldStateDate(alertConfiguration.StartDate),
                    AllowReplay = alertConfiguration.AllowReplay,
                    Expiry = new Shared.Models.WorldStateDate(alertConfiguration.EndDate),
                    MissionInfo = new GetWorldStateResultJsonAlertMissionInfo()
                    {
                        CompleteTag = alertConfiguration.CompleteTag,
                        completions = alertConfiguration.Completions,
                        completionText = alertConfiguration.CompletionText,
                        descText = alertConfiguration.Description,
                        difficulty = alertConfiguration.Difficulty,
                        enemies = alertConfiguration.AlertEnemyConfigurations != null ? alertConfiguration.AlertEnemyConfigurations.Select(s => new GetWorldStateResultJsonEnemy() { agent = s.EnemyId, maxSimultaneous = s.MaxSimultaneous, probability = s.Probability, tier = s.Tier }).ToList() : [],
                        enemySpec = alertConfiguration.EnemySpec,
                        faction = alertConfiguration.Faction,
                        icon = alertConfiguration.Icon,
                        introText = alertConfiguration.IntroText,
                        levelOverride = alertConfiguration.LevelOverride,
                        location = alertConfiguration.Location,
                        maxEnemyLevel = alertConfiguration.MaxEnemyLevel,
                        minEnemyLevel = alertConfiguration.MinEnemyLevel,
                        missionReward = new GetWorldStateResultJsonMissionReward()
                        {
                            credits = clientSideReward != null ? clientSideReward.Credits : 500,
                            items = !string.IsNullOrWhiteSpace(clientSideRewardItemString) ? clientSideRewardItemString.Split(";").ToList() : [],
                            randomizedItems = clientSideReward != null ? clientSideReward.RandomizedItems : "",
                            xp = clientSideReward != null ? clientSideReward.Xp : 500,
                        },
                        missionType = alertConfiguration.MissionType,
                        seed = alertConfiguration.Seed,
                        uniqueName = alertConfiguration.UniqueName,
                        unlocked = alertConfiguration.Unlocked,
                        vipAgent = alertConfiguration.VIPAgent
                    }
                });

            }


            return returnJson;


        }
    }
}
