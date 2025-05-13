namespace WFClassic.Web.Logic.Credits.Add
{
    public class AddAccountTransactionResult
    {
        public AddAccountTransactionResultStatus AddAccountTransactionResultStatus { get; set; }
    }

    public enum AddAccountTransactionResultStatus
    {
        ValidationErrors,
        Failure,
        Success
    }
}