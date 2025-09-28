using FluentValidation;

namespace WFClassic.Web.Logic.Inventory.WarframeItemAddition
{
    public class AddWarframeItemValidator : AbstractValidator<AddWarframeItem>
    {
        public AddWarframeItemValidator()
        {
            RuleFor(r => r.AccountId).NotEmpty();
            RuleFor(r => r.ItemType).NotEmpty().Unless(u => u.WarframeItemId != Guid.Empty);
        }
    }
}