using Microsoft.EntityFrameworkCore;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;
using WFClassic.Web.Logic.Friendship.Add;
using WFClassic.Web.Logic.Shared.Models;

namespace WFClassic.Web.Logic.Friendship.Get
{
    public class GetFriendsRequestHandler
    {

        private ApplicationDbContext _applicationDbContext;
        private ILogger<GetFriendsRequestHandler> _logger;

        public GetFriendsRequestHandler(ApplicationDbContext applicationDbContext, ILogger<GetFriendsRequestHandler> logger)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
        }


        public GetFriendsResult Handle(GetFriendsRequest getFriendsRequest)
        {
            GetFriendsResult getFriendsResult = new GetFriendsResult();
            var validationResults = new GetFriendsRequestValidator().Validate(getFriendsRequest);

            if (!validationResults.IsValid)
            {
                 _logger.LogError("GetFriendsRequestHandler => accountId {AccountID} nonce {Nonce} => Validation failure {ValidationErrors}", getFriendsRequest.AccountId, getFriendsRequest.Nonce, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                getFriendsResult.GetFriendsResultStatus = GetFriendsResultStatus.ValidationErrors;
                return getFriendsResult;
            }


            List<FriendshipRequest> friendshipRequests = null;
            List<PersonRelationship> friends = null;


            try
            {
                _logger.LogInformation("GetFriendsRequestHandler => accountId {AccountID} nonce {Nonce} =>  Starting friend and friend request query ", getFriendsRequest.AccountId, getFriendsRequest.Nonce);

                friendshipRequests =   _applicationDbContext.FriendshipRequests
                                                                  .Include(i => i.Requestor)
                                                                  .Include(i => i.Friend)
                                                                  .Where(w => w.FriendId == getFriendsRequest.AccountId || w.RequestorId == getFriendsRequest.AccountId)
                                                                  .ToList();

                friends = _applicationDbContext.PersonRelationships
                                                                    .Include(i=> i.Friend)
                                                                    .Where(w=> w.UserId == getFriendsRequest.AccountId && w.PersonRelationshipType == Data.Enums.PersonRelationshipType.Friend)
                                                                    .ToList();

                _logger.LogInformation("GetFriendsRequestHandler => accountId {AccountID} nonce {Nonce} =>  Friend query complete ", getFriendsRequest.AccountId, getFriendsRequest.Nonce);
            }
            catch (Exception ex)
            {
                _logger.LogError("GetFriendsRequestHandler => accountId {AccountID} nonce {Nonce} => Exception while searching for friends {Ex}", getFriendsRequest.AccountId, getFriendsRequest.Nonce, ex);
                getFriendsResult.GetFriendsResultStatus = GetFriendsResultStatus.DatabaseErrors;
                return getFriendsResult;
            }
            _logger.LogInformation("GetFriendsRequestHandler => accountId {AccountID} nonce {Nonce} =>  Found {friendshipRequestCount} friendship requests", getFriendsRequest.AccountId, getFriendsRequest.Nonce, friendshipRequests.Count);
            _logger.LogInformation("GetFriendsRequestHandler => accountId {AccountID} nonce {Nonce} =>  Found {friendCount} friends", getFriendsRequest.AccountId, getFriendsRequest.Nonce, friends.Count);



            try
            {
                _logger.LogInformation("GetFriendsRequestHandler => accountId {AccountID} nonce {Nonce} => Mapping onto result object ", getFriendsRequest.AccountId, getFriendsRequest.Nonce);
                getFriendsResult.JsonGetFriendsResult = new JsonGetFriendsResult()
                {
                    Current = friends.Select(s => new GetFriendsResultFriendItem() { DisplayName = s.Friend.DisplayName, id = new MongoId(s.FriendId) }).ToList(),
                    IncomingFriendRequests = friendshipRequests.Where(w => w.FriendId == getFriendsRequest.AccountId).Select(s => new GetFriendsResultFriendItem() { DisplayName = s.Requestor.DisplayName, id = new MongoId(s.RequestorId) }).ToList(),
                    OutgoingFriendRequests = friendshipRequests.Where(w => w.RequestorId == getFriendsRequest.AccountId).Select(s => new GetFriendsResultFriendItem() { DisplayName = s.Friend.DisplayName, id = new MongoId(s.FriendId) }).ToList(),
                };

                getFriendsResult.GetFriendsResultStatus = GetFriendsResultStatus.Success;
                _logger.LogInformation("GetFriendsRequestHandler => accountId {AccountID} nonce {Nonce} => mapping complete  ", getFriendsRequest.AccountId, getFriendsRequest.Nonce);
            }
            catch (Exception ex)
            {
                _logger.LogError("GetFriendsRequestHandler => accountId {AccountID} nonce {Nonce} => Exception while mapping friends onto return object {Ex}", getFriendsRequest.AccountId, getFriendsRequest.Nonce, ex);
                getFriendsResult.GetFriendsResultStatus = GetFriendsResultStatus.MappingFailure;
            }
           
            return getFriendsResult;
        }


        class QueryResultItem
        {
            public string DisplayName { get; set; }
            public Guid Id { get; set; }
        }
    }
}
