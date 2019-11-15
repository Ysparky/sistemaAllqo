﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaAllqo.Models
{
    public class tipoPerro
    {
        [Key]
        public int idTipo { get; set; }
        public string nombre { get; set; }
        public float agregado { get; set; }
    }
}
