using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Test_Razor.Models;

namespace Test_Razor.Pages
{
    public class VerPublModel : PageModel
    {
        private readonly ApplicationDbContext db;

        public VerPublModel( ApplicationDbContext db)
        {
            this.db = db;
        }
        [BindProperty]
        public Publicacion Publicacion { get; set; }
        public async Task OnGet(int id)
        {
            Publicacion = await db.Publicacion.FindAsync(id);

        }
    }
}
