using System;
using FluentValidation;

namespace WFClassic.Web.Logic.Admin.Ban;

public class BanPlayerValidator : AbstractValidator<BanPlayer>
{
    public BanPlayerValidator()
    {
        this.RuleFor(r => r.AccountId).NotEmpty();
        this.RuleFor(r => r.BanReason).NotEmpty();
        this.RuleFor(r => r).Must(m => m.PermaBan || m.BanInEffectUntil.HasValue);
        this.RuleFor(r => r.BanInEffectUntil).Must(m => m.HasValue && m.Value > DateTimeOffset.Now).Unless(u => u.PermaBan);
        this.RuleFor(r => r.BannedByUserId).NotEmpty();
    }
}
