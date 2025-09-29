using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using WFClassic.Web.Logic.UI.ListPlayers;

namespace WFClassic.Web.Pages
{
    [Authorize]

    public class PlayersModel : PageModel
    {
        private readonly GetPlayerListHandler _getPlayerListHandler;

        public PlayersModel(GetPlayerListHandler getPlayerListHandler)
        {
            _getPlayerListHandler = getPlayerListHandler;
        }

        [BindProperty]
        public IEnumerable<GetPlayerListResultDetailItem> Players { get; set; }



        public void OnGet(int numberOfItemsPerPage=50, int pageNumber=0)
        {
            var result = this._getPlayerListHandler.Handle(new GetPlayerList() { NumberOfItemsPerPage = numberOfItemsPerPage, PageNumber = pageNumber });
            if (result.GetPlayerListResultStatus != GetPlayerListResultStatus.Success)
            {
                Console.WriteLine("cats");
                this.StatusCode(500);
            }
            this.Players = result.GetPlayerListResultDetailItems;
            this.Page();
        }
    }
}
