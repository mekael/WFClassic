namespace WFClassic.Web.Logic.Economics.Slots
{
    public class PurchaseSlotsResult
    {
        public PurchaseSlotsResultStatus PurchaseSlotsResultStatus { get; set; }
    }

    public enum PurchaseSlotsResultStatus
    {
        ValidationErrors,
        DatabaseErrors,
        Success
    }
}