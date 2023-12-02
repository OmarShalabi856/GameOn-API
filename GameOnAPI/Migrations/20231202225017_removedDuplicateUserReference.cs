using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOnAPI.Migrations
{
    /// <inheritdoc />
    public partial class removedDuplicateUserReference : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Match_User_captainId",
                table: "Match");

            migrationBuilder.RenameColumn(
                name: "captainId",
                table: "Match",
                newName: "UserId1");

            migrationBuilder.RenameIndex(
                name: "IX_Match_captainId",
                table: "Match",
                newName: "IX_Match_UserId1");

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 50, 17, 15, DateTimeKind.Local).AddTicks(8559), new DateTime(2023, 12, 7, 2, 50, 17, 15, DateTimeKind.Local).AddTicks(8555), new DateTime(2023, 12, 7, 0, 50, 17, 15, DateTimeKind.Local).AddTicks(8549) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 11, 8, 50, 17, 15, DateTimeKind.Local).AddTicks(8543), new DateTime(2023, 12, 6, 2, 50, 17, 15, DateTimeKind.Local).AddTicks(8539), new DateTime(2023, 12, 6, 0, 50, 17, 15, DateTimeKind.Local).AddTicks(8535) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 15, 12, 50, 17, 15, DateTimeKind.Local).AddTicks(8528), new DateTime(2023, 12, 5, 3, 50, 17, 15, DateTimeKind.Local).AddTicks(8523), new DateTime(2023, 12, 5, 0, 50, 17, 15, DateTimeKind.Local).AddTicks(8459) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4b53c598-cadb-4cfe-bbd8-4f15a1569554", "216a4948-b2b3-4c07-8037-050f7affba02" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5b55be25-d938-461e-85e0-c4a0aff3ce37", "143d9bf3-b7fa-4917-ac20-21e0543a0e98" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "021bd735-60af-4c0d-a62c-8dfd29b2cf6f", "07453034-f2e8-4caf-b925-91f54dd1dbe8" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cc9d9d12-a15f-4659-8891-74eac465e913", "0c6505d7-c907-471c-a8d1-3581127495e2" });

            migrationBuilder.AddForeignKey(
                name: "FK_Match_User_UserId1",
                table: "Match",
                column: "UserId1",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Match_User_UserId1",
                table: "Match");

            migrationBuilder.RenameColumn(
                name: "UserId1",
                table: "Match",
                newName: "captainId");

            migrationBuilder.RenameIndex(
                name: "IX_Match_UserId1",
                table: "Match",
                newName: "IX_Match_captainId");

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 7, 23, 15, 11, 932, DateTimeKind.Local).AddTicks(2583), new DateTime(2023, 12, 7, 1, 15, 11, 932, DateTimeKind.Local).AddTicks(2577), new DateTime(2023, 12, 6, 23, 15, 11, 932, DateTimeKind.Local).AddTicks(2571) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 11, 7, 15, 11, 932, DateTimeKind.Local).AddTicks(2562), new DateTime(2023, 12, 6, 1, 15, 11, 932, DateTimeKind.Local).AddTicks(2555), new DateTime(2023, 12, 5, 23, 15, 11, 932, DateTimeKind.Local).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 15, 11, 15, 11, 932, DateTimeKind.Local).AddTicks(2539), new DateTime(2023, 12, 5, 2, 15, 11, 932, DateTimeKind.Local).AddTicks(2531), new DateTime(2023, 12, 4, 23, 15, 11, 932, DateTimeKind.Local).AddTicks(2457) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9d22a690-2895-430b-92bd-4e50d3444570", "7b89ee23-4a64-4e64-bea4-87bdc651f91f" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f7e9acfe-0600-4bd9-b16a-9f72957cf47f", "eca3756c-751b-468b-a073-131e63dd5cd0" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fd4f6843-465d-44c5-81f8-d27a28b6f88a", "830cb749-3e39-4aa2-8ffc-1c4018f1ca77" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a5300ccd-1f55-4104-80fc-1bb72917c20d", "fa1d6b16-d758-428b-a3e9-8aefebdb1880" });

            migrationBuilder.AddForeignKey(
                name: "FK_Match_User_captainId",
                table: "Match",
                column: "captainId",
                principalTable: "User",
                principalColumn: "Id");
        }
    }
}
