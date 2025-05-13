namespace WFClassic.Web.Logic.Admin.CheckOnline
{
    public class IsUserOnlineQuery
    {
        public IsUserOnlineQuery(Guid accountId, long nonce)
        {
            this.AccountId = accountId;
            this.Nonce = nonce;
        }

        public Guid AccountId { get; set; }
        public long Nonce { get; set; }
    }
}