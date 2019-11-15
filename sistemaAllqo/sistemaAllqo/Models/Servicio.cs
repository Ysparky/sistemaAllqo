using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaAllqo.Models
{
    public class Servicio
    {
        [Key]
        public int idServicio { get; set; }
        [DisplayName("Categoria")]
        public string categoria { get; set; }
        [DisplayName("Descripción")]
        public string descripcion { get; set; }
        [DisplayName("Precio")]
        public decimal precio { get; set; }
        public ICollection<Reserva> reservas { get; set; }
        public ICollection<DetalleComprobante> detalles { get; set; }
    }
}