using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class OperationConfigurations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OperationConfigurations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    StartDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    AllowReplay = table.Column<bool>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    OperationType = table.Column<string>(type: "TEXT", nullable: true),
                    TransmissionPath = table.Column<string>(type: "TEXT", nullable: true),
                    CurrentCompletionCount = table.Column<int>(type: "INTEGER", nullable: false),
                    GoalCompletionCount = table.Column<int>(type: "INTEGER", nullable: false),
                    SuccessIndicator = table.Column<bool>(type: "INTEGER", nullable: false),
                    RewardItemType = table.Column<string>(type: "TEXT", nullable: true),
                    RewardItemCount = table.Column<int>(type: "INTEGER", nullable: false),
                    RewardCreditsAmount = table.Column<int>(type: "INTEGER", nullable: false),
                    IsFusionMoaEvent = table.Column<bool>(type: "INTEGER", nullable: false),
                    PostEventCompletionTaskCompleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreationTimestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    LastModificationTimestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationConfigurations", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OperationConfigurations");
        }
    }
}
