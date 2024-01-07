using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOnAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateMatchfields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AgeGroup",
                table: "Match",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Match",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Match",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AgeGroup", "City", "DeadlineRequestsDateTime", "EndDateTime", "Gender", "StartDateTime" },
                values: new object[] { "10-15", "Sidon", new DateTime(2024, 1, 11, 23, 49, 50, 952, DateTimeKind.Local).AddTicks(6249), new DateTime(2024, 1, 11, 1, 49, 50, 952, DateTimeKind.Local).AddTicks(6246), "Female", new DateTime(2024, 1, 10, 23, 49, 50, 952, DateTimeKind.Local).AddTicks(6243) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AgeGroup", "City", "DeadlineRequestsDateTime", "EndDateTime", "Gender", "StartDateTime" },
                values: new object[] { "18+", "Jezzine", new DateTime(2024, 1, 15, 7, 49, 50, 952, DateTimeKind.Local).AddTicks(6237), new DateTime(2024, 1, 10, 1, 49, 50, 952, DateTimeKind.Local).AddTicks(6234), "Male", new DateTime(2024, 1, 9, 23, 49, 50, 952, DateTimeKind.Local).AddTicks(6231) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AgeGroup", "City", "DeadlineRequestsDateTime", "EndDateTime", "Gender", "StartDateTime" },
                values: new object[] { "18+", "Jezzine", new DateTime(2024, 1, 19, 11, 49, 50, 952, DateTimeKind.Local).AddTicks(6225), new DateTime(2024, 1, 9, 2, 49, 50, 952, DateTimeKind.Local).AddTicks(6221), "Male", new DateTime(2024, 1, 8, 23, 49, 50, 952, DateTimeKind.Local).AddTicks(6218) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AgeGroup", "City", "DeadlineRequestsDateTime", "EndDateTime", "Gender", "StartDateTime" },
                values: new object[] { "10-15", "Sidon", new DateTime(2024, 1, 11, 23, 49, 50, 952, DateTimeKind.Local).AddTicks(6213), new DateTime(2024, 1, 11, 1, 49, 50, 952, DateTimeKind.Local).AddTicks(6210), "Female", new DateTime(2024, 1, 10, 23, 49, 50, 952, DateTimeKind.Local).AddTicks(6205) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AgeGroup", "City", "DeadlineRequestsDateTime", "EndDateTime", "Gender" },
                values: new object[] { "under10", "Beirut", new DateTime(2024, 1, 15, 7, 49, 50, 952, DateTimeKind.Local).AddTicks(6199), new DateTime(2024, 1, 10, 1, 49, 50, 952, DateTimeKind.Local).AddTicks(6196), "Male" });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AgeGroup", "City", "DeadlineRequestsDateTime", "EndDateTime", "Gender", "StartDateTime" },
                values: new object[] { "Under 10", "Beirut", new DateTime(2024, 1, 19, 11, 49, 50, 952, DateTimeKind.Local).AddTicks(6187), new DateTime(2024, 1, 9, 2, 49, 50, 952, DateTimeKind.Local).AddTicks(6183), "Male", new DateTime(2024, 1, 8, 23, 49, 50, 952, DateTimeKind.Local).AddTicks(6130) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgeGroup",
                table: "Match");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Match");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Match");

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

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 6, 1, 37, 40, 837, DateTimeKind.Local).AddTicks(6238), new DateTime(2024, 1, 5, 3, 37, 40, 837, DateTimeKind.Local).AddTicks(6235), new DateTime(2024, 1, 5, 1, 37, 40, 837, DateTimeKind.Local).AddTicks(6232) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime" },
                values: new object[] { new DateTime(2024, 1, 9, 9, 37, 40, 837, DateTimeKind.Local).AddTicks(6226), new DateTime(2024, 1, 4, 3, 37, 40, 837, DateTimeKind.Local).AddTicks(6223) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 13, 13, 37, 40, 837, DateTimeKind.Local).AddTicks(6215), new DateTime(2024, 1, 3, 4, 37, 40, 837, DateTimeKind.Local).AddTicks(6211), new DateTime(2024, 1, 3, 1, 37, 40, 837, DateTimeKind.Local).AddTicks(6155) });

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
    }
}
