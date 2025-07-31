using System;

namespace WFClassic.Web.Logic.Admin.Ban;

public class BanPlayerResult
{
    public Guid AccountId { get; set; }
    public BanPlayerResultStatus BanPlayerResultStatus { get; set; }
}
public enum BanPlayerResultStatus
{
    ValidationErrors,
    DatabaseErrors,
    ExistingBanInPlace,
    Success
}