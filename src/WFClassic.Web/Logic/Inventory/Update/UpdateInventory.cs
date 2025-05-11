using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Inventory.Update
{
    public class UpdateInventory
    {
        public Guid AccountId { get; set; }
        public long Nonce { get; set; }

        public UpdateInventoryFromMissionObject UpdateInventoryFromMissionObject { get; set; }
    }


    public class UpdateInventoryFromMissionObject
    {
        public List<JsonIncomingEquipmentItem> LongGuns { get; set; }
        public List<JsonIncomingEquipmentItem> Pistols { get; set; }
        public List<JsonIncomingEquipmentItem> Suits { get; set; }
        public List<JsonIncomingEquipmentItem> Melee { get; set; }
        public List<JsonIncomingEquipmentItem> Sentinels { get; set; }
        public List<JsonIncomingEquipmentItem> SentinelWeapons { get; set; }
        public object[] WeaponSkins { get; set; }
        public Upgrade[] Upgrades { get; set; }
        public object[] Boosters { get; set; }
        public object[] Robotics { get; set; }
        public List<ItemCountPair> Consumables { get; set; }
        public object[] FlavourItems { get; set; }
        public List<ItemCountPair> MiscItems { get; set; }
        public object[] Cards { get; set; }
        public List<ItemCountPair> Recipes { get; set; }
        public object[] XPInfo { get; set; } 

        public Bin SuitBin { get; set; }
        public Bin WeaponBin { get; set; }
        public Bin MiscBin { get; set; }
        public Bin SentinelBin { get; set; }
        public int RegularCredits { get; set; }
        public int PremiumCredits { get; set; }
        public int PlayerXP { get; set; }
        public int AdditionalPlayerXP { get; set; }
        public int Rating { get; set; }
        public int PlayerLevel { get; set; }
        public Trainingdate TrainingDate { get; set; }
        public float AliveTime { get; set; }
        public JsonIncomingMission Missions { get; set; }
        public object[] AssignedMissions { get; set; }
        public object[] CompletedAlerts { get; set; }
        public object[] DeathMarks { get; set; }
        public IncomingMissionreport MissionReport { get; set; }
    }

    public class Bin
    {
        public int Slots { get; set; }
        public int Extra { get; set; }
    }

    public class Trainingdate
    {
        public string sec { get; set; }
        public string usec { get; set; }
    }

    public class JsonIncomingMission
    {
        public string Tag { get; set; }
        public int Completes { get; set; }
        public float BestRating { get; set; }
    }

    public class IncomingMissionreport
    {
        public string HostId { get; set; }
        public string MishStartTime { get; set; }
        public string MishName { get; set; }
        public Playerreport PlayerReport { get; set; }
    }

    public class Playerreport
    {
        public string ReporterId { get; set; }
        public bool FullReport { get; set; }
        public List<Playermishinfo> PlayerMishInfos { get; set; }
    }

    public class Playermishinfo
    {
        public string Pid { get; set; }
        public int Creds { get; set; }
        public int CredBonus { get; set; }
        public int Xp { get; set; }
        public int XpBonus { get; set; }
        public int SuitXpBonus { get; set; }
        public int PistolXpBonus { get; set; }
        public int RfileXpBonus { get; set; }
        public int MeleeXpBonus { get; set; }
        public int SentnlXPBonus { get; set; }
        public int SentnlWepXpBonus { get; set; }
        public float Rating { get; set; }
        public string[] Upgrades { get; set; }
    }

    public class JsonIncomingEquipmentItem
    {
        public string ItemType { get; set; }
        public Itemid ItemId { get; set; }
        public int XP { get; set; }
        public int UpgradeVer { get; set; }
        public int UnlockLevel { get; set; }
        public int ExtraCapacity { get; set; }
        public int ExtraRemaining { get; set; }
    }

    public class Itemid
    {
        [JsonPropertyName("$id")]
        public string id { get; set; }
    }

    public class Upgrade
    {
        public string ItemType { get; set; }
        public Itemid ItemId { get; set; }
        public string UpgradeFingerprint { get; set; }
        public int Slot { get; set; }
        public Itemid ParentId { get; set; }
    }

    public class ItemCountPair
    {
        public int ItemCount { get; set; }
        public string ItemType { get; set; }
    }

}


