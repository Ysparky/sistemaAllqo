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
        public int numMascotas { get; set; }
        public string estado { get; set; }
        public int idReserva { get; set; }
        public Reserva reserva { get; set; }
    }
}
