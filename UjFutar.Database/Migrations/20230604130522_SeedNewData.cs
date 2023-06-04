using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UjFutar.Database.Migrations
{
    /// <inheritdoc />
    public partial class SeedNewData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CsomagAdatok",
                columns: new[] { "CsomagId", "AktualisPozicio", "Allapot", "JarmuRendszam" },
                values: new object[,]
                {
                    { 1, "Teszt utca 1", 0, "" },
                    { 2, "Teszt utca 2", 0, "" },
                    { 3, "Teszt utca 3", 0, "" }
                });

            migrationBuilder.InsertData(
                table: "Szemely",
                columns: new[] { "Id", "Cim", "Email", "Nev", "SzallitasiAdatokCsomagAdatokId" },
                values: new object[,]
                {
                    { 1, "Teszt utca 1", "teszt1@teszt.hu", "Teszt Elek1", null },
                    { 2, "Teszt utca 2", "teszt2@teszt.hu", "Teszt Elek2", null },
                    { 3, "Teszt utca 3", "teszt3@teszt.hu", "Teszt Elek3", null }
                });

            migrationBuilder.InsertData(
                table: "SzallitasiAdatok",
                columns: new[] { "CsomagAdatokId", "CimzettId", "FeladoId", "Id" },
                values: new object[,]
                {
                    { 1, 2, 1, 0 },
                    { 2, 1, 3, 0 },
                    { 3, 3, 2, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SzallitasiAdatok",
                keyColumn: "CsomagAdatokId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SzallitasiAdatok",
                keyColumn: "CsomagAdatokId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SzallitasiAdatok",
                keyColumn: "CsomagAdatokId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CsomagAdatok",
                keyColumn: "CsomagId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CsomagAdatok",
                keyColumn: "CsomagId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CsomagAdatok",
                keyColumn: "CsomagId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Szemely",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Szemely",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Szemely",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
