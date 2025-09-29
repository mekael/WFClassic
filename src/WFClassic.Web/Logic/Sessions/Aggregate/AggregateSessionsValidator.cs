using FluentValidation;

namespace WFClassic.Web.Logic.Sessions.Aggregate
{
    public class AggregateSessionsValidator : AbstractValidator<AggregateSessions>
    {
        public AggregateSessionsValidator()
        {
            RuleFor(r => r.AccountId).NotEmpty();
            RuleFor(r => r.Nonce).GreaterThan(0);
        }
    }
}