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
        [Required(ErrorMessage = "Este campo de obligatorio")]
        public DateTime fecha { get; set; }

        [Display(Name = "Fecha de Actualización")]
        public DateTime actualizacion { get; set; }

        [Display(Name = "Nombre del Animal")]
        [Required(ErrorMessage = "Este campo de obligatorio")]
        [RegularExpression(@"[a-zA-Z0-9 ñÑáéíóúÁÉÍÓÚ,.:;'-]{1,30}",
         ErrorMessage = "Caracteres no permitidos")]
        [MaxLength(30)]
        public string nombre { get; set; }

        [Display(Name = "Especie del Animal")]
        [Required(ErrorMessage = "Este campo de obligatorio")]
        public string especie { get; set; }

        [Display(Name = "Tipo de pelaje")]
        [Required(ErrorMessage = "Este campo de obligatorio")]
        public string pelaje { get; set; }

        [Display(Name = "Color de pelaje")]
        [Required(ErrorMessage = "Este campo de obligatorio")]
        public string color { get; set; }

        [Display(Name = "Raza del animal")]
        [Required(ErrorMessage = "Este campo de obligatorio")]
        public string raza { get; set; }

        [Display(Name = "Tamaño del Animal")]
        [Required(ErrorMessage = "Este campo de obligatorio")]
        public string tamano { get; set; }

        [Display(Name = "Edad del Animal")]
        [Required(ErrorMessage = "Este campo de obligatorio")]
        public string edad { get; set; }

        [Display(Name = "Género del Animal")]
        [Required(ErrorMessage = "Este campo de obligatorio")]
        public string genero { get; set; }

        [Display(Name = "Imagen del Animal")]
        public string rutaimg { get; set; }

        [Display(Name = "Estado del Animal")]
        [Required(ErrorMessage = "Este campo de obligatorio")]
        public string estado { get; set; }

        [Display(Name = "Ubicación del Animal")]
        [Required(ErrorMessage = "Este campo de obligatorio")]
        [RegularExpression(@"[a-zA-Z0-9 ñÑáéíóúÁÉÍÓÚ,.:;'-]{1,100}",
         ErrorMessage = "Caracteres no permitidos")]
        [MaxLength(100)]
        public string ubicacion { get; set; }

        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "Este campo de obligatorio")]
        [RegularExpression(@"[a-zA-Z0-9 (\r\n|\r|\n)ñÑáéíóúÁÉÍÓÚ,.:;'?!-]{1,500}",
         ErrorMessage = "Caracteres no permitidos")]
        [MaxLength(500)]
        public string descripcion { get; set; }

        [Display(Name = "Rut del Usuario")]
        [Required]
        public string rut { get; set; }

        public double score { get; set; }
        public double scoreContenido { get; set; }
        public string filepath { get; set; }
    }
}
