using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddElionWorkaroundMission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"INSERT INTO AlertConfigurations
(Id, IsActive, StartDate, EndDate, AllowReplay, MissionType, Faction, UniqueName, Icon, Unlocked, Completions, Seed, Difficulty, Description, IntroText, CompletionText, Location, LevelOverride, EnemySpec, VIPAgent, MinEnemyLevel, MaxEnemyLevel, CompleteTag, CreationTimestamp, LastModificationTimestamp, LevelKeyName, MaxWaveCount)
VALUES('FB8C45D9-FF24-48E9-8C37-EA8DDCCDDC42', 1, '2025-10-01 00:00:00.000000-05:00', '2055-07-01 00:00:00.000000-05:00', 1, 'MT_RESCUE', 'FC_GRINEER', '', '', 1, 0, 7843521, 0.1, 'Use this mission if the 8.x capture mission is bugged.', '', '', 'SolNode12', '/Lotus/Levels/Proc/Grineer/GrineerSimpleLevel', '/Lotus/Types/Game/GrineerSquadOne', '', 1, 1, 'SolNode12', '2025-11-14 00:00:00.000000-05:00', '2025-11-14 00:00:00.000000-05:00', NULL, 0);


INSERT INTO AlertRewardConfigurations
(Id, AlertConfigurationId, RewardProvidedAtLocation, Credits, Xp, RandomizedItems, ItemsArray, CreationTimestamp, LastModificationTimestamp)
VALUES('B1F44DCA-1716-49D8-AF6B-5D3B63E495BA', 'FB8C45D9-FF24-48E9-8C37-EA8DDCCDDC42', 0, 0, 0, '', '', '2025-11-14 00:00:00.000000-05:00', '2025-11-14 00:00:00.000000-05:00');

");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
