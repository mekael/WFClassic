using Microsoft.EntityFrameworkCore;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;

namespace WFClassic.Web.Logic.Credits.Get
{
    public class GetCreditsHandler
    {
        private ApplicationDbContext _applicationDbContext;
        private ILogger<GetCreditsHandler> _logger;

        public GetCreditsHandler(ApplicationDbContext applicationDbContext, ILogger<GetCreditsHandler> logger)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
        }

        public GetCreditsResult Handle(GetCredits getCredits)
        {
            GetCreditsResult result = new GetCreditsResult();

            var validationResults = new GetCreditsValidator().Validate(getCredits);

            if (!validationResults.IsValid)
            {
                _logger.LogError("GetCreditsHandler => accountId {AccountID} nonce {Nonce} => Validation failure {ValidationErrors}", getCredits.AccountId, getCredits.Nonce, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                result.GetCreditsResultStatus = GetCreditsResultStatus.ValidationErrors;
                return result;
            }

            List<BankAccount> bankAccounts = null;
            try
            {
                _logger.LogInformation("GetCreditsHandler => accountId {AccountID} nonce {Nonce} => Querying for bank accounts", getCredits.AccountId, getCredits.Nonce);
                bankAccounts = _applicationDbContext.BankAccounts.Include(i => i.Player).Where(w => w.Player.ApplicationUserId == getCredits.AccountId).ToList();
                _logger.LogInformation("GetCreditsHandler => accountId {AccountID} nonce {Nonce} => Query completed", getCredits.AccountId, getCredits.Nonce);
            }
            catch (Exception ex)
            {
                _logger.LogError("GetCreditsHandler => accountId {AccountID} nonce {Nonce} => Exception while querying for bank accounts {Ex}", getCredits.AccountId, getCredits.Nonce, ex);
                result.GetCreditsResultStatus = GetCreditsResultStatus.Failure;
                return result;
            }

            //TODO :Figure out if we want throw an error or not,if we dont get back both types of account.

            var regularCredits = bankAccounts.FirstOrDefault(fod => fod.BankAccountType == Data.Enums.CurrencyType.StandardCredits)?.CurrentBalance;
            var premiumCredits = bankAccounts.FirstOrDefault(fod => fod.BankAccountType == Data.Enums.CurrencyType.Platinum)?.CurrentBalance;

            result.GetCreditsResultDetails = new GetCreditsResultDetails()
            {
                RegularCredits = regularCredits.HasValue ? regularCredits.Value : 0,
                PremiumCredits = premiumCredits.HasValue ? premiumCredits.Value : 0
            };
            result.GetCreditsResultStatus = GetCreditsResultStatus.Success;

            return result;
        }
    }
}