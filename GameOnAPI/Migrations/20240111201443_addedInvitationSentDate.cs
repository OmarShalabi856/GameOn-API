using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOnAPI.Migrations
{
    /// <inheritdoc />
    public partial class addedInvitationSentDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 16, 22, 14, 43, 195, DateTimeKind.Local).AddTicks(71), new DateTime(2024, 1, 16, 0, 14, 43, 195, DateTimeKind.Local).AddTicks(66), new DateTime(2024, 1, 15, 22, 14, 43, 195, DateTimeKind.Local).AddTicks(60) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 20, 6, 14, 43, 195, DateTimeKind.Local).AddTicks(50), new DateTime(2024, 1, 15, 0, 14, 43, 195, DateTimeKind.Local).AddTicks(42), new DateTime(2024, 1, 14, 22, 14, 43, 195, DateTimeKind.Local).AddTicks(34) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 24, 10, 14, 43, 195, DateTimeKind.Local).AddTicks(22), new DateTime(2024, 1, 14, 1, 14, 43, 195, DateTimeKind.Local).AddTicks(16), new DateTime(2024, 1, 13, 22, 14, 43, 195, DateTimeKind.Local).AddTicks(9) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 16, 22, 14, 43, 195, DateTimeKind.Local), new DateTime(2024, 1, 16, 0, 14, 43, 194, DateTimeKind.Local).AddTicks(9995), new DateTime(2024, 1, 15, 22, 14, 43, 194, DateTimeKind.Local).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime" },
                values: new object[] { new DateTime(2024, 1, 20, 6, 14, 43, 194, DateTimeKind.Local).AddTicks(9980), new DateTime(2024, 1, 15, 0, 14, 43, 194, DateTimeKind.Local).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 24, 10, 14, 43, 194, DateTimeKind.Local).AddTicks(9962), new DateTime(2024, 1, 14, 1, 14, 43, 194, DateTimeKind.Local).AddTicks(9951), new DateTime(2024, 1, 13, 22, 14, 43, 194, DateTimeKind.Local).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "28f21ff6-07c3-4508-b614-4057baf26a3b", "730988a5-7d4a-4309-b0c5-9724c88595b2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a35e8226-daa5-4513-80d5-cb6d2ff965ae", "1cc8b6f7-f64f-4691-97b4-73f1e7584245" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "26f83c1c-76da-4efc-8a52-e2ff8f39c53f", "fce6fd09-3251-458b-a22c-f16335d2f615" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "84f7dfee-862c-4552-85ce-179c5832aa02", "ab62ec66-9923-4825-bca6-3b5874507240" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 33, 41, 312, DateTimeKind.Local).AddTicks(2510), new DateTime(2024, 1, 15, 1, 33, 41, 312, DateTimeKind.Local).AddTicks(2506), new DateTime(2024, 1, 14, 23, 33, 41, 312, DateTimeKind.Local).AddTicks(2503) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 19, 7, 33, 41, 312, DateTimeKind.Local).AddTicks(2498), new DateTime(2024, 1, 14, 1, 33, 41, 312, DateTimeKind.Local).AddTicks(2495), new DateTime(2024, 1, 13, 23, 33, 41, 312, DateTimeKind.Local).AddTicks(2492) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 23, 11, 33, 41, 312, DateTimeKind.Local).AddTicks(2487), new DateTime(2024, 1, 13, 2, 33, 41, 312, DateTimeKind.Local).AddTicks(2483), new DateTime(2024, 1, 12, 23, 33, 41, 312, DateTimeKind.Local).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 33, 41, 312, DateTimeKind.Local).AddTicks(2475), new DateTime(2024, 1, 15, 1, 33, 41, 312, DateTimeKind.Local).AddTicks(2472), new DateTime(2024, 1, 14, 23, 33, 41, 312, DateTimeKind.Local).AddTicks(2468) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime" },
                values: new object[] { new DateTime(2024, 1, 19, 7, 33, 41, 312, DateTimeKind.Local).AddTicks(2462), new DateTime(2024, 1, 14, 1, 33, 41, 312, DateTimeKind.Local).AddTicks(2459) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 23, 11, 33, 41, 312, DateTimeKind.Local).AddTicks(2447), new DateTime(2024, 1, 13, 2, 33, 41, 312, DateTimeKind.Local).AddTicks(2442), new DateTime(2024, 1, 12, 23, 33, 41, 312, DateTimeKind.Local).AddTicks(2387) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cf07704d-ed07-4588-91e9-0fe11b5773b5", "735d7dd3-ccf5-4a22-b340-03b9bf8ca34d" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ec2dcdac-322b-4d03-aca7-d4ebcb8068e9", "2d993835-392b-4cc2-9370-76ef5039b6e0" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1acfbd18-a7d0-41df-806a-e82bf02af51b", "c853daf5-b7e9-4967-9db3-d5bae262004c" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "00941f6e-f2af-4684-ba73-14062e5cb551", "b8529bbb-b2ba-475c-bc93-65e76f663050" });
        }
    }
}
