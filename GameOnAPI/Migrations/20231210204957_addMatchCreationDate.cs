using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOnAPI.Migrations
{
    /// <inheritdoc />
    public partial class addMatchCreationDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Match",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 15, 22, 49, 57, 189, DateTimeKind.Local).AddTicks(429), new DateTime(2023, 12, 15, 0, 49, 57, 189, DateTimeKind.Local).AddTicks(426), new DateTime(2023, 12, 14, 22, 49, 57, 189, DateTimeKind.Local).AddTicks(423) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 19, 6, 49, 57, 189, DateTimeKind.Local).AddTicks(418), new DateTime(2023, 12, 14, 0, 49, 57, 189, DateTimeKind.Local).AddTicks(415), new DateTime(2023, 12, 13, 22, 49, 57, 189, DateTimeKind.Local).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 23, 10, 49, 57, 189, DateTimeKind.Local).AddTicks(405), new DateTime(2023, 12, 13, 1, 49, 57, 189, DateTimeKind.Local).AddTicks(401), new DateTime(2023, 12, 12, 22, 49, 57, 189, DateTimeKind.Local).AddTicks(352) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "adf25f4a-7a63-4e55-b403-aecb3fca0fbd", "10e52003-63a5-44b5-8f94-5b7ef48d7fee" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2f38ddc3-c47f-41b9-b5dc-c69d291e0cbe", "c3ce04c1-9399-4637-be96-99d7386effe9" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "44309f94-1167-4fd3-9b21-4a9f207b2dfc", "96dd08e9-abf8-4c86-8abb-4d8f50ec986a" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8073a1a5-919b-4c54-ba76-f6b611528244", "d6b40473-fa49-4a3d-aaea-61b66e3ea4f2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Match");

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
    }
}
