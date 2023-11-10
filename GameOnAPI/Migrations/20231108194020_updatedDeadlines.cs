using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOnAPI.Migrations
{
    /// <inheritdoc />
    public partial class updatedDeadlines : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 8, 10, 4, 1, 882, DateTimeKind.Local).AddTicks(1131), new DateTime(2023, 11, 10, 22, 4, 1, 882, DateTimeKind.Local).AddTicks(1125), new DateTime(2023, 11, 10, 20, 4, 1, 882, DateTimeKind.Local).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 8, 10, 4, 1, 882, DateTimeKind.Local).AddTicks(1113), new DateTime(2023, 11, 9, 22, 4, 1, 882, DateTimeKind.Local).AddTicks(1108), new DateTime(2023, 11, 9, 20, 4, 1, 882, DateTimeKind.Local).AddTicks(1103) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 8, 12, 4, 1, 882, DateTimeKind.Local).AddTicks(1093), new DateTime(2023, 11, 8, 23, 4, 1, 882, DateTimeKind.Local).AddTicks(1084), new DateTime(2023, 11, 8, 20, 4, 1, 882, DateTimeKind.Local).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "53a387e5-1775-4187-a746-d3c714ab1100", "d4ee5d4f-d74e-4ac9-9c1d-f920d713aef2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b77b4396-5828-451b-9b58-197fca7d7e61", "484e79fc-fe3a-44b0-9fc2-eac14d17174e" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a910a7f5-c30f-4a28-8b5e-c117a1080306", "70fd57f0-a640-429a-8f38-78aa4fbc46d2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1aaafa5e-0f14-40e0-b39a-96599fb03100", "b4d432ee-b3f3-4771-9d00-0f9220339188" });
        }
    }
}
