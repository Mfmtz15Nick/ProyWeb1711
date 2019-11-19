using Microsoft.EntityFrameworkCore.Migrations;

namespace Mudanza1711.Migrations
{
    public partial class Camion55 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sede",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Alias = table.Column<string>(nullable: true),
                    Ciudad = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    Latitud = table.Column<string>(nullable: true),
                    Longitud = table.Column<string>(nullable: true),
                    TipoSede = table.Column<int>(nullable: false),
                    IdAministrador = table.Column<int>(nullable: false),
                    Pertenece = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sede", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sede");
        }
    }
}
