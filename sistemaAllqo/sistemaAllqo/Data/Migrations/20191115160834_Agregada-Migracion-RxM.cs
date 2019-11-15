using Microsoft.EntityFrameworkCore.Migrations;

namespace sistemaAllqo.Data.Migrations
{
    public partial class AgregadaMigracionRxM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "numCel",
                table: "Trabajador",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "precio",
                table: "Servicio",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<string>(
                name: "edad",
                table: "Mascota",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "agregado",
                table: "Lugar",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<long>(
                name: "numCelular",
                table: "Cliente",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.CreateTable(
                name: "ReservaxMascota",
                columns: table => new
                {
                    idReserva = table.Column<int>(nullable: false),
                    Reserva_ID = table.Column<int>(nullable: true),
                    idMascota = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservaxMascota", x => new { x.idReserva, x.idMascota });
                    table.ForeignKey(
                        name: "FK_ReservaxMascota_Reserva_Reserva_ID",
                        column: x => x.Reserva_ID,
                        principalTable: "Reserva",
                        principalColumn: "Reserva_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReservaxMascota_Mascota_idMascota",
                        column: x => x.idMascota,
                        principalTable: "Mascota",
                        principalColumn: "idMascota",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReservaxMascota_Reserva_ID",
                table: "ReservaxMascota",
                column: "Reserva_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ReservaxMascota_idMascota",
                table: "ReservaxMascota",
                column: "idMascota");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReservaxMascota");

            migrationBuilder.AlterColumn<int>(
                name: "numCel",
                table: "Trabajador",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<float>(
                name: "precio",
                table: "Servicio",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "edad",
                table: "Mascota",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "agregado",
                table: "Lugar",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "numCelular",
                table: "Cliente",
                nullable: false,
                oldClrType: typeof(long));
        }
    }
}
