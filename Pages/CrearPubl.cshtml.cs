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
        [Required(ErrorMessage = "Ingrese una imagen del animal")]
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
            Publicacion.actualizacion = Publicacion.fecha;
            Publicacion.rutaimg = NombreImg;
            Publicacion.filepath = ruta;
            Publicacion.especie = Publicacion.especie == "1" ? ("Perro") : ("Gato");
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

//Test de abuso
/* for(int i = 0; i < 10; i++)
            {
                _db.Add(new Publicacion() { 
                    fecha= Publicacion.fecha,
                    actualizacion = Publicacion.fecha,
                    especie = Publicacion.especie,
                    raza = Publicacion.raza,
                    color = Publicacion.color,
                    pelaje = Publicacion.pelaje,
                    genero = Publicacion.genero,
                    tamano = Publicacion.tamano,
                    edad = Publicacion.edad,
                    rut = Publicacion.rut,
                    ubicacion = Publicacion.ubicacion,
                    estado = Publicacion.estado,
                    descripcion = Publicacion.descripcion,
                    rutaimg =Photo.FileName, 
                    nombre= "TestAbusoInducido" 
                
                });
            }*/