using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Clans.Get
{
    public class GetGuild
    {
        public Guid AccountId { get; set; }

        public long Nonce { get; set; }
    }
}