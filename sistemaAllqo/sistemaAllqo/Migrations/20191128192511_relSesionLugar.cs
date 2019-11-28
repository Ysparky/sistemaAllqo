using Microsoft.EntityFrameworkCore.Migrations;

namespace sistemaAllqo.Migrations
{
    public partial class relSesionLugar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tipoMascota",
                table: "Sesion",
                newName: "idTipo");

            migrationBuilder.CreateIndex(
                name: "IX_Sesion_idTipo",
                table: "Sesion",
                column: "idTipo");

            migrationBuilder.AddForeignKey(
                name: "FK_Sesion_TipoPerro_idTipo",
                table: "Sesion",
                column: "idTipo",
                principalTable: "TipoPerro",
                principalColumn: "idTipo",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sesion_TipoPerro_idTipo",
                table: "Sesion");

            migrationBuilder.DropIndex(
                name: "IX_Sesion_idTipo",
                table: "Sesion");

            migrationBuilder.RenameColumn(
                name: "idTipo",
                table: "Sesion",
                newName: "tipoMascota");
        }
    }
}
