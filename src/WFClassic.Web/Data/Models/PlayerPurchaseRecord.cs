using WFClassic.Web.Data.Enums;

namespace WFClassic.Web.Data.Models
{
    public class PlayerPurchaseRecord : EntityBase
    {
        public Guid PlayerID { get; set; }
        public Player Player { get; set; }
        public Guid MarketPackageDefinitionId { get; set; }
        public MarketPackageDefinition MarketPackageDefinition { get; set; }
        public DateTimeOffset PurchaseDate { get; set; } = DateTimeOffset.Now;
        public int PurchaseAmount { get; set; }
        public CurrencyType? CurrencyType { get; set; } //nullable just in case we want to "gift" packages to players.
    }
}
