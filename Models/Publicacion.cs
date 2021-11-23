using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test_Razor.Models
{
    public class Publicacion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Display(Name = "Fecha de publicación")]
        [Required]
        public DateTime fecha { get; set; }

        [Display(Name = "Fecha de Actualización")]
        public DateTime actualizacion { get; set; }

        [Display(Name = "Nombre del Animal")]
        [Required]
        [MaxLength(30)]
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
        public string rutaimg { get; set; }

        [Display(Name = "Estado del Animal")]
        [Required]
        public string estado { get; set; }

        [Display(Name = "Ubicación del Animal")]
        [Required]
        [MaxLength(100)]
        public string ubicacion { get; set; }

        [Display(Name = "Descripción")]
        [Required]
        [MaxLength(500)]
        public string descripcion { get; set; }

        [Display(Name = "Rut del Usuario")]
        [Required]
        public string rut { get; set; }
    }
}
