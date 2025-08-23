using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddHolidayColorFlavourItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"


INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('457D1A1C-1284-4F8C-A7E1-5AE3FAF74F32', '/Lotus/Types/StoreItems/SuitCustomizations/ColourPickerItemD', 1, 0, 75, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/StoreItems/SuitCustomizations/ColourPickerIceItemA');

INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('457D1A1C-1284-4F8C-A7E1-5AE3FAF74F32', '/Lotus/Types/StoreItems/SuitCustomizations/ColourPickerItemD', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');

INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('457D1A1C-1284-4F8C-A7E1-5AE3FAF74F32', '457D1A1C-1284-4F8C-A7E1-5AE3FAF74F32', '/Lotus/Types/StoreItems/SuitCustomizations/ColourPickerItemD', 'ColourPickerItemD', 10, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);


INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('FCB07590-C650-4B1C-8DE4-9E72CFB26ADD', '/Lotus/Types/StoreItems/SuitCustomizations/ColourPickerValItemA', 1, 0, 75, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/StoreItems/SuitCustomizations/ColourPickerIceItemA');

INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('FCB07590-C650-4B1C-8DE4-9E72CFB26ADD', '/Lotus/Types/StoreItems/SuitCustomizations/ColourPickerValItemA', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');

INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('FCB07590-C650-4B1C-8DE4-9E72CFB26ADD', 'FCB07590-C650-4B1C-8DE4-9E72CFB26ADD', '/Lotus/Types/StoreItems/SuitCustomizations/ColourPickerValItemA', 'ColourPickerValItemA', 10, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);


INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('AEC27EA6-3875-45EA-8227-C6699A2A6B05', '/Lotus/Types/StoreItems/SuitCustomizations/ColourPickerEasterItemA', 1, 0, 75, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/StoreItems/SuitCustomizations/ColourPickerIceItemA');

INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('AEC27EA6-3875-45EA-8227-C6699A2A6B05', '/Lotus/Types/StoreItems/SuitCustomizations/ColourPickerEasterItemA', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');

INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('AEC27EA6-3875-45EA-8227-C6699A2A6B05', 'AEC27EA6-3875-45EA-8227-C6699A2A6B05', '/Lotus/Types/StoreItems/SuitCustomizations/ColourPickerEasterItemA', 'ColourPickerEasterItemA', 10, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);

");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}