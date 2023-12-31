using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOnAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateUserColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Match_User_UserId1",
                table: "Match");

            //migrationBuilder.DropIndex(
            //    name: "IX_Match_UserId1",
            //    table: "Match");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Match");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Match",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime", "UserId" },
                values: new object[] { new DateTime(2024, 1, 6, 1, 11, 28, 38, DateTimeKind.Local).AddTicks(6090), new DateTime(2024, 1, 5, 3, 11, 28, 38, DateTimeKind.Local).AddTicks(6087), new DateTime(2024, 1, 5, 1, 11, 28, 38, DateTimeKind.Local).AddTicks(6084), "141b7af4-e40a-4330-b7cf-9b85cb579c7c" });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime", "UserId" },
                values: new object[] { new DateTime(2024, 1, 9, 9, 11, 28, 38, DateTimeKind.Local).AddTicks(6079), new DateTime(2024, 1, 4, 3, 11, 28, 38, DateTimeKind.Local).AddTicks(6075), new DateTime(2024, 1, 4, 1, 11, 28, 38, DateTimeKind.Local).AddTicks(6072), "141b7af4-e40a-4330-b7cf-9b85cb579c7c" });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime", "UserId" },
                values: new object[] { new DateTime(2024, 1, 13, 13, 11, 28, 38, DateTimeKind.Local).AddTicks(6063), new DateTime(2024, 1, 3, 4, 11, 28, 38, DateTimeKind.Local).AddTicks(6057), new DateTime(2024, 1, 3, 1, 11, 28, 38, DateTimeKind.Local).AddTicks(6002), "069a5b6e-deb5-4dcc-bfd7-92dce2aea524" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "22d2dd90-3203-4a09-be8a-baff0ce50cc1", "bbcd1958-338b-4e4e-89d0-7efd2d653dd3" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "67ab15f4-a724-463c-a8ff-a88305333d82", "54254de6-66b4-4f4c-8158-4e8dde647f54" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fb528b21-2800-4dfe-b34a-5629e4aa81a5", "668bdfa5-68cd-4d91-bdfa-c95b51053ba4" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "706f86fe-b166-41c7-b7b2-ecd3614c1418", "05cf1f71-a7c9-4dfa-a851-cc99c3b7c16e" });

            migrationBuilder.CreateIndex(
                name: "IX_Match_UserId",
                table: "Match",
                column: "UserId");

			migrationBuilder.AddForeignKey(
	           name: "FK_Match_User_UserId",
	           table: "Match",
	           column: "UserId",
	           principalTable: "User",
	           principalColumn: "Id",
	           onDelete: ReferentialAction.NoAction);

		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Match_User_UserId",
                table: "Match");

            migrationBuilder.DropIndex(
                name: "IX_Match_UserId",
                table: "Match");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Match");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Match",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b97b060c-fea0-4f8f-936f-a5a30e5567aa", "82bdfcc0-52cf-4e00-8530-833d5f0df48e" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "698878e9-f746-4668-b3a3-cafd283f0497", "422359ca-bc17-46de-b22c-f272010049de" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4b0bf0b3-e777-46cf-afad-22c3b75c9c1b", "48352dc6-3979-4353-bed8-b80f8dad0513" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4dff06e4-3d30-4597-b026-bdd15a04917f", "850ac63f-9a00-4f55-9a40-131e22b08032" });

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
