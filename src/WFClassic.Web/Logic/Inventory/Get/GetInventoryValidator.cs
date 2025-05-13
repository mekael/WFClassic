using FluentValidation;

namespace WFClassic.Web.Logic.Inventory.Get
{
    public class GetInventoryValidator : AbstractValidator<GetInventory>
    {
        public GetInventoryValidator()
        {
            RuleFor(r => r.AccountId).NotEmpty();
            RuleFor(r => r.Nonce).GreaterThan(0);
        }
    }
}