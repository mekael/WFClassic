using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddFoundryMarketItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('ABBE0F34-341A-4B90-976B-AFA5A4297362', '/Lotus/Weapons/Tenno/Akimbo/AkimboPistol', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('AB0383C0-B105-41F4-9233-FF0BEAE304DA', '/Lotus/Weapons/Tenno/Pistol/AutoPistol', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('AB1E136C-41AA-492A-9596-66F6DEDA95A7', '/Lotus/Weapons/Tenno/Pistol/BurstPistol', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('ABC2E164-49F8-4EF7-BA00-4433608ED47C', '/Lotus/Weapons/Tenno/Rifle/BurstRifle', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('AB260C26-C169-4966-8BC4-2822CDE7C113', '/Lotus/Weapons/Tenno/Melee/DualShortSword/DualShortSword', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('AB56B60B-AB8F-458B-95C2-E035C08E4924', '/Lotus/Weapons/Tenno/Melee/Fist/Fist', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('AB985677-1CCD-4DA0-9986-504359CEE4F9', '/Lotus/Weapons/Tenno/Shotgun/FullAutoShotgun', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('ABCA4F5D-94D3-49C1-876C-6691C0B881DC', '/Lotus/Weapons/Tenno/Pistol/HandShotGun', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('AB14421F-2513-4A48-91B3-641181E54BA2', '/Lotus/Weapons/Tenno/Pistol/HeavyPistol', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('ABBEA529-6034-4583-80F4-A0AEAAF7CBBE', '/Lotus/Weapons/Tenno/Rifle/HeavyRifle', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('ABC4CD29-E091-4D1C-95E1-D47FAD799F3A', '/Lotus/Weapons/Tenno/Melee/LongSword/LongSword', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('AB17007A-A395-4DDE-B4F6-8F5602AECA2B', '/Lotus/Weapons/Tenno/Pistol/Pistol', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('AB35E281-AF57-4DC2-9788-C42C128612B4', '/Lotus/Weapons/Tenno/Rifle/Rifle', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('ABEBC6DC-7DB2-46C8-A66E-F0134E9ADA87', '/Lotus/Weapons/Tenno/Rifle/SemiAutoRifle', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('AB215FC7-1AB0-47BC-9F47-71524EC20F74', '/Lotus/Weapons/Tenno/Shotgun/Shotgun', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('ABA88984-FDAF-4877-A256-99D7354C549E', '/Lotus/Weapons/Tenno/Rifle/SniperRifle', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('AB2D3E1C-F679-4463-827F-0A03642FDBF1', '/Lotus/Weapons/Tenno/Melee/Staff/Staff', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('AB64CBB1-9334-48DF-8CC9-4127E3D56E12', '/Lotus/Weapons/Tenno/Rifle/StartingRifle', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('AB081E15-6C53-499F-881A-BF81116AA39B', '/Lotus/Weapons/Tenno/Rifle/VIPRifle', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00');



INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('AB9FD9C8-E7C3-4BDA-8A19-E96289A118FE', 'ABBE0F34-341A-4B90-976B-AFA5A4297362', '/Lotus/Weapons/Tenno/Akimbo/AkimboPistol', 'AkimboPistol', 0, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00', 1, 1, -1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('ABEBEDB9-47D7-469F-A19A-9444B2AA9E94', 'AB0383C0-B105-41F4-9233-FF0BEAE304DA', '/Lotus/Weapons/Tenno/Pistol/AutoPistol', 'AutoPistol', 0, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00', 1, 1, -1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('AB9E1530-71C1-45A7-8068-F016E632343D', 'AB1E136C-41AA-492A-9596-66F6DEDA95A7', '/Lotus/Weapons/Tenno/Pistol/BurstPistol', 'BurstPistol', 0, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00', 1, 1, -1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('AB3FA58A-6599-4577-9C00-396C900D2B27', 'ABC2E164-49F8-4EF7-BA00-4433608ED47C', '/Lotus/Weapons/Tenno/Rifle/BurstRifle', 'BurstRifle', 1, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00', 1, 1, -1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('ABF01F52-3C47-4C08-8486-390DCCA32235', 'AB260C26-C169-4966-8BC4-2822CDE7C113', '/Lotus/Weapons/Tenno/Melee/DualShortSword/DualShortSword', 'DualShortSword', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00', 1, 1, -1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('ABC2E36B-38C3-4F30-BC44-F1E6230FEB47', 'AB56B60B-AB8F-458B-95C2-E035C08E4924', '/Lotus/Weapons/Tenno/Melee/Fist/Fist', 'Fist', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00', 1, 1, -1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('AB756103-EBC9-4116-86D8-B36601BCB4F9', 'AB985677-1CCD-4DA0-9986-504359CEE4F9', '/Lotus/Weapons/Tenno/Shotgun/FullAutoShotgun', 'FullAutoShotgun', 1, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00', 1, 1, -1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('ABF33EFE-7568-4A64-AAE8-3A0F7F26988E', 'ABCA4F5D-94D3-49C1-876C-6691C0B881DC', '/Lotus/Weapons/Tenno/Pistol/HandShotGun', 'HandShotGun', 0, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00', 1, 1, -1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('AB1E3C1D-9477-448B-B2DC-A1CFDD43E183', 'AB14421F-2513-4A48-91B3-641181E54BA2', '/Lotus/Weapons/Tenno/Pistol/HeavyPistol', 'HeavyPistol', 0, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00', 1, 1, -1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('AB7A0119-3342-41FC-8CC8-0451EB3906D7', 'ABBEA529-6034-4583-80F4-A0AEAAF7CBBE', '/Lotus/Weapons/Tenno/Rifle/HeavyRifle', 'HeavyRifle', 1, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00', 1, 1, -1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('AB8F6C96-F572-4391-9E71-8B6B1B1B2718', 'ABC4CD29-E091-4D1C-95E1-D47FAD799F3A', '/Lotus/Weapons/Tenno/Melee/LongSword/LongSword', 'LongSword', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00', 1, 1, -1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('AB15A59C-B35A-44C9-B2E7-40813A2A543E', 'AB17007A-A395-4DDE-B4F6-8F5602AECA2B', '/Lotus/Weapons/Tenno/Pistol/Pistol', 'Pistol', 0, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00', 1, 1, -1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('ABD9D387-8DC1-4AB7-89C5-106D3393C0C1', 'AB35E281-AF57-4DC2-9788-C42C128612B4', '/Lotus/Weapons/Tenno/Rifle/Rifle', 'Rifle', 1, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00', 1, 1, -1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('AB18600C-ECC7-458A-BD48-22C0BC184CE8', 'ABEBC6DC-7DB2-46C8-A66E-F0134E9ADA87', '/Lotus/Weapons/Tenno/Rifle/SemiAutoRifle', 'SemiAutoRifle', 1, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00', 1, 1, -1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('AB679452-58FB-4FA3-863B-BFA86B93F8C6', 'AB215FC7-1AB0-47BC-9F47-71524EC20F74', '/Lotus/Weapons/Tenno/Shotgun/Shotgun', 'Shotgun', 1, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00', 1, 1, -1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('ABA7C199-FF90-4337-8FDE-0046B850EFED', 'ABA88984-FDAF-4877-A256-99D7354C549E', '/Lotus/Weapons/Tenno/Rifle/SniperRifle', 'SniperRifle', 1, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00', 1, 1, -1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('ABDDEC40-55F1-4331-9E66-DCF720BB4151', 'AB2D3E1C-F679-4463-827F-0A03642FDBF1', '/Lotus/Weapons/Tenno/Melee/Staff/Staff', 'Staff', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00', 1, 1, -1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('AB0451E7-4899-4B9F-88B6-CD23D7EEF80F', 'AB64CBB1-9334-48DF-8CC9-4127E3D56E12', '/Lotus/Weapons/Tenno/Rifle/StartingRifle', 'StartingRifle', 1, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00', 1, 1, -1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('ABEF61BC-60AA-42D4-9221-BA7D9AA74785', 'AB081E15-6C53-499F-881A-BF81116AA39B', '/Lotus/Weapons/Tenno/Rifle/VIPRifle', 'VIPRifle', 1, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-10-20 00:00:00.000000-05:00', '2025-10-20 00:00:00.000000-05:00', 1, 1, -1);


update WarframeItemComponents 
set NumberOfBinsToAdd = -1 * numberofbinstoadd
where numberofbinstoadd < 0;

");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
