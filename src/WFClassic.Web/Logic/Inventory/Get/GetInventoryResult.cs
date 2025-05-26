using Newtonsoft.Json;
using System.Text.Json.Serialization;
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
        public int Founder { get; set; }

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
        public GetInventoryResultJsonInventoryBin SuitBin { get; set; }

        [JsonPropertyName("WeaponBin")]
        public GetInventoryResultJsonInventoryBin WeaponBin { get; set; }

        [JsonPropertyName("MiscBin")]
        public GetInventoryResultJsonInventoryBin MiscBin { get; set; }

        [JsonPropertyName("SentinelBin")]
        public GetInventoryResultJsonInventoryBin SentinelBin { get; set; }

        [JsonPropertyName("InvalidBin")]
        public GetInventoryResultJsonInventoryBin InvalidBin { get; set; }

        [JsonPropertyName("LongGuns")]
        public List<GetInventoryResultJsonEquipmentItem> LongGuns { get; set; }

        [JsonPropertyName("Cards")]
        public List<GetInventoryResultJsonUpgradeItem> Cards { get; set; }

        [JsonPropertyName("Pistols")]
        public List<GetInventoryResultJsonEquipmentItem> Pistols { get; set; }

        [JsonPropertyName("Suits")]
        public List<GetInventoryResultJsonEquipmentItem> Suits { get; set; }

        [JsonPropertyName("Melee")]
        public List<GetInventoryResultJsonEquipmentItem> Melee { get; set; }

        [JsonPropertyName("Sentinels")]
        public List<GetInventoryResultJsonEquipmentItem> Sentinels { get; set; }

        [JsonPropertyName("SentinelWeapons")]
        public List<GetInventoryResultJsonEquipmentItem> SentinelWeapons { get; set; }

        [JsonPropertyName("Missions")]
        public List<GetInventoryResultJsonMission> Missions { get; set; }

        [JsonPropertyName("DeathMarks")]
        public List<string> DeathMarks { get; set; }

        [JsonPropertyName("CompletedAlerts")]
        public List<string> CompletedAlerts { get; set; }

        [JsonPropertyName("Consumables")]
        public List<GetInventoryResultJsonTypeCount> Consumables { get; set; }

        [JsonPropertyName("MiscItems")]
        public List<GetInventoryResultJsonTypeCount> MiscItems { get; set; }

        [JsonPropertyName("Recipes")]
        public List<GetInventoryResultJsonTypeCount> Recipes { get; set; }

        [JsonPropertyName("Components")]
        [System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<GetInventoryResultJsonTypeCount> Components { get; set; }

        [JsonPropertyName("XPInfo")]
        public List<GetInventoryResultJsonXpInfoItem> XPInfo { get; set; }

        [JsonPropertyName("TauntHistory")]
        public List<GetInventoryResultJsonTauntHistoryItem> TauntHistory { get; set; }

        [JsonPropertyName("Upgrades")]
        public List<GetInventoryResultJsonUpgradeItem> Upgrades { get; set; }

        [JsonPropertyName("FlavourItems")]
        public List<GetInventoryResultJsonFlavourItem> FlavourItems { get;set; }

        [JsonPropertyName("ActiveAvatarImageType")]
        public string ActiveAvatarImageType { get; set; }

    }

    public class GetInventoryResultJsonFlavourItem
    {
        [JsonProperty("ItemType")]
        public string ItemType { get; set; }
    }


    public class GetInventoryResultJsonXpInfoItem
    {
        [JsonProperty("ItemType")]
        public string ItemType { get; set; }

        [JsonProperty("XP")]
        public long XP { get; set; }
    }

    public class GetInventoryResultJsonUpgradeItem
    {
        [JsonPropertyName("ItemType")]
        public string ItemType { get; set; }

        [JsonPropertyName("ItemId")]
        public MongoId ItemId { get; set; }

        [JsonPropertyName("ParentId")]
        [System.Text.Json.Serialization.JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingNull)]
        public MongoId ParentId { get; set; }

        [JsonPropertyName("Slot")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Slot { get; set; }

        [JsonPropertyName("UpgradeFingerprint")]
        public string UpgradeFingerPrint { get; set; }

        [JsonPropertyName("Rank")]
        public int Rank { get; set; } = 10;

        [JsonPropertyName("AmountRemaining")]
        public int AmountRemaining { get; set; } = 99999;
    }

    public class GetInventoryResultJsonTypeCount
    {
        [JsonProperty("ItemType")]
        public string ItemType { get; set; }

        [JsonProperty("ItemCount")]
        public int ItemCount { get; set; }
    }

    public class GetInventoryResultJsonTauntHistoryItem
    {
        [JsonPropertyName("node")]
        public string node { get; set; }
    }

    public class GetInventoryResultJsonMission
    {
        [JsonPropertyName("Tag")]
        public string Tag { get; set; }

        [JsonPropertyName("Completes")]
        public int Completes { get; set; }

        [JsonPropertyName("BestRating")]
        public float BestRating { get; set; }
    }

    public class GetInventoryResultJsonInventoryBin
    {
        [JsonProperty("Slots")]
        public int Slots { get; set; }

        [JsonProperty("Extra")]
        public int Extra { get; set; }
    }

    public class GetInventoryResultJsonEquipmentItem
    {
        [JsonPropertyName("ItemType")]
        public string ItemType { get; set; }

        [JsonPropertyName("ItemId")]
        public MongoId ItemId { get; set; }

        [JsonPropertyName("XP")]
        public long XP { get; set; }

        [JsonPropertyName("UpgradeVer")]
        public long UpgradeVer { get; set; }

        [JsonPropertyName("UnlockLevel")]
        public int UnlockLevel { get; set; }

        [JsonPropertyName("ExtraCapacity")]
        public int ExtraCapacity { get; set; }

        [JsonPropertyName("ExtraRemaining")]
        public int ExtraRemaining { get; set; }  



    }

    public class GetInventoryResultJsonCardItem
    {
        public string ItemType { get; set; }
        public int Rank { get; set; }
        public int AmountRemaining { get; set; }
    }

    public enum GetInventoryResultStatus
    {
        ValidationErrors,
        DatabaseErrors,
        MappingFailure,
        Success
    }
}