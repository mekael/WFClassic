using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class FrameRecipeMarketPackages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('3FCF5B77-A127-45B7-A8BE-F635A9EB4636', '/Lotus/Powersuits/Ninja/Ninja', 1, 0, 375, 1, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('B02BF220-0C77-4C10-A72A-7BFC74AE4628', '/Lotus/Powersuits/Banshee/Banshee', 1, 0, 225, 1, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('60189A6F-13EA-47CB-A6BC-6F145F02C293', '/Lotus/Powersuits/Ember/Ember', 1, 0, 225, 1, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('9AEBF75D-9BC4-47EB-B0E1-69B123457FAC', '/Lotus/Powersuits/Excalibur/ExcaliburPrime', 1, 0, 10000000, 1, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('3B33DBC8-420E-4178-B444-45BE2B62B3B1', '/Lotus/Powersuits/Excalibur/Excalibur', 1, 0, 75, 1, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('1386BFD0-0DF1-421A-ABFD-DAFF27780D78', '/Lotus/Powersuits/Frost/FrostPrime', 1, 0, 375, 1, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('E1B760DD-9C44-4CBD-A5EE-E2480BE0B486', '/Lotus/Powersuits/Frost/Frost', 1, 0, 375, 1, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('4984CEF1-B4F3-4290-B9AD-E733D3F87DB2', '/Lotus/Powersuits/Jade/Jade', 1, 0, 225, 1, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('017EF28B-5578-45C3-B139-43237CC3FD1B', '/Lotus/Powersuits/Loki/Loki', 1, 0, 75, 1, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('FB352C3E-67E3-490D-BAB4-5C118F9985B3', '/Lotus/Powersuits/Mag/Mag', 1, 0, 175, 1, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('016E8953-FBA9-4D68-BE09-ECA66C3CA52B', '/Lotus/Powersuits/Rhino/Rhino', 1, 0, 375, 1, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('C8CF33BA-672A-4F4B-84B4-A9FF71A715BB', '/Lotus/Powersuits/Saryn/Saryn', 1, 0, 225, 1, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('1565D41C-1077-40F5-B7F1-032AAA14CEC1', '/Lotus/Powersuits/Trapper/Trapper', 1, 0, 225, 1, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('789406BB-161F-4C52-B822-13DB3FB79C27', '/Lotus/Powersuits/Trinity/Trinity', 1, 0, 225, 1, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('5DEEDC53-E403-4CF3-99D5-E61F57E34422', '/Lotus/Powersuits/Volt/Volt', 1, 0, 75, 1, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('F40B069A-5D14-41EF-B858-BA6086D9B697', '/Lotus/Types/Recipes/WarframeRecipes/AshBlueprint', 1, 35000, 0, 0, 1, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('0276B509-40B7-48CB-B631-7C73AC64FECD', '/Lotus/Types/Recipes/WarframeRecipes/BansheeBlueprint', 1, 35000, 0, 0, 1, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('A4C6C411-6949-48FD-B133-AE1F5636C840', '/Lotus/Types/Recipes/WarframeRecipes/EmberBlueprint', 1, 25000, 0, 0, 1, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('B7A60991-F7AF-4028-B433-B3DC26619AC5', '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburBlueprint', 1, 35000, 0, 0, 1, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('A5B4ABE9-B835-49C3-BB11-A2213DD20489', '/Lotus/Types/Recipes/WarframeRecipes/FrostBlueprint', 1, 25000, 0, 0, 1, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('822DB367-290E-4D15-A24E-37A8FFDD666C', '/Lotus/Types/Recipes/WarframeRecipes/LOKIBlueprint', 1, 35000, 0, 0, 1, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('090BC735-3924-4BFB-8019-B124E9E9E1F3', '/Lotus/Types/Recipes/WarframeRecipes/MagBlueprint', 1, 25000, 0, 0, 1, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('BE782BA2-DCCA-48F4-8C0D-4DC819A3C081', '/Lotus/Types/Recipes/WarframeRecipes/NyxBlueprint', 1, 25000, 0, 0, 1, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('DA6361B0-7939-462C-AD06-B630A35089B9', '/Lotus/Types/Recipes/WarframeRecipes/RhinoBlueprint', 1, 35000, 0, 0, 1, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('9093DDAB-FA7E-457E-9A06-4652313DE596', '/Lotus/Types/Recipes/WarframeRecipes/SarynBlueprint', 1, 35000, 0, 0, 1, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('FE3F17C5-20CB-4F33-B8BB-91E0B71847AF', '/Lotus/Types/Recipes/WarframeRecipes/TrinityBlueprint', 1, 25000, 0, 0, 1, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('5CFCE63B-F33F-41DB-9556-438AC39F2D5C', '/Lotus/Types/Recipes/WarframeRecipes/VOLTBlueprint', 1, 35000, 0, 0, 1, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');





INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('3FCF5B77-A127-45B7-A8BE-F635A9EB4636', '3FCF5B77-A127-45B7-A8BE-F635A9EB4636', 3, 1, 1, 1, '/Lotus/Powersuits/Ninja/Ninja', 'Ninja', 101, 1, 4, 'lvl=0|', 1, 0, 1, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('560141BA-7683-4EC2-88F3-E48F9EDBBA8E', '3FCF5B77-A127-45B7-A8BE-F635A9EB4636', 4, 1, 1, 1, '/Lotus/Powersuits/Ninja/GlaiveAbilityCard', 'GlaiveAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('C1686F79-DD44-4987-8C65-C4CF5C36645A', '3FCF5B77-A127-45B7-A8BE-F635A9EB4636', 4, 1, 1, 1, '/Lotus/Powersuits/Ninja/NinjaStormAbilityCard', 'NinjaStormAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('155ED38F-112D-49EA-BCB7-94994F40899B', '3FCF5B77-A127-45B7-A8BE-F635A9EB4636', 4, 1, 1, 1, '/Lotus/Powersuits/Ninja/SmokeScreenAbilityCard', 'SmokeScreenAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('60DAC97E-DC33-4F39-B7D4-5CB615FC0F39', '3FCF5B77-A127-45B7-A8BE-F635A9EB4636', 4, 1, 1, 1, '/Lotus/Powersuits/Ninja/TelelportToAbilityCard', 'TelelportToAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('B02BF220-0C77-4C10-A72A-7BFC74AE4628', 'B02BF220-0C77-4C10-A72A-7BFC74AE4628', 3, 1, 1, 1, '/Lotus/Powersuits/Banshee/Banshee', 'Banshee', 101, 1, 4, 'lvl=0|', 1, 0, 1, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('921967FA-CBC3-441D-8705-0D139CC1C6F0', 'B02BF220-0C77-4C10-A72A-7BFC74AE4628', 4, 1, 1, 1, '/Lotus/Powersuits/Banshee/EarthQuakeAbilityCard', 'EarthQuakeAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('A5CAEFCB-D6B4-4666-8B6E-A51D593EED23', 'B02BF220-0C77-4C10-A72A-7BFC74AE4628', 4, 1, 1, 1, '/Lotus/Powersuits/Banshee/PushAbilityCard', 'PushAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('A4261105-5638-439F-BF4D-5CC75AFE4C29', 'B02BF220-0C77-4C10-A72A-7BFC74AE4628', 4, 1, 1, 1, '/Lotus/Powersuits/Banshee/SilenceAbilityCard', 'SilenceAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('6467684B-460F-411D-A3EB-9B69EA880636', 'B02BF220-0C77-4C10-A72A-7BFC74AE4628', 4, 1, 1, 1, '/Lotus/Powersuits/Banshee/SonarAbilityCard', 'SonarAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('60189A6F-13EA-47CB-A6BC-6F145F02C293', '60189A6F-13EA-47CB-A6BC-6F145F02C293', 3, 1, 1, 1, '/Lotus/Powersuits/Ember/Ember', 'Ember', 101, 1, 4, 'lvl=0|', 1, 0, 1, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('418FA436-CF06-4B94-A108-F3C2480EAEAA', '60189A6F-13EA-47CB-A6BC-6F145F02C293', 4, 1, 1, 1, '/Lotus/Powersuits/Ember/FireBallAbilityCard', 'FireBallAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('3319C1D2-F048-4F46-9BD0-25C3A62420B1', '60189A6F-13EA-47CB-A6BC-6F145F02C293', 4, 1, 1, 1, '/Lotus/Powersuits/Ember/FireBlastAbilityCard', 'FireBlastAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('25D9D2D0-3FC9-46BD-9614-5EE3D5172269', '60189A6F-13EA-47CB-A6BC-6F145F02C293', 4, 1, 1, 1, '/Lotus/Powersuits/Ember/FireSkinAbilityCard', 'FireSkinAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('6F2BD7CC-D0DD-4FDC-938F-DE00EB5177AD', '60189A6F-13EA-47CB-A6BC-6F145F02C293', 4, 1, 1, 1, '/Lotus/Powersuits/Ember/WorldOnFireAbilityCard', 'WorldOnFireAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('9AEBF75D-9BC4-47EB-B0E1-69B123457FAC', '9AEBF75D-9BC4-47EB-B0E1-69B123457FAC', 3, 1, 1, 1, '/Lotus/Powersuits/Excalibur/ExcaliburPrime', 'ExcaliburPrime', 101, 1, 4, 'lvl=0|', 1, 0, 1, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('8BC124B7-8139-49AE-91AC-412D52DABE67', '9AEBF75D-9BC4-47EB-B0E1-69B123457FAC', 4, 1, 1, 1, '/Lotus/Powersuits/Excalibur/RadialBlindAbilityCard', 'RadialBlindAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('D3C621CD-B3F6-45CC-8853-7BDAD4C9D1F0', '9AEBF75D-9BC4-47EB-B0E1-69B123457FAC', 4, 1, 1, 1, '/Lotus/Powersuits/Excalibur/RadialJavelinAbilityCard', 'RadialJavelinAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('FA579A3C-26FB-492A-B867-6EAFEBB87031', '9AEBF75D-9BC4-47EB-B0E1-69B123457FAC', 4, 1, 1, 1, '/Lotus/Powersuits/Excalibur/SlashDashAbilityCard', 'SlashDashAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('0BE4E6DC-7BF6-4AF5-A065-3C400BE54D9B', '9AEBF75D-9BC4-47EB-B0E1-69B123457FAC', 4, 1, 1, 1, '/Lotus/Powersuits/Excalibur/SuperJumpAbilityCard', 'SuperJumpAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('3B33DBC8-420E-4178-B444-45BE2B62B3B1', '3B33DBC8-420E-4178-B444-45BE2B62B3B1', 3, 1, 1, 1, '/Lotus/Powersuits/Excalibur/Excalibur', 'Excalibur', 101, 1, 4, 'lvl=0|', 1, 0, 1, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('83D1A3BF-8D2D-4089-B512-C5FA898789AB', '3B33DBC8-420E-4178-B444-45BE2B62B3B1', 4, 1, 1, 1, '/Lotus/Powersuits/Excalibur/RadialBlindAbilityCard', 'RadialBlindAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('F376EA09-19E4-418D-92D0-3A6C5F036C4A', '3B33DBC8-420E-4178-B444-45BE2B62B3B1', 4, 1, 1, 1, '/Lotus/Powersuits/Excalibur/RadialJavelinAbilityCard', 'RadialJavelinAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('51168878-2704-4BD1-BD13-BE102F14639E', '3B33DBC8-420E-4178-B444-45BE2B62B3B1', 4, 1, 1, 1, '/Lotus/Powersuits/Excalibur/SlashDashAbilityCard', 'SlashDashAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('83C8A9FE-F850-40D1-96D5-658390836523', '3B33DBC8-420E-4178-B444-45BE2B62B3B1', 4, 1, 1, 1, '/Lotus/Powersuits/Excalibur/SuperJumpAbilityCard', 'SuperJumpAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('1386BFD0-0DF1-421A-ABFD-DAFF27780D78', '1386BFD0-0DF1-421A-ABFD-DAFF27780D78', 3, 1, 1, 1, '/Lotus/Powersuits/Frost/FrostPrime', 'FrostPrime', 101, 1, 4, 'lvl=0|', 1, 0, 1, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('C0C21982-EF93-4C49-A2B2-5833965621E1', '1386BFD0-0DF1-421A-ABFD-DAFF27780D78', 4, 1, 1, 1, '/Lotus/Powersuits/Frost/AvalancheAbilityCard', 'AvalancheAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('44599091-6505-403B-91DF-3509391A2DDD', '1386BFD0-0DF1-421A-ABFD-DAFF27780D78', 4, 1, 1, 1, '/Lotus/Powersuits/Frost/IceShieldAbilityCard', 'IceShieldAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('91AF2B45-FC0F-404C-B2E1-2082C5EE2648', '1386BFD0-0DF1-421A-ABFD-DAFF27780D78', 4, 1, 1, 1, '/Lotus/Powersuits/Frost/IceSpikeAbilityCard', 'IceSpikeAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('0FEDAEC1-684D-423F-B9B2-70E0C55FA429', '1386BFD0-0DF1-421A-ABFD-DAFF27780D78', 4, 1, 1, 1, '/Lotus/Powersuits/Frost/IcicleAbilityCard', 'IcicleAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('E1B760DD-9C44-4CBD-A5EE-E2480BE0B486', 'E1B760DD-9C44-4CBD-A5EE-E2480BE0B486', 3, 1, 1, 1, '/Lotus/Powersuits/Frost/Frost', 'Frost', 101, 1, 4, 'lvl=0|', 1, 0, 1, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('2EEB1F6D-04B5-468E-BD3C-306EB1209621', 'E1B760DD-9C44-4CBD-A5EE-E2480BE0B486', 4, 1, 1, 1, '/Lotus/Powersuits/Frost/AvalancheAbilityCard', 'AvalancheAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('2DF6E9C2-5A57-4374-81EB-FE29DC53BE84', 'E1B760DD-9C44-4CBD-A5EE-E2480BE0B486', 4, 1, 1, 1, '/Lotus/Powersuits/Frost/IceShieldAbilityCard', 'IceShieldAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('2C97E0AA-BF02-4594-9278-292CB3DB7A82', 'E1B760DD-9C44-4CBD-A5EE-E2480BE0B486', 4, 1, 1, 1, '/Lotus/Powersuits/Frost/IceSpikeAbilityCard', 'IceSpikeAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('40916B31-67D8-44BE-AE54-8C53F8BC7386', 'E1B760DD-9C44-4CBD-A5EE-E2480BE0B486', 4, 1, 1, 1, '/Lotus/Powersuits/Frost/IcicleAbilityCard', 'IcicleAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('4984CEF1-B4F3-4290-B9AD-E733D3F87DB2', '4984CEF1-B4F3-4290-B9AD-E733D3F87DB2', 3, 1, 1, 1, '/Lotus/Powersuits/Jade/Jade', 'Jade', 101, 1, 4, 'lvl=0|', 1, 0, 1, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('399CB637-BB44-4017-AA81-4075C20F59E3', '4984CEF1-B4F3-4290-B9AD-E733D3F87DB2', 4, 1, 1, 1, '/Lotus/Powersuits/Jade/MindControlAbilityCard', 'MindControlAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('DAB539CB-FB97-4781-925B-BF66D2A0D537', '4984CEF1-B4F3-4290-B9AD-E733D3F87DB2', 4, 1, 1, 1, '/Lotus/Powersuits/Jade/DaggerAbilityCard', 'DaggerAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('021B1612-A473-4420-A6AF-FE394CBABBF6', '4984CEF1-B4F3-4290-B9AD-E733D3F87DB2', 4, 1, 1, 1, '/Lotus/Powersuits/Jade/ChaosAbilityCard', 'ChaosAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('F6300295-299F-4AF8-92CE-D20A92AEE229', '4984CEF1-B4F3-4290-B9AD-E733D3F87DB2', 4, 1, 1, 1, '/Lotus/Powersuits/Jade/SelfBulletAttractorAbilityCard', 'SelfBulletAttractorAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('017EF28B-5578-45C3-B139-43237CC3FD1B', '017EF28B-5578-45C3-B139-43237CC3FD1B', 3, 1, 1, 1, '/Lotus/Powersuits/Loki/Loki', 'Loki', 101, 1, 4, 'lvl=0|', 1, 0, 1, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('89016973-F3FC-4474-8AD8-AAE1451399F9', '017EF28B-5578-45C3-B139-43237CC3FD1B', 4, 1, 1, 1, '/Lotus/Powersuits/Loki/DecoyAbilityCard', 'DecoyAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('7048EBB7-9F43-4B82-9083-D756354EAB94', '017EF28B-5578-45C3-B139-43237CC3FD1B', 4, 1, 1, 1, '/Lotus/Powersuits/Loki/DisarmAbilityCard', 'DisarmAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('C8697818-91B0-4E91-9B65-5DEDF2A11766', '017EF28B-5578-45C3-B139-43237CC3FD1B', 4, 1, 1, 1, '/Lotus/Powersuits/Loki/InvisibilityAbilityCard', 'InvisibilityAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('3C1B6A96-E75B-4700-959A-277C7283A2A6', '017EF28B-5578-45C3-B139-43237CC3FD1B', 4, 1, 1, 1, '/Lotus/Powersuits/Loki/SwitchAbilityCard', 'SwitchAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('FB352C3E-67E3-490D-BAB4-5C118F9985B3', 'FB352C3E-67E3-490D-BAB4-5C118F9985B3', 3, 1, 1, 1, '/Lotus/Powersuits/Mag/Mag', 'Mag', 101, 1, 4, 'lvl=0|', 1, 0, 1, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('8EF5B694-A1AF-4D3C-803E-05505E786212', 'FB352C3E-67E3-490D-BAB4-5C118F9985B3', 4, 1, 1, 1, '/Lotus/Powersuits/Mag/BulletAttractorAbilityCard', 'BulletAttractorAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('28ADBCC2-D749-474E-BCFD-A61688D36CFB', 'FB352C3E-67E3-490D-BAB4-5C118F9985B3', 4, 1, 1, 1, '/Lotus/Powersuits/Mag/CrushAbilityCard', 'CrushAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('3DD60427-FF34-4DFA-BFAF-584E295161FE', 'FB352C3E-67E3-490D-BAB4-5C118F9985B3', 4, 1, 1, 1, '/Lotus/Powersuits/Mag/PullAbilityCard', 'PullAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('F3B2AB59-9802-43BC-AC99-EF1F8EBBECC2', 'FB352C3E-67E3-490D-BAB4-5C118F9985B3', 4, 1, 1, 1, '/Lotus/Powersuits/Mag/ShieldRegenAbilityCard', 'ShieldRegenAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('016E8953-FBA9-4D68-BE09-ECA66C3CA52B', '016E8953-FBA9-4D68-BE09-ECA66C3CA52B', 3, 1, 1, 1, '/Lotus/Powersuits/Rhino/Rhino', 'Rhino', 101, 1, 4, 'lvl=0|', 1, 0, 1, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('17E15B2C-93C7-46A1-9F2C-5C705CDB0B65', '016E8953-FBA9-4D68-BE09-ECA66C3CA52B', 4, 1, 1, 1, '/Lotus/Powersuits/Rhino/IronSkinAbilityCard', 'IronSkinAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('CB6AD453-8ABB-4D1B-85B1-C80C021D5F38', '016E8953-FBA9-4D68-BE09-ECA66C3CA52B', 4, 1, 1, 1, '/Lotus/Powersuits/Rhino/RadialBlastAbilityCard', 'RadialBlastAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('83C3D0F4-DDB0-48B7-8AAF-3B5D9E48A315', '016E8953-FBA9-4D68-BE09-ECA66C3CA52B', 4, 1, 1, 1, '/Lotus/Powersuits/Rhino/RhinoChargeAbilityCard', 'RhinoChargeAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('DF75F827-A77E-4246-A058-ED3D58D67951', '016E8953-FBA9-4D68-BE09-ECA66C3CA52B', 4, 1, 1, 1, '/Lotus/Powersuits/Rhino/RhinoStompAbilityCard', 'RhinoStompAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('C8CF33BA-672A-4F4B-84B4-A9FF71A715BB', 'C8CF33BA-672A-4F4B-84B4-A9FF71A715BB', 3, 1, 1, 1, '/Lotus/Powersuits/Saryn/Saryn', 'Saryn', 101, 1, 4, 'lvl=0|', 1, 0, 1, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('3FDCE813-375C-4D17-8251-8838191E30E6', 'C8CF33BA-672A-4F4B-84B4-A9FF71A715BB', 4, 1, 1, 1, '/Lotus/Powersuits/Saryn/ExplosiveDissolveAbilityCard', 'ExplosiveDissolveAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('A2AA0203-85C9-4507-8E5B-C40D72E82F29', 'C8CF33BA-672A-4F4B-84B4-A9FF71A715BB', 4, 1, 1, 1, '/Lotus/Powersuits/Saryn/PoisonAbilityCard', 'PoisonAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('62111E4A-A736-437E-9FD5-33BE449A9EFC', 'C8CF33BA-672A-4F4B-84B4-A9FF71A715BB', 4, 1, 1, 1, '/Lotus/Powersuits/Saryn/ShedAbilityCard', 'ShedAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('4BCF46BD-A8E4-4C99-B09E-12F93A9ADC81', 'C8CF33BA-672A-4F4B-84B4-A9FF71A715BB', 4, 1, 1, 1, '/Lotus/Powersuits/Saryn/WeaponPoisonAbilityCard', 'WeaponPoisonAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('1565D41C-1077-40F5-B7F1-032AAA14CEC1', '1565D41C-1077-40F5-B7F1-032AAA14CEC1', 3, 1, 1, 1, '/Lotus/Powersuits/Trapper/Trapper', 'Trapper', 101, 1, 4, 'lvl=0|', 1, 0, 1, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('C45291AA-7325-4C75-9977-54CD8F8F64E8', '1565D41C-1077-40F5-B7F1-032AAA14CEC1', 4, 1, 1, 1, '/Lotus/Powersuits/Rhino/IronSkinAbilityCard', 'IronSkinAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('8D7A69BC-790F-4302-B923-8A5DBD9A97FD', '1565D41C-1077-40F5-B7F1-032AAA14CEC1', 4, 1, 1, 1, '/Lotus/Powersuits/Rhino/RadialBlastAbilityCard', 'RadialBlastAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('7A22ECEF-C561-48C8-946E-41BF03B33746', '1565D41C-1077-40F5-B7F1-032AAA14CEC1', 4, 1, 1, 1, '/Lotus/Powersuits/Rhino/RhinoChargeAbilityCard', 'RhinoChargeAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('00B6ED18-A001-4709-ACDB-36CD541A10DE', '1565D41C-1077-40F5-B7F1-032AAA14CEC1', 4, 1, 1, 1, '/Lotus/Powersuits/Rhino/RhinoStompAbilityCard', 'RhinoStompAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('789406BB-161F-4C52-B822-13DB3FB79C27', '789406BB-161F-4C52-B822-13DB3FB79C27', 3, 1, 1, 1, '/Lotus/Powersuits/Trinity/Trinity', 'Trinity', 101, 1, 4, 'lvl=0|', 1, 0, 1, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('81DBBD4E-A0C2-4AE7-8FFD-B6DEDB0051B4', '789406BB-161F-4C52-B822-13DB3FB79C27', 4, 1, 1, 1, '/Lotus/Powersuits/Trinity/BlessingAbilityCard', 'BlessingAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('7A213364-1D62-4B20-87E3-B876F93B7C29', '789406BB-161F-4C52-B822-13DB3FB79C27', 4, 1, 1, 1, '/Lotus/Powersuits/Trinity/EnergyVampireAbilityCard', 'EnergyVampireAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('5C17F09F-B2E2-4986-B414-6241B241124D', '789406BB-161F-4C52-B822-13DB3FB79C27', 4, 1, 1, 1, '/Lotus/Powersuits/Trinity/LinkAbilityCard', 'LinkAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('1DB571FA-851B-4F99-A1DC-D131DFC3A535', '789406BB-161F-4C52-B822-13DB3FB79C27', 4, 1, 1, 1, '/Lotus/Powersuits/Trinity/WellOfLifeAbilityCard', 'WellOfLifeAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('5DEEDC53-E403-4CF3-99D5-E61F57E34422', '5DEEDC53-E403-4CF3-99D5-E61F57E34422', 3, 1, 1, 1, '/Lotus/Powersuits/Volt/Volt', 'Volt', 101, 1, 4, 'lvl=0|', 1, 0, 1, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('AC5E8F50-0637-4CDE-A8DB-B9039BE20BFA', '5DEEDC53-E403-4CF3-99D5-E61F57E34422', 4, 1, 1, 1, '/Lotus/Powersuits/Volt/OverloadAbilityCard', 'OverloadAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('F2871FFB-319E-44E1-BAAF-C7F2B32E9AB0', '5DEEDC53-E403-4CF3-99D5-E61F57E34422', 4, 1, 1, 1, '/Lotus/Powersuits/Volt/ShieldAbilityCard', 'ShieldAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('21C4D47F-C74B-412E-9156-F709D517D9B9', '5DEEDC53-E403-4CF3-99D5-E61F57E34422', 4, 1, 1, 1, '/Lotus/Powersuits/Volt/ShockAbilityCard', 'ShockAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('A4AC724A-080F-4875-85D6-8CDE1C2B05B2', '5DEEDC53-E403-4CF3-99D5-E61F57E34422', 4, 1, 1, 1, '/Lotus/Powersuits/Volt/SpeedAbilityCard', 'SpeedAbilityCard', 0, 0, 0, 'lvl=0|', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('F40B069A-5D14-41EF-B858-BA6086D9B697', 'F40B069A-5D14-41EF-B858-BA6086D9B697', 13, 0, 1, 1, '/Lotus/Types/Recipes/WarframeRecipes/AshBlueprint', 'AshBlueprint', 0, 0, 0, '', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('0276B509-40B7-48CB-B631-7C73AC64FECD', '0276B509-40B7-48CB-B631-7C73AC64FECD', 13, 0, 1, 1, '/Lotus/Types/Recipes/WarframeRecipes/BansheeBlueprint', 'BansheeBlueprint', 0, 0, 0, '', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('A4C6C411-6949-48FD-B133-AE1F5636C840', 'A4C6C411-6949-48FD-B133-AE1F5636C840', 13, 0, 1, 1, '/Lotus/Types/Recipes/WarframeRecipes/EmberBlueprint', 'EmberBlueprint', 0, 0, 0, '', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('B7A60991-F7AF-4028-B433-B3DC26619AC5', 'B7A60991-F7AF-4028-B433-B3DC26619AC5', 13, 0, 1, 1, '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburBlueprint', 'ExcaliburBlueprint', 0, 0, 0, '', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('A5B4ABE9-B835-49C3-BB11-A2213DD20489', 'A5B4ABE9-B835-49C3-BB11-A2213DD20489', 13, 0, 1, 1, '/Lotus/Types/Recipes/WarframeRecipes/FrostBlueprint', 'FrostBlueprint', 0, 0, 0, '', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('822DB367-290E-4D15-A24E-37A8FFDD666C', '822DB367-290E-4D15-A24E-37A8FFDD666C', 13, 0, 1, 1, '/Lotus/Types/Recipes/WarframeRecipes/LOKIBlueprint', 'LOKIBlueprint', 0, 0, 0, '', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('090BC735-3924-4BFB-8019-B124E9E9E1F3', '090BC735-3924-4BFB-8019-B124E9E9E1F3', 13, 0, 1, 1, '/Lotus/Types/Recipes/WarframeRecipes/MagBlueprint', 'MagBlueprint', 0, 0, 0, '', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('BE782BA2-DCCA-48F4-8C0D-4DC819A3C081', 'BE782BA2-DCCA-48F4-8C0D-4DC819A3C081', 13, 0, 1, 1, '/Lotus/Types/Recipes/WarframeRecipes/NyxBlueprint', 'NyxBlueprint', 0, 0, 0, '', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('DA6361B0-7939-462C-AD06-B630A35089B9', 'DA6361B0-7939-462C-AD06-B630A35089B9', 13, 0, 1, 1, '/Lotus/Types/Recipes/WarframeRecipes/RhinoBlueprint', 'RhinoBlueprint', 0, 0, 0, '', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('9093DDAB-FA7E-457E-9A06-4652313DE596', '9093DDAB-FA7E-457E-9A06-4652313DE596', 13, 0, 1, 1, '/Lotus/Types/Recipes/WarframeRecipes/SarynBlueprint', 'SarynBlueprint', 0, 0, 0, '', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('FE3F17C5-20CB-4F33-B8BB-91E0B71847AF', 'FE3F17C5-20CB-4F33-B8BB-91E0B71847AF', 13, 0, 1, 1, '/Lotus/Types/Recipes/WarframeRecipes/TrinityBlueprint', 'TrinityBlueprint', 0, 0, 0, '', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('5CFCE63B-F33F-41DB-9556-438AC39F2D5C', '5CFCE63B-F33F-41DB-9556-438AC39F2D5C', 13, 0, 1, 1, '/Lotus/Types/Recipes/WarframeRecipes/VOLTBlueprint', 'VOLTBlueprint', 0, 0, 0, '', 0, 0, 0, '2025-05-07 22:01:19.6008208-05:00', '2025-05-07 22:01:19.6008208-05:00');




");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}