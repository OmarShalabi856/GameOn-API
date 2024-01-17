using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOnAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateInvitationSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "sentDate",
                table: "Invitation",
                newName: "SentDate");

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 22, 22, 45, 36, 961, DateTimeKind.Local).AddTicks(4164), new DateTime(2024, 1, 22, 0, 45, 36, 961, DateTimeKind.Local).AddTicks(4161), new DateTime(2024, 1, 21, 22, 45, 36, 961, DateTimeKind.Local).AddTicks(4158) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 26, 6, 45, 36, 961, DateTimeKind.Local).AddTicks(4152), new DateTime(2024, 1, 21, 0, 45, 36, 961, DateTimeKind.Local).AddTicks(4149), new DateTime(2024, 1, 20, 22, 45, 36, 961, DateTimeKind.Local).AddTicks(4146) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 30, 10, 45, 36, 961, DateTimeKind.Local).AddTicks(4141), new DateTime(2024, 1, 20, 1, 45, 36, 961, DateTimeKind.Local).AddTicks(4138), new DateTime(2024, 1, 19, 22, 45, 36, 961, DateTimeKind.Local).AddTicks(4134) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 22, 22, 45, 36, 961, DateTimeKind.Local).AddTicks(4129), new DateTime(2024, 1, 22, 0, 45, 36, 961, DateTimeKind.Local).AddTicks(4126), new DateTime(2024, 1, 21, 22, 45, 36, 961, DateTimeKind.Local).AddTicks(4122) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime" },
                values: new object[] { new DateTime(2024, 1, 26, 6, 45, 36, 961, DateTimeKind.Local).AddTicks(4116), new DateTime(2024, 1, 21, 0, 45, 36, 961, DateTimeKind.Local).AddTicks(4113) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 30, 10, 45, 36, 961, DateTimeKind.Local).AddTicks(4103), new DateTime(2024, 1, 20, 1, 45, 36, 961, DateTimeKind.Local).AddTicks(4097), new DateTime(2024, 1, 19, 22, 45, 36, 961, DateTimeKind.Local).AddTicks(4039) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4b6b20a7-482a-462d-9264-146331483707", "dcbe0311-07ca-43f4-a0e6-09fb25f1d8f9" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f7195c96-6a4d-4f96-bd05-7aef2639f336", "c6985dcc-575b-4780-ad05-b70e25dfeaaa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8060b4eb-c60e-40be-aa8e-240083a63438", "10a3e2d5-577a-4798-8edc-f160c87b09b0" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ba0e65fe-78e9-4658-8408-d98f17221b85", "7f2b9051-9364-49c0-b1c6-e847273b57cc" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SentDate",
                table: "Invitation",
                newName: "sentDate");

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
        }
    }
}
