using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sistemaAllqo.Migrations
{
    public partial class Entitys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                name: "tipoPerro",
                columns: table => new
                {
                    idTipo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: true),
                    agregado = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipoPerro", x => x.idTipo);
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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_Raza_tipoPerro_idTipo",
                        column: x => x.idTipo,
                        principalTable: "tipoPerro",
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
                    idRaza = table.Column<int>(nullable: false)
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
                    idMascota = table.Column<int>(nullable: false),
                    idServicio = table.Column<int>(nullable: false),
                    idTrabajador = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserva", x => x.idReserva);
                    table.ForeignKey(
                        name: "FK_Reserva_Mascota_idMascota",
                        column: x => x.idMascota,
                        principalTable: "Mascota",
                        principalColumn: "idMascota",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reserva_Servicio_idServicio",
                        column: x => x.idServicio,
                        principalTable: "Servicio",
                        principalColumn: "idServicio",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
                name: "IX_Raza_idTipo",
                table: "Raza",
                column: "idTipo");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_idMascota",
                table: "Reserva",
                column: "idMascota");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_idServicio",
                table: "Reserva",
                column: "idServicio");

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Reserva");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Mascota");

            migrationBuilder.DropTable(
                name: "Trabajador");

            migrationBuilder.DropTable(
                name: "Raza");

            migrationBuilder.DropTable(
                name: "Especialidad");

            migrationBuilder.DropTable(
                name: "tipoPerro");

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
