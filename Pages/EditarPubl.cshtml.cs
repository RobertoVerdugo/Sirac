using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Test_Razor.Models;

namespace Test_Razor.Pages
{
    public class EditarPublModel : PageModel
    {
        private readonly ApplicationDbContext db;

        public EditarPublModel(ApplicationDbContext db, ICategoryService categoryService, UserManager<IdentityUser> userManager, IWebHostEnvironment environment)
        {
            this.db = db;
            this.categoryService = categoryService;
            this.userManager = userManager;
            this.environment = environment;
        }
        private ICategoryService categoryService;
        private readonly UserManager<IdentityUser> userManager;
        private readonly IWebHostEnvironment environment;

        [BindProperty(SupportsGet = true)]
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public SelectList Categories { get; set; }

        [BindProperty]
        public Publicacion Publicacion { get; set; }
        [BindProperty]
        public IFormFile Photo { get; set; }
        public async Task<IActionResult> OnGet(int id)
        {
            if (db.VerificarPublicacion(id))
            {
                Publicacion = await db.Publicacion.FindAsync(id);
                if (db.VerificarPropiedadUsuario(Publicacion.rut, userManager.GetUserName(User)))
                {
                    Categories = new SelectList(categoryService.GetCategories(), nameof(Category.CategoryId), nameof(Category.CategoryName));
                    return Page();
                }
                return RedirectToPage("403");
            }
            return RedirectToPage("404Publicacion"); 
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                Publicacion.actualizacion = DateTime.Now;
                Publicacion.especie = Publicacion.especie == "1" ? ("Perro") : ("Gato");
                if (Photo != null)
                {
                    db.DeleteFile(Publicacion.filepath);
                    var ruta = Path.Combine(environment.WebRootPath, "img", Photo.FileName);
                    int i = 0;
                    string NombreImg = Photo.FileName;
                    while (System.IO.File.Exists(ruta))
                    {
                        string aux = i.ToString();
                        NombreImg = aux + Photo.FileName;
                        ruta = Path.Combine(environment.WebRootPath, "img", NombreImg);
                        i++;
                    }
                    using (var fileStream = new FileStream(ruta, FileMode.Create))
                    {
                        await Photo.CopyToAsync(fileStream);
                    }
                    Publicacion.rutaimg = NombreImg;
                    Publicacion.filepath = ruta;
                }

                db.Publicacion.Update(Publicacion);
                await db.SaveChangesAsync();
                return RedirectToPage("Dashboard");
            }
            Categories = new SelectList(categoryService.GetCategories(), nameof(Category.CategoryId), nameof(Category.CategoryName));
            return Page();
        }
        public JsonResult OnGetSubCategories()
        {
            return new JsonResult(categoryService.GetSubCategories(CategoryId));
        }
    }
}
