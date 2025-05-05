using Microsoft.EntityFrameworkCore;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;
using WFClassic.Web.Logic.Admin.CheckOnline;

namespace WFClassic.Web.Logic.Taunt
{
    public class AddTauntHandler
    {

        private ApplicationDbContext _applicationDbContext;
        private ILogger<AddTauntHandler> _logger;

        public AddTauntHandler(ApplicationDbContext applicationDbContext, ILogger<AddTauntHandler> logger)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
        }

        public AddTauntResult Handle(AddTaunt addTaunt)
        {
            AddTauntResult result = new AddTauntResult();
            var validationResults = new AddTauntValidator().Validate(addTaunt);

            if (!validationResults.IsValid)
            {
                _logger.LogError("AddTauntHandler => accountId {AccountID} nonce {Nonce} => Validation failure {ValidationErrors}", addTaunt.AccountId, addTaunt.Nonce, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                result.AddTauntResultStatus = AddTauntResultStatus.ValidationErrors;
                return result;
            }

            Player player = null;

            try
            {
                _logger.LogInformation("AddTauntHandler => accountId {AccountID} nonce {Nonce} => Starting Query for player", addTaunt.AccountId, addTaunt.Nonce);

                player = _applicationDbContext.Players.Include(i => i.TauntHistoryItems).FirstOrDefault(fod => fod.ApplicationUserId == addTaunt.AccountId);

                _logger.LogInformation("AddTauntHandler => accountId {AccountID} nonce {Nonce} => Query Complete for player ", addTaunt.AccountId, addTaunt.Nonce);

            }
            catch (Exception ex)
            {
                _logger.LogError("AddTauntHandler => accountId {AccountID} nonce {Nonce} => Exception while querying for player object : {Ex}", addTaunt.AccountId, addTaunt.Nonce, ex);
                result.AddTauntResultStatus = AddTauntResultStatus.DatabaseErrors;
                return result;
            }


            if (player.TauntHistoryItems.Any(a => a.Node == addTaunt.IncomingAddTaunt.Node))
            {

                result.AddTauntResultStatus = AddTauntResultStatus.Success;
            }
            else
            {
                TauntHistoryItem tauntHistoryItem = new TauntHistoryItem()
                {
                    Node = addTaunt.IncomingAddTaunt.Node,
                    PlayerId = player.Id,
                }
                    ;

                try
                {
                    _logger.LogInformation("AddTauntHandler => accountId {AccountID} nonce {Nonce} => adding taunt history item", addTaunt.AccountId, addTaunt.Nonce);
                    _applicationDbContext.TauntHistoryItems.Add(tauntHistoryItem);
                    _applicationDbContext.SaveChanges();
                    _logger.LogInformation("AddTauntHandler => accountId {AccountID} nonce {Nonce} => taunt history item added ", addTaunt.AccountId, addTaunt.Nonce);
                    result.AddTauntResultStatus = AddTauntResultStatus.Success;

                }
                catch (Exception ex)
                {
                    _logger.LogError("AddTauntHandler => accountId {AccountID} nonce {Nonce} => Exception while adding taunt history item : {Ex}", addTaunt.AccountId, addTaunt.Nonce, ex);
                    result.AddTauntResultStatus = AddTauntResultStatus.DatabaseErrors;
                }

            }
            return result;
        }


    }
}
