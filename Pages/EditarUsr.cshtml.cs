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
    public class EditarUsrModel : PageModel
    {
        private readonly ApplicationDbContext db;
        private readonly UserManager<IdentityUser> userManager;

        public EditarUsrModel(ApplicationDbContext db, UserManager<IdentityUser> userManager)
        {
            this.db = db;
            this.userManager = userManager;
        }
        [BindProperty]
        public Usuario Usuario { get; set; }

        public async Task<IActionResult> OnGet(string id)
        {
            if(db.VerificarPropiedadUsuario(id, userManager.GetUserName(User)))
            {
                Usuario = await db.Usuario.FindAsync(id);
                return Page();
            }
            if (db.ExisteUsuario(id))
            {
                return RedirectToPage("403");
            }
            return RedirectToPage("404Usuario");
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                db.Usuario.Update(Usuario);
                await db.SaveChangesAsync();
                return RedirectToPage("Dashboard");
            }
            return Page();
        }
    }
}
