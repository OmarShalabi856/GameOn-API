using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameOnAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateMatches3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 6, 1, 37, 40, 837, DateTimeKind.Local).AddTicks(6271), new DateTime(2024, 1, 5, 3, 37, 40, 837, DateTimeKind.Local).AddTicks(6268), new DateTime(2024, 1, 5, 1, 37, 40, 837, DateTimeKind.Local).AddTicks(6265) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 9, 9, 37, 40, 837, DateTimeKind.Local).AddTicks(6260), new DateTime(2024, 1, 4, 3, 37, 40, 837, DateTimeKind.Local).AddTicks(6257), new DateTime(2024, 1, 4, 1, 37, 40, 837, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 13, 13, 37, 40, 837, DateTimeKind.Local).AddTicks(6249), new DateTime(2024, 1, 3, 4, 37, 40, 837, DateTimeKind.Local).AddTicks(6246), new DateTime(2024, 1, 3, 1, 37, 40, 837, DateTimeKind.Local).AddTicks(6242) });

            migrationBuilder.InsertData(
                table: "Match",
                columns: new[] { "Id", "CreationDateTime", "DeadlineRequestsDateTime", "EndDateTime", "Featured", "FieldId", "Notes", "PlayerCount", "StartDateTime", "UserId", "feePerPlayer" },
                values: new object[,]
                {
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 1, 37, 40, 837, DateTimeKind.Local).AddTicks(6238), new DateTime(2024, 1, 5, 3, 37, 40, 837, DateTimeKind.Local).AddTicks(6235), true, 1, "", 16, new DateTime(2024, 1, 5, 1, 37, 40, 837, DateTimeKind.Local).AddTicks(6232), "141b7af4-e40a-4330-b7cf-9b85cb579c7c", 12.0 },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 9, 9, 37, 40, 837, DateTimeKind.Local).AddTicks(6226), new DateTime(2024, 1, 4, 3, 37, 40, 837, DateTimeKind.Local).AddTicks(6223), true, 2, "", 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "141b7af4-e40a-4330-b7cf-9b85cb579c7c", 10.0 },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 13, 37, 40, 837, DateTimeKind.Local).AddTicks(6215), new DateTime(2024, 1, 3, 4, 37, 40, 837, DateTimeKind.Local).AddTicks(6211), true, 3, "", 8, new DateTime(2024, 1, 3, 1, 37, 40, 837, DateTimeKind.Local).AddTicks(6155), "069a5b6e-deb5-4dcc-bfd7-92dce2aea524", 7.0 }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "52e6c55b-3289-4643-9dba-597d7e55087e", "01efb863-30f8-4a7b-b060-1d17912c2770" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "38ccb328-1f0f-4e49-a714-263ad33ef16c", "06e043e4-c0f9-4446-91cd-1c58a1e5e5b2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "50df3b8b-7179-4267-a5e1-5b096bc253fc", "89b9036e-e042-46a5-b356-62e1c2be9aec" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4cef7167-af5c-446f-8a61-162b8d23be4d", "fbf9d46c-4879-4c9e-8f2a-c0060eee277b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 6, 1, 36, 9, 668, DateTimeKind.Local).AddTicks(5002), new DateTime(2024, 1, 5, 3, 36, 9, 668, DateTimeKind.Local).AddTicks(4999), new DateTime(2024, 1, 5, 1, 36, 9, 668, DateTimeKind.Local).AddTicks(4996) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 9, 9, 36, 9, 668, DateTimeKind.Local).AddTicks(4991), new DateTime(2024, 1, 4, 3, 36, 9, 668, DateTimeKind.Local).AddTicks(4987), new DateTime(2024, 1, 4, 1, 36, 9, 668, DateTimeKind.Local).AddTicks(4984) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 13, 13, 36, 9, 668, DateTimeKind.Local).AddTicks(4976), new DateTime(2024, 1, 3, 4, 36, 9, 668, DateTimeKind.Local).AddTicks(4972), new DateTime(2024, 1, 3, 1, 36, 9, 668, DateTimeKind.Local).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4ffeeaa9-4009-46b7-be48-b4ead4079547", "b7fce1b9-add3-4255-ad98-53dedbb7ccf4" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5f7027dc-7b5c-48b6-be80-02131e97e789", "07b6d91c-6eee-4993-a7fb-beca875712e7" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4ae4de75-4606-4652-a279-2c546e046662", "2bae8646-9c46-4317-9b39-091800c547cd" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0ee0bcc6-4823-4025-b53c-eb1130b75650", "55311ef0-28b4-4c7b-b61a-52cbfb087228" });
        }
    }
}
