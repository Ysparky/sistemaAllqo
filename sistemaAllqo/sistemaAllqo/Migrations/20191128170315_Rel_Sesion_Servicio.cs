using Microsoft.EntityFrameworkCore.Migrations;

namespace sistemaAllqo.Migrations
{
    public partial class Rel_Sesion_Servicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idServicio",
                table: "Sesion",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sesion_idServicio",
                table: "Sesion",
                column: "idServicio");

            migrationBuilder.AddForeignKey(
                name: "FK_Sesion_Servicio_idServicio",
                table: "Sesion",
                column: "idServicio",
                principalTable: "Servicio",
                principalColumn: "idServicio",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sesion_Servicio_idServicio",
                table: "Sesion");

            migrationBuilder.DropIndex(
                name: "IX_Sesion_idServicio",
                table: "Sesion");

            migrationBuilder.DropColumn(
                name: "idServicio",
                table: "Sesion");
        }
    }
}
