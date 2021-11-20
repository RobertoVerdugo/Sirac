using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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

        public bool verificarut(string rut)
        {
            if (verificarExistenciaRut(rut) && verificarFormatoRut(rut))
            {
                return true;
            }
            return false;
        }

        private bool verificarFormatoRut(string rut)
        {
            if (rut.Length <= 12 && rut[0] != '0')
            {
                Match m = Regex.Match(rut, "[0-9]{1,2}[.][1-9][0-9]{2}[.][1-9][0-9]{2}[-]([1-9]|(k|K))");
                if (m.Success)
                {
                    return true;
                }
            }
            return false;
        }

        public bool verificarExistenciaRut(string rut)
        {
            rut = rut.Replace(".", "");
            char digitoVerificador = rut[rut.Length - 1];
            rut = rut.Substring(0, rut.Length - 2);
            int multiplicador = 2;
            int suma = 0;
            for (int i = rut.Length - 1; i >= 0; i--)
            {
                suma += (int)Char.GetNumericValue(rut[i]) * multiplicador;
                multiplicador += 1;
                if (multiplicador == 8)
                {
                    multiplicador = 2;
                }
            }
            int division = suma / 11;
            int multiplicado = division * 11;
            int resta = Math.Abs(suma - multiplicado);
            if (Math.Abs((11 - resta)) == (int)Char.GetNumericValue(digitoVerificador))
            {
                return true;
            }
            else if (digitoVerificador == 'K' && Math.Abs((11 - resta)) == 10)
            {
                return true;
            }
            else if (digitoVerificador == '0' && Math.Abs((11 - resta)) == 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
