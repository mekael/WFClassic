using Newtonsoft.Json;
using WFClassic.Web.Data.Models;
using WFClassic.Web.Logic.Shared.Models;

namespace WFClassic.Web.Logic.Inventory.Get
{
    public class GetInventoryResult
    {

        public GetInventoryResultStatus GetInventoryResultStatus { get; set; }

        public GetInventoryResultDetails GetInventoryResultDetails { get; set; }    

    }

    public class GetInventoryResultDetails
    {
       

        [JsonProperty("SubscribedToEmails")]
        public int SubscribedToEmails { get; set; }

        [JsonProperty("RewardSeed")]
        public long RewardSeed { get; set; }

        [JsonProperty("RegularCredits")]
        public long RegularCredits { get; set; }

        [JsonProperty("PremiumCredits")]
        public long PremiumCredits { get; set; }

        [JsonProperty("ReceivedStartingGear")]
        public bool ReceivedStartingGear { get; set; }

        [JsonProperty("Founder")]
        public string Founder { get; set; }

        [JsonProperty("TrainingDate")]
        public MongoDate TrainingDate { get; set; }

        [JsonProperty("PlayerLevel")]
        public int PlayerLevel { get; set; }

        [JsonProperty("PlayerXP")]
        public long PlayerXP { get; set; }

        [JsonProperty("AdditionalPlayerXP")]
        public long AdditionalPlayerXP { get; set; }

        [JsonProperty("Rating")]
        public int Rating { get; set; }

        [JsonProperty("SuitBin")]
        public JsonInventoryBin SuitBin { get; set; }

        [JsonProperty("WeaponBin")]
        public JsonInventoryBin WeaponBin { get; set; }

        [JsonProperty("MiscBin")]
        public JsonInventoryBin MiscBin { get; set; }

        [JsonProperty("SentinelBin")]
        public JsonInventoryBin SentinelBin { get; set; }

        [JsonProperty("InvalidBin")]
        public JsonInventoryBin InvalidBin { get; set; }

        [JsonProperty("LongGuns")]
        public List<JsonEquipmentItem> LongGuns { get; set; }

        [JsonProperty("Pistols")]
        public List<JsonEquipmentItem> Pistols { get; set; }

        [JsonProperty("Suits")]
        public List<JsonEquipmentItem> Suits { get; set; }

        [JsonProperty("Melee")]
        public List<JsonEquipmentItem> Melee { get; set; }

        [JsonProperty("Sentinels")]
        public List<JsonEquipmentItem> Sentinels { get; set; }

        [JsonProperty("SentinelWeapons")]
        public List<JsonEquipmentItem> SentinelWeapons { get; set; }

        [JsonProperty("Missions")]
        public List<JsonMission> Missions { get; set; }

        [JsonProperty("DeathMarks")]
        public List<string> DeathMarks { get; set; }

        [JsonProperty("CompletedAlerts")]
        public List<string> CompletedAlerts { get; set; }

        [JsonProperty("XPInfo")]
        public List<JsonXpInfoItem> XPInfo { get; set; }
    }


    public enum GetInventoryResultStatus
    {
        ValidationErrors,
        LoginCheckFailure,
        AlreadyReceivedStartingGear,
        DatabaseErrors,
        MappingFailure,
        Success
    }

}
