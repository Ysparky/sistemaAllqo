using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaAllqo.Models
{
    public class Trabajador
    {
        [Key]
        public int idTrabajador { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public int dni { get; set; }
        public  int numCel{ get; set; }
        public string direccion { get; set; }
        public int idEspecialidad { get; set; }
        public Especialidad especialidad { get; set; }
        public ICollection<Reserva> reservas { get; set; }
    }
}
