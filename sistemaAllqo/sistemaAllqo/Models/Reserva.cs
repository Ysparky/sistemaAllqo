﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaAllqo.Models
{
    public class Reserva
    {
        [Key]
        public int idReserva { get; set; }
        [DisplayName("Fecha Reservada")]
        public DateTime fechaReservada { get; set; }
        [DisplayName("Fecha de Sesión")]
        public DateTime fechaSesion { get; set; }
        [DisplayName("Estado")]
        public string estado { get; set; }
        [DisplayName("Cliente")]
        public int idCliente { get; set; }
        [DisplayName("Cliente")]
        public Cliente cliente { get; set; }
        [DisplayName("Servicio")]
        public int idServicio { get; set; }
        [DisplayName("Servicio")]
        public Servicio servicio { get; set; }
        [DisplayName("Trabajador")]
        public int idTrabajador { get; set; }
        [DisplayName("Trabajador")]
        public Trabajador trabajador { get; set; }
        public int? idSesion { get; set; }
        public Sesion sesion { get; set; } 
    }
}
