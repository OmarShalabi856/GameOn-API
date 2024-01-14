using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOnAPI.Migrations
{
    /// <inheritdoc />
    public partial class addedInvitationEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 49, 50, 952, DateTimeKind.Local).AddTicks(6249), new DateTime(2024, 1, 11, 1, 49, 50, 952, DateTimeKind.Local).AddTicks(6246), new DateTime(2024, 1, 10, 23, 49, 50, 952, DateTimeKind.Local).AddTicks(6243) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 15, 7, 49, 50, 952, DateTimeKind.Local).AddTicks(6237), new DateTime(2024, 1, 10, 1, 49, 50, 952, DateTimeKind.Local).AddTicks(6234), new DateTime(2024, 1, 9, 23, 49, 50, 952, DateTimeKind.Local).AddTicks(6231) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 49, 50, 952, DateTimeKind.Local).AddTicks(6225), new DateTime(2024, 1, 9, 2, 49, 50, 952, DateTimeKind.Local).AddTicks(6221), new DateTime(2024, 1, 8, 23, 49, 50, 952, DateTimeKind.Local).AddTicks(6218) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 49, 50, 952, DateTimeKind.Local).AddTicks(6213), new DateTime(2024, 1, 11, 1, 49, 50, 952, DateTimeKind.Local).AddTicks(6210), new DateTime(2024, 1, 10, 23, 49, 50, 952, DateTimeKind.Local).AddTicks(6205) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime" },
                values: new object[] { new DateTime(2024, 1, 15, 7, 49, 50, 952, DateTimeKind.Local).AddTicks(6199), new DateTime(2024, 1, 10, 1, 49, 50, 952, DateTimeKind.Local).AddTicks(6196) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 49, 50, 952, DateTimeKind.Local).AddTicks(6187), new DateTime(2024, 1, 9, 2, 49, 50, 952, DateTimeKind.Local).AddTicks(6183), new DateTime(2024, 1, 8, 23, 49, 50, 952, DateTimeKind.Local).AddTicks(6130) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0dc0244e-5e0a-4c9f-a8bd-60907f2ae2df", "66e0ee1a-887c-4a67-9bd9-265fd87adea0" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a9591b21-2baf-415a-82d4-16bff9a84742", "796057ee-1efa-4631-a7e8-617c49c8c2cf" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1462d66a-7d5d-4c6f-a6cf-e2d214fa753b", "0c83cc9d-251a-4ce3-9e21-f6e550fb0c6c" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dfa8f760-c3b3-4c31-bd1e-f92f0ae7baa6", "6b24bb7c-8fd9-4c4d-b703-56b94f543433" });
        }
    }
}
