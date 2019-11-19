using Microsoft.EntityFrameworkCore.Migrations;

namespace Mudanza1711.Migrations
{
    public partial class Camion33 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kilomentraje",
                table: "Camion");

            migrationBuilder.DropColumn(
                name: "KilomentrajeUltimoServicio",
                table: "Camion");

            migrationBuilder.AddColumn<int>(
                name: "Kilometraje",
                table: "Camion",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KilometrajeUltimoServicio",
                table: "Camion",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kilometraje",
                table: "Camion");

            migrationBuilder.DropColumn(
                name: "KilometrajeUltimoServicio",
                table: "Camion");

            migrationBuilder.AddColumn<int>(
                name: "Kilomentraje",
                table: "Camion",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KilomentrajeUltimoServicio",
                table: "Camion",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
