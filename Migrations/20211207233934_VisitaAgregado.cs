using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_Razor.Migrations
{
    public partial class VisitaAgregado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Visita",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rut = table.Column<string>(nullable: false),
                    idPublicacion = table.Column<int>(nullable: false),
                    ranking = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visita", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Visita");
        }
    }
}
