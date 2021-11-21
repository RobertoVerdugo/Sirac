using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_Razor.Migrations
{
    public partial class Publicacion3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "titulo",
                table: "Publicacion");

            migrationBuilder.AlterColumn<string>(
                name: "ubicacion",
                table: "Publicacion",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Publicacion",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "descripcion",
                table: "Publicacion",
                maxLength: 500,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "descripcion",
                table: "Publicacion");

            migrationBuilder.AlterColumn<string>(
                name: "ubicacion",
                table: "Publicacion",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Publicacion",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AddColumn<string>(
                name: "titulo",
                table: "Publicacion",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
