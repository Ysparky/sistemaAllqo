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
        public int edad { get; set; }
    }
}
