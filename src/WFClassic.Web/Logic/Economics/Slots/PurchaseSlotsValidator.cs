using FluentValidation;

namespace WFClassic.Web.Logic.Economics.Slots
{
    public class PurchaseSlotsValidator : AbstractValidator<PurchaseSlots>
    {
        public PurchaseSlotsValidator()
        {
            RuleFor(r => r.AccountId).NotEmpty();
            RuleFor(r => r.Nonce).GreaterThan(0);
            RuleFor(r => r.IncomingPurchaseSlotsJsonObject).NotEmpty();

        }
    }
}