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
        private readonly IWebHostEnvironment environment;

        public DashboardModel(ApplicationDbContext db, UserManager<IdentityUser> userManager, IWebHostEnvironment environment)
        {
            this.db = db;
            this.userManager = userManager;
            this.environment = environment;
        }

        public IEnumerable<Publicacion> Publicaciones;
        public void OnGet()
        {
            Publicaciones = db.Publicacion.ToList();
            var rut = userManager.GetUserName(User);
            Publicaciones = Publicaciones.Where(u => u.rut == rut).ToList();
        }
        public async Task<IActionResult> OnPostDelete(int id)
        {
            var pub = await db.Publicacion.FindAsync(id);
            if(pub == null)
            {
                return RedirectToPage("Index");
            }
            string path = Path.Combine(environment.WebRootPath, "img", pub.rut);
            FileInfo file = new FileInfo(path);
            if (file.Exists)
            {
                file.Delete();
            }
            db.Publicacion.Remove(pub);
            await db.SaveChangesAsync();
            return Page();

        }
    }
}
