using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOnAPI.Migrations
{
    /// <inheritdoc />
    public partial class fixedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 16, 19, 16, 1, 177, DateTimeKind.Local).AddTicks(1032), new DateTime(2023, 11, 15, 21, 16, 1, 177, DateTimeKind.Local).AddTicks(1029), new DateTime(2023, 11, 15, 19, 16, 1, 177, DateTimeKind.Local).AddTicks(1026) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 20, 3, 16, 1, 177, DateTimeKind.Local).AddTicks(1022), new DateTime(2023, 11, 14, 21, 16, 1, 177, DateTimeKind.Local).AddTicks(1018), new DateTime(2023, 11, 14, 19, 16, 1, 177, DateTimeKind.Local).AddTicks(1015) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 24, 7, 16, 1, 177, DateTimeKind.Local).AddTicks(1007), new DateTime(2023, 11, 13, 22, 16, 1, 177, DateTimeKind.Local).AddTicks(1003), new DateTime(2023, 11, 13, 19, 16, 1, 177, DateTimeKind.Local).AddTicks(953) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4e2dd62e-d9c6-4c1b-90d0-2fc2486a3510", "6b4d3d12-d40b-4cad-8e6e-1eda21e1e625" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "12fa360b-c26a-4573-bd43-48af7253a823", "0a21fd98-86fa-4798-a1f9-7137078dc352" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "508e6700-89eb-42a2-a30e-308f42b64d08", "fc0f3876-317c-4196-b470-634a7d6dcb00" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e04f6359-c4f5-4259-b1f1-3b897e93e69d", "bb1f9d44-f1fb-4b14-be09-5d8df48de246" });
        }
    }
}
