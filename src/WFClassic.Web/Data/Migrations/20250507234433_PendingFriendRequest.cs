using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class PendingFriendRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventoryItems_Players_PlayerId",
                table: "InventoryItems");

            migrationBuilder.AlterColumn<Guid>(
                name: "PlayerId",
                table: "InventoryItems",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "FriendshipRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    RequestorId = table.Column<Guid>(type: "TEXT", nullable: false),
                    FriendId = table.Column<Guid>(type: "TEXT", nullable: false),
                    RequestStatus = table.Column<int>(type: "INTEGER", nullable: false),
                    RequestAcceptedOrDeclinedOn = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreationTimestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    LastModificationTimestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FriendshipRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FriendshipRequests_AspNetUsers_FriendId",
                        column: x => x.FriendId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FriendshipRequests_AspNetUsers_RequestorId",
                        column: x => x.RequestorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FriendshipRequests_FriendId",
                table: "FriendshipRequests",
                column: "FriendId");

            migrationBuilder.CreateIndex(
                name: "IX_FriendshipRequests_RequestorId",
                table: "FriendshipRequests",
                column: "RequestorId");

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryItems_Players_PlayerId",
                table: "InventoryItems",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventoryItems_Players_PlayerId",
                table: "InventoryItems");

            migrationBuilder.DropTable(
                name: "FriendshipRequests");

            migrationBuilder.AlterColumn<Guid>(
                name: "PlayerId",
                table: "InventoryItems",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryItems_Players_PlayerId",
                table: "InventoryItems",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id");
        }
    }
}
