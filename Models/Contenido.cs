using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Razor.Models
{
    public class Contenido
    {
        [Key]
        [MaxLength(12)]
        public string rut { get; set; }

        public int Macho { get; set; }
        public int Hembra { get; set; }
        public int Cachorro { get; set; }
        public int Adulto { get; set; }
        public int Senior { get; set; }
        public int Desconocido { get; set; }
        public int Duro { get; set; }
        public int Rizado { get; set; }
        public int Corto { get; set; }
        public int Largo { get; set; }
        //public int Lampiño { get; set; }
        public int Negro { get; set; }
        public int Blanco { get; set; }
        public int Beige { get; set; }
        public int Gris { get; set; }
        public int Café { get; set; }
       // public int Café Claro { get; set; }

}
}
