using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_Razor.Migrations
{
    public partial class PreferenciaFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Retiever",
                table: "Preferencia");

            migrationBuilder.AddColumn<int>(
                name: "Labrador_Retriever",
                table: "Preferencia",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Labrador_Retriever",
                table: "Preferencia");

            migrationBuilder.AddColumn<int>(
                name: "Retiever",
                table: "Preferencia",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
