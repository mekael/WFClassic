using FluentValidation;

namespace WFClassic.Web.Logic.Economics.Purchase
{
    public class PurchaseItemValidator : AbstractValidator<PurchaseItem>
    {
        public PurchaseItemValidator()
        {
            RuleFor(r => r.AccountId).NotEmpty();
            RuleFor(r => r.Nonce).GreaterThan(0);
            RuleFor(r => r.ProductName).NotEmpty();

        }
    }
}