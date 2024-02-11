using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOnAPI.Migrations
{
    /// <inheritdoc />
    public partial class addStatusToMatch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Match",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 16, 21, 35, 41, 115, DateTimeKind.Local).AddTicks(1984), new DateTime(2024, 2, 15, 23, 35, 41, 115, DateTimeKind.Local).AddTicks(1979), new DateTime(2024, 2, 15, 21, 35, 41, 115, DateTimeKind.Local).AddTicks(1974), "Pending Confirmation" });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 20, 5, 35, 41, 115, DateTimeKind.Local).AddTicks(1965), new DateTime(2024, 2, 14, 23, 35, 41, 115, DateTimeKind.Local).AddTicks(1959), new DateTime(2024, 2, 14, 21, 35, 41, 115, DateTimeKind.Local).AddTicks(1953), "Pending Confirmation" });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 24, 9, 35, 41, 115, DateTimeKind.Local).AddTicks(1943), new DateTime(2024, 2, 14, 0, 35, 41, 115, DateTimeKind.Local).AddTicks(1937), new DateTime(2024, 2, 13, 21, 35, 41, 115, DateTimeKind.Local).AddTicks(1931), "Pending Confirmation" });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 16, 21, 35, 41, 115, DateTimeKind.Local).AddTicks(1921), new DateTime(2024, 2, 15, 23, 35, 41, 115, DateTimeKind.Local).AddTicks(1914), new DateTime(2024, 2, 15, 21, 35, 41, 115, DateTimeKind.Local).AddTicks(1908), "Pending Confirmation" });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 20, 5, 35, 41, 115, DateTimeKind.Local).AddTicks(1897), new DateTime(2024, 2, 14, 23, 35, 41, 115, DateTimeKind.Local).AddTicks(1891), "Pending Confirmation" });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 24, 9, 35, 41, 115, DateTimeKind.Local).AddTicks(1878), new DateTime(2024, 2, 14, 0, 35, 41, 115, DateTimeKind.Local).AddTicks(1871), new DateTime(2024, 2, 13, 21, 35, 41, 115, DateTimeKind.Local).AddTicks(1810), "Pending Confirmation" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Match");

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
    }
}
