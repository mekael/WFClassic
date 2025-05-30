using FluentValidation;

namespace WFClassic.Web.Logic.Credits.Add
{
    public class AddAccountTransactionValidator : AbstractValidator<AddAccountTransaction>
    {
        public AddAccountTransactionValidator()
        {
            RuleFor(r => r.AccountId).NotEmpty();
        }
    }
}