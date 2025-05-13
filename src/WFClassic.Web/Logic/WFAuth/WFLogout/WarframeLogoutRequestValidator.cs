using FluentValidation;

namespace WFClassic.Web.Logic.WFAuth.WFLogout
{
    public class WarframeLogoutRequestValidator : AbstractValidator<WarframeLogoutRequest>
    {
        public WarframeLogoutRequestValidator()
        {
            RuleFor(r => r.accountId).NotEmpty();
            RuleFor(r => r.nonce).GreaterThan(0);
        }
    }
}