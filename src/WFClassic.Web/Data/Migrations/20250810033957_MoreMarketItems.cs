using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class MoreMarketItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('A34F9C6D-BDB6-4639-8841-6EEA79382B69', '/Lotus/Types/Restoratives/ChargeableSelfHeal', 1, 1500, 14, 1, 1, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00', '/Lotus/Types/Restoratives/ChargeableSelfHeal');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('6AD5D3F9-9D59-4FAC-B6D8-B60C6B13CFCC', '/Lotus/Types/Restoratives/SelfHealLarge', 1, 500, 0, 0, 1, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00', '/Lotus/Types/Restoratives/SelfHealLarge');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('286EA647-A3CD-4565-B0F7-BC4DCBE87ADE', '/Lotus/Types/Restoratives/SelfHealSmall', 1, 250, 0, 0, 1, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00', '/Lotus/Types/Restoratives/SelfHealSmall');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('2709DA2D-AD18-48F7-A74D-CAD52D6F2E81', '/Lotus/Types/Restoratives/SelfOmniAmmo', 1, 0, 12, 1, 0, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00', '/Lotus/Types/Restoratives/SelfOmniAmmo');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('D619103B-1F80-41D1-99A8-90DF7A1B67BB', '/Lotus/Types/Restoratives/SelfPistolAmmo', 1, 1000, 0, 0, 1, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00', '/Lotus/Types/Restoratives/SelfPistolAmmo');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('DDDA59D0-5BFA-4DB5-A800-7F4FD4CCB16B', '/Lotus/Types/Restoratives/SelfRespawn', 1, 0, 3, 1, 0, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00', '/Lotus/Types/Restoratives/SelfRespawn');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('A3A097E4-49F4-4E81-A09A-AF9F577AEC22', '/Lotus/Types/Restoratives/SelfRevive', 1, 1500, 4, 1, 1, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00', '/Lotus/Types/Restoratives/SelfRevive');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('54CB4474-11D3-4193-B07D-F0B2655343EA', '/Lotus/Types/Restoratives/SelfRifleAmmo', 1, 1000, 0, 0, 1, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00', '/Lotus/Types/Restoratives/SelfRifleAmmo');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('2318011C-9BEA-425D-9E63-55A9F88AC3F2', '/Lotus/Types/Restoratives/SelfShieldHeal', 1, 100, 0, 0, 1, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00', '/Lotus/Types/Restoratives/SelfShieldHeal');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('E94DE942-0310-4374-9A8F-AD467C97C228', '/Lotus/Types/Restoratives/SelfShotgunAmmo', 1, 1000, 0, 0, 1, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00', '/Lotus/Types/Restoratives/SelfShotgunAmmo');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('FDC6F3E6-46D4-4FC5-9928-4937080DD77C', '/Lotus/Types/Restoratives/SelfSniperAmmo', 1, 1000, 0, 0, 1, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00', '/Lotus/Types/Restoratives/SelfSniperAmmo');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('352A5164-6ACE-4098-ADA1-FBBA902BC006', '/Lotus/Types/Restoratives/TeamHeal', 1, 750, 0, 0, 1, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00', '/Lotus/Types/Restoratives/TeamHeal');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('590DE8DF-2A5C-49E5-B4E2-10DDE8CC5DEB', '/Lotus/Types/Boosters/AffinityBooster', 1, 0, 0, 0, 0, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00', '/Lotus/Types/Boosters/AffinityBooster');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('86439153-CC8B-41E2-AA80-7DCAE8421CE6', '/Lotus/Types/Boosters/CreditBooster', 1, 0, 0, 0, 0, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00', '/Lotus/Types/Boosters/CreditBooster');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('E5179698-37F6-4AE3-BC65-4BB7702BE66A', '/Lotus/Types/Boosters/ReviveBooster', 1, 0, 0, 0, 0, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00', '/Lotus/Types/Boosters/ReviveBooster');    



INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('A34F9C6D-BDB6-4639-8841-6EEA79382B69', '/Lotus/Types/Restoratives/ChargeableSelfHeal', 1, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('6AD5D3F9-9D59-4FAC-B6D8-B60C6B13CFCC', '/Lotus/Types/Restoratives/SelfHealLarge', 1, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('286EA647-A3CD-4565-B0F7-BC4DCBE87ADE', '/Lotus/Types/Restoratives/SelfHealSmall', 1, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('2709DA2D-AD18-48F7-A74D-CAD52D6F2E81', '/Lotus/Types/Restoratives/SelfOmniAmmo', 1, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('D619103B-1F80-41D1-99A8-90DF7A1B67BB', '/Lotus/Types/Restoratives/SelfPistolAmmo', 1, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('DDDA59D0-5BFA-4DB5-A800-7F4FD4CCB16B', '/Lotus/Types/Restoratives/SelfRespawn', 1, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('A3A097E4-49F4-4E81-A09A-AF9F577AEC22', '/Lotus/Types/Restoratives/SelfRevive', 1, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('54CB4474-11D3-4193-B07D-F0B2655343EA', '/Lotus/Types/Restoratives/SelfRifleAmmo', 1, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('2318011C-9BEA-425D-9E63-55A9F88AC3F2', '/Lotus/Types/Restoratives/SelfShieldHeal', 1, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('E94DE942-0310-4374-9A8F-AD467C97C228', '/Lotus/Types/Restoratives/SelfShotgunAmmo', 1, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('FDC6F3E6-46D4-4FC5-9928-4937080DD77C', '/Lotus/Types/Restoratives/SelfSniperAmmo', 1, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('352A5164-6ACE-4098-ADA1-FBBA902BC006', '/Lotus/Types/Restoratives/TeamHeal', 1, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('590DE8DF-2A5C-49E5-B4E2-10DDE8CC5DEB', '/Lotus/Types/Boosters/AffinityBooster', 1, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('86439153-CC8B-41E2-AA80-7DCAE8421CE6', '/Lotus/Types/Boosters/CreditBooster', 1, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('E5179698-37F6-4AE3-BC65-4BB7702BE66A', '/Lotus/Types/Boosters/ReviveBooster', 1, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00');

INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('5223C0DA-44D0-42F9-9F9B-A3A347DE2162', 'A34F9C6D-BDB6-4639-8841-6EEA79382B69', '/Lotus/Types/Restoratives/ChargeableSelfHeal', 'ChargeableSelfHeal', 2, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('750445E9-B83E-47B1-8F3C-F7AAA2494A2E', '6AD5D3F9-9D59-4FAC-B6D8-B60C6B13CFCC', '/Lotus/Types/Restoratives/SelfHealLarge', 'SelfHealLarge', 2, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('8E66DB0D-E7E9-471C-886E-F3AB872B5BE3', '286EA647-A3CD-4565-B0F7-BC4DCBE87ADE', '/Lotus/Types/Restoratives/SelfHealSmall', 'SelfHealSmall', 2, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('886EB7B7-F40A-47F3-A830-AAAF8F698BA9', '2709DA2D-AD18-48F7-A74D-CAD52D6F2E81', '/Lotus/Types/Restoratives/SelfOmniAmmo', 'SelfOmniAmmo', 2, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('80CBB2BC-FBF0-4ACB-9DE3-0E96764B1D7B', 'D619103B-1F80-41D1-99A8-90DF7A1B67BB', '/Lotus/Types/Restoratives/SelfPistolAmmo', 'SelfPistolAmmo', 2, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('F16CC269-C278-4B40-985F-340EAAFCFBF0', 'DDDA59D0-5BFA-4DB5-A800-7F4FD4CCB16B', '/Lotus/Types/Restoratives/SelfRespawn', 'SelfRespawn', 2, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('48F7B18D-1392-4BB6-AFD8-C7BECAD9027B', 'A3A097E4-49F4-4E81-A09A-AF9F577AEC22', '/Lotus/Types/Restoratives/SelfRevive', 'SelfRevive', 2, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('F5513DFD-8D90-4028-84A9-7AF671CC4816', '54CB4474-11D3-4193-B07D-F0B2655343EA', '/Lotus/Types/Restoratives/SelfRifleAmmo', 'SelfRifleAmmo', 2, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('685126F4-4315-4F30-BF32-96676A531DCA', '2318011C-9BEA-425D-9E63-55A9F88AC3F2', '/Lotus/Types/Restoratives/SelfShieldHeal', 'SelfShieldHeal', 2, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('89E97365-4073-4C03-823A-095F4323832D', 'E94DE942-0310-4374-9A8F-AD467C97C228', '/Lotus/Types/Restoratives/SelfShotgunAmmo', 'SelfShotgunAmmo', 2, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('B0BF6E24-99E6-44EE-BCBE-77EB26879A94', 'FDC6F3E6-46D4-4FC5-9928-4937080DD77C', '/Lotus/Types/Restoratives/SelfSniperAmmo', 'SelfSniperAmmo', 2, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('614A528E-27F2-4507-95ED-5BE93BA12A8B', '352A5164-6ACE-4098-ADA1-FBBA902BC006', '/Lotus/Types/Restoratives/TeamHeal', 'TeamHeal', 2, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('738E01F5-47E3-47DF-BD09-109CC784DEB5', '590DE8DF-2A5C-49E5-B4E2-10DDE8CC5DEB', '/Lotus/Types/Boosters/AffinityBooster', 'AffinityBooster', 8, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('EAAECB1A-2F43-4434-AB73-5529FD6DAAA5', '86439153-CC8B-41E2-AA80-7DCAE8421CE6', '/Lotus/Types/Boosters/CreditBooster', 'CreditBooster', 8, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('8A6D85F0-AC20-4786-BF18-0B05E51E16A6', 'E5179698-37F6-4AE3-BC65-4BB7702BE66A', '/Lotus/Types/Boosters/ReviveBooster', 'ReviveBooster', 8, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-09 00:00:00.000000-05:00', '2025-08-09 00:00:00.000000-05:00', 0, 4, 0);

");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}