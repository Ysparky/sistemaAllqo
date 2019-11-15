using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaAllqo.Models
{
    public class ReservaxMascota
    {
        [Key]
        public int idresxMas { get; set; }
        public int idReserva { get; set; }
        public Reserva reserva { get; set; }
        public int idMascota { get; set; }
        public Mascota mascota { get; set; }
    }
}
