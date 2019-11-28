using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaAllqo.Models
{
    public class SesionxMascota
    {
        [Key]
        public int idSesionxm { get; set; }
        public int? idMascota { get; set; }
        public Mascota mascota { get; set; }
        public int? idSesion { get; set; }
        public Sesion sesion { get; set; }
    }
}
