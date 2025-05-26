using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddRewardsSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from DailyRewardDefinitions");

            migrationBuilder.Sql(@"
INSERT INTO DailyRewardDefinitions
(Id, RewardType, Icon, ItemType, ProductCategory, Amount, Tier, DisplayName, Rarity, StreakStartDate, StreakEndDate, RandLowerBound, RandUpperBound, CreationTimestamp, LastModificationTimestamp)
VALUES('879649ed-e3f5-48e7-854a-6a2234cb0dce', 'RT_CREDITS', '/Lotus/Interface/Icons/Store/CreditBooster.png', '', 'Pistols', 2500, 1, '', 'COMMON', 0, 2, 1, 25, '2025-05-08 21:00:23.1978374-05:00', '2025-05-08 21:00:23.1978374-05:00');
INSERT INTO DailyRewardDefinitions
(Id, RewardType, Icon, ItemType, ProductCategory, Amount, Tier, DisplayName, Rarity, StreakStartDate, StreakEndDate, RandLowerBound, RandUpperBound, CreationTimestamp, LastModificationTimestamp)
VALUES('08ddf7a6-6ab8-48f2-9bf8-f905097ad8e3', 'RT_ITEM_XP', '/Lotus/Interface/Icons/Store/PistolB.png', '', 'Pistols', 600, 1, '', 'COMMON', 0, 2, 26, 50, '2025-05-08 21:00:23.1978374-05:00', '2025-05-08 21:00:23.1978374-05:00');
INSERT INTO DailyRewardDefinitions
(Id, RewardType, Icon, ItemType, ProductCategory, Amount, Tier, DisplayName, Rarity, StreakStartDate, StreakEndDate, RandLowerBound, RandUpperBound, CreationTimestamp, LastModificationTimestamp)
VALUES('91133d6c-be85-449a-b90e-42aced6c3684', 'RT_ITEM_XP', '/Lotus/Interface/Icons/Store/CorpusAutoRifle.png', '', 'LongGuns', 600, 1, '', 'COMMON', 0, 2, 51, 75, '2025-05-08 21:00:23.1978374-05:00', '2025-05-08 21:00:23.1978374-05:00');
INSERT INTO DailyRewardDefinitions
(Id, RewardType, Icon, ItemType, ProductCategory, Amount, Tier, DisplayName, Rarity, StreakStartDate, StreakEndDate, RandLowerBound, RandUpperBound, CreationTimestamp, LastModificationTimestamp)
VALUES('fe2cbc8b-a5d2-4e70-a83b-30c68dc717b0', 'RT_ITEM_XP', '/Lotus/Interface/Icons/Store/Excalibur.png', '', 'Suits', 600, 1, '', 'UNCOMMON', 0, 2, 76, 85, '2025-05-08 21:00:23.1978374-05:00', '2025-05-08 21:00:23.1978374-05:00');
INSERT INTO DailyRewardDefinitions
(Id, RewardType, Icon, ItemType, ProductCategory, Amount, Tier, DisplayName, Rarity, StreakStartDate, StreakEndDate, RandLowerBound, RandUpperBound, CreationTimestamp, LastModificationTimestamp)
VALUES('863a216e-d8fb-4c52-bc68-48d44a406bbd', 'RT_ITEM_XP', '/Lotus/Interface/Icons/Store/Skana.png', '', 'Melee', 600, 1, '', 'UNCOMMON', 0, 2, 86, 95, '2025-05-08 21:00:23.1978374-05:00', '2025-05-08 21:00:23.1978374-05:00');
INSERT INTO DailyRewardDefinitions
(Id, RewardType, Icon, ItemType, ProductCategory, Amount, Tier, DisplayName, Rarity, StreakStartDate, StreakEndDate, RandLowerBound, RandUpperBound, CreationTimestamp, LastModificationTimestamp)
VALUES('f5640b9c-3022-4118-9d84-72015a874ab5', 'RT_CREDITS', '/Lotus/Interface/Icons/Store/CreditBooster.png', '', 'Pistols', 5000, 2, '', 'COMMON', 3, 6, 84, 100, '2025-05-08 21:00:23.1978374-05:00', '2025-05-08 21:00:23.1978374-05:00');
INSERT INTO DailyRewardDefinitions
(Id, RewardType, Icon, ItemType, ProductCategory, Amount, Tier, DisplayName, Rarity, StreakStartDate, StreakEndDate, RandLowerBound, RandUpperBound, CreationTimestamp, LastModificationTimestamp)
VALUES('37a67ad3-f349-4d8b-9fd2-04844a26fb77', 'RT_ITEM_XP', '/Lotus/Interface/Icons/Store/PistolE.png', '', 'Pistols', 1200, 2, '', 'COMMON', 3, 6, 67, 83, '2025-05-08 21:00:23.1978374-05:00', '2025-05-08 21:00:23.1978374-05:00');
INSERT INTO DailyRewardDefinitions
(Id, RewardType, Icon, ItemType, ProductCategory, Amount, Tier, DisplayName, Rarity, StreakStartDate, StreakEndDate, RandLowerBound, RandUpperBound, CreationTimestamp, LastModificationTimestamp)
VALUES('e248b4bb-fbe2-4548-bbae-8aeafc60a2bd', 'RT_ITEM_XP', '/Lotus/Interface/Icons/Store/CorpusAutoRifle.png', '', 'LongGuns', 1200, 2, '', 'COMMON', 3, 6, 51, 66, '2025-05-08 21:00:23.1978374-05:00', '2025-05-08 21:00:23.1978374-05:00');
INSERT INTO DailyRewardDefinitions
(Id, RewardType, Icon, ItemType, ProductCategory, Amount, Tier, DisplayName, Rarity, StreakStartDate, StreakEndDate, RandLowerBound, RandUpperBound, CreationTimestamp, LastModificationTimestamp)
VALUES('42c7db14-8da7-4df9-b46a-2753dfb95430', 'RT_ITEM_XP', '/Lotus/Interface/Icons/Store/Excalibur.png', '', 'Suits', 1200, 2, '', 'COMMON', 3, 6, 34, 50, '2025-05-08 21:00:23.1978374-05:00', '2025-05-08 21:00:23.1978374-05:00');
INSERT INTO DailyRewardDefinitions
(Id, RewardType, Icon, ItemType, ProductCategory, Amount, Tier, DisplayName, Rarity, StreakStartDate, StreakEndDate, RandLowerBound, RandUpperBound, CreationTimestamp, LastModificationTimestamp)
VALUES('ec0e4077-e7ef-4e71-9cde-777feafead79', 'RT_ITEM_XP', '/Lotus/Interface/Icons/Store/Skana.png', '', 'Melee', 1200, 2, '', 'COMMON', 3, 6, 16, 33, '2025-05-08 21:00:23.1978374-05:00', '2025-05-08 21:00:23.1978374-05:00');
INSERT INTO DailyRewardDefinitions
(Id, RewardType, Icon, ItemType, ProductCategory, Amount, Tier, DisplayName, Rarity, StreakStartDate, StreakEndDate, RandLowerBound, RandUpperBound, CreationTimestamp, LastModificationTimestamp)
VALUES('36eca8a3-b64a-4f43-9a3b-7677869ce9d1', 'RT_RECIPE', '/Lotus/Interface/Icons/Store/Axe.png', '/Lotus/Types/Recipes/Weapons/AxeBlueprint', 'Pistols', 1, 2, '', 'UNCOMMON', 3, 6, 11, 15, '2025-05-08 21:00:23.1978374-05:00', '2025-05-08 21:00:23.1978374-05:00');
INSERT INTO DailyRewardDefinitions
(Id, RewardType, Icon, ItemType, ProductCategory, Amount, Tier, DisplayName, Rarity, StreakStartDate, StreakEndDate, RandLowerBound, RandUpperBound, CreationTimestamp, LastModificationTimestamp)
VALUES('7e380399-1eea-4fa7-94f3-5389bbe89dc7', 'RT_RECIPE', '/Lotus/Interface/Icons/Store/Furis.png', '/Lotus/Types/Recipes/Weapons/FurisBlueprint', 'Pistols', 1, 2, '', 'UNCOMMON', 3, 6, 6, 10, '2025-05-08 21:00:23.1978374-05:00', '2025-05-08 21:00:23.1978374-05:00');
INSERT INTO DailyRewardDefinitions
(Id, RewardType, Icon, ItemType, ProductCategory, Amount, Tier, DisplayName, Rarity, StreakStartDate, StreakEndDate, RandLowerBound, RandUpperBound, CreationTimestamp, LastModificationTimestamp)
VALUES('858726dd-8ddc-474c-9417-22be33875ee8', 'RT_RECIPE', '/Lotus/Interface/Icons/Store/GrineerAssaultRifle.png', '/Lotus/Types/Recipes/Weapons/GrnAssaultRifleBlueprint', 'Pistols', 1, 2, '', 'UNCOMMON', 3, 6, 1, 5, '2025-05-08 21:00:23.1978374-05:00', '2025-05-08 21:00:23.1978374-05:00');
INSERT INTO DailyRewardDefinitions
(Id, RewardType, Icon, ItemType, ProductCategory, Amount, Tier, DisplayName, Rarity, StreakStartDate, StreakEndDate, RandLowerBound, RandUpperBound, CreationTimestamp, LastModificationTimestamp)
VALUES('40e1145e-1c5c-4815-b7c7-548913a0a04e', 'RT_CREDITS', '/Lotus/Interface/Icons/Store/CreditBooster.png', '', 'Pistols', 10000, 3, '', 'COMMON', 7, 99999, 30, 69, '2025-05-08 21:00:23.1978374-05:00', '2025-05-08 21:00:23.1978374-05:00');
INSERT INTO DailyRewardDefinitions
(Id, RewardType, Icon, ItemType, ProductCategory, Amount, Tier, DisplayName, Rarity, StreakStartDate, StreakEndDate, RandLowerBound, RandUpperBound, CreationTimestamp, LastModificationTimestamp)
VALUES('05da91f2-c9a8-4d17-a1fb-fb28f477d7ef', 'RT_ITEM_XP', '/Lotus/Interface/Icons/Store/PistolE.png', '', 'Pistols', 2400, 3, '', 'COMMON', 7, 99999, 70, 79, '2025-05-08 21:00:23.1978374-05:00', '2025-05-08 21:00:23.1978374-05:00');
INSERT INTO DailyRewardDefinitions
(Id, RewardType, Icon, ItemType, ProductCategory, Amount, Tier, DisplayName, Rarity, StreakStartDate, StreakEndDate, RandLowerBound, RandUpperBound, CreationTimestamp, LastModificationTimestamp)
VALUES('2615e1ad-499b-4d66-9298-9cb0c9029553', 'RT_ITEM_XP', '/Lotus/Interface/Icons/Store/CorpusAutoRifle.png', '', 'LongGuns', 2400, 3, '', 'COMMON', 7, 99999, 80, 89, '2025-05-08 21:00:23.1978374-05:00', '2025-05-08 21:00:23.1978374-05:00');
INSERT INTO DailyRewardDefinitions
(Id, RewardType, Icon, ItemType, ProductCategory, Amount, Tier, DisplayName, Rarity, StreakStartDate, StreakEndDate, RandLowerBound, RandUpperBound, CreationTimestamp, LastModificationTimestamp)
VALUES('f66d6d4c-735f-46a5-9510-65df9590c2bc', 'RT_ITEM_XP', '/Lotus/Interface/Icons/Store/Excalibur.png', '', 'Suits', 2400, 3, '', 'COMMON', 7, 99999, 90, 100, '2025-05-08 21:00:23.1978374-05:00', '2025-05-08 21:00:23.1978374-05:00');
INSERT INTO DailyRewardDefinitions
(Id, RewardType, Icon, ItemType, ProductCategory, Amount, Tier, DisplayName, Rarity, StreakStartDate, StreakEndDate, RandLowerBound, RandUpperBound, CreationTimestamp, LastModificationTimestamp)
VALUES('ecd67078-e9eb-4d24-a6f2-e122bb910930', 'RT_RECIPE', '/Lotus/Interface/Icons/Store/Banshee.png', '/Lotus/Types/Recipes/WarframeRecipes/BansheeBlueprint', 'Pistols', 1, 3, '', 'UNCOMMON', 7, 99999, 25, 29, '2025-05-08 21:00:23.1978374-05:00', '2025-05-08 21:00:23.1978374-05:00');
INSERT INTO DailyRewardDefinitions
(Id, RewardType, Icon, ItemType, ProductCategory, Amount, Tier, DisplayName, Rarity, StreakStartDate, StreakEndDate, RandLowerBound, RandUpperBound, CreationTimestamp, LastModificationTimestamp)
VALUES('45fc6b91-1d6f-4c1e-9503-a3b888c0c9ca', 'RT_RECIPE', '/Lotus/Interface/Icons/Store/Engineer.png', '/Lotus/Types/Recipes/WarframeRecipes/TrapperBlueprint', 'Pistols', 1, 3, '', 'UNCOMMON', 7, 99999, 20, 24, '2025-05-08 21:00:23.1978374-05:00', '2025-05-08 21:00:23.1978374-05:00');
INSERT INTO DailyRewardDefinitions
(Id, RewardType, Icon, ItemType, ProductCategory, Amount, Tier, DisplayName, Rarity, StreakStartDate, StreakEndDate, RandLowerBound, RandUpperBound, CreationTimestamp, LastModificationTimestamp)
VALUES('7b3f9f51-a9c9-4bac-9ff3-d5fc1ac66090', 'RT_RECIPE', '/Lotus/Interface/Icons/Store/AxeSmall.png', '/Lotus/Types/Recipes/Weapons/DualAxeBlueprint', 'Pistols', 1, 3, '', 'UNCOMMON', 7, 99999, 15, 19, '2025-05-08 21:00:23.1978374-05:00', '2025-05-08 21:00:23.1978374-05:00');
INSERT INTO DailyRewardDefinitions
(Id, RewardType, Icon, ItemType, ProductCategory, Amount, Tier, DisplayName, Rarity, StreakStartDate, StreakEndDate, RandLowerBound, RandUpperBound, CreationTimestamp, LastModificationTimestamp)
VALUES('0b409b98-1184-476c-b718-535a78cd6202', 'RT_RECIPE', '/Lotus/Interface/Icons/Store/GlaiveLight.png', '/Lotus/Types/Recipes/Weapons/GlaiveBlueprint', 'Pistols', 1, 3, '', 'UNCOMMON', 7, 99999, 10, 14, '2025-05-08 21:00:23.1978374-05:00', '2025-05-08 21:00:23.1978374-05:00');
INSERT INTO DailyRewardDefinitions
(Id, RewardType, Icon, ItemType, ProductCategory, Amount, Tier, DisplayName, Rarity, StreakStartDate, StreakEndDate, RandLowerBound, RandUpperBound, CreationTimestamp, LastModificationTimestamp)
VALUES('91d6c17c-f526-4710-ab98-31c1cf5371b0', 'RT_RECIPE', '/Lotus/Interface/Icons/Store/Gorgon.png', '/Lotus/Types/Recipes/Weapons/GorgonBlueprint', 'Pistols', 1, 3, '', 'UNCOMMON', 7, 99999, 5, 9, '2025-05-08 21:00:23.1978374-05:00', '2025-05-08 21:00:23.1978374-05:00');
INSERT INTO DailyRewardDefinitions
(Id, RewardType, Icon, ItemType, ProductCategory, Amount, Tier, DisplayName, Rarity, StreakStartDate, StreakEndDate, RandLowerBound, RandUpperBound, CreationTimestamp, LastModificationTimestamp)
VALUES('07cd870f-9f88-4c6e-9931-3c8cb2e9a800', 'RT_RECIPE', '/Lotus/Interface/Icons/Store/ComponentCatalyst.png', '/Lotus/Types/Recipes/Components/OrokinCatalystBlueprint', 'Recipes', 1, 3, '', 'RARE', 7, 99999, 4, 4, '2025-05-08 21:00:23.1978374-05:00', '2025-05-08 21:00:23.1978374-05:00');
INSERT INTO DailyRewardDefinitions
(Id, RewardType, Icon, ItemType, ProductCategory, Amount, Tier, DisplayName, Rarity, StreakStartDate, StreakEndDate, RandLowerBound, RandUpperBound, CreationTimestamp, LastModificationTimestamp)
VALUES('8bdff07b-cd64-403c-973c-8c3ad85cf3a6', 'RT_RECIPE', '/Lotus/Interface/Icons/Store/ComponentReactor.png', '/Lotus/Types/Recipes/Components/OrokinReactorBlueprint', 'Recipes', 1, 3, '', 'RARE', 7, 99999, 3, 3, '2025-05-08 21:00:23.1978374-05:00', '2025-05-08 21:00:23.1978374-05:00');
INSERT INTO DailyRewardDefinitions
(Id, RewardType, Icon, ItemType, ProductCategory, Amount, Tier, DisplayName, Rarity, StreakStartDate, StreakEndDate, RandLowerBound, RandUpperBound, CreationTimestamp, LastModificationTimestamp)
VALUES('4b8de189-1c62-487d-984d-6c9cca97dd4d', 'RT_RECIPE', '/Lotus/Interface/Icons/Store/Ninja.png', '/Lotus/Types/Recipes/WarframeRecipes/AshBlueprint', 'Recipes', 1, 3, '', 'RARE', 7, 99999, 2, 2, '2025-05-08 21:00:23.1978374-05:00', '2025-05-08 21:00:23.1978374-05:00');
INSERT INTO DailyRewardDefinitions
(Id, RewardType, Icon, ItemType, ProductCategory, Amount, Tier, DisplayName, Rarity, StreakStartDate, StreakEndDate, RandLowerBound, RandUpperBound, CreationTimestamp, LastModificationTimestamp)
VALUES('e6cc2e11-a407-44ae-8ccb-102dd563ac33', 'RT_RECIPE', '/Lotus/Interface/Icons/Store/Ember.png', '/Lotus/Types/Recipes/WarframeRecipes/EmberBlueprint', 'Recipes', 1, 3, '', 'RARE', 7, 99999, 1, 1, '2025-05-08 21:00:23.1978374-05:00', '2025-05-08 21:00:23.1978374-05:00');
INSERT INTO DailyRewardDefinitions
(Id, RewardType, Icon, ItemType, ProductCategory, Amount, Tier, DisplayName, Rarity, StreakStartDate, StreakEndDate, RandLowerBound, RandUpperBound, CreationTimestamp, LastModificationTimestamp)
VALUES('31F6109C-D511-4FD2-A7EF-6874B72A4416', 'RT_ITEM_XP', '/Lotus/Interface/Icons/Store/Skana.png', '', 'Melee', 2400, 1, '', 'RARE', 0, 2, 96, 100, '2025-05-08 21:00:23.1978374-05:00', '2025-05-08 21:00:23.1978374-05:00');
");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
