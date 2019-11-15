﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using sistemaAllqo.Models;

namespace sistemaAllqo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<sistemaAllqo.Models.Cliente> Cliente { get; set; }
        public DbSet<sistemaAllqo.Models.ComprobantePago> ComprobantePago { get; set; }
        public DbSet<sistemaAllqo.Models.DetalleComprobante> DetalleComprobante { get; set; }
        public DbSet<sistemaAllqo.Models.Especialidad> Especialidad { get; set; }
        public DbSet<sistemaAllqo.Models.Lugar> Lugar { get; set; }
        public DbSet<sistemaAllqo.Models.Mascota> Mascota { get; set; }
        public DbSet<sistemaAllqo.Models.Raza> Raza { get; set; }
        public DbSet<sistemaAllqo.Models.Reserva> Reserva { get; set; }
        public DbSet<sistemaAllqo.Models.Servicio> Servicio { get; set; }
        public DbSet<sistemaAllqo.Models.tipoPerro> tipoPerro { get; set; }
        public DbSet<sistemaAllqo.Models.Trabajador> Trabajador { get; set; }
        public DbSet<sistemaAllqo.Models.Usuario> Usuario { get; set; }
<<<<<<< HEAD
=======
<<<<<<< HEAD
        public DbSet<sistemaAllqo.Models.Sesion> Sesion { get; set; }
=======
        public DbSet<sistemaAllqo.Models.ReservaxMascota> ReservaxMascota { get; set; }
>>>>>>> 2fb3174d6ff52f2b40c23d6f211f3371579e1951
>>>>>>> cd360ee7a0379be5ee1af12e4f0d06b1d77049fa
    }
}
