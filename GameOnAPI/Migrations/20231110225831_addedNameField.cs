using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOnAPI.Migrations
{
    /// <inheritdoc />
    public partial class addedNameField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "ConcurrencyStamp", "Name", "SecurityStamp" },
                values: new object[] { "90ed0c00-4cf2-42ae-8851-12930a8cb4f5", "Omar Shalabi", "240e0c4b-8eae-4314-b9c3-692768cc1718" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "Name", "SecurityStamp" },
                values: new object[] { "364102c0-5406-43b8-a736-bcc39a2df446", "Hussein Ali", "53c0cb5a-ab50-40cb-b0af-8d5a14e8d227" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "Name", "SecurityStamp" },
                values: new object[] { "f8c9ae19-e496-49f0-8c22-eb051df92067", "Samer Shalabi", "a4b86f86-4df2-41af-8553-0cdf0a1f4197" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "Name", "SecurityStamp" },
                values: new object[] { "2be68cbb-e306-4423-a1aa-988caf89fd45", "Ali Hussein", "74c6cdb8-9798-4132-b8c4-f439d5974314" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "User");

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 13, 21, 40, 20, 285, DateTimeKind.Local).AddTicks(6329), new DateTime(2023, 11, 12, 23, 40, 20, 285, DateTimeKind.Local).AddTicks(6323), new DateTime(2023, 11, 12, 21, 40, 20, 285, DateTimeKind.Local).AddTicks(6317) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 17, 5, 40, 20, 285, DateTimeKind.Local).AddTicks(6309), new DateTime(2023, 11, 11, 23, 40, 20, 285, DateTimeKind.Local).AddTicks(6302), new DateTime(2023, 11, 11, 21, 40, 20, 285, DateTimeKind.Local).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 21, 9, 40, 20, 285, DateTimeKind.Local).AddTicks(6280), new DateTime(2023, 11, 11, 0, 40, 20, 285, DateTimeKind.Local).AddTicks(6268), new DateTime(2023, 11, 10, 21, 40, 20, 285, DateTimeKind.Local).AddTicks(6175) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "10a39671-e58c-434d-891a-4440e56979db", "41bceada-3d06-4c56-8b00-bd2924d5437e" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b2c591fe-7fb8-495a-b83b-7fbe9e7cae93", "eb64821a-03d1-4be5-bc33-3046138517db" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b5faaf63-8f69-4d5c-a931-ae11f7695096", "5d200a28-69e7-47aa-8401-65f902b76f52" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cdec9d42-897d-49ce-a3a4-902800a98e1b", "7415a501-9128-497d-a197-6add3be68995" });
        }
    }
}
