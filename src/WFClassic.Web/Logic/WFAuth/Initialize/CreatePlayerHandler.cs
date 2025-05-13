using WFClassic.Web.Data;
using WFClassic.Web.Data.Enums;
using WFClassic.Web.Data.Models;

namespace WFClassic.Web.Logic.WFAuth.Initialize
{
    public class CreatePlayerHandler
    {
        private ApplicationDbContext _applicationDbContext;
        private ILogger<CreatePlayerHandler> _logger;

        public CreatePlayerHandler(ApplicationDbContext applicationDbContext, ILogger<CreatePlayerHandler> logger)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
        }

        public CreatePlayerResult Handle(CreatePlayer createPlayer)
        {
            CreatePlayerResult result = new CreatePlayerResult();

            var validationResults = new CreatePlayerValidator().Validate(createPlayer);

            if (!validationResults.IsValid)
            {
                _logger.LogError("CreatePlayerHandler => accountId {AccountID}  => Validation failure {ValidationErrors}", createPlayer.ApplicationUserId, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                result.CreatePlayerResultStatus = CreatePlayerResultStatus.ValidationErrors;
                return result;
            }

            _logger.LogInformation("CreatePlayerHandler => accountId {AccountID}  => Constructing player object", createPlayer.ApplicationUserId);

            Player player = new Player
            {
                ApplicationUserId = createPlayer.ApplicationUserId,
                PlayerLevel = 0,
                BankAccounts = new List<BankAccount>()
                {
                     new BankAccount()
                                        {
                                            BankAccountType = BankAccountType.Platinum,
                                            CurrentBalance = 50,
                                            BankAccountTransactions = new List<BankAccountTransaction>() {
                                                new BankAccountTransaction() {
                                                    Amount = createPlayer.PlatinumGiftAmount,
                                                    BankAccountTransactionType =BankAccountTransactionType.Credit,
                                                    MemoCode="Intial Plat Gift" } }
                                        }
                }
            };

            ;

            try
            {
                _logger.LogInformation("CreatePlayerHandler => accountId {AccountID}  => Creating player object in db", createPlayer.ApplicationUserId);
                _applicationDbContext.Add(player);
                _applicationDbContext.SaveChanges();
                _logger.LogInformation("CreatePlayerHandler => accountId {AccountID}  => Successfully created player object", createPlayer.ApplicationUserId);
                result.CreatePlayerResultStatus = CreatePlayerResultStatus.Success;
            }
            catch (Exception ex)
            {
                _logger.LogInformation("CreatePlayerHandler => accountId {AccountID}  => Exception while creating player object {Ex}", createPlayer.ApplicationUserId, ex);
                result.CreatePlayerResultStatus = CreatePlayerResultStatus.DatabaseErrors;
            }
            return result;
        }
    }
}