using System.Text.Json.Serialization;
using WFClassic.Web.Data.Enums;

namespace WFClassic.Web.Data.Models
{
    public class BankAccountTransaction : EntityBase
    {
        [JsonIgnore]
        public Guid BankAccountId { get; set; }
        [JsonIgnore]
        public BankAccount BankAccount { get; set; }
        public BankAccountTransactionType BankAccountTransactionType { get; set; }
        public long Amount { get; set; }
        public string MemoCode { get; set; }
    }
}