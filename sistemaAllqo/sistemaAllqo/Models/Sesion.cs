using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaAllqo.Models
{
    public class Sesion
    {
        [Key]
        public int idSesion { get; set; }
        public DateTime fechaSesion { get; set; }
        public int? lugar { get; set; }
        public int? tipoMascota { get; set; }
        public int? numMascotas { get; set; }
        public string estado { get; set; }
        public ICollection<Reserva> reservas { get; set; }
        public ICollection<SesionxMascota> sesionxMascotas { get; set; }
    }
}
