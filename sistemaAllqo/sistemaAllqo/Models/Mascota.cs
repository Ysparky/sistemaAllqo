using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaAllqo.Models
{
    public class Mascota
    {
        [Key]
        public int idMascota { get; set; }
        public string nombre { get; set; }
        public string edad { get; set; }
        public int idCliente { get; set; }
        public Cliente cliente { get; set; }
        public int idRaza { get; set; }
        public Raza raza { get; set; }
    }
}
