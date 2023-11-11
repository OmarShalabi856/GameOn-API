using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameOnAPI.Migrations
{
    /// <inheritdoc />
    public partial class updatedMatchParticipationEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TeamPlayedFor",
                table: "MatchParticipation",
                newName: "position");

            migrationBuilder.RenameColumn(
                name: "GoalsScored",
                table: "MatchParticipation",
                newName: "TeamPlayingFor");

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "MatchParticipation",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 16, 18, 51, 40, 823, DateTimeKind.Local).AddTicks(2698), new DateTime(2023, 11, 15, 20, 51, 40, 823, DateTimeKind.Local).AddTicks(2695), new DateTime(2023, 11, 15, 18, 51, 40, 823, DateTimeKind.Local).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 20, 2, 51, 40, 823, DateTimeKind.Local).AddTicks(2687), new DateTime(2023, 11, 14, 20, 51, 40, 823, DateTimeKind.Local).AddTicks(2684), new DateTime(2023, 11, 14, 18, 51, 40, 823, DateTimeKind.Local).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 24, 6, 51, 40, 823, DateTimeKind.Local).AddTicks(2673), new DateTime(2023, 11, 13, 21, 51, 40, 823, DateTimeKind.Local).AddTicks(2669), new DateTime(2023, 11, 13, 18, 51, 40, 823, DateTimeKind.Local).AddTicks(2621) });

            migrationBuilder.InsertData(
                table: "MatchParticipation",
                columns: new[] { "Id", "MatchId", "Rating", "TeamPlayingFor", "UserId", "position" },
                values: new object[,]
                {
                    { 1, 1, 0.0, 1, "3232onffenmessi8marvfwdewd83404", 5 },
                    { 2, 1, 0.0, 2, "32ewdewd83404", 0 }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "position" },
                values: new object[] { "1a17ccbf-91e8-46fb-8922-66d291ede647", "e1dea281-3863-4f1d-b801-a1269cb0ef11", 0 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "position" },
                values: new object[] { "9886bd2c-be7c-4daa-a195-4f79d4b7c939", "c55404d0-971e-4d95-85eb-b1de9e61ee76", 6 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "position" },
                values: new object[] { "c34ea45b-4280-47e9-84bb-08d1cfd011ae", "8bea7942-97e4-45a0-9ea9-cd992c72cf8d", 4 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "position" },
                values: new object[] { "1659768f-362b-4e88-9053-5cb84b96b3eb", "ec0cbbcd-c369-498f-bfe2-ebff0bbe6eff", 7 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MatchParticipation",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MatchParticipation",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "MatchParticipation");

            migrationBuilder.RenameColumn(
                name: "position",
                table: "MatchParticipation",
                newName: "TeamPlayedFor");

            migrationBuilder.RenameColumn(
                name: "TeamPlayingFor",
                table: "MatchParticipation",
                newName: "GoalsScored");

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 16, 0, 58, 30, 871, DateTimeKind.Local).AddTicks(8584), new DateTime(2023, 11, 15, 2, 58, 30, 871, DateTimeKind.Local).AddTicks(8581), new DateTime(2023, 11, 15, 0, 58, 30, 871, DateTimeKind.Local).AddTicks(8578) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 19, 8, 58, 30, 871, DateTimeKind.Local).AddTicks(8573), new DateTime(2023, 11, 14, 2, 58, 30, 871, DateTimeKind.Local).AddTicks(8570), new DateTime(2023, 11, 14, 0, 58, 30, 871, DateTimeKind.Local).AddTicks(8567) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 23, 12, 58, 30, 871, DateTimeKind.Local).AddTicks(8560), new DateTime(2023, 11, 13, 3, 58, 30, 871, DateTimeKind.Local).AddTicks(8557), new DateTime(2023, 11, 13, 0, 58, 30, 871, DateTimeKind.Local).AddTicks(8506) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "position" },
                values: new object[] { "90ed0c00-4cf2-42ae-8851-12930a8cb4f5", "240e0c4b-8eae-4314-b9c3-692768cc1718", 1 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "position" },
                values: new object[] { "364102c0-5406-43b8-a736-bcc39a2df446", "53c0cb5a-ab50-40cb-b0af-8d5a14e8d227", 1 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "position" },
                values: new object[] { "f8c9ae19-e496-49f0-8c22-eb051df92067", "a4b86f86-4df2-41af-8553-0cdf0a1f4197", 0 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "position" },
                values: new object[] { "2be68cbb-e306-4423-a1aa-988caf89fd45", "74c6cdb8-9798-4132-b8c4-f439d5974314", 2 });
        }
    }
}
