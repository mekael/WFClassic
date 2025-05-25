using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SystemTaskTrackingEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SystemTaskHistory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    SystemTaskType = table.Column<int>(type: "INTEGER", nullable: false),
                    TaskWasSuccessful = table.Column<bool>(type: "INTEGER", nullable: false),
                    ReasonForTaskExecution = table.Column<string>(type: "TEXT", nullable: true),
                    TaskExecutionTimestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    CreationTimestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    LastModificationTimestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemTaskHistory", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SystemTaskHistory");
        }
    }
}
