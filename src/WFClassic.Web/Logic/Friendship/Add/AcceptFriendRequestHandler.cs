using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;

namespace WFClassic.Web.Logic.Friendship.Add
{
    public class AcceptFriendRequestHandler
    {
        private ApplicationDbContext _applicationDbContext;
        private ILogger<AcceptFriendRequestHandler> _logger;

        public AcceptFriendRequestHandler(ApplicationDbContext applicationDbContext, ILogger<AcceptFriendRequestHandler> logger)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
        }

        public AcceptFriendResult Handle(AcceptFriendRequest acceptFriendRequest)
        {
            AcceptFriendResult result = new AcceptFriendResult();

            var validationResults = new AcceptFriendRequestValidator().Validate(acceptFriendRequest);

            if (!validationResults.IsValid)
            {
                _logger.LogError("AcceptFriendRequestHandler => accountId {AccountID} nonce {Nonce} => Validation failure {ValidationErrors}", acceptFriendRequest.AccountId, acceptFriendRequest.Nonce, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                result.AcceptFriendResultStatus = AcceptFriendResultStatus.ValidationErrors;
                return result;
            }

            FriendshipRequest friendshipRequest = null;

            try
            {
                _logger.LogInformation("AcceptFriendRequestHandler => accountId {AccountID} nonce {Nonce} => Querying for friendship request for {FriendUsername}", acceptFriendRequest.AccountId, acceptFriendRequest.Nonce, acceptFriendRequest.Friend);
                friendshipRequest = _applicationDbContext.FriendshipRequests.Where(w => w.RequestorId == acceptFriendRequest.Friend && w.FriendId == acceptFriendRequest.AccountId).FirstOrDefault();
            }
            catch (Exception ex)
            {
                _logger.LogError("AcceptFriendRequestHandler => accountId {AccountID} nonce {Nonce} => Exception while querying for friendship request  {Ex}", acceptFriendRequest.AccountId, acceptFriendRequest.Nonce, ex);
                result.AcceptFriendResultStatus = AcceptFriendResultStatus.DatabaseErrors;
                return result;
            }

            if (friendshipRequest == null)
            {
                // no friendship request present.
                _logger.LogError("AcceptFriendRequestHandler => accountId {AccountID} nonce {Nonce} =>  No friendship request exists", acceptFriendRequest.AccountId, acceptFriendRequest.Nonce);
                result.AcceptFriendResultStatus = AcceptFriendResultStatus.ValidationErrors;
                return result;
            }
            _logger.LogInformation("AcceptFriendRequestHandler => accountId {AccountID} nonce {Nonce} =>  Friendship request exists. ", acceptFriendRequest.AccountId, acceptFriendRequest.Nonce);

            List<PersonRelationship> personRelationships = new List<PersonRelationship>()
            {
                    new PersonRelationship() {
                        FriendId = acceptFriendRequest.Friend,
                        UserId = acceptFriendRequest.AccountId,
                        PersonRelationshipType = Data.Enums.PersonRelationshipType.Friend
                    },
                       new PersonRelationship() {
                        FriendId = acceptFriendRequest.AccountId,
                        UserId = acceptFriendRequest.Friend,
                        PersonRelationshipType = Data.Enums.PersonRelationshipType.Friend
                    }
            }
                ;

            try
            {
                _logger.LogInformation("AcceptFriendRequestHandler => accountId {AccountID} nonce {Nonce} =>  Saving new friendship and removing request", acceptFriendRequest.AccountId, acceptFriendRequest.Nonce);
                _applicationDbContext.PersonRelationships.AddRange(personRelationships);
                _applicationDbContext.Entry(friendshipRequest).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                _applicationDbContext.SaveChanges();
                result.AcceptFriendResultStatus = AcceptFriendResultStatus.Success;
                _logger.LogInformation("AcceptFriendRequestHandler => accountId {AccountID} nonce {Nonce} =>  Created new friendship and removed request", acceptFriendRequest.AccountId, acceptFriendRequest.Nonce);
            }
            catch (Exception ex)
            {
                _logger.LogError("AcceptFriendRequestHandler => accountId {AccountID} nonce {Nonce} => Exception while creating new person relationship and removing existing pending request {Ex}", acceptFriendRequest.AccountId, acceptFriendRequest.Nonce, ex);
                result.AcceptFriendResultStatus = AcceptFriendResultStatus.DatabaseErrors;
            }
            return result;
        }
    }
}