using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOnAPI.Migrations
{
    /// <inheritdoc />
    public partial class addMatches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 6, 1, 28, 45, 89, DateTimeKind.Local).AddTicks(4449), new DateTime(2024, 1, 5, 3, 28, 45, 89, DateTimeKind.Local).AddTicks(4446), new DateTime(2024, 1, 5, 1, 28, 45, 89, DateTimeKind.Local).AddTicks(4442) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 9, 9, 28, 45, 89, DateTimeKind.Local).AddTicks(4437), new DateTime(2024, 1, 4, 3, 28, 45, 89, DateTimeKind.Local).AddTicks(4434), new DateTime(2024, 1, 4, 1, 28, 45, 89, DateTimeKind.Local).AddTicks(4430) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 13, 13, 28, 45, 89, DateTimeKind.Local).AddTicks(4419), new DateTime(2024, 1, 3, 4, 28, 45, 89, DateTimeKind.Local).AddTicks(4413), new DateTime(2024, 1, 3, 1, 28, 45, 89, DateTimeKind.Local).AddTicks(4356) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8461ae28-d65b-41d2-a031-b57179f9a600", "ceaea197-9a22-4967-bf03-fdfb1470494e" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f419943c-ef64-4728-adf5-6be14c77f8ab", "bed6a34b-0671-42bb-8fdb-8be21fc99723" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "62edbe63-eed6-4b5a-bccd-1a2956d23480", "5ebca50b-64a3-4871-be68-886a75447fa7" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5b2c438c-6ef7-4408-ae77-50355b1fa343", "c74f5ba9-a357-41ee-9921-522bc51acaa1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 6, 1, 11, 28, 38, DateTimeKind.Local).AddTicks(6090), new DateTime(2024, 1, 5, 3, 11, 28, 38, DateTimeKind.Local).AddTicks(6087), new DateTime(2024, 1, 5, 1, 11, 28, 38, DateTimeKind.Local).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 9, 9, 11, 28, 38, DateTimeKind.Local).AddTicks(6079), new DateTime(2024, 1, 4, 3, 11, 28, 38, DateTimeKind.Local).AddTicks(6075), new DateTime(2024, 1, 4, 1, 11, 28, 38, DateTimeKind.Local).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 13, 13, 11, 28, 38, DateTimeKind.Local).AddTicks(6063), new DateTime(2024, 1, 3, 4, 11, 28, 38, DateTimeKind.Local).AddTicks(6057), new DateTime(2024, 1, 3, 1, 11, 28, 38, DateTimeKind.Local).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "22d2dd90-3203-4a09-be8a-baff0ce50cc1", "bbcd1958-338b-4e4e-89d0-7efd2d653dd3" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "67ab15f4-a724-463c-a8ff-a88305333d82", "54254de6-66b4-4f4c-8158-4e8dde647f54" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fb528b21-2800-4dfe-b34a-5629e4aa81a5", "668bdfa5-68cd-4d91-bdfa-c95b51053ba4" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "706f86fe-b166-41c7-b7b2-ecd3614c1418", "05cf1f71-a7c9-4dfa-a851-cc99c3b7c16e" });
        }
    }
}
