using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOnAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateMatches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 15, 20, 27, 19, 890, DateTimeKind.Local).AddTicks(8806), new DateTime(2023, 12, 14, 22, 27, 19, 890, DateTimeKind.Local).AddTicks(8799), new DateTime(2023, 12, 14, 20, 27, 19, 890, DateTimeKind.Local).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 19, 4, 27, 19, 890, DateTimeKind.Local).AddTicks(8785), new DateTime(2023, 12, 13, 22, 27, 19, 890, DateTimeKind.Local).AddTicks(8780), new DateTime(2023, 12, 13, 20, 27, 19, 890, DateTimeKind.Local).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 23, 8, 27, 19, 890, DateTimeKind.Local).AddTicks(8761), new DateTime(2023, 12, 12, 23, 27, 19, 890, DateTimeKind.Local).AddTicks(8752), new DateTime(2023, 12, 12, 20, 27, 19, 890, DateTimeKind.Local).AddTicks(8686) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "81ff36c9-ce31-402f-979e-5e904d62b247", "58afd7b5-249d-41e2-9040-da226de67bf1" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "08882ff4-81ea-411e-897a-0d6d93afd3ba", "bed58127-a693-4492-933f-0e8da23c793b" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c654ceeb-a73d-4ca9-8738-ea177e46a81d", "b3371b7f-4778-45b4-ac35-4104c3bf8644" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6c6d3e11-6ed6-4f6d-96ed-79ec132aa05e", "e1ec570b-9d6f-415f-af64-2776e9fbbd33" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 50, 17, 15, DateTimeKind.Local).AddTicks(8559), new DateTime(2023, 12, 7, 2, 50, 17, 15, DateTimeKind.Local).AddTicks(8555), new DateTime(2023, 12, 7, 0, 50, 17, 15, DateTimeKind.Local).AddTicks(8549) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 11, 8, 50, 17, 15, DateTimeKind.Local).AddTicks(8543), new DateTime(2023, 12, 6, 2, 50, 17, 15, DateTimeKind.Local).AddTicks(8539), new DateTime(2023, 12, 6, 0, 50, 17, 15, DateTimeKind.Local).AddTicks(8535) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 15, 12, 50, 17, 15, DateTimeKind.Local).AddTicks(8528), new DateTime(2023, 12, 5, 3, 50, 17, 15, DateTimeKind.Local).AddTicks(8523), new DateTime(2023, 12, 5, 0, 50, 17, 15, DateTimeKind.Local).AddTicks(8459) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4b53c598-cadb-4cfe-bbd8-4f15a1569554", "216a4948-b2b3-4c07-8037-050f7affba02" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5b55be25-d938-461e-85e0-c4a0aff3ce37", "143d9bf3-b7fa-4917-ac20-21e0543a0e98" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "021bd735-60af-4c0d-a62c-8dfd29b2cf6f", "07453034-f2e8-4caf-b925-91f54dd1dbe8" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cc9d9d12-a15f-4659-8891-74eac465e913", "0c6505d7-c907-471c-a8d1-3581127495e2" });
        }
    }
}
