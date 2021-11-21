using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public Usuario Usuario { get; set; }
        [BindProperty]
        [Display(Name = "Contrase�a")]
        [Required]
        [MaxLength(16)]
        public string password { get; set; }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid && verificarut(Usuario.rut) && verificarEdad(Usuario.fecha))
            {
                IdentityUser user = new IdentityUser()
                {
                    UserName = Usuario.rut,
                };

                var result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, false);
                    _db.Add(Usuario);
                    await _db.SaveChangesAsync();
                    return RedirectToPage("Index");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return Page();
        }

        private bool verificarEdad(DateTime fecha)
        {
            if (verificarEdadPosible(fecha) && verificarMayorDeEdad(fecha))
            {
                return true;
            }
            return false;
        }

        private bool verificarMayorDeEdad(DateTime fecha)
        {
            fecha = fecha.AddYears(18);
            if (fecha <= DateTime.Now)
            {
                return true;
            }
            ModelState.AddModelError("", "Debe ser mayor de edad");
            return false;
        }

        private bool verificarEdadPosible(DateTime fecha)
        {
            if (fecha <= DateTime.Now)
            {
                return true;
            }
            ModelState.AddModelError("", "Edad invalida");
            return false;
        }

        public bool verificarut(string rut)
        {
            if (verificarFormatoRut(rut) && verificarExistenciaRut(rut))
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
            ModelState.AddModelError("", "Formato de rut inv�lido");
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
                ModelState.AddModelError("", "El rut no existe");
                return false;
            }
        }
    }
}
