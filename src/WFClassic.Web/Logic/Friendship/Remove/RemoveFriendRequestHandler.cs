using Microsoft.EntityFrameworkCore;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;

namespace WFClassic.Web.Logic.Friendship.Remove
{
    public class RemoveFriendRequestHandler
    {
        private ApplicationDbContext _applicationDbContext;
        private ILogger<RemoveFriendRequestHandler> _logger;

        public RemoveFriendRequestHandler(ApplicationDbContext applicationDbContext, ILogger<RemoveFriendRequestHandler> logger)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
        }

        public RemoveFriendResult Handle(RemoveFriendRequest removeFriendRequest)
        {
            RemoveFriendResult getFriendsResult = new RemoveFriendResult();
            var validationResults = new RemoveFriendRequestValidator().Validate(removeFriendRequest);

            if (!validationResults.IsValid)
            {
                _logger.LogError("RemoveFriendRequestHandler => accountId {AccountID} nonce {Nonce} => Validation failure {ValidationErrors}", removeFriendRequest.AccountId, removeFriendRequest.Nonce, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                getFriendsResult.RemoveFriendResultStatus = RemoveFriendResultStatus.ValidationErrors;
                return getFriendsResult;
            }

            List<FriendshipRequest> friendshipRequests = null;
            List<PersonRelationship> friends = null;

            try
            {
                _logger.LogInformation("RemoveFriendRequestHandler => accountId {AccountID} nonce {Nonce} =>  Starting friend and friend request query ", removeFriendRequest.AccountId, removeFriendRequest.Nonce);

                friendshipRequests = _applicationDbContext.FriendshipRequests
                                                                  .Where(w => (w.RequestorId == removeFriendRequest.AccountId && w.FriendId == removeFriendRequest.Friend)
                                                                                  || (w.RequestorId == removeFriendRequest.Friend && w.FriendId == removeFriendRequest.AccountId))
                                                                  .ToList();

                friends = _applicationDbContext.PersonRelationships
                                                                    .Include(i => i.Friend)
                                                                    .Where(w => ((w.UserId == removeFriendRequest.AccountId && w.FriendId == removeFriendRequest.Friend)
                                                                                  || (w.UserId == removeFriendRequest.Friend && w.FriendId == removeFriendRequest.AccountId)) && w.PersonRelationshipType == Data.Enums.PersonRelationshipType.Friend)
                                                                    .ToList();

                _logger.LogInformation("RemoveFriendRequestHandler => accountId {AccountID} nonce {Nonce} =>  Friend query complete ", removeFriendRequest.AccountId, removeFriendRequest.Nonce);
            }
            catch (Exception ex)
            {
                _logger.LogError("RemoveFriendRequestHandler => accountId {AccountID} nonce {Nonce} => Exception while searching for friends {Ex}", removeFriendRequest.AccountId, removeFriendRequest.Nonce, ex);
                getFriendsResult.RemoveFriendResultStatus = RemoveFriendResultStatus.DatabaseErrors;
                return getFriendsResult;
            }

            _logger.LogInformation("RemoveFriendRequestHandler => accountId {AccountID} nonce {Nonce} =>  Found {friendshipRequestCount} friendship requests", removeFriendRequest.AccountId, removeFriendRequest.Nonce, friendshipRequests.Count);
            _logger.LogInformation("RemoveFriendRequestHandler => accountId {AccountID} nonce {Nonce} =>  Found {friendCount} friends", removeFriendRequest.AccountId, removeFriendRequest.Nonce, friends.Count);

            try
            {
                _logger.LogInformation("RemoveFriendRequestHandler => accountId {AccountID} nonce {Nonce} => Mapping onto result object ", removeFriendRequest.AccountId, removeFriendRequest.Nonce);
                friends.ForEach(f => _applicationDbContext.Entry(f).State = EntityState.Deleted);
                friendshipRequests.ForEach(f => _applicationDbContext.Entry(f).State = EntityState.Deleted);
                _applicationDbContext.SaveChanges();
                _logger.LogInformation("RemoveFriendRequestHandler => accountId {AccountID} nonce {Nonce} => mapping complete  ", removeFriendRequest.AccountId, removeFriendRequest.Nonce);
            }
            catch (Exception ex)
            {
                _logger.LogError("RemoveFriendRequestHandler => accountId {AccountID} nonce {Nonce} => Exception while deleting friend relationships {Ex}", removeFriendRequest.AccountId, removeFriendRequest.Nonce, ex);
                getFriendsResult.RemoveFriendResultStatus = RemoveFriendResultStatus.DatabaseErrors;
            }

            return getFriendsResult;
        }

        private class QueryResultItem
        {
            public string DisplayName { get; set; }
            public Guid Id { get; set; }
        }
    }
}