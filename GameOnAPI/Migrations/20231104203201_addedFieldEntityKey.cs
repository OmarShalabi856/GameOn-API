using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOnAPI.Migrations
{
    /// <inheritdoc />
    public partial class addedFieldEntityKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 5, 18, 31, 35, 629, DateTimeKind.Local).AddTicks(7622), new DateTime(2023, 11, 9, 0, 31, 35, 629, DateTimeKind.Local).AddTicks(7619), new DateTime(2023, 11, 8, 22, 31, 35, 629, DateTimeKind.Local).AddTicks(7617) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 31, 35, 629, DateTimeKind.Local).AddTicks(7612), new DateTime(2023, 11, 8, 0, 31, 35, 629, DateTimeKind.Local).AddTicks(7608), new DateTime(2023, 11, 7, 22, 31, 35, 629, DateTimeKind.Local).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 5, 22, 31, 35, 629, DateTimeKind.Local).AddTicks(7597), new DateTime(2023, 11, 7, 1, 31, 35, 629, DateTimeKind.Local).AddTicks(7593), new DateTime(2023, 11, 6, 22, 31, 35, 629, DateTimeKind.Local).AddTicks(7541) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cc59c205-8ede-4aea-b13f-2fe8ec1114f3", "2456cf31-ea08-43c3-a26c-a250634edba7" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "13f9fc2d-bada-4452-aa6b-3fee32bd56eb", "9c7d23c7-abea-40f6-a853-7d54b4691843" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6f3da92a-89fd-49d7-80e4-caf7f1e74013", "3e7def01-442f-47f1-95a5-a416bd4e4a0d" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1cee34c2-151b-4404-9ccc-18b42b925cd8", "10fe0e70-71f6-420e-b939-eba9ffa474f1" });
        }
    }
}
