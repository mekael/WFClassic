using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Clans.Create
{
    public class AddGuild
    {
        public Guid AccountId { get; set; }

        public long Nonce { get; set; }

        public string GuildName { get; set; }
    }
}