using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOnAPI.Migrations
{
    /// <inheritdoc />
    public partial class removedCityFieldFromMatch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Match");

            migrationBuilder.CreateTable(
                name: "Invitation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatchCaptainId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InvitedPlayerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MatchId = table.Column<int>(type: "int", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invitation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invitation_Match_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Match",
                        principalColumn: "Id",
						onDelete: ReferentialAction.NoAction);
					table.ForeignKey(
                        name: "FK_Invitation_User_InvitedPlayerId",
                        column: x => x.InvitedPlayerId,
                        principalTable: "User",
                        principalColumn: "Id",
						onDelete: ReferentialAction.NoAction);
					table.ForeignKey(
                        name: "FK_Invitation_User_MatchCaptainId",
                        column: x => x.MatchCaptainId,
                        principalTable: "User",
                        principalColumn: "Id",
					   onDelete: ReferentialAction.NoAction);
				});

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 19, 13, 36, 45, 343, DateTimeKind.Local).AddTicks(3419), new DateTime(2024, 1, 18, 15, 36, 45, 343, DateTimeKind.Local).AddTicks(3416), new DateTime(2024, 1, 18, 13, 36, 45, 343, DateTimeKind.Local).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 36, 45, 343, DateTimeKind.Local).AddTicks(3407), new DateTime(2024, 1, 17, 15, 36, 45, 343, DateTimeKind.Local).AddTicks(3404), new DateTime(2024, 1, 17, 13, 36, 45, 343, DateTimeKind.Local).AddTicks(3401) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 27, 1, 36, 45, 343, DateTimeKind.Local).AddTicks(3376), new DateTime(2024, 1, 16, 16, 36, 45, 343, DateTimeKind.Local).AddTicks(3373), new DateTime(2024, 1, 16, 13, 36, 45, 343, DateTimeKind.Local).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 19, 13, 36, 45, 343, DateTimeKind.Local).AddTicks(3365), new DateTime(2024, 1, 18, 15, 36, 45, 343, DateTimeKind.Local).AddTicks(3362), new DateTime(2024, 1, 18, 13, 36, 45, 343, DateTimeKind.Local).AddTicks(3359) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 36, 45, 343, DateTimeKind.Local).AddTicks(3353), new DateTime(2024, 1, 17, 15, 36, 45, 343, DateTimeKind.Local).AddTicks(3349) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 27, 1, 36, 45, 343, DateTimeKind.Local).AddTicks(3341), new DateTime(2024, 1, 16, 16, 36, 45, 343, DateTimeKind.Local).AddTicks(3337), new DateTime(2024, 1, 16, 13, 36, 45, 343, DateTimeKind.Local).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7a666dc4-d089-4087-94bf-f0a607cfb169", "239adad0-dc35-435f-9397-21c5ba479ad0" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5b60048b-1a46-47cf-ab92-c2f7785bf2f7", "5c2fdb12-4c4d-45e8-808f-49ba96125b24" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "94168d31-94d0-4df9-9d4c-5e36726fac8e", "3e6c61e8-4e13-4626-b8f8-413ce9306e9c" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d0228d4e-8e77-4e52-bf38-a915ec7eba5b", "1e8ac924-bb26-4254-b734-63f4d26fc491" });

            migrationBuilder.CreateIndex(
                name: "IX_Invitation_InvitedPlayerId",
                table: "Invitation",
                column: "InvitedPlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Invitation_MatchCaptainId",
                table: "Invitation",
                column: "MatchCaptainId");

            migrationBuilder.CreateIndex(
                name: "IX_Invitation_MatchId",
                table: "Invitation",
                column: "MatchId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invitation");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Match",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { "Sidon", new DateTime(2024, 1, 16, 22, 14, 43, 195, DateTimeKind.Local).AddTicks(71), new DateTime(2024, 1, 16, 0, 14, 43, 195, DateTimeKind.Local).AddTicks(66), new DateTime(2024, 1, 15, 22, 14, 43, 195, DateTimeKind.Local).AddTicks(60) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { "Jezzine", new DateTime(2024, 1, 20, 6, 14, 43, 195, DateTimeKind.Local).AddTicks(50), new DateTime(2024, 1, 15, 0, 14, 43, 195, DateTimeKind.Local).AddTicks(42), new DateTime(2024, 1, 14, 22, 14, 43, 195, DateTimeKind.Local).AddTicks(34) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { "Jezzine", new DateTime(2024, 1, 24, 10, 14, 43, 195, DateTimeKind.Local).AddTicks(22), new DateTime(2024, 1, 14, 1, 14, 43, 195, DateTimeKind.Local).AddTicks(16), new DateTime(2024, 1, 13, 22, 14, 43, 195, DateTimeKind.Local).AddTicks(9) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "City", "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { "Sidon", new DateTime(2024, 1, 16, 22, 14, 43, 195, DateTimeKind.Local), new DateTime(2024, 1, 16, 0, 14, 43, 194, DateTimeKind.Local).AddTicks(9995), new DateTime(2024, 1, 15, 22, 14, 43, 194, DateTimeKind.Local).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "City", "DeadlineRequestsDateTime", "EndDateTime" },
                values: new object[] { "Beirut", new DateTime(2024, 1, 20, 6, 14, 43, 194, DateTimeKind.Local).AddTicks(9980), new DateTime(2024, 1, 15, 0, 14, 43, 194, DateTimeKind.Local).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "City", "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { "Beirut", new DateTime(2024, 1, 24, 10, 14, 43, 194, DateTimeKind.Local).AddTicks(9962), new DateTime(2024, 1, 14, 1, 14, 43, 194, DateTimeKind.Local).AddTicks(9951), new DateTime(2024, 1, 13, 22, 14, 43, 194, DateTimeKind.Local).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "28f21ff6-07c3-4508-b614-4057baf26a3b", "730988a5-7d4a-4309-b0c5-9724c88595b2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a35e8226-daa5-4513-80d5-cb6d2ff965ae", "1cc8b6f7-f64f-4691-97b4-73f1e7584245" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "26f83c1c-76da-4efc-8a52-e2ff8f39c53f", "fce6fd09-3251-458b-a22c-f16335d2f615" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "84f7dfee-862c-4552-85ce-179c5832aa02", "ab62ec66-9923-4825-bca6-3b5874507240" });
        }
    }
}
