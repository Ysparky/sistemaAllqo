using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaAllqo.Models
{
    public class DetalleComprobante
    {
        [Key]
        public int numDetalle { get; set; }
        public int cantidad { get; set; }
        public float precioUnit { get; set; }
        public float subtotal { get; set; }
        public float total { get; set; }
        public float importe { get; set; }
        public int idServicio { get; set; }
        public Servicio servicio { get; set; }
    }
}
