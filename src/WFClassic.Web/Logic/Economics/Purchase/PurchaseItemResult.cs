namespace WFClassic.Web.Logic.Economics.Purchase
{
    public class PurchaseItemResult
    {
        public PurchaseItemResultStatus PurchaseItemResultStatus { get; set; }
    }

    public enum PurchaseItemResultStatus
    {
        ValidationErrors,
        DatabaseErrors,
        AlreadyOwned,
        Success
    }
}