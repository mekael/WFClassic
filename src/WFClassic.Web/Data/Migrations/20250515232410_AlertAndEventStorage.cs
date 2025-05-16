using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlertAndEventStorage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AlertConfigurations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    StartDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    AllowReplay = table.Column<int>(type: "INTEGER", nullable: false),
                    MissionType = table.Column<string>(type: "TEXT", nullable: true),
                    Faction = table.Column<string>(type: "TEXT", nullable: true),
                    UniqueName = table.Column<string>(type: "TEXT", nullable: true),
                    Icon = table.Column<string>(type: "TEXT", nullable: true),
                    Unlocked = table.Column<int>(type: "INTEGER", nullable: false),
                    Completions = table.Column<int>(type: "INTEGER", nullable: false),
                    Seed = table.Column<int>(type: "INTEGER", nullable: false),
                    Difficulty = table.Column<float>(type: "REAL", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    IntroText = table.Column<string>(type: "TEXT", nullable: true),
                    CompletionText = table.Column<string>(type: "TEXT", nullable: true),
                    Location = table.Column<string>(type: "TEXT", nullable: true),
                    LevelOverride = table.Column<string>(type: "TEXT", nullable: true),
                    EnemySpec = table.Column<string>(type: "TEXT", nullable: true),
                    VIPAgent = table.Column<string>(type: "TEXT", nullable: true),
                    MinEnemyLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxEnemyLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    CompleteTag = table.Column<string>(type: "TEXT", nullable: true),
                    CreationTimestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    LastModificationTimestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlertConfigurations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorldStateEventMessages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Message = table.Column<string>(type: "TEXT", nullable: true),
                    MessageType = table.Column<int>(type: "INTEGER", nullable: false),
                    Property = table.Column<string>(type: "TEXT", nullable: true),
                    MessageDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    MessageExpirationDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreationTimestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    LastModificationTimestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorldStateEventMessages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AlertEnemyConfigurations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AlertConfigurationId = table.Column<Guid>(type: "TEXT", nullable: false),
                    EnemyId = table.Column<string>(type: "TEXT", nullable: true),
                    Probability = table.Column<float>(type: "REAL", nullable: false),
                    MaxSimultaneous = table.Column<int>(type: "INTEGER", nullable: false),
                    Tier = table.Column<int>(type: "INTEGER", nullable: false),
                    CreationTimestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    LastModificationTimestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlertEnemyConfigurations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlertEnemyConfigurations_AlertConfigurations_AlertConfigurationId",
                        column: x => x.AlertConfigurationId,
                        principalTable: "AlertConfigurations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlertRewardConfigurations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AlertConfigurationId = table.Column<Guid>(type: "TEXT", nullable: false),
                    RewardProvidedAtLocation = table.Column<int>(type: "INTEGER", nullable: false),
                    Credits = table.Column<int>(type: "INTEGER", nullable: false),
                    Xp = table.Column<int>(type: "INTEGER", nullable: false),
                    RandomizedItems = table.Column<string>(type: "TEXT", nullable: true),
                    ItemsArray = table.Column<string>(type: "TEXT", nullable: true),
                    CreationTimestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    LastModificationTimestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlertRewardConfigurations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlertRewardConfigurations_AlertConfigurations_AlertConfigurationId",
                        column: x => x.AlertConfigurationId,
                        principalTable: "AlertConfigurations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlertEnemyConfigurations_AlertConfigurationId",
                table: "AlertEnemyConfigurations",
                column: "AlertConfigurationId");

            migrationBuilder.CreateIndex(
                name: "IX_AlertRewardConfigurations_AlertConfigurationId",
                table: "AlertRewardConfigurations",
                column: "AlertConfigurationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlertEnemyConfigurations");

            migrationBuilder.DropTable(
                name: "AlertRewardConfigurations");

            migrationBuilder.DropTable(
                name: "WorldStateEventMessages");

            migrationBuilder.DropTable(
                name: "AlertConfigurations");
        }
    }
}
