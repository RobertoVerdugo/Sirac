﻿using System;
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
        [MaxLength(12)]
        public string rut { get; set; }
        
        [Required]
        [Display(Name = "Nombre")]
        [MaxLength(16)]
        public string nombre { get; set; }

        [Required]
        [Display(Name = "Apellidos")]
        [MaxLength(25)]
        public string apellidos { get; set; }

        [Required]
        [Display(Name = "Fecha de nacimiento")]
        public DateTime fecha { get; set; }

        [Required]
        [Display(Name = "Correo electrónico")]
        [MaxLength(30)]
        public string email { get; set; }

        [Display(Name = "Dirección")]
        [MaxLength(60)]
        public string direccion { get; set; }

        [Display(Name = "Número Telefónico")]
        [MaxLength(11)]
        public string telefono { get; set; }

    }
}
