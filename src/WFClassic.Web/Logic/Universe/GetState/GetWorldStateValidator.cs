using FluentValidation;

namespace WFClassic.Web.Logic.Universe.GetState
{
    public class GetWorldStateValidator : AbstractValidator<GetWorldState>
    {
        public GetWorldStateValidator()
        {
            RuleFor(r => r.AccountId).NotEmpty();
            RuleFor(r => r.Nonce).GreaterThan(0);
        }
    }
}