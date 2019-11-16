using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sistemaAllqo.Migrations
{
    public partial class Tablas_Allqo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Lugar",
                columns: table => new
                {
                    idLugar = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: true),
                    agregado = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lugar", x => x.idLugar);
                });

            migrationBuilder.CreateTable(
                name: "Servicio",
                columns: table => new
                {
                    idServicio = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    categoria = table.Column<string>(nullable: true),
                    descripcion = table.Column<string>(nullable: true),
                    precio = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicio", x => x.idServicio);
                });

            migrationBuilder.CreateTable(
                name: "Sesion",
                columns: table => new
                {
                    idSesion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    numMascotas = table.Column<int>(nullable: false),
                    estado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sesion", x => x.idSesion);
                });

            migrationBuilder.CreateTable(
                name: "TipoPerro",
                columns: table => new
                {
                    idTipo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: true),
                    agregado = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPerro", x => x.idTipo);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    idUsuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    usuario = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.idUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Trabajador",
                columns: table => new
                {
                    idTrabajador = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombres = table.Column<string>(nullable: true),
                    apellidos = table.Column<string>(nullable: true),
                    dni = table.Column<int>(nullable: false),
                    numCel = table.Column<long>(nullable: false),
                    direccion = table.Column<string>(nullable: true),
                    idEspecialidad = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trabajador", x => x.idTrabajador);
                    table.ForeignKey(
                        name: "FK_Trabajador_Especialidad_idEspecialidad",
                        column: x => x.idEspecialidad,
                        principalTable: "Especialidad",
                        principalColumn: "idEspecialidad",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    idCliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombres = table.Column<string>(nullable: true),
                    apellidos = table.Column<string>(nullable: true),
                    direccion = table.Column<string>(nullable: true),
                    dni = table.Column<int>(nullable: false),
                    correo = table.Column<string>(nullable: true),
                    numCelular = table.Column<long>(nullable: false),
                    estado = table.Column<string>(nullable: true),
                    idLugar = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.idCliente);
                    table.ForeignKey(
                        name: "FK_Cliente_Lugar_idLugar",
                        column: x => x.idLugar,
                        principalTable: "Lugar",
                        principalColumn: "idLugar",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Raza",
                columns: table => new
                {
                    idRaza = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: true),
                    idTipo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Raza", x => x.idRaza);
                    table.ForeignKey(
                        name: "FK_Raza_TipoPerro_idTipo",
                        column: x => x.idTipo,
                        principalTable: "TipoPerro",
                        principalColumn: "idTipo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mascota",
                columns: table => new
                {
                    idMascota = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: true),
                    edad = table.Column<string>(nullable: true),
                    idCliente = table.Column<int>(nullable: false),
                    idRaza = table.Column<int>(nullable: false),
                    idSesion = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mascota", x => x.idMascota);
                    table.ForeignKey(
                        name: "FK_Mascota_Cliente_idCliente",
                        column: x => x.idCliente,
                        principalTable: "Cliente",
                        principalColumn: "idCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mascota_Raza_idRaza",
                        column: x => x.idRaza,
                        principalTable: "Raza",
                        principalColumn: "idRaza",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mascota_Sesion_idSesion",
                        column: x => x.idSesion,
                        principalTable: "Sesion",
                        principalColumn: "idSesion",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reserva",
                columns: table => new
                {
                    idReserva = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fechaReservada = table.Column<DateTime>(nullable: false),
                    fechaSesion = table.Column<DateTime>(nullable: false),
                    estado = table.Column<string>(nullable: true),
                    idCliente = table.Column<int>(nullable: false),
                    idServicio = table.Column<int>(nullable: false),
                    idTrabajador = table.Column<int>(nullable: false),
                    idSesion = table.Column<int>(nullable: true),
                    MascotaidMascota = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserva", x => x.idReserva);
                    table.ForeignKey(
                        name: "FK_Reserva_Mascota_MascotaidMascota",
                        column: x => x.MascotaidMascota,
                        principalTable: "Mascota",
                        principalColumn: "idMascota",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reserva_Cliente_idCliente",
                        column: x => x.idCliente,
                        principalTable: "Cliente",
                        principalColumn: "idCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reserva_Servicio_idServicio",
                        column: x => x.idServicio,
                        principalTable: "Servicio",
                        principalColumn: "idServicio",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reserva_Sesion_idSesion",
                        column: x => x.idSesion,
                        principalTable: "Sesion",
                        principalColumn: "idSesion",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reserva_Trabajador_idTrabajador",
                        column: x => x.idTrabajador,
                        principalTable: "Trabajador",
                        principalColumn: "idTrabajador",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComprobantePago",
                columns: table => new
                {
                    numComprobante = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fecha = table.Column<DateTime>(nullable: false),
                    comentario = table.Column<string>(nullable: true),
                    estadoPago = table.Column<string>(nullable: true),
                    numDetalle = table.Column<int>(nullable: false),
                    idCliente = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComprobantePago", x => x.numComprobante);
                    table.ForeignKey(
                        name: "FK_ComprobantePago_Cliente_idCliente",
                        column: x => x.idCliente,
                        principalTable: "Cliente",
                        principalColumn: "idCliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetalleComprobante",
                columns: table => new
                {
                    numDetalle = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cantidad = table.Column<int>(nullable: false),
                    precioUnit = table.Column<float>(nullable: false),
                    subtotal = table.Column<float>(nullable: false),
                    total = table.Column<float>(nullable: false),
                    importe = table.Column<float>(nullable: false),
                    idServicio = table.Column<int>(nullable: false),
                    ComprobantePagonumComprobante = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleComprobante", x => x.numDetalle);
                    table.ForeignKey(
                        name: "FK_DetalleComprobante_ComprobantePago_ComprobantePagonumComprobante",
                        column: x => x.ComprobantePagonumComprobante,
                        principalTable: "ComprobantePago",
                        principalColumn: "numComprobante",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleComprobante_Servicio_idServicio",
                        column: x => x.idServicio,
                        principalTable: "Servicio",
                        principalColumn: "idServicio",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_idLugar",
                table: "Cliente",
                column: "idLugar");

            migrationBuilder.CreateIndex(
                name: "IX_ComprobantePago_idCliente",
                table: "ComprobantePago",
                column: "idCliente");

            migrationBuilder.CreateIndex(
                name: "IX_ComprobantePago_numDetalle",
                table: "ComprobantePago",
                column: "numDetalle");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleComprobante_ComprobantePagonumComprobante",
                table: "DetalleComprobante",
                column: "ComprobantePagonumComprobante");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleComprobante_idServicio",
                table: "DetalleComprobante",
                column: "idServicio");

            migrationBuilder.CreateIndex(
                name: "IX_Mascota_idCliente",
                table: "Mascota",
                column: "idCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Mascota_idRaza",
                table: "Mascota",
                column: "idRaza");

            migrationBuilder.CreateIndex(
                name: "IX_Mascota_idSesion",
                table: "Mascota",
                column: "idSesion");

            migrationBuilder.CreateIndex(
                name: "IX_Raza_idTipo",
                table: "Raza",
                column: "idTipo");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_MascotaidMascota",
                table: "Reserva",
                column: "MascotaidMascota");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_idCliente",
                table: "Reserva",
                column: "idCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_idServicio",
                table: "Reserva",
                column: "idServicio");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_idSesion",
                table: "Reserva",
                column: "idSesion");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_idTrabajador",
                table: "Reserva",
                column: "idTrabajador");

            migrationBuilder.CreateIndex(
                name: "IX_Trabajador_idEspecialidad",
                table: "Trabajador",
                column: "idEspecialidad");

            migrationBuilder.AddForeignKey(
                name: "FK_ComprobantePago_DetalleComprobante_numDetalle",
                table: "ComprobantePago",
                column: "numDetalle",
                principalTable: "DetalleComprobante",
                principalColumn: "numDetalle",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Lugar_idLugar",
                table: "Cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_ComprobantePago_Cliente_idCliente",
                table: "ComprobantePago");

            migrationBuilder.DropForeignKey(
                name: "FK_ComprobantePago_DetalleComprobante_numDetalle",
                table: "ComprobantePago");

            migrationBuilder.DropTable(
                name: "Reserva");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Mascota");

            migrationBuilder.DropTable(
                name: "Trabajador");

            migrationBuilder.DropTable(
                name: "Raza");

            migrationBuilder.DropTable(
                name: "Sesion");

            migrationBuilder.DropTable(
                name: "Especialidad");

            migrationBuilder.DropTable(
                name: "TipoPerro");

            migrationBuilder.DropTable(
                name: "Lugar");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "DetalleComprobante");

            migrationBuilder.DropTable(
                name: "ComprobantePago");

            migrationBuilder.DropTable(
                name: "Servicio");
        }
    }
}
