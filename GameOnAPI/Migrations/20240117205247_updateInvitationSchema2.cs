using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOnAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateInvitationSchema2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Invitation_User_UserId",
            //    table: "Invitation");

            //migrationBuilder.DropIndex(
            //    name: "IX_Invitation_UserId",
            //    table: "Invitation");

            //migrationBuilder.DropColumn(
            //    name: "UserId",
            //    table: "Invitation");

            migrationBuilder.RenameColumn(
                name: "sentDate",
                table: "Invitation",
                newName: "SentDate");

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 22, 22, 52, 46, 533, DateTimeKind.Local).AddTicks(4025), new DateTime(2024, 1, 22, 0, 52, 46, 533, DateTimeKind.Local).AddTicks(4021), new DateTime(2024, 1, 21, 22, 52, 46, 533, DateTimeKind.Local).AddTicks(4017) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 26, 6, 52, 46, 533, DateTimeKind.Local).AddTicks(3927), new DateTime(2024, 1, 21, 0, 52, 46, 533, DateTimeKind.Local).AddTicks(3924), new DateTime(2024, 1, 20, 22, 52, 46, 533, DateTimeKind.Local).AddTicks(3921) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 30, 10, 52, 46, 533, DateTimeKind.Local).AddTicks(3915), new DateTime(2024, 1, 20, 1, 52, 46, 533, DateTimeKind.Local).AddTicks(3912), new DateTime(2024, 1, 19, 22, 52, 46, 533, DateTimeKind.Local).AddTicks(3909) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 22, 22, 52, 46, 533, DateTimeKind.Local).AddTicks(3904), new DateTime(2024, 1, 22, 0, 52, 46, 533, DateTimeKind.Local).AddTicks(3901), new DateTime(2024, 1, 21, 22, 52, 46, 533, DateTimeKind.Local).AddTicks(3897) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime" },
                values: new object[] { new DateTime(2024, 1, 26, 6, 52, 46, 533, DateTimeKind.Local).AddTicks(3892), new DateTime(2024, 1, 21, 0, 52, 46, 533, DateTimeKind.Local).AddTicks(3888) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 30, 10, 52, 46, 533, DateTimeKind.Local).AddTicks(3877), new DateTime(2024, 1, 20, 1, 52, 46, 533, DateTimeKind.Local).AddTicks(3872), new DateTime(2024, 1, 19, 22, 52, 46, 533, DateTimeKind.Local).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "24e14afa-1330-4027-928d-1dd98dadc7fd", "3b7b12aa-ea48-4fab-9236-331ddb0f82b5" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0f4af53e-f4bb-4778-9fa2-b92e4c39dbc2", "b2543763-7399-4aef-b6a6-a16ca169dd9c" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f961f516-5592-46ef-b659-c278cb78d0f2", "a9728182-e159-47ff-a83b-0801d368bcfa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3f3e5734-8ebd-4d57-ade1-f391d15d3451", "9d04f313-1455-4cb7-9e4a-aa115131ee86" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SentDate",
                table: "Invitation",
                newName: "sentDate");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Invitation",
                type: "nvarchar(450)",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Invitation_UserId",
                table: "Invitation",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invitation_User_UserId",
                table: "Invitation",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");
        }
    }
}
