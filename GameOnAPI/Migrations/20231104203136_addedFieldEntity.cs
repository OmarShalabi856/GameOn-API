using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameOnAPI.Migrations
{
    /// <inheritdoc />
    public partial class addedFieldEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FieldName",
                table: "Match");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Match");

            migrationBuilder.AddColumn<int>(
                name: "FieldId",
                table: "Match",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Field",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FieldName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FieldImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Field", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Field",
                columns: new[] { "Id", "FieldImage", "FieldName", "Location" },
                values: new object[,]
                {
                    { 1, "https://assets.rappler.com/6677C2B68AF94FD1BD758C065AC43A07/img/43648E3295544C6A8EF16B42BDF2F6D6/6.jpg", "AllSports", "Bchamoun" },
                    { 2, "https://th.bing.com/th/id/R.59f002d1a5d3dae68612a521fb245ffe?rik=2Z9vdMR9H5Ni9g&riu=http%3a%2f%2fwww.artificialturf-grass.com%2fphoto%2fpl11353642-durable_false_turf_playground_soccer_synthetic_grass_environment_friendly.jpg&ehk=z4WhEwLG8xnj49JE3nraLCVHEmerkxdcLha7MK9qDjY%3d&risl=&pid=ImgRaw&r=0", "GreenField", "Aley" },
                    { 3, "https://th.bing.com/th/id/OIP.WNQW57IvkqWmB7lcL08MMgHaE7?pid=ImgDet&w=207&h=138&c=7", "KasKas", "Beirut" }
                });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "FieldId", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 5, 18, 31, 35, 629, DateTimeKind.Local).AddTicks(7622), new DateTime(2023, 11, 9, 0, 31, 35, 629, DateTimeKind.Local).AddTicks(7619), 1, new DateTime(2023, 11, 8, 22, 31, 35, 629, DateTimeKind.Local).AddTicks(7617) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "FieldId", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 5, 20, 31, 35, 629, DateTimeKind.Local).AddTicks(7612), new DateTime(2023, 11, 8, 0, 31, 35, 629, DateTimeKind.Local).AddTicks(7608), 2, new DateTime(2023, 11, 7, 22, 31, 35, 629, DateTimeKind.Local).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "FieldId", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 5, 22, 31, 35, 629, DateTimeKind.Local).AddTicks(7597), new DateTime(2023, 11, 7, 1, 31, 35, 629, DateTimeKind.Local).AddTicks(7593), 3, new DateTime(2023, 11, 6, 22, 31, 35, 629, DateTimeKind.Local).AddTicks(7541) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cc59c205-8ede-4aea-b13f-2fe8ec1114f3", "2456cf31-ea08-43c3-a26c-a250634edba7" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "13f9fc2d-bada-4452-aa6b-3fee32bd56eb", "9c7d23c7-abea-40f6-a853-7d54b4691843" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6f3da92a-89fd-49d7-80e4-caf7f1e74013", "3e7def01-442f-47f1-95a5-a416bd4e4a0d" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1cee34c2-151b-4404-9ccc-18b42b925cd8", "10fe0e70-71f6-420e-b939-eba9ffa474f1" });

            migrationBuilder.CreateIndex(
                name: "IX_Match_FieldId",
                table: "Match",
                column: "FieldId");

            migrationBuilder.AddForeignKey(
                name: "FK_Match_Field_FieldId",
                table: "Match",
                column: "FieldId",
                principalTable: "Field",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Match_Field_FieldId",
                table: "Match");

            migrationBuilder.DropTable(
                name: "Field");

            migrationBuilder.DropIndex(
                name: "IX_Match_FieldId",
                table: "Match");

            migrationBuilder.DropColumn(
                name: "FieldId",
                table: "Match");

            migrationBuilder.AddColumn<string>(
                name: "FieldName",
                table: "Match",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Match",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "FieldName", "Location", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 5, 15, 40, 33, 423, DateTimeKind.Local).AddTicks(4096), new DateTime(2023, 11, 8, 21, 40, 33, 423, DateTimeKind.Local).AddTicks(4093), "Field 4", "Sample Location 4", new DateTime(2023, 11, 8, 19, 40, 33, 423, DateTimeKind.Local).AddTicks(4089) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "FieldName", "Location", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 5, 17, 40, 33, 423, DateTimeKind.Local).AddTicks(4084), new DateTime(2023, 11, 7, 21, 40, 33, 423, DateTimeKind.Local).AddTicks(4081), "Field 3", "Sample Location 3", new DateTime(2023, 11, 7, 19, 40, 33, 423, DateTimeKind.Local).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "Match",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeadlineRequestsDateTime", "EndDateTime", "FieldName", "Location", "StartDateTime" },
                values: new object[] { new DateTime(2023, 11, 5, 19, 40, 33, 423, DateTimeKind.Local).AddTicks(4070), new DateTime(2023, 11, 6, 22, 40, 33, 423, DateTimeKind.Local).AddTicks(4064), "Field 2", "Sample Location 2", new DateTime(2023, 11, 6, 19, 40, 33, 423, DateTimeKind.Local).AddTicks(4008) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32322432nvfvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5ab3769f-373c-4642-ada2-bfc19bb436af", "d522cd36-f030-40f1-9846-bbef5fa7439f" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3232onffenmessi8marvfwdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0138c9a7-01ff-49fd-9b54-7041c15e5caa", "90d27fb7-9dda-43a4-b3f0-bd26a54a3210" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "324u3943583404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a962336d-70be-4494-9d53-ea3ecd9b9259", "71386c20-0fb4-4a1e-8e9a-ea95e0582ae5" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "32ewdewd83404",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1bd63788-2c6e-4325-9779-20d629b47d5b", "e333bcf8-212c-40a6-990d-fc99cc7b99c6" });
        }
    }
}
