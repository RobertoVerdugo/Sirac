using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Test_Razor.Models;

namespace Test_Razor.Pages
{
    //[Authorize(Policy = "usuario")]
    public class CrearPublModel : PageModel
    {

        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> userManager;

        public CrearPublModel(ApplicationDbContext db, UserManager<IdentityUser> userManager)
        {
            _db = db;
            this.userManager = userManager;
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
            IdentityUser user = await userManager.GetUserAsync(User);
            Publicacion.rut = user.UserName;
            _db.Add(Publicacion);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
