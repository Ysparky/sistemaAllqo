using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sistemaAllqo.Migrations
{
    public partial class Integrado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trabajador_Especialidad_idEspecialidad",
                table: "Trabajador");

            migrationBuilder.DropTable(
                name: "Especialidad");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Trabajador_idEspecialidad",
                table: "Trabajador");

            migrationBuilder.DropColumn(
                name: "idEspecialidad",
                table: "Trabajador");

            migrationBuilder.AlterColumn<int>(
                name: "numCel",
                table: "Trabajador",
                nullable: false,
                oldClrType: typeof(long));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "numCel",
                table: "Trabajador",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "idEspecialidad",
                table: "Trabajador",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Especialidad",
                columns: table => new
                {
                    idEspecialidad = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidad", x => x.idEspecialidad);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    idUsuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    password = table.Column<string>(nullable: true),
                    usuario = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.idUsuario);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trabajador_idEspecialidad",
                table: "Trabajador",
                column: "idEspecialidad");

            migrationBuilder.AddForeignKey(
                name: "FK_Trabajador_Especialidad_idEspecialidad",
                table: "Trabajador",
                column: "idEspecialidad",
                principalTable: "Especialidad",
                principalColumn: "idEspecialidad",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
