using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOnAPI.Migrations
{
    /// <inheritdoc />
    public partial class addOtherTeamCaptain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Match_User_UserId",
                table: "Match");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Match",
                newName: "TeamTwoCaptainId");

            migrationBuilder.RenameIndex(
                name: "IX_Match_UserId",
                table: "Match",
                newName: "IX_Match_TeamTwoCaptainId");

            migrationBuilder.AddColumn<string>(
                name: "TeamOneCaptainId",
                table: "Match",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime", "TeamOneCaptainId", "TeamTwoCaptainId" },
                values: new object[] { new DateTime(2024, 2, 16, 18, 38, 56, 637, DateTimeKind.Local).AddTicks(3520), new DateTime(2024, 2, 15, 20, 38, 56, 637, DateTimeKind.Local).AddTicks(3515), new DateTime(2024, 2, 15, 18, 38, 56, 637, DateTimeKind.Local).AddTicks(3510), "141b7af4-e40a-4330-b7cf-9b85cb579c7c", "069a5b6e-deb5-4dcc-bfd7-92dce2aea524" });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime", "TeamOneCaptainId", "TeamTwoCaptainId" },
                values: new object[] { new DateTime(2024, 2, 20, 2, 38, 56, 637, DateTimeKind.Local).AddTicks(3502), new DateTime(2024, 2, 14, 20, 38, 56, 637, DateTimeKind.Local).AddTicks(3496), new DateTime(2024, 2, 14, 18, 38, 56, 637, DateTimeKind.Local).AddTicks(3491), "141b7af4-e40a-4330-b7cf-9b85cb579c7c", "069a5b6e-deb5-4dcc-bfd7-92dce2aea524" });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime", "TeamOneCaptainId" },
                values: new object[] { new DateTime(2024, 2, 24, 6, 38, 56, 637, DateTimeKind.Local).AddTicks(3484), new DateTime(2024, 2, 13, 21, 38, 56, 637, DateTimeKind.Local).AddTicks(3478), new DateTime(2024, 2, 13, 18, 38, 56, 637, DateTimeKind.Local).AddTicks(3473), "141b7af4-e40a-4330-b7cf-9b85cb579c7c" });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime", "TeamOneCaptainId", "TeamTwoCaptainId" },
                values: new object[] { new DateTime(2024, 2, 16, 18, 38, 56, 637, DateTimeKind.Local).AddTicks(3466), new DateTime(2024, 2, 15, 20, 38, 56, 637, DateTimeKind.Local).AddTicks(3461), new DateTime(2024, 2, 15, 18, 38, 56, 637, DateTimeKind.Local).AddTicks(3455), "141b7af4-e40a-4330-b7cf-9b85cb579c7c", "069a5b6e-deb5-4dcc-bfd7-92dce2aea524" });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "TeamOneCaptainId", "TeamTwoCaptainId" },
                values: new object[] { new DateTime(2024, 2, 20, 2, 38, 56, 637, DateTimeKind.Local).AddTicks(3446), new DateTime(2024, 2, 14, 20, 38, 56, 637, DateTimeKind.Local).AddTicks(3440), "141b7af4-e40a-4330-b7cf-9b85cb579c7c", "069a5b6e-deb5-4dcc-bfd7-92dce2aea524" });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime", "TeamOneCaptainId", "TeamTwoCaptainId" },
                values: new object[] { new DateTime(2024, 2, 24, 6, 38, 56, 637, DateTimeKind.Local).AddTicks(3428), new DateTime(2024, 2, 13, 21, 38, 56, 637, DateTimeKind.Local).AddTicks(3420), new DateTime(2024, 2, 13, 18, 38, 56, 637, DateTimeKind.Local).AddTicks(3350), "069a5b6e-deb5-4dcc-bfd7-92dce2aea524", "141b7af4-e40a-4330-b7cf-9b85cb579c7c" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "80b4f85f-8699-4b42-ba8a-63c0c0a8364a", "b614893e-8d1e-4ea7-b60b-1b822c627ecc" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "047335df-e006-4558-a65f-ad35d88a7d9b", "8f2d8949-9d2b-4e81-828c-9042ca235060" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "21493ea0-17f4-4fbf-8aac-9efb36b42c26", "89e64959-6050-4d87-9055-61b8722ae1a7" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "23c8bf64-d546-4867-825b-f0ce012bd8a5", "bb5ec843-6a63-4cd9-a17a-ff0505afbefb" });

            migrationBuilder.CreateIndex(
                name: "IX_Match_TeamOneCaptainId",
                table: "Match",
                column: "TeamOneCaptainId");

            migrationBuilder.AddForeignKey(
                name: "FK_Match_User_TeamOneCaptainId",
                table: "Match",
                column: "TeamOneCaptainId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Match_User_TeamTwoCaptainId",
                table: "Match",
                column: "TeamTwoCaptainId",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Match_User_TeamOneCaptainId",
                table: "Match");

            migrationBuilder.DropForeignKey(
                name: "FK_Match_User_TeamTwoCaptainId",
                table: "Match");

            migrationBuilder.DropIndex(
                name: "IX_Match_TeamOneCaptainId",
                table: "Match");

            migrationBuilder.DropColumn(
                name: "TeamOneCaptainId",
                table: "Match");

            migrationBuilder.RenameColumn(
                name: "TeamTwoCaptainId",
                table: "Match",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Match_TeamTwoCaptainId",
                table: "Match",
                newName: "IX_Match_UserId");

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime", "UserId" },
                values: new object[] { new DateTime(2024, 2, 15, 17, 56, 33, 42, DateTimeKind.Local).AddTicks(8431), new DateTime(2024, 2, 14, 19, 56, 33, 42, DateTimeKind.Local).AddTicks(8428), new DateTime(2024, 2, 14, 17, 56, 33, 42, DateTimeKind.Local).AddTicks(8425), "141b7af4-e40a-4330-b7cf-9b85cb579c7c" });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime", "UserId" },
                values: new object[] { new DateTime(2024, 2, 19, 1, 56, 33, 42, DateTimeKind.Local).AddTicks(8420), new DateTime(2024, 2, 13, 19, 56, 33, 42, DateTimeKind.Local).AddTicks(8417), new DateTime(2024, 2, 13, 17, 56, 33, 42, DateTimeKind.Local).AddTicks(8414), "141b7af4-e40a-4330-b7cf-9b85cb579c7c" });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 2, 23, 5, 56, 33, 42, DateTimeKind.Local).AddTicks(8409), new DateTime(2024, 2, 12, 20, 56, 33, 42, DateTimeKind.Local).AddTicks(8405), new DateTime(2024, 2, 12, 17, 56, 33, 42, DateTimeKind.Local).AddTicks(8402) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime", "UserId" },
                values: new object[] { new DateTime(2024, 2, 15, 17, 56, 33, 42, DateTimeKind.Local).AddTicks(8397), new DateTime(2024, 2, 14, 19, 56, 33, 42, DateTimeKind.Local).AddTicks(8394), new DateTime(2024, 2, 14, 17, 56, 33, 42, DateTimeKind.Local).AddTicks(8391), "141b7af4-e40a-4330-b7cf-9b85cb579c7c" });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "UserId" },
                values: new object[] { new DateTime(2024, 2, 19, 1, 56, 33, 42, DateTimeKind.Local).AddTicks(8385), new DateTime(2024, 2, 13, 19, 56, 33, 42, DateTimeKind.Local).AddTicks(8382), "141b7af4-e40a-4330-b7cf-9b85cb579c7c" });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime", "UserId" },
                values: new object[] { new DateTime(2024, 2, 23, 5, 56, 33, 42, DateTimeKind.Local).AddTicks(8374), new DateTime(2024, 2, 12, 20, 56, 33, 42, DateTimeKind.Local).AddTicks(8370), new DateTime(2024, 2, 12, 17, 56, 33, 42, DateTimeKind.Local).AddTicks(8318), "069a5b6e-deb5-4dcc-bfd7-92dce2aea524" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b9f928c1-87f1-4c24-8a31-7b987725e5be", "33eaa570-ed96-4d99-8b93-0b2a68ffc9cd" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "268bcb8d-a7e3-44e5-bb48-8d35b290aed2", "24421568-398d-44af-8b5f-0cebd3cb9e06" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "82ceef32-605d-4199-a3d7-a9df8d797d1d", "76d4aeac-2be2-4ffc-ba05-38351f325889" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c31b7be8-e650-4eb5-9f91-edfb7aa4258c", "065bdcf2-26f8-42db-a3ff-ed0ad1de0812" });

            migrationBuilder.AddForeignKey(
                name: "FK_Match_User_UserId",
                table: "Match",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
