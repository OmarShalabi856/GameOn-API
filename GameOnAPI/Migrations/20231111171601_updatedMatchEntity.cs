using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOnAPI.Migrations
{
    /// <inheritdoc />
    public partial class updatedMatchEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Match_MatchId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Match_MatchId1",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_MatchId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_MatchId1",
                table: "User");

            migrationBuilder.DropColumn(
                name: "MatchId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "MatchId1",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Team1GoalCount",
                table: "Match");

            migrationBuilder.DropColumn(
                name: "Team2GoalCount",
                table: "Match");

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 16, 19, 16, 1, 177, DateTimeKind.Local).AddTicks(1032), new DateTime(2023, 11, 15, 21, 16, 1, 177, DateTimeKind.Local).AddTicks(1029), new DateTime(2023, 11, 15, 19, 16, 1, 177, DateTimeKind.Local).AddTicks(1026) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 20, 3, 16, 1, 177, DateTimeKind.Local).AddTicks(1022), new DateTime(2023, 11, 14, 21, 16, 1, 177, DateTimeKind.Local).AddTicks(1018), new DateTime(2023, 11, 14, 19, 16, 1, 177, DateTimeKind.Local).AddTicks(1015) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 24, 7, 16, 1, 177, DateTimeKind.Local).AddTicks(1007), new DateTime(2023, 11, 13, 22, 16, 1, 177, DateTimeKind.Local).AddTicks(1003), new DateTime(2023, 11, 13, 19, 16, 1, 177, DateTimeKind.Local).AddTicks(953) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4e2dd62e-d9c6-4c1b-90d0-2fc2486a3510", "6b4d3d12-d40b-4cad-8e6e-1eda21e1e625" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "12fa360b-c26a-4573-bd43-48af7253a823", "0a21fd98-86fa-4798-a1f9-7137078dc352" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "508e6700-89eb-42a2-a30e-308f42b64d08", "fc0f3876-317c-4196-b470-634a7d6dcb00" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e04f6359-c4f5-4259-b1f1-3b897e93e69d", "bb1f9d44-f1fb-4b14-be09-5d8df48de246" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MatchId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MatchId1",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Team1GoalCount",
                table: "Match",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Team2GoalCount",
                table: "Match",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime", "Team1GoalCount", "Team2GoalCount" },
                values: new object[] { new DateTime(2023, 11, 16, 18, 51, 40, 823, DateTimeKind.Local).AddTicks(2698), new DateTime(2023, 11, 15, 20, 51, 40, 823, DateTimeKind.Local).AddTicks(2695), new DateTime(2023, 11, 15, 18, 51, 40, 823, DateTimeKind.Local).AddTicks(2692), 2, 4 });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime", "Team1GoalCount", "Team2GoalCount" },
                values: new object[] { new DateTime(2023, 11, 20, 2, 51, 40, 823, DateTimeKind.Local).AddTicks(2687), new DateTime(2023, 11, 14, 20, 51, 40, 823, DateTimeKind.Local).AddTicks(2684), new DateTime(2023, 11, 14, 18, 51, 40, 823, DateTimeKind.Local).AddTicks(2681), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime", "Team1GoalCount", "Team2GoalCount" },
                values: new object[] { new DateTime(2023, 11, 24, 6, 51, 40, 823, DateTimeKind.Local).AddTicks(2673), new DateTime(2023, 11, 13, 21, 51, 40, 823, DateTimeKind.Local).AddTicks(2669), new DateTime(2023, 11, 13, 18, 51, 40, 823, DateTimeKind.Local).AddTicks(2621), 1, 2 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "MatchId", "MatchId1", "SecurityStamp" },
                values: new object[] { "1a17ccbf-91e8-46fb-8922-66d291ede647", null, null, "e1dea281-3863-4f1d-b801-a1269cb0ef11" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "MatchId", "MatchId1", "SecurityStamp" },
                values: new object[] { "9886bd2c-be7c-4daa-a195-4f79d4b7c939", null, null, "c55404d0-971e-4d95-85eb-b1de9e61ee76" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "MatchId", "MatchId1", "SecurityStamp" },
                values: new object[] { "c34ea45b-4280-47e9-84bb-08d1cfd011ae", null, null, "8bea7942-97e4-45a0-9ea9-cd992c72cf8d" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "MatchId", "MatchId1", "SecurityStamp" },
                values: new object[] { "1659768f-362b-4e88-9053-5cb84b96b3eb", null, null, "ec0cbbcd-c369-498f-bfe2-ebff0bbe6eff" });

            migrationBuilder.CreateIndex(
                name: "IX_User_MatchId",
                table: "User",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_User_MatchId1",
                table: "User",
                column: "MatchId1");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Match_MatchId",
                table: "User",
                column: "MatchId",
                principalTable: "Match",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Match_MatchId1",
                table: "User",
                column: "MatchId1",
                principalTable: "Match",
                principalColumn: "Id");
        }
    }
}
