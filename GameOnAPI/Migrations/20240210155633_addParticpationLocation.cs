using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOnAPI.Migrations
{
    /// <inheritdoc />
    public partial class addParticpationLocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "xPosition",
                table: "MatchParticipation",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "yPosition",
                table: "MatchParticipation",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 2, 15, 17, 56, 33, 42, DateTimeKind.Local).AddTicks(8431), new DateTime(2024, 2, 14, 19, 56, 33, 42, DateTimeKind.Local).AddTicks(8428), new DateTime(2024, 2, 14, 17, 56, 33, 42, DateTimeKind.Local).AddTicks(8425) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 2, 19, 1, 56, 33, 42, DateTimeKind.Local).AddTicks(8420), new DateTime(2024, 2, 13, 19, 56, 33, 42, DateTimeKind.Local).AddTicks(8417), new DateTime(2024, 2, 13, 17, 56, 33, 42, DateTimeKind.Local).AddTicks(8414) });

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
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 2, 15, 17, 56, 33, 42, DateTimeKind.Local).AddTicks(8397), new DateTime(2024, 2, 14, 19, 56, 33, 42, DateTimeKind.Local).AddTicks(8394), new DateTime(2024, 2, 14, 17, 56, 33, 42, DateTimeKind.Local).AddTicks(8391) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime" },
                values: new object[] { new DateTime(2024, 2, 19, 1, 56, 33, 42, DateTimeKind.Local).AddTicks(8385), new DateTime(2024, 2, 13, 19, 56, 33, 42, DateTimeKind.Local).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 2, 23, 5, 56, 33, 42, DateTimeKind.Local).AddTicks(8374), new DateTime(2024, 2, 12, 20, 56, 33, 42, DateTimeKind.Local).AddTicks(8370), new DateTime(2024, 2, 12, 17, 56, 33, 42, DateTimeKind.Local).AddTicks(8318) });

            migrationBuilder.UpdateData(
                table: "MatchParticipation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "xPosition", "yPosition" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "MatchParticipation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "xPosition", "yPosition" },
                values: new object[] { 0.0, 0.0 });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "xPosition",
                table: "MatchParticipation");

            migrationBuilder.DropColumn(
                name: "yPosition",
                table: "MatchParticipation");

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
    }
}
