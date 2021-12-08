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
        [Required(ErrorMessage ="Este campo de obligatorio")]
        [MaxLength(12)]
        public string rut { get; set; }
        
        [Required(ErrorMessage = "Este campo de obligatorio")]
        [Display(Name = "Nombre")]
        [RegularExpression(@"[a-zA-Z ñÑáéíóúÁÉÍÓÚ]{1,25}", 
         ErrorMessage = "Caracteres no permitidos")]
        [MaxLength(16)]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Este campo de obligatorio")]
        [Display(Name = "Apellidos")]
        [RegularExpression(@"[a-zA-Z ñÑáéíóúÁÉÍÓÚ]{1,25}",
         ErrorMessage = "Caracteres no permitidos")]
        [MaxLength(25)]
        public string apellidos { get; set; }

        [Required(ErrorMessage = "Este campo de obligatorio")]
        [Display(Name = "Fecha de nacimiento"), DataType(DataType.Date)]
        public DateTime fecha { get; set; }

        [Required(ErrorMessage = "Este campo de obligatorio")]
        [Display(Name = "Correo electrónico")]
        [MaxLength(30)]
        public string email { get; set; }

        [Display(Name = "Número Telefónico")]
        [MaxLength(11)]
        [RegularExpression(@"[0-9]{1,11}",
         ErrorMessage = "Caracteres no permitidos")]
        public string telefono { get; set; }

    }
}
