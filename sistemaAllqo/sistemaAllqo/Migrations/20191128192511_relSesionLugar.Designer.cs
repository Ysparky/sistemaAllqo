﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using sistemaAllqo.Data;

namespace sistemaAllqo.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191128192511_relSesionLugar")]
    partial class relSesionLugar
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("sistemaAllqo.Models.Cliente", b =>
                {
                    b.Property<int>("idCliente")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellidos");

                    b.Property<string>("correo");

                    b.Property<string>("direccion");

                    b.Property<int>("dni");

                    b.Property<string>("estado");

                    b.Property<int>("idLugar");

                    b.Property<string>("nombres");

                    b.Property<long>("numCelular");

                    b.HasKey("idCliente");

                    b.HasIndex("idLugar");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("sistemaAllqo.Models.ComprobantePago", b =>
                {
                    b.Property<int>("numComprobante")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("comentario");

                    b.Property<string>("estadoPago");

                    b.Property<DateTime>("fecha");

                    b.Property<int>("idCliente");

                    b.HasKey("numComprobante");

                    b.HasIndex("idCliente");

                    b.ToTable("ComprobantePago");
                });

            modelBuilder.Entity("sistemaAllqo.Models.DetalleComprobante", b =>
                {
                    b.Property<int>("numDetalle")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("cantidad");

                    b.Property<int>("idServicio");

                    b.Property<float>("importe");

                    b.Property<int>("numComprobante");

                    b.Property<float>("precioUnit");

                    b.Property<float>("subtotal");

                    b.Property<float>("total");

                    b.HasKey("numDetalle");

                    b.HasIndex("idServicio");

                    b.HasIndex("numComprobante");

                    b.ToTable("DetalleComprobante");
                });

            modelBuilder.Entity("sistemaAllqo.Models.Especialidad", b =>
                {
                    b.Property<int>("idEspecialidad")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombre");

                    b.HasKey("idEspecialidad");

                    b.ToTable("Especialidad");
                });

            modelBuilder.Entity("sistemaAllqo.Models.Lugar", b =>
                {
                    b.Property<int>("idLugar")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("agregado");

                    b.Property<string>("nombre");

                    b.HasKey("idLugar");

                    b.ToTable("Lugar");
                });

            modelBuilder.Entity("sistemaAllqo.Models.Mascota", b =>
                {
                    b.Property<int>("idMascota")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("edad");

                    b.Property<int>("idCliente");

                    b.Property<int?>("idRaza");

                    b.Property<string>("nombre");

                    b.HasKey("idMascota");

                    b.HasIndex("idCliente");

                    b.HasIndex("idRaza");

                    b.ToTable("Mascota");
                });

            modelBuilder.Entity("sistemaAllqo.Models.Raza", b =>
                {
                    b.Property<int>("idRaza")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("idTipo");

                    b.Property<string>("nombre");

                    b.HasKey("idRaza");

                    b.HasIndex("idTipo");

                    b.ToTable("Raza");
                });

            modelBuilder.Entity("sistemaAllqo.Models.Reserva", b =>
                {
                    b.Property<int>("idReserva")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("estado");

                    b.Property<DateTime>("fechaReservada");

                    b.Property<DateTime>("fechaSesion");

                    b.Property<int>("idCliente");

                    b.Property<int>("idServicio");

                    b.Property<int?>("idSesion");

                    b.Property<int>("idTrabajador");

                    b.HasKey("idReserva");

                    b.HasIndex("idCliente");

                    b.HasIndex("idServicio");

                    b.HasIndex("idSesion");

                    b.HasIndex("idTrabajador");

                    b.ToTable("Reserva");
                });

            modelBuilder.Entity("sistemaAllqo.Models.Servicio", b =>
                {
                    b.Property<int>("idServicio")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categoria");

                    b.Property<string>("descripcion");

                    b.Property<decimal>("precio");

                    b.HasKey("idServicio");

                    b.ToTable("Servicio");
                });

            modelBuilder.Entity("sistemaAllqo.Models.Sesion", b =>
                {
                    b.Property<int>("idSesion")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("estado");

                    b.Property<DateTime>("fechaSesion");

                    b.Property<int?>("idServicio");

                    b.Property<int?>("idTipo");

                    b.Property<string>("lugar");

                    b.Property<int?>("numMascotas");

                    b.HasKey("idSesion");

                    b.HasIndex("idServicio");

                    b.HasIndex("idTipo");

                    b.ToTable("Sesion");
                });

            modelBuilder.Entity("sistemaAllqo.Models.SesionxMascota", b =>
                {
                    b.Property<int>("idSesionxm")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("idMascota");

                    b.Property<int?>("idSesion");

                    b.HasKey("idSesionxm");

                    b.HasIndex("idMascota");

                    b.HasIndex("idSesion");

                    b.ToTable("SesionxMascota");
                });

            modelBuilder.Entity("sistemaAllqo.Models.TipoPerro", b =>
                {
                    b.Property<int>("idTipo")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("agregado");

                    b.Property<string>("nombre");

                    b.HasKey("idTipo");

                    b.ToTable("TipoPerro");
                });

            modelBuilder.Entity("sistemaAllqo.Models.Trabajador", b =>
                {
                    b.Property<int>("idTrabajador")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellidos");

                    b.Property<string>("direccion");

                    b.Property<int>("dni");

                    b.Property<int>("idEspecialidad");

                    b.Property<string>("nombres");

                    b.Property<long>("numCel");

                    b.HasKey("idTrabajador");

                    b.HasIndex("idEspecialidad");

                    b.ToTable("Trabajador");
                });

            modelBuilder.Entity("sistemaAllqo.Models.Usuario", b =>
                {
                    b.Property<int>("idUsuario")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("password");

                    b.Property<string>("usuario");

                    b.HasKey("idUsuario");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("sistemaAllqo.Models.Cliente", b =>
                {
                    b.HasOne("sistemaAllqo.Models.Lugar", "lugar")
                        .WithMany("clientes")
                        .HasForeignKey("idLugar")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("sistemaAllqo.Models.ComprobantePago", b =>
                {
                    b.HasOne("sistemaAllqo.Models.Cliente", "cliente")
                        .WithMany("comprobantes")
                        .HasForeignKey("idCliente")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("sistemaAllqo.Models.DetalleComprobante", b =>
                {
                    b.HasOne("sistemaAllqo.Models.Servicio", "servicio")
                        .WithMany("detalles")
                        .HasForeignKey("idServicio")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("sistemaAllqo.Models.ComprobantePago", "comprobante")
                        .WithMany("detalles")
                        .HasForeignKey("numComprobante")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("sistemaAllqo.Models.Mascota", b =>
                {
                    b.HasOne("sistemaAllqo.Models.Cliente", "cliente")
                        .WithMany("mascotas")
                        .HasForeignKey("idCliente")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("sistemaAllqo.Models.Raza", "raza")
                        .WithMany("mascotas")
                        .HasForeignKey("idRaza");
                });

            modelBuilder.Entity("sistemaAllqo.Models.Raza", b =>
                {
                    b.HasOne("sistemaAllqo.Models.TipoPerro", "tipoperro")
                        .WithMany("razas")
                        .HasForeignKey("idTipo")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("sistemaAllqo.Models.Reserva", b =>
                {
                    b.HasOne("sistemaAllqo.Models.Cliente", "cliente")
                        .WithMany()
                        .HasForeignKey("idCliente")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("sistemaAllqo.Models.Servicio", "servicio")
                        .WithMany("reservas")
                        .HasForeignKey("idServicio")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("sistemaAllqo.Models.Sesion", "sesion")
                        .WithMany("reservas")
                        .HasForeignKey("idSesion");

                    b.HasOne("sistemaAllqo.Models.Trabajador", "trabajador")
                        .WithMany("reservas")
                        .HasForeignKey("idTrabajador")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("sistemaAllqo.Models.Sesion", b =>
                {
                    b.HasOne("sistemaAllqo.Models.Servicio", "servicio")
                        .WithMany("sesiones")
                        .HasForeignKey("idServicio");

                    b.HasOne("sistemaAllqo.Models.TipoPerro", "tipoPerro")
                        .WithMany()
                        .HasForeignKey("idTipo");
                });

            modelBuilder.Entity("sistemaAllqo.Models.SesionxMascota", b =>
                {
                    b.HasOne("sistemaAllqo.Models.Mascota", "mascota")
                        .WithMany("sesionxMascotas")
                        .HasForeignKey("idMascota");

                    b.HasOne("sistemaAllqo.Models.Sesion", "sesion")
                        .WithMany("sesionxMascotas")
                        .HasForeignKey("idSesion");
                });

            modelBuilder.Entity("sistemaAllqo.Models.Trabajador", b =>
                {
                    b.HasOne("sistemaAllqo.Models.Especialidad", "especialidad")
                        .WithMany("trabajadores")
                        .HasForeignKey("idEspecialidad")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}