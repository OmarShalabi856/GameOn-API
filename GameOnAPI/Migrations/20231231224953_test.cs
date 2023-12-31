using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOnAPI.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropForeignKey(
				name: "FK_Match_User_UserId1",
				table: "Match");

			migrationBuilder.DropColumn(
				name: "UserId",
				table: "Match");

			migrationBuilder.DropIndex(
				name: "IX_Match_UserId1",
				table: "Match");

			//migrationBuilder.AddColumn<string>(
			//	name: "UserId1",
			//	table: "Match",
			//	nullable: true);

			migrationBuilder.UpdateData(
				table: "Match",
				keyColumn: "Id",
				keyValue: 1,
				columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime", "UserId1" },
				values: new object[] { new DateTime(2024, 1, 6, 0, 49, 52, 759, DateTimeKind.Local).AddTicks(2222), new DateTime(2024, 1, 5, 2, 49, 52, 759, DateTimeKind.Local).AddTicks(2219), new DateTime(2024, 1, 5, 0, 49, 52, 759, DateTimeKind.Local).AddTicks(2216), "141b7af4-e40a-4330-b7cf-9b85cb579c7c" });

			migrationBuilder.UpdateData(
				table: "Match",
				keyColumn: "Id",
				keyValue: 2,
				columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime", "UserId1" },
				values: new object[] { new DateTime(2024, 1, 9, 8, 49, 52, 759, DateTimeKind.Local).AddTicks(2211), new DateTime(2024, 1, 4, 2, 49, 52, 759, DateTimeKind.Local).AddTicks(2207), new DateTime(2024, 1, 4, 0, 49, 52, 759, DateTimeKind.Local).AddTicks(2204), "141b7af4-e40a-4330-b7cf-9b85cb579c7c" });

			migrationBuilder.UpdateData(
				table: "Match",
				keyColumn: "Id",
				keyValue: 3,
				columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime", "UserId1" },
				values: new object[] { new DateTime(2024, 1, 13, 12, 49, 52, 759, DateTimeKind.Local).AddTicks(2197), new DateTime(2024, 1, 3, 3, 49, 52, 759, DateTimeKind.Local).AddTicks(2194), new DateTime(2024, 1, 3, 0, 49, 52, 759, DateTimeKind.Local).AddTicks(2141), "069a5b6e-deb5-4dcc-bfd7-92dce2aea524" });

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

            migrationBuilder.DropIndex(
                name: "IX_Match_UserId1",
                table: "Match");

            //migrationBuilder.DropColumn(
            //    name: "UserId1",
            //    table: "Match");

            //migrationBuilder.AlterColumn<string>(
            //    name: "UserId1",
            //    table: "Match",
            //    type: "nvarchar(450)",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(max)");

            //migrationBuilder.AddColumn<int>(
            //    name: "UserId",
            //    table: "Match",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime", "UserId", "UserId1" },
                values: new object[] { new DateTime(2024, 1, 6, 0, 34, 9, 796, DateTimeKind.Local).AddTicks(844), new DateTime(2024, 1, 5, 2, 34, 9, 796, DateTimeKind.Local).AddTicks(841), new DateTime(2024, 1, 5, 0, 34, 9, 796, DateTimeKind.Local).AddTicks(838), 1, null });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime", "UserId", "UserId1" },
                values: new object[] { new DateTime(2024, 1, 9, 8, 34, 9, 796, DateTimeKind.Local).AddTicks(833), new DateTime(2024, 1, 4, 2, 34, 9, 796, DateTimeKind.Local).AddTicks(830), new DateTime(2024, 1, 4, 0, 34, 9, 796, DateTimeKind.Local).AddTicks(826), 1, null });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime", "UserId", "UserId1" },
                values: new object[] { new DateTime(2024, 1, 13, 12, 34, 9, 796, DateTimeKind.Local).AddTicks(819), new DateTime(2024, 1, 3, 3, 34, 9, 796, DateTimeKind.Local).AddTicks(815), new DateTime(2024, 1, 3, 0, 34, 9, 796, DateTimeKind.Local).AddTicks(758), 1, null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2ee95bd0-9e14-4871-830b-17db08ae44bc", "e97c98f8-bc11-451c-9c91-3afb9e95b4d9" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d9e0097d-ab47-4734-85e9-96e17ceec399", "dea360ba-7b4a-4e75-80a8-0350ea21997b" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7409e67a-097e-434b-80cc-e69bf75cfa8b", "644f5d8f-e537-4d42-af3f-076b05e6554e" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d0fd5237-b85a-40c3-8934-ec0cdd27697c", "1c169bbf-2464-4d5e-b36d-a387bce92f72" });

            migrationBuilder.CreateIndex(
                name: "IX_Match_UserId1",
                table: "Match",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Match_User_UserId1",
                table: "Match",
                column: "UserId1",
                principalTable: "User",
                principalColumn: "Id");
        }
    }
}
