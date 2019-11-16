using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaAllqo.Models
{
    public class Mascota
    {
        [Key]
        public int idMascota { get; set; }
        [DisplayName("Nombre")]
        public string nombre { get; set; }
        [DisplayName("Edad")]
        public string edad { get; set; }
        [DisplayName("Cliente")]
        public int idCliente { get; set; }
        [DisplayName("Cliente")]
        public Cliente cliente { get; set; }
        [DisplayName("Raza")]
        public int idRaza { get; set; }
        [DisplayName("Raza")]
        public Raza raza { get; set; }
        public int idSesion { get; set; }
        public Sesion sesion { get; set; }
        public ICollection<Reserva> reservas { get; set; }
    }
}
