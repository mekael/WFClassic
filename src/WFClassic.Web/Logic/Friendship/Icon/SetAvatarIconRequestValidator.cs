using FluentValidation;

namespace WFClassic.Web.Logic.Friendship.Icon
{
    public class SetAvatarIconRequestValidator : AbstractValidator<SetAvatarIconRequest>
    {
        public SetAvatarIconRequestValidator()
        {
            RuleFor(r => r.AccountId).NotEmpty();
            RuleFor(r => r.Nonce).GreaterThan(0);
            RuleFor(r => r.AvatarImage).NotEmpty();
            RuleFor(r => r.AvatarImageType).NotEmpty();
        }
    }
}