using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExampleWSMessages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                                    INSERT INTO WorldStateEventMessages
                                    (Id, Message, MessageType, Property, MessageDate, MessageExpirationDate, IsActive, CreationTimestamp, LastModificationTimestamp)
                                    VALUES('31DACE59-46AA-4491-B1CD-9E98147B0D08', 'Check out the SNS Discord', 1, 'https://discord.gg/dhPJYkgK', '2025-05-13 20:10:58.3970551-05:00', '2999-05-13 20:10:58.3970551-05:00', 1, '2025-05-13 20:10:58.3970551-05:00', '2025-05-13 20:10:58.3970551-05:00');
                                    INSERT INTO WorldStateEventMessages
                                    (Id, Message, MessageType, Property, MessageDate, MessageExpirationDate, IsActive, CreationTimestamp, LastModificationTimestamp)
                                    VALUES('1AA2E9CD-85E5-4292-BF47-0CE92DB6ED7E', 'Remember to be a cat', 1, '', '2025-05-13 20:10:58.3970551-05:00', '2999-05-13 20:10:58.3970551-05:00', 1, '2025-05-13 20:10:58.3970551-05:00', '2025-05-13 20:10:58.3970551-05:00');
                                    ");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
