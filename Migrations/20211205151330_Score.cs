using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_Razor.Migrations
{
    public partial class Score : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "score",
                table: "Publicacion",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "score",
                table: "Publicacion");
        }
    }
}
