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
        private readonly ApplicationDbContext db;
        private readonly UserManager<IdentityUser> userManager;

        public DashboardModel(ApplicationDbContext db, UserManager<IdentityUser> userManager)
        {
            this.db = db;
            this.userManager = userManager;
        }

        public IEnumerable<Publicacion> Publicaciones;
        public IEnumerable<Reporte> Reportes;
        public IdentityUser admin { get; set; }
        public Usuario Usuario { get; set; }
        public async Task<IActionResult> OnGet()
        {
            Publicaciones = db.Publicacion.ToList();
            Reportes = db.Reporte.ToList();
            var rut = userManager.GetUserName(User);
            Publicaciones = Publicaciones.Where(u => u.rut == rut);
            Usuario = await db.Usuario.FindAsync(rut);
            admin = await userManager.FindByNameAsync(rut);
            if (admin != null && Usuario != null)
            {
                return Page();
            }
            else
            {
                return RedirectToPage("Dashboard");
            }
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var pub = await db.Publicacion.FindAsync(id);
            if (pub == null)
            {
                return RedirectToPage("Dashboard");
            }
            /*string path = Path.Combine(environment.WebRootPath, "img", pub.rutaimg);
            FileInfo file = new FileInfo(path);
            if (file.Exists)
            {
                //System.IO.File.Delete(path);
                file.Delete();
            }*/
            db.Publicacion.Remove(pub);
            await db.SaveChangesAsync();
            return RedirectToPage("Dashboard");

        }
    }
}
