using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Test_Razor.Models
{
    public class Auth
    {
        [Required(ErrorMessage = "Ingrese su Rut")]
        [Display(Name = "Rut")]
        public string rut { get; set; }

        [Required(ErrorMessage = "Ingrese su Contraseña")]
        [Display(Name = "Contraseña")]
        public string password { get; set; }

    }
}
