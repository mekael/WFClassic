using System.Text.Json.Serialization;
using WFClassic.Web.Data.Enums;

namespace WFClassic.Web.Data.Models
{
    public class BankAccount : EntityBase
    {
        [JsonIgnore]
        public Guid PlayerId { get; set; }
        [JsonIgnore]
        public Player Player { get; set; }
        public CurrencyType BankAccountType { get; set; }
        public List<BankAccountTransaction> BankAccountTransactions { get; set; }
        public long CurrentBalance { get; set; }
    }
}