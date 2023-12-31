using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOnAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateMatches2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 6, 1, 36, 9, 668, DateTimeKind.Local).AddTicks(5002), new DateTime(2024, 1, 5, 3, 36, 9, 668, DateTimeKind.Local).AddTicks(4999), new DateTime(2024, 1, 5, 1, 36, 9, 668, DateTimeKind.Local).AddTicks(4996) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 9, 9, 36, 9, 668, DateTimeKind.Local).AddTicks(4991), new DateTime(2024, 1, 4, 3, 36, 9, 668, DateTimeKind.Local).AddTicks(4987), new DateTime(2024, 1, 4, 1, 36, 9, 668, DateTimeKind.Local).AddTicks(4984) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 1, 13, 13, 36, 9, 668, DateTimeKind.Local).AddTicks(4976), new DateTime(2024, 1, 3, 4, 36, 9, 668, DateTimeKind.Local).AddTicks(4972), new DateTime(2024, 1, 3, 1, 36, 9, 668, DateTimeKind.Local).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4ffeeaa9-4009-46b7-be48-b4ead4079547", "b7fce1b9-add3-4255-ad98-53dedbb7ccf4" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5f7027dc-7b5c-48b6-be80-02131e97e789", "07b6d91c-6eee-4993-a7fb-beca875712e7" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4ae4de75-4606-4652-a279-2c546e046662", "2bae8646-9c46-4317-9b39-091800c547cd" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0ee0bcc6-4823-4025-b53c-eb1130b75650", "55311ef0-28b4-4c7b-b61a-52cbfb087228" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
