using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Test_Razor.Models;

namespace Test_Razor.Pages
{
    public class DashboardModel : PageModel
    {
        public readonly ApplicationDbContext db;
        private readonly UserManager<IdentityUser> userManager;

        public DashboardModel(ApplicationDbContext db, UserManager<IdentityUser> userManager)
        {
            this.db = db;
            this.userManager = userManager;
        }

        public IEnumerable<Publicacion> Publicaciones;
        public IEnumerable<Reporte> Reportes;
        public IdentityUser Admin { get; set; }
        public Usuario Usuario { get; set; }
        public async Task<IActionResult> OnGet()
        {
            Publicaciones = db.Publicacion.ToList();
            Reportes = db.Reporte.ToList();
            Reportes = Reportes.Where(u=> db.VerificarPublicacion(u.idPublicacion)==true);

            var rut = userManager.GetUserName(User);
            Publicaciones = Publicaciones.Where(u => u.rut == rut);
            Usuario = await db.Usuario.FindAsync(rut);
            Admin = await userManager.FindByNameAsync(rut);

            if (Admin != null && Usuario != null)
            {
                return Page();
            }
            else
            {
                return RedirectToPage("Dashboard");
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
