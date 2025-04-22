using WFClassic.Web.Data.Enums;

namespace WFClassic.Web.Data.Models
{
    public class BankAccountTransaction : EntityBase
    {
        public Guid BankAccountId { get; set; }
        public BankAccount BankAccount { get; set; }
        public BankAccountTransactionType BankAccountTransactionType { get; set; }
        public long Amount { get; set; }
        public string MemoCode { get; set; }
    }
}
