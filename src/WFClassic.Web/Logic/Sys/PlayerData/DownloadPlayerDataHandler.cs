using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

using Coravel.Invocable;

using Microsoft.EntityFrameworkCore;

using WFClassic.Web.Data;
using WFClassic.Web.Data.Enums;
using WFClassic.Web.Data.Models;

namespace WFClassic.Web.Logic.Sys.PlayerData
{
    public class DownloadPlayerDataHandler
    {

        private readonly ApplicationDbContext _applicationDbContext;
        private readonly ILogger<DownloadPlayerDataHandler> _logger;


        public DownloadPlayerDataHandler(ApplicationDbContext applicationDbContext, ILogger<DownloadPlayerDataHandler> logger)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
        }
        public DownloadPlayerDataResult Handle(DownloadPlayerData downloadPlayerData)
        {
            DownloadPlayerDataResult downloadPlayerDataResult = new DownloadPlayerDataResult();
            _logger.LogInformation("DownloadPlayerDataHandler => userId {UserId} => ", downloadPlayerData.ApplicationUserId);

            if (downloadPlayerData.ApplicationUserId == Guid.Empty)
            {
                _logger.LogError("DownloadPlayerDataHandler => userId {UserId} => No userId provided", downloadPlayerData.ApplicationUserId);
                downloadPlayerDataResult.DownloadPlayerDataResultStatus = DownloadPlayerDataResultStatus.ValidationErrors;
                return downloadPlayerDataResult;
            }

            Player player = null;

            try
            {
                _logger.LogInformation("DownloadPlayerDataHandler => userId {UserId} => Querying for player data", downloadPlayerData.ApplicationUserId);
                player = _applicationDbContext.Players
                                                  .Include(i => i.InventoryItems)
                                                  .Include(i => i.InventoryBins)
                                                  .Include(i => i.Missions)
                                                  .Include(i => i.TauntHistoryItems)
                                                  .Include(i => i.BankAccounts)
                                                  .AsSplitQuery()
                                                  .FirstOrDefault(w => w.ApplicationUserId == downloadPlayerData.ApplicationUserId);
                _logger.LogInformation("DownloadPlayerDataHandler => userId {UserId} => Player query completed", downloadPlayerData.ApplicationUserId);
            }
            catch (Exception ex)
            {
                _logger.LogError("DownloadPlayerDataHandler => userId {UserId} => Error while querying for player data {Ex}", downloadPlayerData.ApplicationUserId, ex);
                downloadPlayerDataResult.DownloadPlayerDataResultStatus = DownloadPlayerDataResultStatus.ServerError;
                return downloadPlayerDataResult;
            }

            if (player == null)
            {
                _logger.LogError("DownloadPlayerDataHandler => userId {UserId} => No player found", downloadPlayerData.ApplicationUserId);
                downloadPlayerDataResult.DownloadPlayerDataResultStatus = DownloadPlayerDataResultStatus.ValidationErrors;
                return downloadPlayerDataResult;
            }

            try
            {
                _logger.LogInformation("DownloadPlayerDataHandler => userId {UserId} => Generating json ", downloadPlayerData.ApplicationUserId);
                downloadPlayerDataResult.JsonFile = JsonSerializer.SerializeToUtf8Bytes(player, new JsonSerializerOptions()
                {
                    ReferenceHandler = ReferenceHandler.IgnoreCycles,
                    WriteIndented = true
                }
);
                downloadPlayerDataResult.FileName = $"{DateTime.Now.ToString("yyyyMMdd")}.{player.Id}.json";
                downloadPlayerDataResult.DownloadPlayerDataResultStatus = DownloadPlayerDataResultStatus.Succsss;
                _logger.LogInformation("DownloadPlayerDataHandler => userId {UserId} => Json generation complete", downloadPlayerData.ApplicationUserId);
            }
            catch (Exception ex)
            {
                _logger.LogError("DownloadPlayerDataHandler => userId {UserId} => Exception while generating json {Ex}", downloadPlayerData.ApplicationUserId, ex);
                downloadPlayerDataResult.DownloadPlayerDataResultStatus = DownloadPlayerDataResultStatus.ServerError;
            }
            return downloadPlayerDataResult;
        }
    }
}