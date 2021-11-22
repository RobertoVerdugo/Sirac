using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Razor.Models;

namespace Test_Razor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext db;
        private readonly ICategoryService categoryService;

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext db, ICategoryService categoryService)
        {
            _logger = logger;
            this.db = db;
            this.categoryService = categoryService;
        }
        [BindProperty(SupportsGet = true)]
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public SelectList Categories { get; set; }

        [BindProperty]
        public  Filtro Filtro { get; set; }

        public IEnumerable<Publicacion> Publicaciones;
        public void OnGet()
        {
            Publicaciones = db.Publicacion.ToList();
            Categories = new SelectList(categoryService.GetCategories(), nameof(Category.CategoryId), nameof(Category.CategoryName));
        }
        public void OnPost()
        {
            Publicaciones = db.Publicacion.ToList();
            if (Filtro.especie != null)
            {
                Publicaciones = Publicaciones.Where(u => u.especie == Filtro.especie);
            }
            if (Filtro.raza != null)
            {
                Publicaciones = Publicaciones.Where(u => u.raza == Filtro.raza);
            }
            if (Filtro.genero != null)
            {
                Publicaciones = Publicaciones.Where(u => u.genero == Filtro.genero);
            }
            if (Filtro.edad != null)
            {
                Publicaciones = Publicaciones.Where(u => u.edad == Filtro.edad);
            }
            if (Filtro.pelaje != null)
            {
                Publicaciones = Publicaciones.Where(u => u.pelaje == Filtro.pelaje);
            }
            if (Filtro.color != null)
            {
                Publicaciones = Publicaciones.Where(u => u.color == Filtro.color);
            }
            if (Filtro.tamano != null)
            {
                Publicaciones = Publicaciones.Where(u => u.tamano == Filtro.tamano);
            }
            if (Filtro.estado != null)
            {
                Publicaciones = Publicaciones.Where(u => u.estado == Filtro.estado);
            }
            if (Filtro.orden!= null)
            {
                if (Filtro.orden== "Nombre (A-Z)")
                {
                    Publicaciones = Publicaciones.OrderBy(u => u.nombre);
                }
                if (Filtro.orden == "Nombre (Z-A)")
                {
                    Publicaciones = Publicaciones.OrderByDescending(u => u.nombre);
                }
                if (Filtro.orden == "Fecha (Nuevo-Antiguo)")
                {
                    Publicaciones = Publicaciones.OrderByDescending(u => u.fecha);
                }
                if (Filtro.orden == "Fecha (Antiguo-Nuevo)")
                {
                    Publicaciones = Publicaciones.OrderBy(u => u.fecha);
                }
            }
            Categories = new SelectList(categoryService.GetCategories(), nameof(Category.CategoryId), nameof(Category.CategoryName));
        }
        public JsonResult OnGetSubCategories()
        {
            return new JsonResult(categoryService.GetSubCategories(CategoryId));
        }
    }
}
