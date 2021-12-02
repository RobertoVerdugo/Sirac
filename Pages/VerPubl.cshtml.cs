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
            if (db.VerificarPublicacion(id))
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
            else
            {
                return RedirectToPage("404Publicacion");
            }
            
        }
        public IActionResult OnPostDelete(int id)
        {
            if (db.EliminarPublicacion(id))
            {
                return RedirectToPage("Index");
            }
            else
            {
                return RedirectToPage("404Publicacion");
            }

        }
    }
}
