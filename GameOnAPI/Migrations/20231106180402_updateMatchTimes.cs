using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOnAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateMatchTimes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 8, 10, 4, 1, 882, DateTimeKind.Local).AddTicks(1131), new DateTime(2023, 11, 10, 22, 4, 1, 882, DateTimeKind.Local).AddTicks(1125), new DateTime(2023, 11, 10, 20, 4, 1, 882, DateTimeKind.Local).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 8, 10, 4, 1, 882, DateTimeKind.Local).AddTicks(1113), new DateTime(2023, 11, 9, 22, 4, 1, 882, DateTimeKind.Local).AddTicks(1108), new DateTime(2023, 11, 9, 20, 4, 1, 882, DateTimeKind.Local).AddTicks(1103) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 8, 12, 4, 1, 882, DateTimeKind.Local).AddTicks(1093), new DateTime(2023, 11, 8, 23, 4, 1, 882, DateTimeKind.Local).AddTicks(1084), new DateTime(2023, 11, 8, 20, 4, 1, 882, DateTimeKind.Local).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "53a387e5-1775-4187-a746-d3c714ab1100", "d4ee5d4f-d74e-4ac9-9c1d-f920d713aef2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b77b4396-5828-451b-9b58-197fca7d7e61", "484e79fc-fe3a-44b0-9fc2-eac14d17174e" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a910a7f5-c30f-4a28-8b5e-c117a1080306", "70fd57f0-a640-429a-8f38-78aa4fbc46d2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1aaafa5e-0f14-40e0-b39a-96599fb03100", "b4d432ee-b3f3-4771-9d00-0f9220339188" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 5, 19, 23, 55, 95, DateTimeKind.Local).AddTicks(1747), new DateTime(2023, 11, 9, 1, 23, 55, 95, DateTimeKind.Local).AddTicks(1738), new DateTime(2023, 11, 8, 23, 23, 55, 95, DateTimeKind.Local).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 5, 21, 23, 55, 95, DateTimeKind.Local).AddTicks(1722), new DateTime(2023, 11, 8, 1, 23, 55, 95, DateTimeKind.Local).AddTicks(1714), new DateTime(2023, 11, 7, 23, 23, 55, 95, DateTimeKind.Local).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 5, 23, 23, 55, 95, DateTimeKind.Local).AddTicks(1693), new DateTime(2023, 11, 7, 2, 23, 55, 95, DateTimeKind.Local).AddTicks(1681), new DateTime(2023, 11, 6, 23, 23, 55, 95, DateTimeKind.Local).AddTicks(1602) });

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
    }
}
