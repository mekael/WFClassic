using Microsoft.AspNetCore.Mvc;

namespace WFClassic.Web.Logic.SessionHandling;

public class UpdateSession
{
    public Guid AccountId { get; set; }
    public long Nonce { get; set; }
    public string SessionId { get; set; }
    public bool FullReset { get; set; }
    public int RegionId { get; set; }
    
    public int GameModeId { get; set; }
}
