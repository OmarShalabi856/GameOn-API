using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOnAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateMatchTiming : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 28, 14, 42, 11, 236, DateTimeKind.Local).AddTicks(6568), new DateTime(2023, 12, 27, 16, 42, 11, 236, DateTimeKind.Local).AddTicks(6564), new DateTime(2023, 12, 27, 14, 42, 11, 236, DateTimeKind.Local).AddTicks(6559) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 31, 22, 42, 11, 236, DateTimeKind.Local).AddTicks(6553), new DateTime(2023, 12, 26, 16, 42, 11, 236, DateTimeKind.Local).AddTicks(6549), new DateTime(2023, 12, 26, 14, 42, 11, 236, DateTimeKind.Local).AddTicks(6545) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 5, 2, 42, 11, 236, DateTimeKind.Local).AddTicks(6536), new DateTime(2023, 12, 25, 17, 42, 11, 236, DateTimeKind.Local).AddTicks(6529), new DateTime(2023, 12, 25, 14, 42, 11, 236, DateTimeKind.Local).AddTicks(6474) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "138ba8b2-e42d-4b0c-8534-85b520926236", "c878cdf6-9251-4ddb-8460-3e6e831eb098" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c906aa5b-f59a-4029-8ee8-916f7ab2a011", "6e8dc861-c3f9-4ac0-b625-b1f9f891c2f5" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2e30a448-0220-44a0-bdb4-a2839133c939", "4eae2c87-c709-41fa-9895-f6f232ac1700" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6c5f6701-24b3-4c8e-84ad-0e08327954d6", "2dbd8698-f4f4-48a7-936f-531fa953ac8e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 25, 23, 23, 39, 319, DateTimeKind.Local).AddTicks(3521), new DateTime(2023, 12, 25, 1, 23, 39, 319, DateTimeKind.Local).AddTicks(3518), new DateTime(2023, 12, 24, 23, 23, 39, 319, DateTimeKind.Local).AddTicks(3515) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 29, 7, 23, 39, 319, DateTimeKind.Local).AddTicks(3510), new DateTime(2023, 12, 24, 1, 23, 39, 319, DateTimeKind.Local).AddTicks(3506), new DateTime(2023, 12, 23, 23, 23, 39, 319, DateTimeKind.Local).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 2, 11, 23, 39, 319, DateTimeKind.Local).AddTicks(3496), new DateTime(2023, 12, 23, 2, 23, 39, 319, DateTimeKind.Local).AddTicks(3490), new DateTime(2023, 12, 22, 23, 23, 39, 319, DateTimeKind.Local).AddTicks(3434) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "89450864-b395-4313-bf0d-00c5a2f12b7f", "c9bb7c9b-bbc9-47cd-9120-99dbb9b25c28" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "060329e8-f2f1-49a6-ab81-2096e3f8a4fc", "dc57ed45-24b4-4827-9dbc-3d7424fd9805" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dc097697-99e4-4902-a72d-ba79e76314a1", "4a20d719-bde4-4dbf-b931-4a16ac1ca548" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0a7d6feb-f9fc-42cc-8c97-159b90a18eb3", "91f4347f-c8e8-4c1b-b7cb-7f0578a5ff65" });
        }
    }
}
