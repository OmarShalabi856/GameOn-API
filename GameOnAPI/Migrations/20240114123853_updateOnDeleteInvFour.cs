using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOnAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateOnDeleteInvFour : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invitation_User_InvitedPlayerId",
                table: "Invitation");

            migrationBuilder.DropForeignKey(
                name: "FK_Invitation_User_MatchCaptainId",
                table: "Invitation");

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 19, 14, 38, 53, 48, DateTimeKind.Local).AddTicks(1172), new DateTime(2024, 1, 18, 16, 38, 53, 48, DateTimeKind.Local).AddTicks(1167), new DateTime(2024, 1, 18, 14, 38, 53, 48, DateTimeKind.Local).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 22, 22, 38, 53, 48, DateTimeKind.Local).AddTicks(1147), new DateTime(2024, 1, 17, 16, 38, 53, 48, DateTimeKind.Local).AddTicks(1139), new DateTime(2024, 1, 17, 14, 38, 53, 48, DateTimeKind.Local).AddTicks(1134) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 38, 53, 48, DateTimeKind.Local).AddTicks(1122), new DateTime(2024, 1, 16, 17, 38, 53, 48, DateTimeKind.Local).AddTicks(1114), new DateTime(2024, 1, 16, 14, 38, 53, 48, DateTimeKind.Local).AddTicks(1108) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 19, 14, 38, 53, 48, DateTimeKind.Local).AddTicks(1097), new DateTime(2024, 1, 18, 16, 38, 53, 48, DateTimeKind.Local).AddTicks(1088), new DateTime(2024, 1, 18, 14, 38, 53, 48, DateTimeKind.Local).AddTicks(1080) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime" },
                values: new object[] { new DateTime(2024, 1, 22, 22, 38, 53, 48, DateTimeKind.Local).AddTicks(1067), new DateTime(2024, 1, 17, 16, 38, 53, 48, DateTimeKind.Local).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 38, 53, 48, DateTimeKind.Local).AddTicks(1043), new DateTime(2024, 1, 16, 17, 38, 53, 48, DateTimeKind.Local).AddTicks(1033), new DateTime(2024, 1, 16, 14, 38, 53, 48, DateTimeKind.Local).AddTicks(953) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c4e7c965-e5d7-47b6-a112-c73ae9cf1fb1", "df7e7e2a-8147-4389-a334-ff4b6a879f92" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9afbdde8-6175-4295-9782-bdfe8a4d2b8c", "5f6d8b9d-ab62-49a7-8d91-c855475317e0" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "983240dd-188a-412b-84e0-acc9130a6f18", "05112324-fdb5-4e56-81bd-2f169f600682" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "314aa7e0-c91f-4390-a654-30313519a9a6", "6bdb8b88-7cd5-46d0-9c9b-93646b927305" });

            migrationBuilder.AddForeignKey(
                name: "FK_Invitation_User_InvitedPlayerId",
                table: "Invitation",
                column: "InvitedPlayerId",
                principalTable: "User",
                principalColumn: "Id",
			   onDelete: ReferentialAction.NoAction);

			migrationBuilder.AddForeignKey(
                name: "FK_Invitation_User_MatchCaptainId",
                table: "Invitation",
                column: "MatchCaptainId",
                principalTable: "User",
                principalColumn: "Id",
				onDelete: ReferentialAction.NoAction);
		}

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invitation_User_InvitedPlayerId",
                table: "Invitation");

            migrationBuilder.DropForeignKey(
                name: "FK_Invitation_User_MatchCaptainId",
                table: "Invitation");

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 19, 14, 36, 39, 235, DateTimeKind.Local).AddTicks(8136), new DateTime(2024, 1, 18, 16, 36, 39, 235, DateTimeKind.Local).AddTicks(8133), new DateTime(2024, 1, 18, 14, 36, 39, 235, DateTimeKind.Local).AddTicks(8130) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 22, 22, 36, 39, 235, DateTimeKind.Local).AddTicks(8125), new DateTime(2024, 1, 17, 16, 36, 39, 235, DateTimeKind.Local).AddTicks(8122), new DateTime(2024, 1, 17, 14, 36, 39, 235, DateTimeKind.Local).AddTicks(8119) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 36, 39, 235, DateTimeKind.Local).AddTicks(8113), new DateTime(2024, 1, 16, 17, 36, 39, 235, DateTimeKind.Local).AddTicks(8110), new DateTime(2024, 1, 16, 14, 36, 39, 235, DateTimeKind.Local).AddTicks(8107) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 19, 14, 36, 39, 235, DateTimeKind.Local).AddTicks(8102), new DateTime(2024, 1, 18, 16, 36, 39, 235, DateTimeKind.Local).AddTicks(8099), new DateTime(2024, 1, 18, 14, 36, 39, 235, DateTimeKind.Local).AddTicks(8095) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime" },
                values: new object[] { new DateTime(2024, 1, 22, 22, 36, 39, 235, DateTimeKind.Local).AddTicks(8089), new DateTime(2024, 1, 17, 16, 36, 39, 235, DateTimeKind.Local).AddTicks(8086) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 27, 2, 36, 39, 235, DateTimeKind.Local).AddTicks(8076), new DateTime(2024, 1, 16, 17, 36, 39, 235, DateTimeKind.Local).AddTicks(8072), new DateTime(2024, 1, 16, 14, 36, 39, 235, DateTimeKind.Local).AddTicks(8018) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "417ae1ac-688d-481e-8f33-7b7df8485c80", "4be8ee80-685a-4a54-840c-370e0720b308" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c1b35285-4704-4b81-b90a-61b37d5ed01c", "9c3835a9-1381-4bac-a982-b75b34e5a39c" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3b7716d6-3258-48ed-8e1a-9c7ccc98dfc3", "4091f1e6-0b4a-4ecf-9068-abf2303bf2e2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bd35432d-ba4f-4978-a0b3-2c228e7fca84", "a7d52fc9-9b96-4f59-b648-b0393342b4cd" });

            migrationBuilder.AddForeignKey(
                name: "FK_Invitation_User_InvitedPlayerId",
                table: "Invitation",
                column: "InvitedPlayerId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Invitation_User_MatchCaptainId",
                table: "Invitation",
                column: "MatchCaptainId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
