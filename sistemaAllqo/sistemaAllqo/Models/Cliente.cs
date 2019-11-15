using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaAllqo.Models
{
    public class Cliente
    {
        [Key]
        public int idCliente { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string direccion { get; set; }
        public int dni { get; set; }
        public string correo { get; set; }
        public int numCelular { get; set; }
        public string estado { get; set; }
    }
}
