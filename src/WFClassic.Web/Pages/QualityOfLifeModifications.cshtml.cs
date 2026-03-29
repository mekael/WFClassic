using System.Configuration;
using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;

using WFClassic.Web.Data.Enums;
using WFClassic.Web.Logic.Credits.Add;
using WFClassic.Web.Logic.QualityOfLife.InventoryChanges;
using WFClassic.Web.Logic.QualityOfLife.StarChart;
using WFClassic.Web.Logic.Shared;

namespace WFClassic.Web.Pages
{
    public class QualityOfLifeModificationsModel : PageModel
    {
        private readonly UnlockStarChartHandler _unlockStarChartHandler;
        private readonly AddAccountTransactionHandler _addAccountTransactionHandler;
        private readonly InventoryChangeHandler _inventoryChangeHandler;
        private readonly ServerConfiguration _serverConfiguration;
 
        public QualityOfLifeModificationsModel(UnlockStarChartHandler unlockStarChartHandler, AddAccountTransactionHandler addAccountTransactionHandler, 
            ServerConfiguration  serverConfiguration, InventoryChangeHandler inventoryChangeHandler)
        {
            this._unlockStarChartHandler = unlockStarChartHandler;
            this._addAccountTransactionHandler= addAccountTransactionHandler;
            this._inventoryChangeHandler = inventoryChangeHandler;
        }



        public IActionResult OnGet()
        {

            return this.Page();
        }


        public async Task<IActionResult> OnPostSubmitUnlockStarchartAsync()
        {

            var result = this._unlockStarChartHandler.Handle(new UnlockStarChart() { UserId = GetUserId() });

            if(result.UnlockStarChartResultStatus == UnlockStarChartResultStatus.Failure)
            {
              return   this.StatusCode(500);
            }
            else if (result.UnlockStarChartResultStatus == UnlockStarChartResultStatus.NotFound)
            {
              return   this.NotFound();
            }
            // add notification ? 
            return this.Page();
        }

        public async Task<IActionResult> OnPostAddToBankAccount(long amountToAdd, CurrencyType bankAccountType)
        {

            var result = this._addAccountTransactionHandler.Handle(new AddAccountTransaction() { Amount = amountToAdd, AccountId = GetUserId(), BankAccountTransactionType = BankAccountTransactionType.Credit, BankAccountType = bankAccountType, MemoCode = "Cheating" });

            if (result.AddAccountTransactionResultStatus == AddAccountTransactionResultStatus.Failure)
            {
                return this.StatusCode(500);
            }
           
            // add notification ? 
            return this.Page();
        }

        public async Task<IActionResult> OnPostAddPotatoes(InternalInventoryItemType internalInventoryItemType)
        {

            this._inventoryChangeHandler.AddPotatoesToInvGroup(GetUserId(), internalInventoryItemType);

            return this.Page();
        }

        public async Task<IActionResult> OnPostSetToLevel30(InternalInventoryItemType internalInventoryItemType)
        {
 
            this._inventoryChangeHandler.SetInvGroupToLevelThirty(GetUserId(), internalInventoryItemType);
            return this.Page();
        }

        public async Task<IActionResult> OnPostSetBoostersTo2035Expiry(InternalInventoryItemType internalInventoryItemType)
        {

            this._inventoryChangeHandler.SetInvGroupToLevelThirty(GetUserId(), internalInventoryItemType);
            return this.Page();
        }




        private Guid GetUserId()
        {
            return Guid.Parse(this.User.Claims.FirstOrDefault(fod => fod.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier").Value);
        }




        public override void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {
            if (!this._serverConfiguration.AllowQualityOfLifeModifications)
            {
                context.HttpContext.Response.StatusCode = StatusCodes.Status403Forbidden;
                context.HttpContext.Response.Redirect("/Identity/Account/AccessDenied");
                return;
            }
        }

    }
}
