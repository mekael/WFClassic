using FluentValidation;

namespace WFClassic.Web.Logic.Friendship.Get
{
    public class GetFriendsRequestValidator : AbstractValidator<GetFriendsRequest>    
    {
        public GetFriendsRequestValidator()
        {
            RuleFor(r=> r.AccountId).NotEmpty();
            RuleFor(r=> r.Nonce).GreaterThan(0);
        }
    }
}
