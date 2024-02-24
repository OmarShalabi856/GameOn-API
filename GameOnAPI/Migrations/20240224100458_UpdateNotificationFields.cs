using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOnAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateNotificationFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Viewed",
                table: "Notification");

            migrationBuilder.AddColumn<bool>(
                name: "Viewed",
                table: "NotificationUser",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Viewed",
                table: "NotificationUser");

            migrationBuilder.AddColumn<bool>(
                name: "Viewed",
                table: "Notification",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
