using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public EditarPublModel(ApplicationDbContext db, ICategoryService categoryService, UserManager<IdentityUser> userManager)
        {
            this.db = db;
            this.categoryService = categoryService;
            this.userManager = userManager;
        }
        private ICategoryService categoryService;
        private readonly UserManager<IdentityUser> userManager;

        [BindProperty(SupportsGet = true)]
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public SelectList Categories { get; set; }

        [BindProperty]
        public Publicacion Publicacion { get; set; }
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
