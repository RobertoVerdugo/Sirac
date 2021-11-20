using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Test_Razor.Models
{
    public class Auth
    {
        [Required]
        [Display(Name = "Rut")]
        public string rut { get; set; }

        [Required]
        [Display(Name = "Contraseña")]
        public string password { get; set; }

    }
}
