using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Test_Razor.Models;

namespace Test_Razor.Pages
{
    public class RegistroModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public RegistroModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Usuario Usuario {get; set;}
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid || _db.Usuario.Find(Usuario.rut)!=null)
            {
                return Page();
            }
            _db.Add(Usuario);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
