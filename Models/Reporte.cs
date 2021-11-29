﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Razor.Models
{
    public class Reporte
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Display(Name = "Causal de reporte")]
        [Required]
        public string causal { get; set; }

        [Display(Name = "Descripción")]
        [Required]
        [MaxLength(500)]
        public string descripcion { get; set; }
        [Display(Name = "ID")]
        [Required]
        public int idPublicacion { get; set; }
    }
}
