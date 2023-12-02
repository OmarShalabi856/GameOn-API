using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOnAPI.Migrations
{
    /// <inheritdoc />
    public partial class updatedMatchModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Match",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "captainId",
                table: "Match",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime", "UserId", "captainId" },
                values: new object[] { new DateTime(2023, 12, 7, 23, 15, 11, 932, DateTimeKind.Local).AddTicks(2583), new DateTime(2023, 12, 7, 1, 15, 11, 932, DateTimeKind.Local).AddTicks(2577), new DateTime(2023, 12, 6, 23, 15, 11, 932, DateTimeKind.Local).AddTicks(2571), 1, null });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime", "UserId", "captainId" },
                values: new object[] { new DateTime(2023, 12, 11, 7, 15, 11, 932, DateTimeKind.Local).AddTicks(2562), new DateTime(2023, 12, 6, 1, 15, 11, 932, DateTimeKind.Local).AddTicks(2555), new DateTime(2023, 12, 5, 23, 15, 11, 932, DateTimeKind.Local).AddTicks(2549), 1, null });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime", "UserId", "captainId" },
                values: new object[] { new DateTime(2023, 12, 15, 11, 15, 11, 932, DateTimeKind.Local).AddTicks(2539), new DateTime(2023, 12, 5, 2, 15, 11, 932, DateTimeKind.Local).AddTicks(2531), new DateTime(2023, 12, 4, 23, 15, 11, 932, DateTimeKind.Local).AddTicks(2457), 1, null });

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

            migrationBuilder.CreateIndex(
                name: "IX_Match_captainId",
                table: "Match",
                column: "captainId");

            migrationBuilder.AddForeignKey(
                name: "FK_Match_User_captainId",
                table: "Match",
                column: "captainId",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Match_User_captainId",
                table: "Match");

            migrationBuilder.DropIndex(
                name: "IX_Match_captainId",
                table: "Match");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Match");

            migrationBuilder.DropColumn(
                name: "captainId",
                table: "Match");

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 3, 22, 46, 38, 645, DateTimeKind.Local).AddTicks(4727), new DateTime(2023, 12, 3, 0, 46, 38, 645, DateTimeKind.Local).AddTicks(4723), new DateTime(2023, 12, 2, 22, 46, 38, 645, DateTimeKind.Local).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 7, 6, 46, 38, 645, DateTimeKind.Local).AddTicks(4716), new DateTime(2023, 12, 2, 0, 46, 38, 645, DateTimeKind.Local).AddTicks(4712), new DateTime(2023, 12, 1, 22, 46, 38, 645, DateTimeKind.Local).AddTicks(4708) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 12, 11, 10, 46, 38, 645, DateTimeKind.Local).AddTicks(4700), new DateTime(2023, 12, 1, 1, 46, 38, 645, DateTimeKind.Local).AddTicks(4695), new DateTime(2023, 11, 30, 22, 46, 38, 645, DateTimeKind.Local).AddTicks(4641) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "50bb1ea2-3fa6-40af-bddb-2f39a9c674a9", "da5f0ae8-2a16-40a3-9d95-0daa1ecb9e00" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9163d0c4-f8ec-413c-a5d9-6f634ffd8fae", "8c61ae48-c676-477a-8051-122a588c2e4e" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3383f109-d8ab-4ce9-8db0-2b5d0b60d3c4", "a1c8d60c-2c5d-4b8a-ae0a-fed59b0600ac" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e27558fc-3ff6-4757-a081-1973b22ff888", "3eaac93c-bd38-47f8-b5ea-eece0b85e980" });
        }
    }
}
