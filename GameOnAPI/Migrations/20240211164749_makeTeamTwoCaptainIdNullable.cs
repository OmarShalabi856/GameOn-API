using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOnAPI.Migrations
{
    /// <inheritdoc />
    public partial class makeTeamTwoCaptainIdNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 2, 16, 18, 47, 48, 578, DateTimeKind.Local).AddTicks(2276), new DateTime(2024, 2, 15, 20, 47, 48, 578, DateTimeKind.Local).AddTicks(2272), new DateTime(2024, 2, 15, 18, 47, 48, 578, DateTimeKind.Local).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 2, 20, 2, 47, 48, 578, DateTimeKind.Local).AddTicks(2263), new DateTime(2024, 2, 14, 20, 47, 48, 578, DateTimeKind.Local).AddTicks(2260), new DateTime(2024, 2, 14, 18, 47, 48, 578, DateTimeKind.Local).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 2, 24, 6, 47, 48, 578, DateTimeKind.Local).AddTicks(2251), new DateTime(2024, 2, 13, 21, 47, 48, 578, DateTimeKind.Local).AddTicks(2248), new DateTime(2024, 2, 13, 18, 47, 48, 578, DateTimeKind.Local).AddTicks(2244) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 2, 16, 18, 47, 48, 578, DateTimeKind.Local).AddTicks(2238), new DateTime(2024, 2, 15, 20, 47, 48, 578, DateTimeKind.Local).AddTicks(2235), new DateTime(2024, 2, 15, 18, 47, 48, 578, DateTimeKind.Local).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime" },
                values: new object[] { new DateTime(2024, 2, 20, 2, 47, 48, 578, DateTimeKind.Local).AddTicks(2224), new DateTime(2024, 2, 14, 20, 47, 48, 578, DateTimeKind.Local).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 2, 24, 6, 47, 48, 578, DateTimeKind.Local).AddTicks(2209), new DateTime(2024, 2, 13, 21, 47, 48, 578, DateTimeKind.Local).AddTicks(2205), new DateTime(2024, 2, 13, 18, 47, 48, 578, DateTimeKind.Local).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9d57389a-4143-4188-8f47-e2c65fad48e6", "281baecf-5e23-4643-b9a7-45fed22c8e1d" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "25a5635e-bc4d-4b2e-8dc3-486c372d6a58", "0e6c68eb-51a3-4d01-aa1a-f470e927e78b" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "51d7ecd6-83b2-4157-8f59-def6bd368d30", "57305475-b2b3-4991-bd22-98e20b3813b0" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dca73981-d6b0-493f-98d8-0b6fa78ca24f", "7f234f93-89be-4b62-87b1-69e07acf7465" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 2, 16, 18, 38, 56, 637, DateTimeKind.Local).AddTicks(3520), new DateTime(2024, 2, 15, 20, 38, 56, 637, DateTimeKind.Local).AddTicks(3515), new DateTime(2024, 2, 15, 18, 38, 56, 637, DateTimeKind.Local).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 2, 20, 2, 38, 56, 637, DateTimeKind.Local).AddTicks(3502), new DateTime(2024, 2, 14, 20, 38, 56, 637, DateTimeKind.Local).AddTicks(3496), new DateTime(2024, 2, 14, 18, 38, 56, 637, DateTimeKind.Local).AddTicks(3491) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 2, 24, 6, 38, 56, 637, DateTimeKind.Local).AddTicks(3484), new DateTime(2024, 2, 13, 21, 38, 56, 637, DateTimeKind.Local).AddTicks(3478), new DateTime(2024, 2, 13, 18, 38, 56, 637, DateTimeKind.Local).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 2, 16, 18, 38, 56, 637, DateTimeKind.Local).AddTicks(3466), new DateTime(2024, 2, 15, 20, 38, 56, 637, DateTimeKind.Local).AddTicks(3461), new DateTime(2024, 2, 15, 18, 38, 56, 637, DateTimeKind.Local).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime" },
                values: new object[] { new DateTime(2024, 2, 20, 2, 38, 56, 637, DateTimeKind.Local).AddTicks(3446), new DateTime(2024, 2, 14, 20, 38, 56, 637, DateTimeKind.Local).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 2, 24, 6, 38, 56, 637, DateTimeKind.Local).AddTicks(3428), new DateTime(2024, 2, 13, 21, 38, 56, 637, DateTimeKind.Local).AddTicks(3420), new DateTime(2024, 2, 13, 18, 38, 56, 637, DateTimeKind.Local).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "80b4f85f-8699-4b42-ba8a-63c0c0a8364a", "b614893e-8d1e-4ea7-b60b-1b822c627ecc" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "047335df-e006-4558-a65f-ad35d88a7d9b", "8f2d8949-9d2b-4e81-828c-9042ca235060" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "21493ea0-17f4-4fbf-8aac-9efb36b42c26", "89e64959-6050-4d87-9055-61b8722ae1a7" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "23c8bf64-d546-4867-825b-f0ce012bd8a5", "bb5ec843-6a63-4cd9-a17a-ff0505afbefb" });
        }
    }
}
