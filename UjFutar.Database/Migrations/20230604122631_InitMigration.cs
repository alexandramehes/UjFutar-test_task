using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UjFutar.Database.Migrations
{
    /// <inheritdoc />
    public partial class InitMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CsomagAdatok",
                columns: table => new
                {
                    CsomagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Allapot = table.Column<int>(type: "int", nullable: false),
                    AktualisPozicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JarmuRendszam = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CsomagAdatok", x => x.CsomagId);
                });

            migrationBuilder.CreateTable(
                name: "SzallitasiAdatok",
                columns: table => new
                {
                    CsomagAdatokId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    FeladoId = table.Column<int>(type: "int", nullable: false),
                    CimzettId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SzallitasiAdatok", x => x.CsomagAdatokId);
                    table.ForeignKey(
                        name: "FK_SzallitasiAdatok_CsomagAdatok_CsomagAdatokId",
                        column: x => x.CsomagAdatokId,
                        principalTable: "CsomagAdatok",
                        principalColumn: "CsomagId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Szemely",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SzallitasiAdatokCsomagAdatokId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Szemely", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Szemely_SzallitasiAdatok_SzallitasiAdatokCsomagAdatokId",
                        column: x => x.SzallitasiAdatokCsomagAdatokId,
                        principalTable: "SzallitasiAdatok",
                        principalColumn: "CsomagAdatokId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SzallitasiAdatok_CimzettId",
                table: "SzallitasiAdatok",
                column: "CimzettId");

            migrationBuilder.CreateIndex(
                name: "IX_SzallitasiAdatok_FeladoId",
                table: "SzallitasiAdatok",
                column: "FeladoId");

            migrationBuilder.CreateIndex(
                name: "IX_Szemely_SzallitasiAdatokCsomagAdatokId",
                table: "Szemely",
                column: "SzallitasiAdatokCsomagAdatokId");

            migrationBuilder.AddForeignKey(
                name: "FK_SzallitasiAdatok_Szemely_CimzettId",
                table: "SzallitasiAdatok",
                column: "CimzettId",
                principalTable: "Szemely",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SzallitasiAdatok_Szemely_FeladoId",
                table: "SzallitasiAdatok",
                column: "FeladoId",
                principalTable: "Szemely",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SzallitasiAdatok_CsomagAdatok_CsomagAdatokId",
                table: "SzallitasiAdatok");

            migrationBuilder.DropForeignKey(
                name: "FK_SzallitasiAdatok_Szemely_CimzettId",
                table: "SzallitasiAdatok");

            migrationBuilder.DropForeignKey(
                name: "FK_SzallitasiAdatok_Szemely_FeladoId",
                table: "SzallitasiAdatok");

            migrationBuilder.DropTable(
                name: "CsomagAdatok");

            migrationBuilder.DropTable(
                name: "Szemely");

            migrationBuilder.DropTable(
                name: "SzallitasiAdatok");
        }
    }
}
