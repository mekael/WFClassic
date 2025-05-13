namespace WFClassic.Web.Logic.Economics.Sell
{
    public class SellItem
    {
        public Guid AccountId { get; set; }
        public long Nonce { get; set; }

        public IncomingSaleJson IncomingSaleJson { get; set; }
    }

    public class IncomingSaleJson
    {
        public IncomingItemsToSell Items { get; set; }
        public int SellPrice { get; set; }
    }

    public class IncomingItemsToSell
    {
        public List<UniqueIncomingItemToSell> Pistols { get; set; }
        public List<UniqueIncomingItemToSell> LongGuns { get; set; }
        public List<IncomingItemToSell> Consumables { get; set; }
        public List<UniqueIncomingItemToSell> Suits { get; set; }
        public List<IncomingItemToSell> Upgrades { get; set; }
        public List<UniqueIncomingItemToSell> Melee { get; set; }
        public List<IncomingItemToSell> WeaponSkins { get; set; }
        public List<IncomingItemToSell> Robotics { get; set; }
        public List<IncomingItemToSell> Boosters { get; set; }
        public List<IncomingItemToSell> Packages { get; set; }
        public List<IncomingItemToSell> FlavourItems { get; set; }
        public List<IncomingItemToSell> MiscItems { get; set; }
        public List<IncomingItemToSell> Cards { get; set; }
        public List<IncomingItemToSell> Recipes { get; set; }
        public List<IncomingItemToSell> CreditBundles { get; set; }
        public List<UniqueIncomingItemToSell> Sentinels { get; set; }
        public List<UniqueIncomingItemToSell> SentinelWeapons { get; set; }
    }

    public class IncomingItemToSell
    {
        public string String { get; set; }
        public int Count { get; set; }
    }

    public class UniqueIncomingItemToSell
    {
        public Guid String { get; set; }
        public int Count { get; set; }
    }
}