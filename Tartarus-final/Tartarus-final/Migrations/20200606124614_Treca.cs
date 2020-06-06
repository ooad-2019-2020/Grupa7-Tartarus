using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tartarus_final.Migrations
{
    public partial class Treca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cuvar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    DatumPrijave = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuvar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sektor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    NadlezniCuvarId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sektor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sektor_Cuvar_NadlezniCuvarId",
                        column: x => x.NadlezniCuvarId,
                        principalTable: "Cuvar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Zatvorenik",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    sektorId = table.Column<int>(nullable: true),
                    ZatvorskaKazna = table.Column<int>(nullable: false),
                    Evaluacija = table.Column<string>(nullable: true),
                    Jmbg = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zatvorenik", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zatvorenik_Sektor_sektorId",
                        column: x => x.sektorId,
                        principalTable: "Sektor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prekrsaj",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Zapisnik = table.Column<string>(nullable: true),
                    KaznenoDjelo = table.Column<string>(nullable: true),
                    DatumPrekrsaja = table.Column<DateTime>(nullable: false),
                    DatumPritvora = table.Column<DateTime>(nullable: false),
                    DatumSudskeOdluke = table.Column<DateTime>(nullable: false),
                    ZatvorenikId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prekrsaj", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prekrsaj_Zatvorenik_ZatvorenikId",
                        column: x => x.ZatvorenikId,
                        principalTable: "Zatvorenik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prekrsaj_ZatvorenikId",
                table: "Prekrsaj",
                column: "ZatvorenikId");

            migrationBuilder.CreateIndex(
                name: "IX_Sektor_NadlezniCuvarId",
                table: "Sektor",
                column: "NadlezniCuvarId");

            migrationBuilder.CreateIndex(
                name: "IX_Zatvorenik_sektorId",
                table: "Zatvorenik",
                column: "sektorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prekrsaj");

            migrationBuilder.DropTable(
                name: "Zatvorenik");

            migrationBuilder.DropTable(
                name: "Sektor");

            migrationBuilder.DropTable(
                name: "Cuvar");
        }
    }
}
