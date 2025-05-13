namespace WFClassic.Web.Logic.WFAuth.WFLogout
{
    public class WarframeLogoutRequest
    {
        public Guid accountId { get; set; }
        public long nonce { get; set; }
    }
}