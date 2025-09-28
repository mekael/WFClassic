using Microsoft.EntityFrameworkCore;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;

namespace WFClassic.Web.Logic.UI.Inventory.AddList
{
    public class GetAllWaframeItemsHandler
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly ILogger<GetAllWaframeItemsHandler> _logger;

        public GetAllWaframeItemsHandler(ApplicationDbContext applicationDbContext, ILogger<GetAllWaframeItemsHandler> logger)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
        }

        public GetAllWaframeItemsResult Handle()
        {
            GetAllWaframeItemsResult getAllWaframeItemsResult = new GetAllWaframeItemsResult();

            List<WarframeItem> warframeItems = null;

            try
            {
                this._logger.LogInformation("{ClassName} => Querying for warframe item listing", this.GetType().Name);
                warframeItems = this._applicationDbContext.WarframeItems.AsSplitQuery().Include(i => i.WarframeItemComponents).ToList();
            }
            catch (Exception ex)
            {
                this._logger.LogError("{ClassName} => Exception while querying for warframe items {Exception}", this.GetType().Name, ex);
                getAllWaframeItemsResult.GetAllWaframeItemsResultStatus = GetAllWarframeItemsResultStatus.DatabaseErrors;
                return getAllWaframeItemsResult;
            }
            try
            {
                foreach (var warframeItem in warframeItems)
                {
                    this._logger.LogInformation("{ClassName} => Mapping item {ItemId}", this.GetType().Name, warframeItem.Id);
                    getAllWaframeItemsResult.GetAllWarframeItemsResultDetailItems.Add(new GetAllWarframeItemsResultDetailItem()
                    {
                        ItemName = warframeItem.ItemType,
                        WarframeItemLocation = warframeItem.WarframeItemLocation,
                        GetAllWarframeItemsResultDetailItemComponents = warframeItem.WarframeItemComponents.Select(s => new GetAllWarframeItemsResultDetailItemComponent()
                        {
                            AddInventoryBin = s.AddInventoryBin,
                            InternalInventoryItemType = s.InternalInventoryItemType,
                            InventoryBinTypeToAdd = s.InventoryBinTypeToAdd,
                            ItemName = s.ItemName,
                            ItemType = s.ItemType,
                            NumberOfBinsToAdd = s.NumberOfBinsToAdd,
                            UnlockLevel = s.UnlockLevel
                        }).ToList()
                    });
                }

            }
            catch (Exception ex)
            {
                this._logger.LogError("{ClassName} => Exception while mapping onto result set {Exception}", this.GetType().Name, ex);
                getAllWaframeItemsResult.GetAllWaframeItemsResultStatus = GetAllWarframeItemsResultStatus.MappingErrors;
            }
            return getAllWaframeItemsResult;
        }
    }
}