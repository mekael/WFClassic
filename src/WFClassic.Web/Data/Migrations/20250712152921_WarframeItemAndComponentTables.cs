using System;

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class WarframeItemAndComponentTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WarframeItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ItemType = table.Column<string>(type: "TEXT", nullable: true),
                    WarframeItemLocation = table.Column<int>(type: "INTEGER", nullable: false),
                    CreationTimestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    LastModificationTimestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarframeItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarframeItemComponents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    WarframeItemId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ItemType = table.Column<string>(type: "TEXT", nullable: true),
                    ItemName = table.Column<string>(type: "TEXT", nullable: true),
                    InternalInventoryItemType = table.Column<int>(type: "INTEGER", nullable: false),
                    Count = table.Column<int>(type: "INTEGER", nullable: false),
                    IsUniqueItem = table.Column<bool>(type: "INTEGER", nullable: false),
                    UpgradeVer = table.Column<int>(type: "INTEGER", nullable: false),
                    XP = table.Column<int>(type: "INTEGER", nullable: false),
                    UnlockLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    ExtraCapacity = table.Column<int>(type: "INTEGER", nullable: false),
                    ExtraRemaining = table.Column<int>(type: "INTEGER", nullable: false),
                    UpgradeFingerprint = table.Column<string>(type: "TEXT", nullable: true),
                    Charge = table.Column<int>(type: "INTEGER", nullable: false),
                    CreationTimestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    LastModificationTimestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarframeItemComponents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WarframeItemComponents_WarframeItems_WarframeItemId",
                        column: x => x.WarframeItemId,
                        principalTable: "WarframeItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WarframeItemComponents_WarframeItemId",
                table: "WarframeItemComponents",
                column: "WarframeItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WarframeItemComponents");

            migrationBuilder.DropTable(
                name: "WarframeItems");
        }
    }
}