using FluentValidation;

namespace WFClassic.Web.Logic.Friendship.Remove
{
    public class RemoveFriendRequestValidator : AbstractValidator<RemoveFriendRequest>
    {
        public RemoveFriendRequestValidator()
        {
            RuleFor(r => r.AccountId).NotEmpty();
            RuleFor(r => r.Nonce).GreaterThan(0);
        }
    }
}