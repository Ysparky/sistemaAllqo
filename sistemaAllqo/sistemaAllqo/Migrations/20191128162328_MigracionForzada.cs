using Microsoft.EntityFrameworkCore.Migrations;

namespace sistemaAllqo.Migrations
{
    public partial class MigracionForzada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SesionxMascota_Mascota_idMascota",
                table: "SesionxMascota");

            migrationBuilder.DropForeignKey(
                name: "FK_SesionxMascota_Sesion_idSesion",
                table: "SesionxMascota");

            migrationBuilder.AlterColumn<int>(
                name: "idSesion",
                table: "SesionxMascota",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "idMascota",
                table: "SesionxMascota",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "lugar",
                table: "Sesion",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SesionxMascota_Mascota_idMascota",
                table: "SesionxMascota",
                column: "idMascota",
                principalTable: "Mascota",
                principalColumn: "idMascota",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SesionxMascota_Sesion_idSesion",
                table: "SesionxMascota",
                column: "idSesion",
                principalTable: "Sesion",
                principalColumn: "idSesion",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SesionxMascota_Mascota_idMascota",
                table: "SesionxMascota");

            migrationBuilder.DropForeignKey(
                name: "FK_SesionxMascota_Sesion_idSesion",
                table: "SesionxMascota");

            migrationBuilder.AlterColumn<int>(
                name: "idSesion",
                table: "SesionxMascota",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "idMascota",
                table: "SesionxMascota",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "lugar",
                table: "Sesion",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SesionxMascota_Mascota_idMascota",
                table: "SesionxMascota",
                column: "idMascota",
                principalTable: "Mascota",
                principalColumn: "idMascota",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SesionxMascota_Sesion_idSesion",
                table: "SesionxMascota",
                column: "idSesion",
                principalTable: "Sesion",
                principalColumn: "idSesion",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
