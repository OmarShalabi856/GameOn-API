using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOnAPI.Migrations
{
    /// <inheritdoc />
    public partial class updatedMatches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 3, 22, 46, 38, 645, DateTimeKind.Local).AddTicks(4727), new DateTime(2023, 12, 3, 0, 46, 38, 645, DateTimeKind.Local).AddTicks(4723), new DateTime(2023, 12, 2, 22, 46, 38, 645, DateTimeKind.Local).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 7, 6, 46, 38, 645, DateTimeKind.Local).AddTicks(4716), new DateTime(2023, 12, 2, 0, 46, 38, 645, DateTimeKind.Local).AddTicks(4712), new DateTime(2023, 12, 1, 22, 46, 38, 645, DateTimeKind.Local).AddTicks(4708) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 46, 38, 645, DateTimeKind.Local).AddTicks(4700), new DateTime(2023, 12, 1, 1, 46, 38, 645, DateTimeKind.Local).AddTicks(4695), new DateTime(2023, 11, 30, 22, 46, 38, 645, DateTimeKind.Local).AddTicks(4641) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "50bb1ea2-3fa6-40af-bddb-2f39a9c674a9", "da5f0ae8-2a16-40a3-9d95-0daa1ecb9e00" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9163d0c4-f8ec-413c-a5d9-6f634ffd8fae", "8c61ae48-c676-477a-8051-122a588c2e4e" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3383f109-d8ab-4ce9-8db0-2b5d0b60d3c4", "a1c8d60c-2c5d-4b8a-ae0a-fed59b0600ac" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e27558fc-3ff6-4757-a081-1973b22ff888", "3eaac93c-bd38-47f8-b5ea-eece0b85e980" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 27, 17, 0, 42, 538, DateTimeKind.Local).AddTicks(655), new DateTime(2023, 11, 26, 19, 0, 42, 538, DateTimeKind.Local).AddTicks(651), new DateTime(2023, 11, 26, 17, 0, 42, 538, DateTimeKind.Local).AddTicks(647) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 1, 1, 0, 42, 538, DateTimeKind.Local).AddTicks(641), new DateTime(2023, 11, 25, 19, 0, 42, 538, DateTimeKind.Local).AddTicks(637), new DateTime(2023, 11, 25, 17, 0, 42, 538, DateTimeKind.Local).AddTicks(633) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 5, 5, 0, 42, 538, DateTimeKind.Local).AddTicks(625), new DateTime(2023, 11, 24, 20, 0, 42, 538, DateTimeKind.Local).AddTicks(618), new DateTime(2023, 11, 24, 17, 0, 42, 538, DateTimeKind.Local).AddTicks(557) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "87d1ec60-97fc-44ee-92dd-f1f3f960491c", "87150c17-f284-41a0-aed9-06679ddddeb0" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e1e1a424-80b6-4a50-8c0f-b5a731d2daed", "73b9cd38-c141-44a6-bdfe-efa228f8b652" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d93c6135-2902-4f23-be2b-da9cc751b1dd", "d4d17d49-8bec-48f6-936e-b783e58dfb4a" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6608ba23-c176-41d9-8dea-79a88badac07", "ef124542-8217-4bf6-8b79-191b1e24bbd9" });
        }
    }
}
