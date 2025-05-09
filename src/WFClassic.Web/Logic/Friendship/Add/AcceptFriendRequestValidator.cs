using FluentValidation;

namespace WFClassic.Web.Logic.Friendship.Add
{
    public class AcceptFriendRequestValidator : AbstractValidator<AcceptFriendRequest>    
    {
        public AcceptFriendRequestValidator()
        {
            RuleFor(r=> r.AccountId).NotEmpty();
            RuleFor(r=> r.Nonce).GreaterThan(0);
            RuleFor(r=> r.Friend).NotEmpty();
        }
    }
}
