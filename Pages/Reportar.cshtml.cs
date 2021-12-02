using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Test_Razor.Models;

namespace Test_Razor.Pages
{
    public class ReportarModel : PageModel
    {
        private readonly ApplicationDbContext db;

        public ReportarModel(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int idPub { get; set; }
        [BindProperty]
        public Reporte Reporte { get; set; }
        public IActionResult OnGet(int id)
        {
            if (db.VerificarPublicacion(id))
            {
                idPub = id;
                return Page();
            }
            else
            {
                return RedirectToPage("404Publicacion");
            }
            
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                db.Add(Reporte);
                await db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
