using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaAllqo.Models
{
    public class Cliente
    {
        [Key]
        public int idCliente { get; set; }
        [DisplayName("Nombres")]
        public string nombres { get; set; }
        [DisplayName("Apellidos")]
        public string apellidos { get; set; }
        [DisplayName("Dirección")]
        public string direccion { get; set; }
        [DisplayName("DNI")]
        public int dni { get; set; }
        [DisplayName("Correo")]
        public string correo { get; set; }
        [DisplayName("Número de Celular")]
        public long numCelular { get; set; }
        [DisplayName("Estado")]
        public string estado { get; set; }
        [DisplayName("Lugar")]
        public int idLugar { get; set; }
        [DisplayName("Lugar")]
        public Lugar lugar { get; set; }
        public ICollection<Mascota> mascotas { get; set; }
        public ICollection<Reserva> reservas { get; set; }
        public ICollection<ComprobantePago> comprobantes { get; set; }
    }
}
