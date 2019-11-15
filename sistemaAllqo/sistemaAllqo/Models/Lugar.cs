using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaAllqo.Models
{
    public class Lugar
    {
        [Key]
        public int idLugar { get; set; }
        public string nombre { get; set; }
        public decimal agregado { get; set; }
        public ICollection<Cliente> clientes { get; set; }
    }
}
