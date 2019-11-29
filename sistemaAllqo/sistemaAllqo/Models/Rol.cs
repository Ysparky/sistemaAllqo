using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaAllqo.Models
{
    public class Rol
    {
        public Rol()
        {
            Usuarios = new List<string>();
        }

        public string Id { get; set; }

        [Required(ErrorMessage = "Este Campo es Obligatorio")]
        [RegularExpression("^[a-zA-ZñÑáéíóúÁÉÍÓÚ]*$", ErrorMessage = "* Solo se permiten letras.")]
        public string NrNombre { get; set; }

        public List<string> Usuarios { get; set; }
        public string UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public bool EsSelec { get; set; }
    }
}
