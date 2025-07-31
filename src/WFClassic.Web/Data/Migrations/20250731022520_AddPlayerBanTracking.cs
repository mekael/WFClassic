using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPlayerBanTracking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlayerBans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ApplicationUserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    BannedByUserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    BanReason = table.Column<string>(type: "TEXT", nullable: true),
                    BanStartedOn = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    BanInEffectUntil = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    BanRescindedBy = table.Column<string>(type: "TEXT", nullable: true),
                    BanRescindedReason = table.Column<string>(type: "TEXT", nullable: true),
                    BanRescindedOnDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    CreationTimestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    LastModificationTimestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerBans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerBans_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerBans_AspNetUsers_BannedByUserId",
                        column: x => x.BannedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerBans_ApplicationUserId",
                table: "PlayerBans",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerBans_BannedByUserId",
                table: "PlayerBans",
                column: "BannedByUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerBans");
        }
    }
}
