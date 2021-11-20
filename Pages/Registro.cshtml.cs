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
    public class RegistroModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public RegistroModel(ApplicationDbContext db, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _db = db;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [BindProperty]
        public Usuario Usuario {get; set;}
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid  && verificarut(Usuario.rut))
            {
                IdentityUser user = new IdentityUser()
                {
                    UserName = Usuario.rut,
                };

                var result = await userManager.CreateAsync(user, Usuario.password);
                if (result.Succeeded)
                {
                    /*_db.Add(Usuario);
                    await _db.SaveChangesAsync();*/
                    await signInManager.SignInAsync(user, false);
                    return RedirectToPage("Index");
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return Page();
        }

        //Verifica el dígito verificador del rut. Retorna False si es falso XD y además verificar el formato del mismo
        public bool verificarut(string rut)
        {
            return true;
        }
    }
}
