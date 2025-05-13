using WFClassic.Web.Data.Enums;

namespace WFClassic.Web.Data.Models
{
    public class BankAccount : EntityBase
    {
        public Guid PlayerId { get; set; }
        public Player Player { get; set; }
        public BankAccountType BankAccountType { get; set; }
        public List<BankAccountTransaction> BankAccountTransactions { get; set; }
        public long CurrentBalance { get; set; }
    }
}