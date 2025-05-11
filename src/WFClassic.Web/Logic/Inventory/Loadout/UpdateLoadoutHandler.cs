using Microsoft.EntityFrameworkCore;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;
using WFClassic.Web.Logic.Inventory.Loadout;

namespace WFClassic.Web.Logic.Inventory.Get
{
    public class UpdateLoadoutHandler
    {

        private ApplicationDbContext _applicationDbContext;
        private ILogger<UpdateLoadoutHandler> _logger;
 
        public UpdateLoadoutHandler(ApplicationDbContext applicationDbContext, ILogger<UpdateLoadoutHandler> logger)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
         }

        public UpdateLoadoutResult Handle(UpdateLoadout updateLoadout)
        {
            UpdateLoadoutResult result = new UpdateLoadoutResult();
            var validationResults = new UpdateLoadoutValidator().Validate(updateLoadout);

            if (!validationResults.IsValid)
            {
                _logger.LogError("UpdateLoadoutHandler => accountId {AccountID} nonce {Nonce} => Validation failure {ValidationErrors}", updateLoadout.AccountId, updateLoadout.Nonce, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                result.UpdateLoadoutResultStatus = UpdateLoadoutResultStatus.ValidationErrors;
                return result;
            }

            Player player = null;
   
            try
            {
                _logger.LogInformation("UpdateLoadoutHandler => accountId {AccountID} nonce {Nonce} => Starting Query for player", updateLoadout.AccountId, updateLoadout.Nonce);
                player = _applicationDbContext.Players.First(w => w.ApplicationUserId == updateLoadout.AccountId);
                result.UpdateLoadoutResultStatus = UpdateLoadoutResultStatus.Success;

                _logger.LogInformation("UpdateLoadoutHandler => accountId {AccountID} nonce {Nonce} => Query Complete for player ", updateLoadout.AccountId, updateLoadout.Nonce);

            }
            catch (Exception ex)
            {
                _logger.LogError("UpdateLoadoutHandler => accountId {AccountID} nonce {Nonce} => Exception while querying for player object : {Ex}", updateLoadout.AccountId, updateLoadout.Nonce, ex);
                result.UpdateLoadoutResultStatus = UpdateLoadoutResultStatus.DatabaseErrors;
                return result;
            }

 
            try
            {
                player.CurrentLoadout = updateLoadout.LoadoutState;
                _applicationDbContext.Entry(player).State = EntityState.Modified;
                _applicationDbContext.SaveChanges();
                result.UpdateLoadoutResultStatus = UpdateLoadoutResultStatus.Success;

            }
            catch (Exception ex)
            {
                _logger.LogError("UpdateLoadoutHandler => accountId {AccountID} nonce {Nonce} => Exception while updating player object : {Ex}", updateLoadout.AccountId, updateLoadout.Nonce, ex);
                result.UpdateLoadoutResultStatus = UpdateLoadoutResultStatus.DatabaseErrors;
            }

            return result;
        }

    }
}
