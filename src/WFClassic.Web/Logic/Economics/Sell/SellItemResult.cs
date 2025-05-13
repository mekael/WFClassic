namespace WFClassic.Web.Logic.Economics.Sell
{
    public class SellItemResult
    {
        public SellItemResultStatus SellItemResultStatus { get; set; }
    }

    public enum SellItemResultStatus
    {
        ValidationErrors,
        DatabaseErrors,
        MappingFailure,
        Success
    }
}