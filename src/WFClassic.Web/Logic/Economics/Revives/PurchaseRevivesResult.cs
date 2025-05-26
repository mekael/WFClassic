namespace WFClassic.Web.Logic.Economics.Revives
{
    public class PurchaseRevivesResult
    {
        public PurchaseRevivesResultStatus PurchaseRevivesResultStatus { get; set; }
    }

    public enum PurchaseRevivesResultStatus
    {
        ValidationErrors,
        DatabaseErrors,
        Success
    }
}