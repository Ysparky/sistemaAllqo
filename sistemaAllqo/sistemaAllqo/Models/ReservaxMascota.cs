﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaAllqo.Models
{
    public class ReservaxMascota
    {
        public int idReserva { get; set; }
        public Reserva reserva { get; set; }
        public int idMascota { get; set; }
        public Mascota mascota { get; set; }
    }
}
