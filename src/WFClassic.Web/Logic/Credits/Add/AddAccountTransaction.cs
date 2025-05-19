using WFClassic.Web.Data.Enums;

namespace WFClassic.Web.Logic.Credits.Add
{
    public class AddAccountTransaction
    {
        public Guid AccountId { get; set; }
        public long Amount { get; set; }
        public BankAccountTransactionType BankAccountTransactionType { get; set; }
        public CurrencyType BankAccountType { get; set; }
        public string MemoCode { get; set; }
    }
}