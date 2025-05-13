using FluentValidation;

namespace WFClassic.Web.Logic.Credits.Get
{
    public class GetCreditsValidator : AbstractValidator<GetCredits>
    {
        public GetCreditsValidator()
        {
            RuleFor(r => r.AccountId).NotEmpty();
            RuleFor(r => r.Nonce).GreaterThan(0);
        }
    }
}