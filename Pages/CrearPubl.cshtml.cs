using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Test_Razor.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Test_Razor.Pages
{
    public class CrearPublModel : PageModel
    {

        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment environment;

        public CrearPublModel(ApplicationDbContext db, IWebHostEnvironment environment, ICategoryService categoryService)
        {
            _db = db;
            this.environment = environment;
            this.categoryService = categoryService;
        }
        private ICategoryService categoryService;
        [BindProperty(SupportsGet = true)]
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public SelectList Categories { get; set; }

        [BindProperty]
        public Publicacion Publicacion{ get; set; }
        [BindProperty]
        [Required]
        public IFormFile Photo { get; set; }
        public void OnGet()
        {
            Categories = new SelectList(categoryService.GetCategories(), nameof(Category.CategoryId), nameof(Category.CategoryName));
        }
        public async Task<IActionResult> OnPost()
        {
            
            if (!ModelState.IsValid)
            {
                Categories = new SelectList(categoryService.GetCategories(), nameof(Category.CategoryId), nameof(Category.CategoryName));
                return Page();
            }
            var file = Path.Combine(environment.WebRootPath, "img", Photo.FileName);
            using (var fileStream = new FileStream(file, FileMode.Create))
            {
                await Photo.CopyToAsync(fileStream);
                
            }
            Publicacion.rutaimg = Photo.FileName;
            _db.Add(Publicacion);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
        public JsonResult OnGetSubCategories()
        {
            return new JsonResult(categoryService.GetSubCategories(CategoryId));
        }
    }
}
