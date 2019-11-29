using System;
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
        public DbSet<sistemaAllqo.Models.Lugar> Lugar { get; set; }
        public DbSet<sistemaAllqo.Models.Mascota> Mascota { get; set; }
        public DbSet<sistemaAllqo.Models.Raza> Raza { get; set; }
        public DbSet<sistemaAllqo.Models.Reserva> Reserva { get; set; }
        public DbSet<sistemaAllqo.Models.Servicio> Servicio { get; set; }
        public DbSet<sistemaAllqo.Models.Sesion> Sesion { get; set; }
        public DbSet<sistemaAllqo.Models.SesionxMascota> SesionxMascota { get; set; }
        public DbSet<sistemaAllqo.Models.TipoPerro> TipoPerro { get; set; }
        public DbSet<sistemaAllqo.Models.Trabajador> Trabajador { get; set; }
    }
}
