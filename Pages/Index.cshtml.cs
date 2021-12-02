﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using Test_Razor.Models;

namespace Test_Razor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext db;
        private readonly ICategoryService categoryService;

        public IndexModel(ApplicationDbContext db, ICategoryService categoryService)
        {
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
            Publicaciones = FiltrarPublicaciones(Publicaciones,Filtro);
            Categories = new SelectList(categoryService.GetCategories(), nameof(Category.CategoryId), nameof(Category.CategoryName));
        }

        public IEnumerable<Publicacion> FiltrarPublicaciones(IEnumerable<Publicacion> Lista, Filtro filtro)
        {
            if (filtro.especie != null)
            {
                if (filtro.especie=="1")
                {
                    filtro.especie = "Perro";
                }
                else if (filtro.especie == "2")
                {
                    filtro.especie = "Gato";
                }
                Lista = Lista.Where(u => u.especie == filtro.especie);
            }
            if (filtro.raza != null)
            {
                Lista = Lista.Where(u => u.raza == filtro.raza);
            }
            if (filtro.genero != null)
            {
                Lista = Lista.Where(u => u.genero == filtro.genero);
            }
            if (filtro.edad != null)
            {
                Lista = Lista.Where(u => u.edad == filtro.edad);
            }
            if (filtro.pelaje != null)
            {
                Lista = Lista.Where(u => u.pelaje == filtro.pelaje);
            }
            if (filtro.color != null)
            {
                Lista = Lista.Where(u => u.color == filtro.color);
            }
            if (filtro.tamano != null)
            {
                Lista = Lista.Where(u => u.tamano == filtro.tamano);
            }
            if (filtro.estado != null)
            {
                Lista = Lista.Where(u => u.estado == filtro.estado);
            }
            if (filtro.orden != null)
            {
                if (filtro.orden == "Nombre (A-Z)")
                {
                    Lista = Lista.OrderBy(u => u.nombre);
                }
                if (filtro.orden == "Nombre (Z-A)")
                {
                    Lista = Lista.OrderByDescending(u => u.nombre);
                }
                if (filtro.orden == "Fecha (Nuevo-Antiguo)")
                {
                    Lista = Lista.OrderByDescending(u => u.fecha);
                }
                if (filtro.orden == "Fecha (Antiguo-Nuevo)")
                {
                    Lista = Lista.OrderBy(u => u.fecha);
                }
            }
            return Lista;
        }

        public JsonResult OnGetSubCategories()
        {
            return new JsonResult(categoryService.GetSubCategories(CategoryId));
        }
    }
}
