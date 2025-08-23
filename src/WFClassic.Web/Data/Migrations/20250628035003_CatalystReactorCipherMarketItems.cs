using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class CatalystReactorCipherMarketItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                            INSERT INTO MarketPackageDefinitions
                            (Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
                            VALUES('C7681BC7-30E0-4BF4-8D49-4CE25CC43414', '/Lotus/Types/Items/MiscItems/OrokinCatalyst', 0, 0, 20, 1, 0, '2025-06-27 22:01:19.6008208-05:00', '2025-06-27 22:01:19.6008208-05:00');
                            INSERT INTO MarketPackageDefinitions
                            (Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
                            VALUES('448F49F8-2E25-4EDD-BAC9-5A53E864BD27', '/Lotus/Types/Items/MiscItems/OrokinReactor', 0, 0, 20, 1, 0, '2025-06-27 22:01:19.6008208-05:00', '2025-06-27 22:01:19.6008208-05:00');
                            INSERT INTO MarketPackageDefinitions
                            (Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
                            VALUES('7449BB9C-1D5B-4702-B7C2-F2D21A67746E', '/Lotus/Types/Restoratives/Cipher', 1, 250, 0, 0, 1, '2025-06-27 22:01:19.6008208-05:00', '2025-06-27 22:01:19.6008208-05:00');



                            INSERT INTO MarketPackageItemDefintions
                            (Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
                            VALUES('C7681BC7-30E0-4BF4-8D49-4CE25CC43414', 'C7681BC7-30E0-4BF4-8D49-4CE25CC43414', 11, 0, 1, 1, '/Lotus/Types/Items/MiscItems/OrokinCatalyst', 'OrokinCatalyst', 0, 0, 0, '', 0, 0, 0, '2025-06-27 22:01:19.6008208-05:00', '2025-06-27 22:01:19.6008208-05:00');
                            INSERT INTO MarketPackageItemDefintions
                            (Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
                            VALUES('448F49F8-2E25-4EDD-BAC9-5A53E864BD27', '448F49F8-2E25-4EDD-BAC9-5A53E864BD27', 11, 0, 1, 1, '/Lotus/Types/Items/MiscItems/OrokinReactor', 'OrokinReactor', 0, 0, 0, '', 0, 0, 0, '2025-06-27 22:01:19.6008208-05:00', '2025-06-27 22:01:19.6008208-05:00');
                            INSERT INTO MarketPackageItemDefintions
                            (Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
                            VALUES('7449BB9C-1D5B-4702-B7C2-F2D21A67746E', '7449BB9C-1D5B-4702-B7C2-F2D21A67746E', 2, 0, 1, 4, '/Lotus/Types/Restoratives/Cipher', 'Cipher', 0, 0, 0, '', 0, 0, 0, '2025-06-27 22:01:19.6008208-05:00', '2025-06-27 22:01:19.6008208-05:00');
");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}