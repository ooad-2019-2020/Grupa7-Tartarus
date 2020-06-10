using Microsoft.EntityFrameworkCore.Migrations;

namespace Tartarus_final.Data.Migrations
{
    public partial class Cetvrta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RegistrationType",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegistrationType",
                table: "AspNetUsers");
        }
    }
}
