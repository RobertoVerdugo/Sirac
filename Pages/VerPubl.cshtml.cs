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
    public class VerPublModel : PageModel
    {
        private readonly ApplicationDbContext db;
        private readonly UserManager<IdentityUser> userManager;

        public VerPublModel(ApplicationDbContext db, UserManager<IdentityUser> userManager)
        {
            this.db = db;
            this.userManager = userManager;
        }
        [BindProperty]
        public Publicacion Publicacion { get; set; }
        [BindProperty]
        public Usuario Usuario { get; set; }
        public IdentityUser admin { get; set; }
        public async Task<IActionResult> OnGet(int id)
        {
            Publicacion = await db.Publicacion.FindAsync(id);
            var rut = userManager.GetUserName(User);
            Usuario = await db.Usuario.FindAsync(rut);
            admin = await userManager.FindByNameAsync(rut);
            if (admin != null && Usuario != null && Publicacion != null)
            {
                return Page();
            }
            else
            {
                return RedirectToPage("Dashboard");
            }
        }
        public async Task<IActionResult> OnPostDelete(int id)
        {
            var pub = await db.Publicacion.FindAsync(id);
            if (pub == null)
            {
                return RedirectToPage("Index");
            }
            db.Publicacion.Remove(pub);
            await db.SaveChangesAsync();
            return RedirectToPage("Index");

        }
    }
}
