using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOnAPI.Migrations
{
    /// <inheritdoc />
    public partial class addedMatchCreationBoolInvitation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "MatchCreation",
                table: "Invitation",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 2, 19, 14, 35, 21, 36, DateTimeKind.Local).AddTicks(2199), new DateTime(2024, 2, 18, 16, 35, 21, 36, DateTimeKind.Local).AddTicks(2196), new DateTime(2024, 2, 18, 14, 35, 21, 36, DateTimeKind.Local).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 2, 22, 22, 35, 21, 36, DateTimeKind.Local).AddTicks(2188), new DateTime(2024, 2, 17, 16, 35, 21, 36, DateTimeKind.Local).AddTicks(2185), new DateTime(2024, 2, 17, 14, 35, 21, 36, DateTimeKind.Local).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 2, 27, 2, 35, 21, 36, DateTimeKind.Local).AddTicks(2177), new DateTime(2024, 2, 16, 17, 35, 21, 36, DateTimeKind.Local).AddTicks(2174), new DateTime(2024, 2, 16, 14, 35, 21, 36, DateTimeKind.Local).AddTicks(2171) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 2, 19, 14, 35, 21, 36, DateTimeKind.Local).AddTicks(2165), new DateTime(2024, 2, 18, 16, 35, 21, 36, DateTimeKind.Local).AddTicks(2162), new DateTime(2024, 2, 18, 14, 35, 21, 36, DateTimeKind.Local).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime" },
                values: new object[] { new DateTime(2024, 2, 22, 22, 35, 21, 36, DateTimeKind.Local).AddTicks(2153), new DateTime(2024, 2, 17, 16, 35, 21, 36, DateTimeKind.Local).AddTicks(2150) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 2, 27, 2, 35, 21, 36, DateTimeKind.Local).AddTicks(2141), new DateTime(2024, 2, 16, 17, 35, 21, 36, DateTimeKind.Local).AddTicks(2136), new DateTime(2024, 2, 16, 14, 35, 21, 36, DateTimeKind.Local).AddTicks(2086) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9f43ae44-ebb1-492c-9a16-4c6cd63fa41c", "205e6b0f-990e-449a-856f-3b8396c11dae" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bd472e72-1359-4687-9f13-b87aaad9aab7", "3f0004a8-29f2-4a5b-9d5b-7a21af60941a" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ae9d4e45-2ff9-4db4-80db-98a8af7f3942", "9e910cda-5e3b-452d-9fea-ef21fb81e4d5" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d6d04b13-926c-4167-a3c4-6f6ba9a24ef3", "702ab00a-76ee-4fcd-820e-aefc41c81fce" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MatchCreation",
                table: "Invitation");

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 2, 16, 21, 35, 41, 115, DateTimeKind.Local).AddTicks(1984), new DateTime(2024, 2, 15, 23, 35, 41, 115, DateTimeKind.Local).AddTicks(1979), new DateTime(2024, 2, 15, 21, 35, 41, 115, DateTimeKind.Local).AddTicks(1974) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 2, 20, 5, 35, 41, 115, DateTimeKind.Local).AddTicks(1965), new DateTime(2024, 2, 14, 23, 35, 41, 115, DateTimeKind.Local).AddTicks(1959), new DateTime(2024, 2, 14, 21, 35, 41, 115, DateTimeKind.Local).AddTicks(1953) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 2, 24, 9, 35, 41, 115, DateTimeKind.Local).AddTicks(1943), new DateTime(2024, 2, 14, 0, 35, 41, 115, DateTimeKind.Local).AddTicks(1937), new DateTime(2024, 2, 13, 21, 35, 41, 115, DateTimeKind.Local).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 2, 16, 21, 35, 41, 115, DateTimeKind.Local).AddTicks(1921), new DateTime(2024, 2, 15, 23, 35, 41, 115, DateTimeKind.Local).AddTicks(1914), new DateTime(2024, 2, 15, 21, 35, 41, 115, DateTimeKind.Local).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime" },
                values: new object[] { new DateTime(2024, 2, 20, 5, 35, 41, 115, DateTimeKind.Local).AddTicks(1897), new DateTime(2024, 2, 14, 23, 35, 41, 115, DateTimeKind.Local).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 2, 24, 9, 35, 41, 115, DateTimeKind.Local).AddTicks(1878), new DateTime(2024, 2, 14, 0, 35, 41, 115, DateTimeKind.Local).AddTicks(1871), new DateTime(2024, 2, 13, 21, 35, 41, 115, DateTimeKind.Local).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5ddb6830-2886-4ca4-a46a-124ed15e0bf2", "ffb5e840-b425-4c1a-8e73-b7a89b0e1739" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9fbda361-5254-4a9a-b272-b93332895150", "10b4daa3-f7c1-41f8-bd1f-0081b743228b" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8074bcfd-57e4-4a03-85f2-af7886bcefaa", "f1152b27-0ec7-408d-a40e-d704f4267511" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8016ae00-e4ce-4323-8277-9a36adcebc37", "281fd5e3-e062-486d-a3e3-33a69ebd7b75" });
        }
    }
}
