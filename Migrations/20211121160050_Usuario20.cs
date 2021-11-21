using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_Razor.Migrations
{
    public partial class Usuario20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    rut = table.Column<string>(maxLength: 12, nullable: false),
                    nombre = table.Column<string>(maxLength: 16, nullable: false),
                    apellidos = table.Column<string>(maxLength: 25, nullable: false),
                    fecha = table.Column<DateTime>(nullable: false),
                    email = table.Column<string>(maxLength: 30, nullable: false),
                    direccion = table.Column<string>(maxLength: 60, nullable: true),
                    telefono = table.Column<string>(maxLength: 11, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.rut);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
