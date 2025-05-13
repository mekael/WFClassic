using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;
using WFClassic.Web.Logic.Shared.Models;

namespace WFClassic.Web.Logic.Exp.Training
{
    public class AddLevelBasedOnTrainingHandler
    {
        private ApplicationDbContext _applicationDbContext;
        private ILogger<AddLevelBasedOnTrainingHandler> _logger;

        public AddLevelBasedOnTrainingHandler(ApplicationDbContext applicationDbContext, ILogger<AddLevelBasedOnTrainingHandler> logger)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
        }

        public AddLevelBasedOnTrainingResult Handle(AddLevelBasedOnTraining addLevelBasedOnTraining)
        {
            AddLevelBasedOnTrainingResult result = new AddLevelBasedOnTrainingResult();

            var validationResults = new AddLevelBasedOnTrainingValidator().Validate(addLevelBasedOnTraining);

            if (!validationResults.IsValid)
            {
                _logger.LogError("AddLevelBasedOnTrainingHandler => accountId {AccountID} nonce {Nonce} => Validation failure {ValidationErrors}", addLevelBasedOnTraining.AccountId, addLevelBasedOnTraining.Nonce, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                result.AddLevelBasedOnTrainingResultStatus = AddLevelBasedOnTrainingResultStatus.ValidationErrors;
                return result;
            }

            Player player = null;

            _logger.LogInformation("AddLevelBasedOnTrainingHandler => accountId {AccountID} nonce {Nonce} =>  ", addLevelBasedOnTraining.AccountId, addLevelBasedOnTraining.Nonce);

            try
            {
                _logger.LogInformation("AddLevelBasedOnTrainingHandler => accountId {AccountID} nonce {Nonce} =>  Searching for player record", addLevelBasedOnTraining.AccountId, addLevelBasedOnTraining.Nonce);
                player = _applicationDbContext.Players.FirstOrDefault(f => f.ApplicationUserId == addLevelBasedOnTraining.AccountId);
                _logger.LogInformation("AddLevelBasedOnTrainingHandler => accountId {AccountID} nonce {Nonce} =>   Completed search for player record", addLevelBasedOnTraining.AccountId, addLevelBasedOnTraining.Nonce);
            }
            catch (Exception ex)
            {
                _logger.LogError("AddLevelBasedOnTrainingHandler => accountId {AccountID} nonce {Nonce} => Exception searching for player record {Ex}", addLevelBasedOnTraining.AccountId, addLevelBasedOnTraining.Nonce, ex);
                result.AddLevelBasedOnTrainingResultStatus = AddLevelBasedOnTrainingResultStatus.DatabaseErrors;
            }

            if (player == null)
            {
            }

            _logger.LogInformation("AddLevelBasedOnTrainingHandler => accountId {AccountID} nonce {Nonce} => Current Player Level {Level} ", addLevelBasedOnTraining.AccountId, addLevelBasedOnTraining.Nonce, player.PlayerLevel);
            // Number of levels gained is always 0 for some reason in the older version
            //TODO: Add in a bugfix for this?
            player.PlayerLevel += addLevelBasedOnTraining.NumLevelsGained;
            player.TrainingDate = DateTime.Now;
            _logger.LogInformation("AddLevelBasedOnTrainingHandler => accountId {AccountID} nonce {Nonce} => New Player Level {Level} ", addLevelBasedOnTraining.AccountId, addLevelBasedOnTraining.Nonce, player.PlayerLevel);

            try
            {
                _logger.LogInformation("AddLevelBasedOnTrainingHandler => accountId {AccountID} nonce {Nonce} => Updating player record ", addLevelBasedOnTraining.AccountId, addLevelBasedOnTraining.Nonce);
                _applicationDbContext.Entry(player).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _applicationDbContext.SaveChanges();
                _logger.LogInformation("AddLevelBasedOnTrainingHandler => accountId {AccountID} nonce {Nonce} =>  Player record updated", addLevelBasedOnTraining.AccountId, addLevelBasedOnTraining.Nonce);
            }
            catch (Exception ex)
            {
                _logger.LogError("AddLevelBasedOnTrainingHandler => accountId {AccountID} nonce {Nonce} => Exception while updating player {ex}", addLevelBasedOnTraining.AccountId, addLevelBasedOnTraining.Nonce, ex);
                result.AddLevelBasedOnTrainingResultStatus = AddLevelBasedOnTrainingResultStatus.DatabaseErrors;
            }

            result.NewTrainingDate = new MongoDate(player.TrainingDate);
            result.NewLevel = player.PlayerLevel;

            return result;
        }
    }
}