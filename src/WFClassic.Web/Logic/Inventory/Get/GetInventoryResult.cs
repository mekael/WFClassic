using Org.BouncyCastle.Bcpg.Sig;
using System.Text.Json.Serialization;
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
       

        [JsonPropertyName("SubscribedToEmails")]
        public int SubscribedToEmails { get; set; }

        [JsonPropertyName("RewardSeed")]
        public long RewardSeed { get; set; }

        [JsonPropertyName("RegularCredits")]
        public long RegularCredits { get; set; }

        [JsonPropertyName("PremiumCredits")]
        public long PremiumCredits { get; set; }

        [JsonPropertyName("ReceivedStartingGear")]
        public bool ReceivedStartingGear { get; set; }

        [JsonPropertyName("Founder")]
        public string Founder { get; set; }

        [JsonPropertyName("TrainingDate")]
        public MongoDate TrainingDate { get; set; }

        [JsonPropertyName("PlayerLevel")]
        public int PlayerLevel { get; set; }

        [JsonPropertyName("PlayerXP")]
        public long PlayerXP { get; set; }

        [JsonPropertyName("AdditionalPlayerXP")]
        public long AdditionalPlayerXP { get; set; }

        [JsonPropertyName("Rating")]
        public int Rating { get; set; }

        [JsonPropertyName("SuitBin")]
        public JsonInventoryBin SuitBin { get; set; }

        [JsonPropertyName("WeaponBin")]
        public JsonInventoryBin WeaponBin { get; set; }

        [JsonPropertyName("MiscBin")]
        public JsonInventoryBin MiscBin { get; set; }

        [JsonPropertyName("SentinelBin")]
        public JsonInventoryBin SentinelBin { get; set; }

        [JsonPropertyName("InvalidBin")]
        public JsonInventoryBin InvalidBin { get; set; }

        [JsonPropertyName("LongGuns")]
        public List<JsonEquipmentItem> LongGuns { get; set; }

        [JsonPropertyName("Pistols")]
        public List<JsonEquipmentItem> Pistols { get; set; }

        [JsonPropertyName("Suits")]
        public List<JsonEquipmentItem> Suits { get; set; }

        [JsonPropertyName("Melee")]
        public List<JsonEquipmentItem> Melee { get; set; }

        [JsonPropertyName("Sentinels")]
        public List<JsonEquipmentItem> Sentinels { get; set; }

        [JsonPropertyName("SentinelWeapons")]
        public List<JsonEquipmentItem> SentinelWeapons { get; set; }

        [JsonPropertyName("Missions")]
        public List<JsonMission> Missions { get; set; }

        [JsonPropertyName("DeathMarks")]
        public List<string> DeathMarks { get; set; }

        [JsonPropertyName("CompletedAlerts")]
        public List<string> CompletedAlerts { get; set; }

        [JsonPropertyName("XPInfo")]
        public List<JsonXpInfoItem> XPInfo { get; set; }

        [JsonPropertyName("TauntHistory")]
        public List<JsonTauntHistoryItem> TauntHistory { get; set; }

        [JsonPropertyName("Upgrades")]
        public List<JsonUpgradeItem> Upgrades { get; set; }
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
