using Coravel.Invocable;
using Microsoft.EntityFrameworkCore;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Enums;

namespace WFClassic.Web.Logic.Sys.Scheduled
{
    public class ResetWarframeRevivesHandler :IInvocable, IInvocableWithPayload<ResetWarframeRevives>
    {

        private ApplicationDbContext _applicationDbContext;
        private ILogger<ResetWarframeRevivesHandler> _logger;

        public ResetWarframeRevives  Payload { get; set; }

        public ResetWarframeRevivesHandler(ApplicationDbContext applicationDbContext, ILogger<ResetWarframeRevivesHandler> logger)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
        }


        public async Task Invoke()
        {
            this.Handle(this.Payload);
        }


        public void Handle(ResetWarframeRevives resetWarframeRevives)
        {
            // check to see when we last reset revives. 
            // if we've already reset them today, then leave early unless resetRegardless is true
            //   update all suits, regardless of player status to have 4 revives if currently less than 4. 

            DateTimeOffset lastReviveResetDate = DateTimeOffset.MinValue;

            try 
            {
                _logger.LogInformation("ResetWarframeRevives => resetReason {ResetReason} => Searching for last successful reset ", resetWarframeRevives.ResetReason);
                lastReviveResetDate = _applicationDbContext.SystemTaskHistory
                                                                            .Where(w => w.SystemTaskType == SystemTaskType.ResetRevives && w.TaskWasSuccessful)
                                                                            .Max(md => md.TaskExecutionTimestamp);
                _logger.LogInformation("ResetWarframeRevives => resetReason {ResetReason} =>  Reset timestamp obtained", resetWarframeRevives.ResetReason);
            }
            catch(Exception ex)
            {

                _logger.LogInformation("ResetWarframeRevivesHandler => resetReason {ResetReason} => Exception while searching for last reset date {Ex}", resetWarframeRevives.ResetReason, ex);
                //TODO: determine whether or not we create a separate handler for tracking the system task execution status 
            }

            _logger.LogInformation("ResetWarframeRevivesHandler => resetReason {ResetReason} => Revives last reset on {LastResetDate}",resetWarframeRevives.ResetReason, lastReviveResetDate);


            if (resetWarframeRevives.ResetRegardless)
            {
                _logger.LogInformation("ResetWarframeRevivesHandler => resetReason {ResetReason} => We are going to reset no matter what", resetWarframeRevives.ResetReason);
            }

            if(lastReviveResetDate.Date == DateTimeOffset.Now.Date && !resetWarframeRevives.ResetRegardless)
            {
                _logger.LogInformation("ResetWarframeRevivesHandler => Not time to reset, carry on.");
                return;
            }

            try {
                _logger.LogInformation("ResetWarframeRevivesHandler => resetReason {ResetReason} => Updating db, setting extra remaining to 4", resetWarframeRevives.ResetReason);
                _applicationDbContext.InventoryItems.Where(w => w.InternalInventoryItemType == InternalInventoryItemType.Suits
                                                   && w.ExtraRemaining < 4)
                                        .ExecuteUpdate(eu => eu.SetProperty(sp => sp.ExtraRemaining, 4));
                _logger.LogInformation("ResetWarframeRevivesHandler => resetReason {ResetReason} => We are going to reset no matter what", resetWarframeRevives.ResetReason);
            }
            catch (Exception ex)
            {
                _logger.LogInformation("ResetWarframeRevivesHandler => resetReason {ResetReason} => Exception while updating DB during reset {Exception}", resetWarframeRevives.ResetReason, ex);
            }

        }

    }
}
