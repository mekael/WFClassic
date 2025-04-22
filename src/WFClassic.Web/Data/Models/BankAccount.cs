using WFClassic.Web.Data.Enums;

namespace WFClassic.Web.Data.Models
{
    public class BankAccount : EntityBase
    {
        public Guid ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public BankAccountType BankAccountType { get; set; }
        public ICollection<BankAccountTransaction> BankAccountTransactions { get; set; }
        public long CurrentBalance { get; set; }
    }
}
