using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Razor.Models
{
    public class Usuario
    {
        [Key]
        [Display(Name = "Rut")]
        [Required]
        public string rut { get; set; }
        [Display(Name = "Contraseña")]
        [Required]
        public string password { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }

        [Required]
        [Display(Name = "Apellidos")]
        public string apellidos { get; set; }

        [Required]
        [Display(Name = "Fecha de nacimiento")]
        public DateTime fecha { get; set; }

        [Required]
        [Display(Name = "Correo electrónico")]
        public string email { get; set; }

        [Display(Name = "Dirección")]
        public string direccion { get; set; }

        [Display(Name = "Número Telefónico")]
        public string telefono { get; set; }

    }
}
