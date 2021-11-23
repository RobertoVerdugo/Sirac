using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_Razor.Migrations
{
    public partial class direccionYactualizacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "direccion",
                table: "Usuario");

            migrationBuilder.AddColumn<DateTime>(
                name: "actualizacion",
                table: "Publicacion",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "actualizacion",
                table: "Publicacion");

            migrationBuilder.AddColumn<string>(
                name: "direccion",
                table: "Usuario",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);
        }
    }
}
