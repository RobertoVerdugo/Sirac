using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Razor.Models
{
    public class Filtro
    {
        public string especie { get; set; }

        public string pelaje { get; set; }

        public string color { get; set; }

        public string raza { get; set; }

        public string tamano { get; set; }

        public string edad { get; set; }

        public string genero { get; set; }

        public string estado { get; set; }

        public string orden { get; set; }
    }
}
