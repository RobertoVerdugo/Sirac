﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Test_Razor.Models
{
    public class Publicacion
    {
        [Display(Name = "Título de la publicación")]
        [Required]
        public string titulo { get; set; }
        [Display(Name = "Fecha de publicación")]
        [Required]
        public DateTime fecha { get; set; }
        [Display(Name = "Nombre del Animal")]
        [Required]
        public string nombre { get; set; }
        [Display(Name = "Especie del Animal")]
        [Required]
        public string especie { get; set; }
        [Display(Name = "Tipo de pelaje")]
        [Required]
        public string pelaje { get; set; }
        [Display(Name = "Color de pelaje")]
        [Required]
        public string color { get; set; }
        [Display(Name = "Raza del animal")]
        [Required]
        public string raza { get; set; }
        [Display(Name = "Tamaño del Animal")]
        [Required]
        public string tamano { get; set; }
        [Display(Name = "Edad del Animal")]
        [Required]
        public string edad { get; set; }
        [Display(Name = "Género del Animal")]
        [Required]
        public string genero { get; set; }
        [Display(Name = "Imagen del Animal")]
        [Required]
        public string rutaimg { get; set; }
        [Display(Name = "Estado del Animal")]
        [Required]
        public string estado { get; set; }
        [Display(Name = "Ubicación del Animal")]
        [Required]
        public string ubicacion { get; set; }
        [Display(Name = "Rut del Usuario")]
        [Required]
        public string rut { get; set; }
    }
}