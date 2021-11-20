using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_Razor.Migrations
{
    public partial class Publicacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "Publicacion",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulo = table.Column<string>(nullable: false),
                    fecha = table.Column<DateTime>(nullable: false),
                    nombre = table.Column<string>(nullable: false),
                    especie = table.Column<string>(nullable: false),
                    pelaje = table.Column<string>(nullable: false),
                    color = table.Column<string>(nullable: false),
                    raza = table.Column<string>(nullable: false),
                    tamano = table.Column<string>(nullable: false),
                    edad = table.Column<string>(nullable: false),
                    genero = table.Column<string>(nullable: false),
                    rutaimg = table.Column<string>(nullable: false),
                    estado = table.Column<string>(nullable: false),
                    ubicacion = table.Column<string>(nullable: false),
                    rut = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publicacion", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Publicacion");

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    rut = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.rut);
                });
        }
    }
}
