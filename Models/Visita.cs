using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Razor.Models
{
    public class Visita
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public string rut { get; set; }
        [Required]
        public int idPublicacion { get; set; }
        [Required]
        public int ranking { get; set; }
    }
}
