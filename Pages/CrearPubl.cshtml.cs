using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Test_Razor.Models;
namespace Test_Razor.Pages
{
    public class CrearPublModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public CrearPublModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Publicacion Publicacion{ get; set; }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid/*|| yaexiste || otra comprobacion*/)
            {
                return Page();
            }

            _db.Add(Publicacion);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
