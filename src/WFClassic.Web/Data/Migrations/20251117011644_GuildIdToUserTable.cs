using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class GuildIdToUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Guilds",
                newName: "DisplayName");

            migrationBuilder.AddColumn<string>(
                name: "CleansedName",
                table: "Guilds",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tier",
                table: "Guilds",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "CurrentGuildId",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CurrentGuildId",
                table: "AspNetUsers",
                column: "CurrentGuildId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Guilds_CurrentGuildId",
                table: "AspNetUsers",
                column: "CurrentGuildId",
                principalTable: "Guilds",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Guilds_CurrentGuildId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CurrentGuildId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CleansedName",
                table: "Guilds");

            migrationBuilder.DropColumn(
                name: "Tier",
                table: "Guilds");

            migrationBuilder.DropColumn(
                name: "CurrentGuildId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "DisplayName",
                table: "Guilds",
                newName: "Name");
        }
    }
}
