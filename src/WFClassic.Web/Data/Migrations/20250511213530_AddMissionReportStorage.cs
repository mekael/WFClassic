using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddMissionReportStorage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MissionReports",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    PlayerId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nonce = table.Column<long>(type: "INTEGER", nullable: false),
                    HostId = table.Column<string>(type: "TEXT", nullable: true),
                    MissionStartTime = table.Column<string>(type: "TEXT", nullable: true),
                    MissionName = table.Column<string>(type: "TEXT", nullable: true),
                    ReporterId = table.Column<string>(type: "TEXT", nullable: true),
                    FullReport = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreationTimestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    LastModificationTimestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MissionReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MissionReports_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerReports",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    MissionReportId = table.Column<Guid>(type: "TEXT", nullable: false),
                    AssociatedAccountId = table.Column<string>(type: "TEXT", nullable: true),
                    Credits = table.Column<int>(type: "INTEGER", nullable: false),
                    CredtBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    Xp = table.Column<int>(type: "INTEGER", nullable: false),
                    XpBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    SuitXpBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    PistolXpBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    RifleXpBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    MeleeXpBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    SentinelXPBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    SentinelWeaponXpBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    Rating = table.Column<float>(type: "REAL", nullable: false),
                    Upgrades = table.Column<string>(type: "TEXT", nullable: true),
                    CreationTimestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    LastModificationTimestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerReports_MissionReports_MissionReportId",
                        column: x => x.MissionReportId,
                        principalTable: "MissionReports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MissionReports_PlayerId",
                table: "MissionReports",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerReports_MissionReportId",
                table: "PlayerReports",
                column: "MissionReportId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerReports");

            migrationBuilder.DropTable(
                name: "MissionReports");
        }
    }
}
