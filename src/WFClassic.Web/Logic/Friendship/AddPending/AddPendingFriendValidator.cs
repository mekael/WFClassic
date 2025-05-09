using FluentValidation;

namespace WFClassic.Web.Logic.Friendship.AddPending
{
    public class AddPendingFriendValidator : AbstractValidator<AddPendingFriend>    
    {
        public AddPendingFriendValidator()
        {
            RuleFor(r=> r.AccountId).NotEmpty();
            RuleFor(r=> r.Nonce).GreaterThan(0);
            RuleFor(r=> r.Friend).NotEmpty();
        }
    }
}
