using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;
using WFClassic.Web.Logic.Taunt;

namespace WFClassic.Web.Logic.UI.ListPlayers
{
    public class GetPlayerListHandler
    {

        private readonly ApplicationDbContext _applicationDbContext;
        private readonly ILogger<GetPlayerListHandler> _logger;

        public GetPlayerListHandler(ApplicationDbContext applicationDbContext, ILogger<GetPlayerListHandler> logger)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
        }

        public GetPlayerListResult Handle(GetPlayerList getPlayerList)
        {
            GetPlayerListResult result = new GetPlayerListResult();


            getPlayerList.NumberOfItemsPerPage = getPlayerList.NumberOfItemsPerPage <= 0 ? 50 : getPlayerList.NumberOfItemsPerPage;
            getPlayerList.PageNumber = getPlayerList.PageNumber <= 0 ? 1 : getPlayerList.PageNumber;

            _logger.LogInformation("GetPlayerListHandler => NumberOfItemsPerPage {NumberOfItemsPerPage}", getPlayerList.NumberOfItemsPerPage);
            _logger.LogInformation("GetPlayerListHandler => PageNumber {PageNumber}", getPlayerList.PageNumber);

            try
            {
                _logger.LogInformation("GetPlayerListHandler => Starting player query");

                result.GetPlayerListResultDetailItems = _applicationDbContext.Players
                                                    //            .OrderBy(obd => obd.ApplicationUser.DisplayName)
                                                    //     .Skip(getPlayerList.NumberOfItemsPerPage * getPlayerList.PageNumber)
                                                    //    .Take(getPlayerList.NumberOfItemsPerPage)
                                                    .Select(s => new GetPlayerListResultDetailItem()
                                                    {
                                                        Id = s.Id,
                                                        IsCurrentlyOnline = s.ApplicationUser.CurrentlyLoggedIn,
                                                        JoinedOnDate = s.CreationTimestamp.Date,
                                                        LastLoginDate = s.ApplicationUser.LastLoginTimestamp.Date,
                                                        UserName = s.ApplicationUser.DisplayName
                                                    })

                                                    .ToList()
                                                    .OrderBy(obd=> obd.JoinedOnDate);
                _logger.LogInformation("GetPlayerListHandler => Player query complete");
            }
            catch (Exception ex)
            {
                _logger.LogError("GetPlayerListHandler => Exception while querying for players {Exception}", ex);
                result.GetPlayerListResultStatus = GetPlayerListResultStatus.DatabaseErrors;
                return result;
            }

            _logger.LogInformation("GetPlayerListHandler => Found {resultCount} items", result.GetPlayerListResultDetailItems.Count());

            if (result.GetPlayerListResultDetailItems.Count() == 0 && getPlayerList.PageNumber > 1)
            {
                _logger.LogInformation("GetPlayerListHandler => Since no items were returned, decrementing page count and running query again. ");
                getPlayerList.PageNumber--;
                result = this.Handle(getPlayerList);
            }

            result.NumberOfItemsPerPage = getPlayerList.NumberOfItemsPerPage;
            result.PageNumber = getPlayerList.PageNumber;
            result.GetPlayerListResultStatus = GetPlayerListResultStatus.Success;
            return result;
        }
    }
}