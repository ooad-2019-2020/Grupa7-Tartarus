using Microsoft.EntityFrameworkCore.Migrations;

namespace Tartarus_final.Migrations
{
    public partial class prva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Obavijesti",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tekst = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obavijesti", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Poruke",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tekst = table.Column<string>(nullable: true),
                    PrimalacEmail = table.Column<string>(nullable: true),
                    posiljalacEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poruke", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Obavijesti");

            migrationBuilder.DropTable(
                name: "Poruke");
        }
    }
}
