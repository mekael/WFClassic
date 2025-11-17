using WFClassic.Web.Data.Enums;

namespace WFClassic.Web.Data.Models;

public class GuildMembership :EntityBase
{
    public string UserDisplayName { get; set; }

    public Guid UserId { get; set; }
    public ApplicationUser User { get; set; }

    public Guid GuildId { get; set; }
    public Guild Guild { get; set; }
    public GuildRank CurrentGuildRank { get; set; }
}
