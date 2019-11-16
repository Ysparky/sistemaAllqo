using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaAllqo.Models
{
    public class ComprobantePago
    {
        [Key]
        public int numComprobante { get; set; }
        public DateTime fecha { get; set; }
        public string comentario { get; set; }
        public string estadoPago { get; set; }
        public int idCliente { get; set; } 
        public Cliente cliente { get; set; }
        public ICollection<DetalleComprobante> detalles { get; set; }
    }
}
