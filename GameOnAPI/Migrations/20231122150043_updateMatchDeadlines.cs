using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOnAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateMatchDeadlines : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 19, 23, 57, 17, 605, DateTimeKind.Local).AddTicks(5105), new DateTime(2023, 11, 19, 1, 57, 17, 605, DateTimeKind.Local).AddTicks(5102), new DateTime(2023, 11, 18, 23, 57, 17, 605, DateTimeKind.Local).AddTicks(5099) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 23, 7, 57, 17, 605, DateTimeKind.Local).AddTicks(5095), new DateTime(2023, 11, 18, 1, 57, 17, 605, DateTimeKind.Local).AddTicks(5092), new DateTime(2023, 11, 17, 23, 57, 17, 605, DateTimeKind.Local).AddTicks(5089) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 27, 11, 57, 17, 605, DateTimeKind.Local).AddTicks(5082), new DateTime(2023, 11, 17, 2, 57, 17, 605, DateTimeKind.Local).AddTicks(5075), new DateTime(2023, 11, 16, 23, 57, 17, 605, DateTimeKind.Local).AddTicks(5024) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "00c5f855-82df-4c7a-847a-b20258ba6b3c", "9265fda5-d4a8-4589-9083-5dac97420f06" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "23039499-1608-461f-8eff-7fd4b2820c8a", "dfb606e4-f50d-4ffc-abc1-686ccb3af3bf" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e7146be2-dde7-44d3-aa00-793c1e22e234", "1fa75e06-a51f-4355-97f0-f6bda708a121" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "60aaaa5d-0010-4210-8568-e0d3b01f7821", "b99e37f8-1f46-4fdf-8d54-1a6983d73868" });
        }
    }
}
