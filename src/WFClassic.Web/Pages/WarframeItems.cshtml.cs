using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WFClassic.Web.Logic.UI.Inventory.AddList;

namespace WFClassic.Web.Pages
{
    public class WarframeItemsModel : PageModel
    {
        private readonly GetAllWaframeItemsHandler _getAllWaframeItemsHandler;

        public WarframeItemsModel(GetAllWaframeItemsHandler getAllWaframeItemsHandler)
        {
            _getAllWaframeItemsHandler = getAllWaframeItemsHandler;
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
                .Select(item => new SelectListItem { Value = item.Id.ToString(), Text =$"({item.WarframeItemLocation}) - {item.ItemName}"  })
                .ToList();

            this.ItemNameOptions.Insert(0, new SelectListItem { Value = "", Text = "-- Select an Item --" });

 
            if (selectedItemId.HasValue && selectedItemId.Value != Guid.Empty)
            {
                this.SelectedItem = result.GetAllWarframeItemsResultDetailItems.FirstOrDefault(fod=> fod.Id == selectedItemId);
            }

            return Page();
        }
    }
}