using Microsoft.EntityFrameworkCore.Migrations;

namespace Tartarus_final.Migrations
{
    public partial class druga : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PorukaId",
                table: "Poruke",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ObavijestId",
                table: "Obavijesti",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Poruke_PorukaId",
                table: "Poruke",
                column: "PorukaId");

            migrationBuilder.CreateIndex(
                name: "IX_Obavijesti_ObavijestId",
                table: "Obavijesti",
                column: "ObavijestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Obavijesti_Obavijesti_ObavijestId",
                table: "Obavijesti",
                column: "ObavijestId",
                principalTable: "Obavijesti",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Poruke_Poruke_PorukaId",
                table: "Poruke",
                column: "PorukaId",
                principalTable: "Poruke",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Obavijesti_Obavijesti_ObavijestId",
                table: "Obavijesti");

            migrationBuilder.DropForeignKey(
                name: "FK_Poruke_Poruke_PorukaId",
                table: "Poruke");

            migrationBuilder.DropIndex(
                name: "IX_Poruke_PorukaId",
                table: "Poruke");

            migrationBuilder.DropIndex(
                name: "IX_Obavijesti_ObavijestId",
                table: "Obavijesti");

            migrationBuilder.DropColumn(
                name: "PorukaId",
                table: "Poruke");

            migrationBuilder.DropColumn(
                name: "ObavijestId",
                table: "Obavijesti");
        }
    }
}
