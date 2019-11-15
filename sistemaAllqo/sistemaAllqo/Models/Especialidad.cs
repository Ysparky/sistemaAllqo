using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaAllqo.Models
{
    public class Especialidad
    {
        [Key]
        public int idEspecialidad { get; set; }
        public string nombre { get; set; }
        public ICollection<Trabajador> trabajadores { get; set; }
    }
}
