using WFClassic.Web.Data;

namespace WFClassic.Web.Logic.Friendship.AddPending
{
    public class AddPendingFriendHandler
    {
        private ApplicationDbContext _applicationDbContext;
        private ILogger<AddPendingFriendHandler> _logger;

        public AddPendingFriendHandler(ApplicationDbContext applicationDbContext, ILogger<AddPendingFriendHandler> logger)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
        }

        public AddPendingFriendResult Handle(AddPendingFriend addPendingFriend)
        {
            AddPendingFriendResult result = new AddPendingFriendResult();

            var validationResults = new AddPendingFriendValidator().Validate(addPendingFriend);

            if (!validationResults.IsValid)
            {
                _logger.LogError("AddPendingFriendHandler => accountId {AccountID} nonce {Nonce} => Validation failure {ValidationErrors}", addPendingFriend.AccountId, addPendingFriend.Nonce, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                result.AddPendingFriendResultStatus = AddPendingFriendResultStatus.ValidationErrors;
                return result;
            }

            // check to see if the other user exists.

            Guid playerId = Guid.Empty;
            bool requestAlreadyServiced = false;
            Guid friendUserId = Guid.Empty;

            try
            {
                _logger.LogInformation("AddPendingFriendHandler => accountId {AccountID} nonce {Nonce} => Querying for friend {FriendUsername}", addPendingFriend.AccountId, addPendingFriend.Nonce, addPendingFriend.Friend);
                friendUserId = _applicationDbContext.Users.Where(w => w.DisplayName == addPendingFriend.Friend).Select(s => s.Id).FirstOrDefault();
                requestAlreadyServiced = _applicationDbContext.FriendshipRequests.Any(w => ((w.RequestorId == addPendingFriend.AccountId && w.FriendId == friendUserId) ||
                (w.FriendId == addPendingFriend.AccountId && w.RequestorId == friendUserId)) && w.RequestAcceptedOrDeclinedOn.HasValue);
            }
            catch (Exception ex)
            {
                _logger.LogError("AddPendingFriendHandler => accountId {AccountID} nonce {Nonce} =>  {Ex}", addPendingFriend.AccountId, addPendingFriend.Nonce, ex);
                result.AddPendingFriendResultStatus = AddPendingFriendResultStatus.DatabaseErrors;
                return result;
            }

            _logger.LogInformation("AddPendingFriendHandler => accountId {AccountID} nonce {Nonce} => Query complete", addPendingFriend.AccountId, addPendingFriend.Nonce);

            if (friendUserId == Guid.Empty)
            {
                _logger.LogError("AddPendingFriendHandler => accountId {AccountID} nonce {Nonce} => {FriendName} does not exist  ", addPendingFriend.AccountId, addPendingFriend.Nonce, addPendingFriend.Friend);
                result.AddPendingFriendResultStatus = AddPendingFriendResultStatus.ValidationErrors;
                return result;
            }
            else if (requestAlreadyServiced)
            {
                _logger.LogError("AddPendingFriendHandler => accountId {AccountID} nonce {Nonce} => {FriendUsername} is already a friend", addPendingFriend.AccountId, addPendingFriend.Nonce, addPendingFriend.Friend);
                result.AddPendingFriendResultStatus = AddPendingFriendResultStatus.ValidationErrors;
                return result;
            }

            _logger.LogInformation("AddPendingFriendHandler => accountId {AccountID} nonce {Nonce} => Found friend {FriendUsername} with id {FriendId}", addPendingFriend.AccountId, addPendingFriend.Nonce, addPendingFriend.Friend, friendUserId);

            Data.Models.FriendshipRequest friendshipRequest = new Data.Models.FriendshipRequest()
            {
                RequestorId = addPendingFriend.AccountId,
                FriendId = friendUserId
            };

            try
            {
                _logger.LogInformation("AddPendingFriendHandler => accountId {AccountID} nonce {Nonce} => Creating new request for {FriendUsername} with id {FriendId}", addPendingFriend.AccountId, addPendingFriend.Nonce, addPendingFriend.Friend, friendUserId);
                _applicationDbContext.FriendshipRequests.Add(friendshipRequest);
                _applicationDbContext.SaveChanges();
                result.AddPendingFriendResultStatus = AddPendingFriendResultStatus.Success;
            }
            catch (Exception ex)
            {
                _logger.LogInformation("AddPendingFriendHandler => accountId {AccountID} nonce {Nonce} => Error while saving new request for {FriendUsername} with id {FriendId} : {Ex}", addPendingFriend.AccountId, addPendingFriend.Nonce, addPendingFriend.Friend, friendUserId, ex);
                result.AddPendingFriendResultStatus = AddPendingFriendResultStatus.DatabaseErrors;
            }

            return result;
        }
    }
}