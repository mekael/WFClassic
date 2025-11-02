using Microsoft.EntityFrameworkCore;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;
using WFClassic.Web.Logic.Shared;

namespace WFClassic.Web.Logic.QualityOfLife.StarChart;

public class UnlockStarChartHandler
{

    private readonly ApplicationDbContext _applicationDbContext;
    private readonly ILogger<UnlockStarChartHandler> _logger;
    private readonly WFClassicAdditionalData _wfClassicAdditionalData;

    public UnlockStarChartHandler(ApplicationDbContext applicationDbContext, ILogger<UnlockStarChartHandler> logger, WFClassicAdditionalData wfClassicAdditionalData)
    {
        this._logger = logger;
        this._applicationDbContext = applicationDbContext;
        this._wfClassicAdditionalData = wfClassicAdditionalData;
    }

    public UnlockStarChartResult Handle(UnlockStarChart unlockStarChart)
    {
        UnlockStarChartResult result = new UnlockStarChartResult();
        Player player = null;

        try
        {
            this._logger.LogInformation("{ClassName} => userId {UserId} => Searching for player ", this.GetType().Name, unlockStarChart.UserId);
            player = this._applicationDbContext.Players.Include(i => i.Missions).FirstOrDefault(fod => fod.ApplicationUserId == unlockStarChart.UserId);
            this._logger.LogInformation("{ClassName} => userId {UserId} =>  Player Query Complete", this.GetType().Name, unlockStarChart.UserId);
        }
        catch (Exception ex)
        {
            this._logger.LogError("{ClassName} => userId {UserId} => Exception while searching for player {Exception}", this.GetType().Name, unlockStarChart.UserId, ex);
            result.UnlockStarChartResultStatus = UnlockStarChartResultStatus.Failure;
            return result;
        }

        if (player == null)
        {
            this._logger.LogInformation("{ClassName} => userId {UserId} => No player object found for given id.", this.GetType().Name, unlockStarChart.UserId);
            result.UnlockStarChartResultStatus = UnlockStarChartResultStatus.NotFound;
            return result;
        }

        List<Mission> missionsToAdd = this._wfClassicAdditionalData.NodeDefinitions.Where(w => !player.Missions.Select(s => s.Tag).Contains(w.Node))
                                                                                   .Select(s => new Mission()
                                                                                   {
                                                                                       Tag = s.Node,
                                                                                       BestRatings = .2f,
                                                                                       Completes = 1,
                                                                                       PlayerId = player.Id
                                                                                   }
                                                                                          )
                                                                                   .ToList();

        if (missionsToAdd.Count == 0)
        {
            this._logger.LogInformation("{ClassName} => userId {UserId} => Player has already unlocked the starchart, returning g2g ", this.GetType().Name, unlockStarChart.UserId);
            result.UnlockStarChartResultStatus = UnlockStarChartResultStatus.Success;
            return result;
        }

        try
        {
            this._logger.LogInformation("{ClassName} => userId {UserId} => Updating player missions", this.GetType().Name, unlockStarChart.UserId);
            this._applicationDbContext.Missions.AddRange(missionsToAdd);
            this._applicationDbContext.SaveChanges();
            this._logger.LogInformation("{ClassName} => userId {UserId} => player missions updated", this.GetType().Name, unlockStarChart.UserId);
            result.UnlockStarChartResultStatus = UnlockStarChartResultStatus.Success;
        }
        catch (Exception ex)
        {
            this._logger.LogError("{ClassName} => userId {UserId} => Exception while updating missions {Exception}", this.GetType().Name, unlockStarChart.UserId, ex);
            result.UnlockStarChartResultStatus = UnlockStarChartResultStatus.Failure;
        }
        return result;
    }
}
