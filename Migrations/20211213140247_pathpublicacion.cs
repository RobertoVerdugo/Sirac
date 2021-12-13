using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_Razor.Migrations
{
    public partial class pathpublicacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "filepath",
                table: "Publicacion",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "filepath",
                table: "Publicacion");
        }
    }
}
