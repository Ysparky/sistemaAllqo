using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaAllqo.Models
{
    public class Servicio
    {
        [Key]
        public int idServicio { get; set; }
        public string categoria { get; set; }
        public string descripcion { get; set; }
        public float precio { get; set; }
    }
}
