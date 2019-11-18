using Microsoft.EntityFrameworkCore.Migrations;

namespace Mudanza1711.Migrations
{
    public partial class Camiones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Camiones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoCamion = table.Column<string>(nullable: true),
                    TipoCombustible = table.Column<string>(nullable: true),
                    Placas = table.Column<string>(nullable: true),
                    CapacidadPeso = table.Column<string>(nullable: true),
                    Volumen = table.Column<string>(nullable: true),
                    Kilomentraje = table.Column<string>(nullable: true),
                    KilomentrajeUltimoServicio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Camiones", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Camiones");
        }
    }
}
