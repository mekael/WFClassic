using FluentValidation;

namespace WFClassic.Web.Logic.Economics.Revives
{
    public class PurchaseRevivesValidator : AbstractValidator<PurchaseRevives>
    {
        public PurchaseRevivesValidator()
        {
            RuleFor(r => r.AccountId).NotEmpty();
            RuleFor(r => r.Nonce).GreaterThan(0);
            RuleFor(r => r.IncomingRefillRevivesJsonObject).NotEmpty();
            RuleFor(r => r.IncomingRefillRevivesJsonObject.Count).GreaterThan(0).Unless(u => u.IncomingRefillRevivesJsonObject == null);
            RuleFor(r => r.IncomingRefillRevivesJsonObject.SuitId).NotEmpty().Unless(u => u.IncomingRefillRevivesJsonObject == null);
        }
    }
}