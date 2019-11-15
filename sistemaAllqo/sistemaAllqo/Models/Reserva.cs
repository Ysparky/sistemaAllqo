using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaAllqo.Models
{
    public class Reserva
    {
        [Key]
        public int Reserva_ID { get; set; }
        public DateTime fechaReservada { get; set; }
        public DateTime fechaSesion { get; set; }
        public string estado { get; set; }
        public int idCliente { get; set; }
        public Cliente cliente { get; set; }
        public int idServicio { get; set; }
        public Servicio servicio { get; set; }
        public int idTrabajador { get; set; }
        public Trabajador trabajador { get; set; }
    }
}
