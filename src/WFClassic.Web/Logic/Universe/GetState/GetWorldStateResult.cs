using System.Text.Json.Serialization;
using WFClassic.Web.Logic.Shared.Models;

namespace WFClassic.Web.Logic.Universe.GetState
{
    public class GetWorldStateResult
    {
        public GetWorldStateResultJson GetWorldStateResultJson { get; set; }
        public GetWorldStateResultStatus GetWorldStateResultStatus { get; set; }
    }

    public enum GetWorldStateResultStatus
    {
        ValidationErrors,
        DatabaseErrors,
        Success,
        MappingErrors
    }

    public class GetWorldStateResultJson
    {
        [JsonPropertyName("Events")]
        public List<GetWorldStateResultJsonEvent> Events { get; set; } = new List<GetWorldStateResultJsonEvent>();
        public List<GetWorldStateResultJsonAlert> Alerts { get; set; } = new List<GetWorldStateResultJsonAlert>();

        public long Time { get; set; }
        public string BuildLabel { get; set; }
    }

    public class GetWorldStateResultJsonEvent
    {
        public WorldStateDate Date { get; set; }
        public MongoId _id { get; set; }
        public string Msg { get; set; }
        public string Prop { get; set; }
        public int Type { get; set; }
    }

    public class GetWorldStateResultJsonAlert
    {
        public WorldStateDate Activation { get; set; }
        public WorldStateDate Expiry { get; set; }
        public int AllowReplay { get; set; }
        public GetWorldStateResultJsonAlertMissionInfo MissionInfo { get; set; }
    }
    public class GetWorldStateResultJsonAlertMissionInfo
    {
        public string missionType { get; set; }
        public string faction { get; set; }
        public string uniqueName { get; set; }
        public string icon { get; set; }
        public int unlocked { get; set; }
        public int completions { get; set; }
        public int seed { get; set; }
        public float difficulty { get; set; }
        public string descText { get; set; }
        public string introText { get; set; }
        public string completionText { get; set; }
        public string location { get; set; }
        public string levelOverride { get; set; }
        public string enemySpec { get; set; }
        public List<GetWorldStateResultJsonEnemy> enemies { get; set; } 
        public string vipAgent { get; set; }
        public int minEnemyLevel { get; set; }
        public int maxEnemyLevel { get; set; }
        public string CompleteTag { get; set; } //?
        public GetWorldStateResultJsonMissionReward missionReward { get; set; }
    }
    public class GetWorldStateResultJsonMissionReward
    {
        public int credits { get; set; } = 500;
        public int xp { get; set; } = 500;


        //TODO: figure this out. 
        [JsonPropertyName("items")]
        public List<string> items { get; set; }
        public string randomizedItems { get; set; }
    }




    public class GetWorldStateResultJsonEnemy
    {
        public string agent { get; set; }
        public float probability { get; set; }
        public int maxSimultaneous { get; set; }
        public int tier { get; set; }
    }


    public class GetWorldStateResultJsonItem
    {
        public string ItemType { get; set; }
        public int ItemCount { get; set; }
 
    }




}

