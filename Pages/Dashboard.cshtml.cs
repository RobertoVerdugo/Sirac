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
        public IEnumerable<Publicacion> PublicacionesActual;
        public Usuario Usuario { get; set; }

        public async Task<IActionResult> OnGet()
        {
            var rut = userManager.GetUserName(User);
            Publicaciones = db.Publicacion.ToList();
            Usuario = await db.Usuario.FindAsync(rut);
            Publicaciones = Publicaciones.Where(u => u.rut == rut);
            PublicacionesActual = PaginarPublicaciones(Publicaciones, 1);
            if (Usuario != null)
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
                return RedirectToPage("Dashboard");
            }
            else
            {
                return RedirectToPage("404Publicacion");
            }
        }
        public async Task<IActionResult> OnPostPaginar(int id)
        {
            var rut = userManager.GetUserName(User);
            Publicaciones = db.Publicacion.ToList();
            Usuario = await db.Usuario.FindAsync(rut);
            Publicaciones = Publicaciones.Where(u => u.rut == rut);
            PublicacionesActual = PaginarPublicaciones(Publicaciones, id);
            if (Usuario != null)
            {
                return Page();
            }
            else
            {
                return RedirectToPage("Dashboard");
            }
        }

        public IEnumerable<Publicacion> PaginarPublicaciones(IEnumerable<Publicacion> Local, int indice)
        {
            if (indice < 1 || indice > ((Local.Count() - 1) / 10) + 1)
            {
                indice = 1;
            }
            List<Publicacion> Lista = new List<Publicacion>();
            int i = ((10 * indice) - 10);
            while (i < ((10 * indice)) && i < Local.Count())
            {
                Lista.Add(Local.ElementAt(i));
                i++;
            }
            return Lista;
        }
    }
}
