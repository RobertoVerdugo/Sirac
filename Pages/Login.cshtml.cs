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
    public class LoginModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly UserManager<IdentityUser> userManager;

        public LoginModel(ApplicationDbContext db, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _db = db;
            this.signInManager = signInManager;
            this.userManager = userManager;
        }
        [BindProperty]
        public Auth Auth { get; set; }

        public async Task<IActionResult> OnPost(string url = null)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(Auth.rut, Auth.password,true,false);
                if (result.Succeeded)
                {
                    if(url==null || url == "/")
                    {
                        return RedirectToPage("Index");
                    }
                    else
                    {
                        return RedirectToPage(url);
                    }
                    
                }
                ModelState.AddModelError("", "Rut o Contraseña incorrectos");
            }
            return Page();
        }
    }
}
