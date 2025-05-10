using Microsoft.EntityFrameworkCore;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;

namespace WFClassic.Web.Logic.Credits.Add
{
    public class AddAccountTransactionHandler
    {
        private ApplicationDbContext _applicationDbContext;
        private ILogger<AddAccountTransactionHandler> _logger;

        public AddAccountTransactionHandler(ApplicationDbContext applicationDbContext, ILogger<AddAccountTransactionHandler> logger)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
        }

        public AddAccountTransactionResult Handle(AddAccountTransaction addAccountTransaction)
        {
            AddAccountTransactionResult result = new AddAccountTransactionResult();

            var validationResults = new AddAccountTransactionValidator().Validate(addAccountTransaction);

            if (!validationResults.IsValid)
            {
                _logger.LogError("AddAccountTransactionHandler => accountId {AccountID}  => Validation failure {ValidationErrors}", addAccountTransaction.AccountId, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                result.AddAccountTransactionResultStatus = AddAccountTransactionResultStatus.ValidationErrors;
                return result;
            }

 

            Player player = null;


            try 
            {
                _logger.LogInformation("AddAccountTransactionHandler => accountId {AccountID}  => Querying for player with bank accounts", addAccountTransaction.AccountId);
                player = _applicationDbContext.Players.Include(i=> i.BankAccounts)
                                                          .ThenInclude(ti=> ti.BankAccountTransactions)
                                                          .FirstOrDefault(fod=> fod.ApplicationUserId == addAccountTransaction.AccountId);
                _logger.LogInformation("AddAccountTransactionHandler => accountId {AccountID}  => Querying for player with bank accounts complete ", addAccountTransaction.AccountId);

            }
            catch (Exception ex)
            {
                _logger.LogError("AddAccountTransactionHandler => accountId {AccountID}  => Exception while querying for bank accounts {Ex}", addAccountTransaction.AccountId, ex);
                result.AddAccountTransactionResultStatus = AddAccountTransactionResultStatus.Failure;
                return result;
            }

            BankAccount bankAccount = player.BankAccounts.FirstOrDefault(fod => fod.BankAccountType == addAccountTransaction.BankAccountType);

            if (bankAccount == null)
            {
                _logger.LogInformation("AddAccountTransactionHandler => accountId {AccountID}  => Account not found for credit type, adding new bank account", addAccountTransaction.AccountId);
                bankAccount = new BankAccount()

                { 
                PlayerId = player.Id,
                BankAccountType = addAccountTransaction.BankAccountType,
                BankAccountTransactions = new List<BankAccountTransaction>()
                }; 
                
                try 
                {
                    _logger.LogInformation("AddAccountTransactionHandler => accountId {AccountID}  => Creating new account", addAccountTransaction.AccountId);
                    _applicationDbContext.BankAccounts.Add(bankAccount);
                    _applicationDbContext.SaveChanges();
                    _logger.LogInformation("AddAccountTransactionHandler => accountId {AccountID}  => Bank account created", addAccountTransaction.AccountId);
                }
                catch (Exception ex)
                {
                    _logger.LogError("AddAccountTransactionHandler => accountId {AccountID}  => Exception while creating new bank account {Ex}", addAccountTransaction.AccountId, ex);
                    result.AddAccountTransactionResultStatus = AddAccountTransactionResultStatus.Failure;
                    return result;
                }
            }


            bankAccount.CurrentBalance += addAccountTransaction.Amount;
            bankAccount.BankAccountTransactions.Add(  
                new BankAccountTransaction()
                {
                    Amount= addAccountTransaction.Amount, 
                    MemoCode= addAccountTransaction.MemoCode,
                    BankAccountTransactionType = addAccountTransaction.BankAccountTransactionType
                }
                );


            try 
            {
                _logger.LogInformation("AddAccountTransactionHandler => accountId {AccountID}  => Saving new transaction", addAccountTransaction.AccountId);
                _applicationDbContext.Entry(bankAccount).State = EntityState.Modified;
                _applicationDbContext.SaveChanges();
                result.AddAccountTransactionResultStatus = AddAccountTransactionResultStatus.Success;
                _logger.LogInformation("AddAccountTransactionHandler => accountId {AccountID}  => New transaction saved", addAccountTransaction.AccountId);

            }
            catch (Exception ex)
            {
                _logger.LogError("AddAccountTransactionHandler => accountId {AccountID}  => Exception while saving new transaction {Ex}", addAccountTransaction.AccountId, ex);
                result.AddAccountTransactionResultStatus = AddAccountTransactionResultStatus.Failure;
            }


            return result;
        }
    }
}
