using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SkinsMarketPackages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"


INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('0D235048-B35F-4F19-89F5-987033351CF8', '/Lotus/Upgrades/Skins/Axe/DaggerAxe', 0, 0, 75, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('88E4B1B3-76AE-4F0F-A6A1-04952118561E', '/Lotus/Upgrades/Skins/Decree/DecreeAltHelmet', 0, 0, 75, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('A46D33BB-A922-496E-B60F-6EC8F4331A6D', '/Lotus/Upgrades/Skins/Sentinels/Tails/CapsuleTail', 0, 0, 15, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('037F3176-058C-4443-A17C-00DFB37119C1', '/Lotus/Upgrades/Skins/Sentinels/Wings/DiamondWings', 0, 0, 15, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('81D7B81D-823B-4FA9-A51B-5FAC2E590A36', '/Lotus/Upgrades/Skins/Sentinels/Wings/DomeWings', 0, 0, 20, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('6EF31E12-0AA3-49EE-808D-898EE46E757A', '/Lotus/Upgrades/Skins/DualAxe/DaggerAxe', 0, 0, 75, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('1A3398CD-8888-4680-91EB-05B6721D4FFE', '/Lotus/Upgrades/Skins/Ember/EmberHelmetAlt', 0, 0, 75, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('6E23CA0A-FB49-4A59-B34A-02531F84DAD4', '/Lotus/Upgrades/Skins/Excalibur/ExcaliburHelmetAlt', 0, 0, 75, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('4CDAA835-EADC-4350-8991-77A2241A5FDD', '/Lotus/Upgrades/Skins/Frost/FrostHelmetAlt', 0, 0, 75, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('D33F48F9-6B1D-4DF5-8965-D4950FABEFDC', '/Lotus/Upgrades/Skins/HeavyAxe/GrnAxe', 0, 0, 75, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('355A56FE-AA0D-460F-AEA6-24A6FBF2CB10', '/Lotus/Upgrades/Skins/Hammer/GrnHammer', 0, 0, 75, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('25265487-880D-4DB7-B6C3-A6976C5DD71C', '/Lotus/Upgrades/Skins/Sentinels/Masks/HunhowMask', 0, 0, 15, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('9CA24A2C-6C2E-4D53-9A23-9C8BB4EA762A', '/Lotus/Upgrades/Skins/Jade/JadeHelmetAlt', 0, 0, 75, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('2747EF89-839D-4DED-842B-D85EDDFAF1A8', '/Lotus/Upgrades/Skins/Sentinels/Masks/KubrowMask', 0, 0, 20, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('D6851597-4628-4322-85B7-822E74A4C126', '/Lotus/Upgrades/Skins/Loki/LokiHelmetAlt', 0, 0, 75, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('8A5E857C-86B5-42F5-9989-17F5E8E10CA8', '/Lotus/Upgrades/Skins/Sentinels/Masks/LotusMask', 0, 0, 30, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('E5FD8213-D8FD-4615-8C45-F4752EBEED34', '/Lotus/Upgrades/Skins/Mag/MagHelmetAlt', 0, 0, 75, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('45948BD9-800D-4EE1-B2D5-D475908C8F5A', '/Lotus/Upgrades/Skins/Ninja/NinjaHelmetAlt', 0, 0, 75, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('2E1EF964-6A43-421C-B1B6-C38B91DFA482', '/Lotus/Upgrades/Skins/Rhino/RhinoHelmetAlt', 0, 0, 75, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('A5FEC660-FF02-4FE4-B2B5-CE1451431D50', '/Lotus/Upgrades/Skins/Asp/AspAltHelmet', 0, 0, 75, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('58266BE0-2C5C-4AAB-AC07-21B313099758', '/Lotus/Upgrades/Skins/Trinity/TrinityHelmetAlt', 0, 0, 75, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('F017C0BE-2C18-46EF-81F8-5A278CFA5181', '/Lotus/Upgrades/Skins/Volt/VoltHelmetAlt', 0, 0, 75, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');












INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('0D235048-B35F-4F19-89F5-987033351CF8', '0D235048-B35F-4F19-89F5-987033351CF8', 6, 1, 0, 1, '/Lotus/Upgrades/Skins/Axe/DaggerAxe', 'DaggerAxe', 0, 0, 0, '', 0, 0, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('88E4B1B3-76AE-4F0F-A6A1-04952118561E', '88E4B1B3-76AE-4F0F-A6A1-04952118561E', 6, 1, 0, 1, '/Lotus/Upgrades/Skins/Decree/DecreeAltHelmet', 'DecreeAltHelmet', 0, 0, 0, '', 0, 0, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('A46D33BB-A922-496E-B60F-6EC8F4331A6D', 'A46D33BB-A922-496E-B60F-6EC8F4331A6D', 6, 1, 0, 1, '/Lotus/Upgrades/Skins/Sentinels/Tails/CapsuleTail', 'CapsuleTail', 0, 0, 0, '', 0, 0, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('037F3176-058C-4443-A17C-00DFB37119C1', '037F3176-058C-4443-A17C-00DFB37119C1', 6, 1, 0, 1, '/Lotus/Upgrades/Skins/Sentinels/Wings/DiamondWings', 'DiamondWings', 0, 0, 0, '', 0, 0, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('81D7B81D-823B-4FA9-A51B-5FAC2E590A36', '81D7B81D-823B-4FA9-A51B-5FAC2E590A36', 6, 1, 0, 1, '/Lotus/Upgrades/Skins/Sentinels/Wings/DomeWings', 'DomeWings', 0, 0, 0, '', 0, 0, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('6EF31E12-0AA3-49EE-808D-898EE46E757A', '6EF31E12-0AA3-49EE-808D-898EE46E757A', 6, 1, 0, 1, '/Lotus/Upgrades/Skins/DualAxe/DaggerAxe', 'DaggerAxe', 0, 0, 0, '', 0, 0, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('1A3398CD-8888-4680-91EB-05B6721D4FFE', '1A3398CD-8888-4680-91EB-05B6721D4FFE', 6, 1, 0, 1, '/Lotus/Upgrades/Skins/Ember/EmberHelmetAlt', 'EmberHelmetAlt', 0, 0, 0, '', 0, 0, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('6E23CA0A-FB49-4A59-B34A-02531F84DAD4', '6E23CA0A-FB49-4A59-B34A-02531F84DAD4', 6, 1, 0, 1, '/Lotus/Upgrades/Skins/Excalibur/ExcaliburHelmetAlt', 'ExcaliburHelmetAlt', 0, 0, 0, '', 0, 0, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('4CDAA835-EADC-4350-8991-77A2241A5FDD', '4CDAA835-EADC-4350-8991-77A2241A5FDD', 6, 1, 0, 1, '/Lotus/Upgrades/Skins/Frost/FrostHelmetAlt', 'FrostHelmetAlt', 0, 0, 0, '', 0, 0, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('D33F48F9-6B1D-4DF5-8965-D4950FABEFDC', 'D33F48F9-6B1D-4DF5-8965-D4950FABEFDC', 6, 1, 0, 1, '/Lotus/Upgrades/Skins/HeavyAxe/GrnAxe', 'GrnAxe', 0, 0, 0, '', 0, 0, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('355A56FE-AA0D-460F-AEA6-24A6FBF2CB10', '355A56FE-AA0D-460F-AEA6-24A6FBF2CB10', 6, 1, 0, 1, '/Lotus/Upgrades/Skins/Hammer/GrnHammer', 'GrnHammer', 0, 0, 0, '', 0, 0, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('25265487-880D-4DB7-B6C3-A6976C5DD71C', '25265487-880D-4DB7-B6C3-A6976C5DD71C', 6, 1, 0, 1, '/Lotus/Upgrades/Skins/Sentinels/Masks/HunhowMask', 'HunhowMask', 0, 0, 0, '', 0, 0, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('9CA24A2C-6C2E-4D53-9A23-9C8BB4EA762A', '9CA24A2C-6C2E-4D53-9A23-9C8BB4EA762A', 6, 1, 0, 1, '/Lotus/Upgrades/Skins/Jade/JadeHelmetAlt', 'JadeHelmetAlt', 0, 0, 0, '', 0, 0, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('2747EF89-839D-4DED-842B-D85EDDFAF1A8', '2747EF89-839D-4DED-842B-D85EDDFAF1A8', 6, 1, 0, 1, '/Lotus/Upgrades/Skins/Sentinels/Masks/KubrowMask', 'KubrowMask', 0, 0, 0, '', 0, 0, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('D6851597-4628-4322-85B7-822E74A4C126', 'D6851597-4628-4322-85B7-822E74A4C126', 6, 1, 0, 1, '/Lotus/Upgrades/Skins/Loki/LokiHelmetAlt', 'LokiHelmetAlt', 0, 0, 0, '', 0, 0, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('8A5E857C-86B5-42F5-9989-17F5E8E10CA8', '8A5E857C-86B5-42F5-9989-17F5E8E10CA8', 6, 1, 0, 1, '/Lotus/Upgrades/Skins/Sentinels/Masks/LotusMask', 'LotusMask', 0, 0, 0, '', 0, 0, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('E5FD8213-D8FD-4615-8C45-F4752EBEED34', 'E5FD8213-D8FD-4615-8C45-F4752EBEED34', 6, 1, 0, 1, '/Lotus/Upgrades/Skins/Mag/MagHelmetAlt', 'MagHelmetAlt', 0, 0, 0, '', 0, 0, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('45948BD9-800D-4EE1-B2D5-D475908C8F5A', '45948BD9-800D-4EE1-B2D5-D475908C8F5A', 6, 1, 0, 1, '/Lotus/Upgrades/Skins/Ninja/NinjaHelmetAlt', 'NinjaHelmetAlt', 0, 0, 0, '', 0, 0, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('2E1EF964-6A43-421C-B1B6-C38B91DFA482', '2E1EF964-6A43-421C-B1B6-C38B91DFA482', 6, 1, 0, 1, '/Lotus/Upgrades/Skins/Rhino/RhinoHelmetAlt', 'RhinoHelmetAlt', 0, 0, 0, '', 0, 0, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('A5FEC660-FF02-4FE4-B2B5-CE1451431D50', 'A5FEC660-FF02-4FE4-B2B5-CE1451431D50', 6, 1, 0, 1, '/Lotus/Upgrades/Skins/Asp/AspAltHelmet', 'AspAltHelmet', 0, 0, 0, '', 0, 0, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('58266BE0-2C5C-4AAB-AC07-21B313099758', '58266BE0-2C5C-4AAB-AC07-21B313099758', 6, 1, 0, 1, '/Lotus/Upgrades/Skins/Trinity/TrinityHelmetAlt', 'TrinityHelmetAlt', 0, 0, 0, '', 0, 0, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('F017C0BE-2C18-46EF-81F8-5A278CFA5181', 'F017C0BE-2C18-46EF-81F8-5A278CFA5181', 6, 1, 0, 1, '/Lotus/Upgrades/Skins/Volt/VoltHelmetAlt', 'VoltHelmetAlt', 0, 0, 0, '', 0, 0, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');



");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}