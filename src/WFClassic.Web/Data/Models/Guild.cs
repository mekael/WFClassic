namespace WFClassic.Web.Data.Models;

public class Guild :EntityBase
{

    public string DisplayName { get; set; }
    public string CleansedName { get; set; }

    public string MessageOfTheDay { get; set; }
    public string Tag { get; set; }
    public int Tier { get; set; }

    public List<GuildMembership> GuildMembers { get; set; }
}
