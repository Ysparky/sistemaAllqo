﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaAllqo.Models
{
    public class Raza
    {
        [Key]
        public int idRaza { get; set; }
        public string nombre { get; set; }

    }
}
