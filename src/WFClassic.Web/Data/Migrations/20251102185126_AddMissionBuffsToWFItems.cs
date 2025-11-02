using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddMissionBuffsToWFItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('4F5E1248-58EA-4A69-90DD-84A12B3725F4', '/Lotus/Types/Game/MissionBuffs/EnemyArmorReductionBuff', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('77EA0E41-2E59-4B42-88F7-15A0A097F68C', '/Lotus/Types/Game/MissionBuffs/EnemyShieldReductionBuff', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('229583E1-854C-4EF7-9F0E-ABC7554E317A', '/Lotus/Types/Game/MissionBuffs/InfestationSpeedReductionBuff', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('4313ACD0-71D7-4D1C-BBFE-EAF55C4B61FC', '/Lotus/Types/Game/MissionBuffs/PlayerElectricityImmunityBuff', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('44B63475-164E-4DB1-885A-40E885079FA2', '/Lotus/Types/Game/MissionBuffs/PlayerEnemyRadarBuff', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('B8D86BED-7F0B-41C3-87B2-27D35CF5FED8', '/Lotus/Types/Game/MissionBuffs/PlayerEnergyRegenBuff', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('BD0E34EF-B790-4153-96A0-862DD9D6DF98', '/Lotus/Types/Game/MissionBuffs/PlayerFireImmunityBuff', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('C142D342-79A5-47CD-9BA3-BAD1CC68449E', '/Lotus/Types/Game/MissionBuffs/PlayerFreezeImmunityBuff', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('D1127D72-E157-4814-B45C-EEF78F33B8E6', '/Lotus/Types/Game/MissionBuffs/PlayerHealthBuff', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('704664C1-E2D7-4353-8365-B48A4495297F', '/Lotus/Types/Game/MissionBuffs/PlayerHealthRegenBuff', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('79D88303-E3EE-4C21-B379-10D294873EFB', '/Lotus/Types/Game/MissionBuffs/PlayerLaserImmunityBuff', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('6F14C5DF-4938-4250-AFC8-A5677AAED93D', '/Lotus/Types/Game/MissionBuffs/PlayerLootRadarBuff', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('4931ECCB-F3A2-4AEF-BA67-BBA0017E1BE1', '/Lotus/Types/Game/MissionBuffs/PlayerMeleeBuff', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('3E5876B8-124E-475D-8051-E45FB3054D72', '/Lotus/Types/Game/MissionBuffs/PlayerPistolAmmoBuff', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('0CB2B2C1-9828-4B78-AEC6-0012ECBCA317', '/Lotus/Types/Game/MissionBuffs/PlayerPistolDamageBuff', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('EE16F12E-0B4D-4981-9615-31B3EC3E7633', '/Lotus/Types/Game/MissionBuffs/PlayerPoisonImmunityBuff', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('81BA2A97-A879-43F2-93A5-DBF47B714F91', '/Lotus/Types/Game/MissionBuffs/PlayerRifleAmmoBuff', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('EFE9361A-D427-49C2-9A8D-A96D7EBDB109', '/Lotus/Types/Game/MissionBuffs/PlayerRifleDamageBuff', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('F4152498-8DA4-4CF7-974B-7343633D6A3F', '/Lotus/Types/Game/MissionBuffs/PlayerShellAmmoBuff', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('CE4AB056-F416-44F6-865C-DEF4B882F3F8', '/Lotus/Types/Game/MissionBuffs/PlayerShellDamageBuff', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('882B9F24-172C-46D5-943F-5C46AE718284', '/Lotus/Types/Game/MissionBuffs/PlayerSniperAmmoBuff', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('08CD44AB-B885-4EA7-A6CC-88A3E28C3A99', '/Lotus/Types/Game/MissionBuffs/PlayerSniperDamageBuff', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('415E5A22-D7A6-40AA-9FB2-8E637AB69277', '/Lotus/Types/Game/MissionBuffs/PlayerSprintBuff', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('46B1642A-9AC1-4322-BC51-AFE39FC1D351', '/Lotus/Types/Game/MissionBuffs/PlayerXPBuff', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('A1B83049-5C8D-475D-BE9C-D0BC9908652F', '/Lotus/Types/Game/MissionBuffs/RobotPoorAimBuff', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00');



INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('4F5E1248-58EA-4A69-90DD-84A12B3725F4', '4F5E1248-58EA-4A69-90DD-84A12B3725F4', '/Lotus/Types/Game/MissionBuffs/EnemyArmorReductionBuff', 'EnemyArmorReductionBuff', 12, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00', 0, 0, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('77EA0E41-2E59-4B42-88F7-15A0A097F68C', '77EA0E41-2E59-4B42-88F7-15A0A097F68C', '/Lotus/Types/Game/MissionBuffs/EnemyShieldReductionBuff', 'EnemyShieldReductionBuff', 12, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00', 0, 0, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('229583E1-854C-4EF7-9F0E-ABC7554E317A', '229583E1-854C-4EF7-9F0E-ABC7554E317A', '/Lotus/Types/Game/MissionBuffs/InfestationSpeedReductionBuff', 'InfestationSpeedReductionBuff', 12, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00', 0, 0, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('4313ACD0-71D7-4D1C-BBFE-EAF55C4B61FC', '4313ACD0-71D7-4D1C-BBFE-EAF55C4B61FC', '/Lotus/Types/Game/MissionBuffs/PlayerElectricityImmunityBuff', 'PlayerElectricityImmunityBuff', 12, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00', 0, 0, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('44B63475-164E-4DB1-885A-40E885079FA2', '44B63475-164E-4DB1-885A-40E885079FA2', '/Lotus/Types/Game/MissionBuffs/PlayerEnemyRadarBuff', 'PlayerEnemyRadarBuff', 12, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00', 0, 0, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('B8D86BED-7F0B-41C3-87B2-27D35CF5FED8', 'B8D86BED-7F0B-41C3-87B2-27D35CF5FED8', '/Lotus/Types/Game/MissionBuffs/PlayerEnergyRegenBuff', 'PlayerEnergyRegenBuff', 12, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00', 0, 0, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('BD0E34EF-B790-4153-96A0-862DD9D6DF98', 'BD0E34EF-B790-4153-96A0-862DD9D6DF98', '/Lotus/Types/Game/MissionBuffs/PlayerFireImmunityBuff', 'PlayerFireImmunityBuff', 12, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00', 0, 0, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('C142D342-79A5-47CD-9BA3-BAD1CC68449E', 'C142D342-79A5-47CD-9BA3-BAD1CC68449E', '/Lotus/Types/Game/MissionBuffs/PlayerFreezeImmunityBuff', 'PlayerFreezeImmunityBuff', 12, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00', 0, 0, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('D1127D72-E157-4814-B45C-EEF78F33B8E6', 'D1127D72-E157-4814-B45C-EEF78F33B8E6', '/Lotus/Types/Game/MissionBuffs/PlayerHealthBuff', 'PlayerHealthBuff', 12, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00', 0, 0, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('704664C1-E2D7-4353-8365-B48A4495297F', '704664C1-E2D7-4353-8365-B48A4495297F', '/Lotus/Types/Game/MissionBuffs/PlayerHealthRegenBuff', 'PlayerHealthRegenBuff', 12, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00', 0, 0, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('79D88303-E3EE-4C21-B379-10D294873EFB', '79D88303-E3EE-4C21-B379-10D294873EFB', '/Lotus/Types/Game/MissionBuffs/PlayerLaserImmunityBuff', 'PlayerLaserImmunityBuff', 12, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00', 0, 0, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('6F14C5DF-4938-4250-AFC8-A5677AAED93D', '6F14C5DF-4938-4250-AFC8-A5677AAED93D', '/Lotus/Types/Game/MissionBuffs/PlayerLootRadarBuff', 'PlayerLootRadarBuff', 12, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00', 0, 0, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('4931ECCB-F3A2-4AEF-BA67-BBA0017E1BE1', '4931ECCB-F3A2-4AEF-BA67-BBA0017E1BE1', '/Lotus/Types/Game/MissionBuffs/PlayerMeleeBuff', 'PlayerMeleeBuff', 12, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00', 0, 0, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('3E5876B8-124E-475D-8051-E45FB3054D72', '3E5876B8-124E-475D-8051-E45FB3054D72', '/Lotus/Types/Game/MissionBuffs/PlayerPistolAmmoBuff', 'PlayerPistolAmmoBuff', 12, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00', 0, 0, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('0CB2B2C1-9828-4B78-AEC6-0012ECBCA317', '0CB2B2C1-9828-4B78-AEC6-0012ECBCA317', '/Lotus/Types/Game/MissionBuffs/PlayerPistolDamageBuff', 'PlayerPistolDamageBuff', 12, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00', 0, 0, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('EE16F12E-0B4D-4981-9615-31B3EC3E7633', 'EE16F12E-0B4D-4981-9615-31B3EC3E7633', '/Lotus/Types/Game/MissionBuffs/PlayerPoisonImmunityBuff', 'PlayerPoisonImmunityBuff', 12, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00', 0, 0, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('81BA2A97-A879-43F2-93A5-DBF47B714F91', '81BA2A97-A879-43F2-93A5-DBF47B714F91', '/Lotus/Types/Game/MissionBuffs/PlayerRifleAmmoBuff', 'PlayerRifleAmmoBuff', 12, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00', 0, 0, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('EFE9361A-D427-49C2-9A8D-A96D7EBDB109', 'EFE9361A-D427-49C2-9A8D-A96D7EBDB109', '/Lotus/Types/Game/MissionBuffs/PlayerRifleDamageBuff', 'PlayerRifleDamageBuff', 12, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00', 0, 0, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('F4152498-8DA4-4CF7-974B-7343633D6A3F', 'F4152498-8DA4-4CF7-974B-7343633D6A3F', '/Lotus/Types/Game/MissionBuffs/PlayerShellAmmoBuff', 'PlayerShellAmmoBuff', 12, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00', 0, 0, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('CE4AB056-F416-44F6-865C-DEF4B882F3F8', 'CE4AB056-F416-44F6-865C-DEF4B882F3F8', '/Lotus/Types/Game/MissionBuffs/PlayerShellDamageBuff', 'PlayerShellDamageBuff', 12, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00', 0, 0, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('882B9F24-172C-46D5-943F-5C46AE718284', '882B9F24-172C-46D5-943F-5C46AE718284', '/Lotus/Types/Game/MissionBuffs/PlayerSniperAmmoBuff', 'PlayerSniperAmmoBuff', 12, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00', 0, 0, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('08CD44AB-B885-4EA7-A6CC-88A3E28C3A99', '08CD44AB-B885-4EA7-A6CC-88A3E28C3A99', '/Lotus/Types/Game/MissionBuffs/PlayerSniperDamageBuff', 'PlayerSniperDamageBuff', 12, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00', 0, 0, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('415E5A22-D7A6-40AA-9FB2-8E637AB69277', '415E5A22-D7A6-40AA-9FB2-8E637AB69277', '/Lotus/Types/Game/MissionBuffs/PlayerSprintBuff', 'PlayerSprintBuff', 12, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00', 0, 0, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('46B1642A-9AC1-4322-BC51-AFE39FC1D351', '46B1642A-9AC1-4322-BC51-AFE39FC1D351', '/Lotus/Types/Game/MissionBuffs/PlayerXPBuff', 'PlayerXPBuff', 12, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00', 0, 0, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('A1B83049-5C8D-475D-BE9C-D0BC9908652F', 'A1B83049-5C8D-475D-BE9C-D0BC9908652F', '/Lotus/Types/Game/MissionBuffs/RobotPoorAimBuff', 'RobotPoorAimBuff', 12, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-11-02 00:00:00.000000-05:00', '2025-11-02 00:00:00.000000-05:00', 0, 0, 0);
");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
