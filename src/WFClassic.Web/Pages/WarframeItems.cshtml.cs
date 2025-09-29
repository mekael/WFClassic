using System.Security.Claims;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WFClassic.Web.Logic.Inventory.WarframeItemAddition;
using WFClassic.Web.Logic.UI.Inventory.AddList;

namespace WFClassic.Web.Pages
{
    [Authorize]

    public class WarframeItemsModel : PageModel
    {
        private readonly GetAllWarframeItemsHandler _getAllWaframeItemsHandler;

        private readonly AddWarframeItemHandler _addWarframeItemHandler;

        public WarframeItemsModel(GetAllWarframeItemsHandler getAllWaframeItemsHandler, AddWarframeItemHandler addWarframeItemHandler)
        {
            _getAllWaframeItemsHandler = getAllWaframeItemsHandler;
            this._addWarframeItemHandler = addWarframeItemHandler;
        }
        [BindProperty]
        public List<SelectListItem> ItemNameOptions { get; set; } = new List<SelectListItem>();

        [BindProperty(SupportsGet = true)]
        public Guid SelectedItemId { get; set; }

        [BindProperty]
        public GetAllWarframeItemsResultDetailItem SelectedItem { get; set; }

        public IActionResult OnGet(Guid? selectedItemId = null)
        {
            var result = this._getAllWaframeItemsHandler.Handle();
            if (result.GetAllWaframeItemsResultStatus != GetAllWarframeItemsResultStatus.Success)
            {
                return StatusCode(500);
            }

            this.ItemNameOptions = result.GetAllWarframeItemsResultDetailItems
                .Select(item => new SelectListItem { Value = item.Id.ToString(), Text = $"({item.WarframeItemLocation}) - {item.ItemName}" })
                .ToList();

            this.ItemNameOptions.Insert(0, new SelectListItem { Value = "", Text = "-- Select an Item --" });


            if (selectedItemId.HasValue && selectedItemId.Value != Guid.Empty)
            {
                this.SelectedItem = result.GetAllWarframeItemsResultDetailItems.FirstOrDefault(fod => fod.Id == selectedItemId);
            }

            return Page();
        }

        public IActionResult OnPost(Guid itemToAddId)
        {
            var userId = Guid.Parse(this.User.Claims.FirstOrDefault(fod => fod.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier").Value);

            AddWarframeItem addWarframeItem = new AddWarframeItem()
            {
                AccountId = userId,
                WarframeItemId = itemToAddId,
            };

            var result = this._addWarframeItemHandler.Handle(addWarframeItem);

            if (result.AddWarframeItemResultStatus == AddWarframeItemResultStatus.ValidationErrors)
            {
                return this.BadRequest();
            }
            else if (result.AddWarframeItemResultStatus == AddWarframeItemResultStatus.DatabaseErrors)
            {
                return this.StatusCode(500);
            }
            //TODO: redirect to the player's inventory rather than the item page. 
            // that's a pain, but it would be a good way to show that the item was truly added. 
            // also cats.
            return this.RedirectToPage(new { selectedItemId = itemToAddId });

        }
    }
}