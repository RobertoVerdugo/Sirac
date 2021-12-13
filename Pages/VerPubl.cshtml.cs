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
        
        public IEnumerable<Visita> Visita;
        public async Task<IActionResult> OnGet(int id)
        {
            if (db.VerificarPublicacion(id))
            {
                var rut_admin = userManager.GetUserName(User);
                Publicacion = db.Publicacion.Find(id);
                var rut = Publicacion.rut;
                Usuario =  db.Usuario.Find(rut);
                admin =  await userManager.FindByNameAsync(rut_admin);
                if (admin != null && Usuario != null && Publicacion != null)
                {
                    await Visitar();
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

        public async Task<IActionResult> Visitar()
        {
            var rut = userManager.GetUserName(User);
            Visita estaVisita;
            Preferencia Preferencia = db.Preferencia.Find(rut);
            Visita = db.Visita.ToList();
            Visita = Visita.Where(u => u.rut == rut);
            Visita = Visita.Where(u => u.idPublicacion == Publicacion.id);
            if (Visita.Count() > 0)
            {
                estaVisita = Visita.First();
                estaVisita.ranking = estaVisita.ranking + 1;
                db.Visita.Update(estaVisita);
            }
            else
            {
                estaVisita = new Visita
                {
                    idPublicacion = Publicacion.id,
                    ranking = 1,
                    rut = rut
                };
                await db.Visita.AddAsync(estaVisita);
            }
            if (Preferencia == null)
            {
                Preferencia = new Preferencia
                {
                    rut = rut,
                };
                Preferencia = Preferencia.updtPreferencia(Preferencia, Publicacion);
                await db.Preferencia.AddAsync(Preferencia);
            }
            else
            {
                Preferencia = Preferencia.updtPreferencia(Preferencia, Publicacion);
                db.Preferencia.Update(Preferencia);
            }
            
            await db.SaveChangesAsync();
            return Page();
        }
    }
}
