using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sistemaAllqo.Migrations
{
    public partial class focusSesion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mascota_Raza_idRaza",
                table: "Mascota");

            migrationBuilder.AlterColumn<int>(
                name: "numMascotas",
                table: "Sesion",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaSesion",
                table: "Sesion",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "lugar",
                table: "Sesion",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tipoMascota",
                table: "Sesion",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "idRaza",
                table: "Mascota",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Mascota_Raza_idRaza",
                table: "Mascota",
                column: "idRaza",
                principalTable: "Raza",
                principalColumn: "idRaza",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mascota_Raza_idRaza",
                table: "Mascota");

            migrationBuilder.DropColumn(
                name: "fechaSesion",
                table: "Sesion");

            migrationBuilder.DropColumn(
                name: "lugar",
                table: "Sesion");

            migrationBuilder.DropColumn(
                name: "tipoMascota",
                table: "Sesion");

            migrationBuilder.AlterColumn<int>(
                name: "numMascotas",
                table: "Sesion",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "idRaza",
                table: "Mascota",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Mascota_Raza_idRaza",
                table: "Mascota",
                column: "idRaza",
                principalTable: "Raza",
                principalColumn: "idRaza",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
