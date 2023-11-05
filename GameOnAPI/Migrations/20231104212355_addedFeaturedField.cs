using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOnAPI.Migrations
{
    /// <inheritdoc />
    public partial class addedFeaturedField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Featured",
                table: "Match",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "Featured", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 5, 19, 23, 55, 95, DateTimeKind.Local).AddTicks(1747), new DateTime(2023, 11, 9, 1, 23, 55, 95, DateTimeKind.Local).AddTicks(1738), true, new DateTime(2023, 11, 8, 23, 23, 55, 95, DateTimeKind.Local).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "Featured", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 5, 21, 23, 55, 95, DateTimeKind.Local).AddTicks(1722), new DateTime(2023, 11, 8, 1, 23, 55, 95, DateTimeKind.Local).AddTicks(1714), true, new DateTime(2023, 11, 7, 23, 23, 55, 95, DateTimeKind.Local).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "Featured", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 5, 23, 23, 55, 95, DateTimeKind.Local).AddTicks(1693), new DateTime(2023, 11, 7, 2, 23, 55, 95, DateTimeKind.Local).AddTicks(1681), true, new DateTime(2023, 11, 6, 23, 23, 55, 95, DateTimeKind.Local).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "69da71ff-4673-47a6-b9ad-8881131b72d0", "f8d41ccf-0b22-4cba-b8fc-bfabf74ec170" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0dc8752d-30df-4eab-87cf-dda47f1ca858", "f0bba428-e9bb-4983-9958-6e0d63ef8ec4" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "38dc2d34-ce2b-48b4-b01d-f61982185755", "69b32084-3810-4827-ae2a-9b8ab88227f5" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0cf44167-2168-48f7-9e8c-f4aeebd475c8", "66d237e6-eb8e-4978-bc9d-83d70cd29e5b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Featured",
                table: "Match");

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 5, 18, 32, 1, 409, DateTimeKind.Local).AddTicks(4584), new DateTime(2023, 11, 9, 0, 32, 1, 409, DateTimeKind.Local).AddTicks(4573), new DateTime(2023, 11, 8, 22, 32, 1, 409, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 32, 1, 409, DateTimeKind.Local).AddTicks(4555), new DateTime(2023, 11, 8, 0, 32, 1, 409, DateTimeKind.Local).AddTicks(4551), new DateTime(2023, 11, 7, 22, 32, 1, 409, DateTimeKind.Local).AddTicks(4548) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 5, 22, 32, 1, 409, DateTimeKind.Local).AddTicks(4540), new DateTime(2023, 11, 7, 1, 32, 1, 409, DateTimeKind.Local).AddTicks(4535), new DateTime(2023, 11, 6, 22, 32, 1, 409, DateTimeKind.Local).AddTicks(4428) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5a9392f1-b7f2-40b6-add2-f7f641e5f228", "abd986b8-bf2c-464e-9c46-c13f822cddfa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4dd31a2c-6ef4-4f01-9639-6ce7ee46f352", "618e9895-c387-4cfc-b3fc-0433b567d106" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4bca7c14-def3-4a95-bd76-f1ad2d01cc9f", "317d5261-3810-4470-b1a0-15da24b04dc7" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b3f1ac27-0444-4bb8-b9aa-16a4eb3f2ba5", "48a60322-a57f-4f59-b767-e92d4a388fd7" });
        }
    }
}
