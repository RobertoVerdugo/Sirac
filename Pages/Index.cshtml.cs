﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Razor.Models;

namespace Test_Razor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext db;
        private readonly ICategoryService categoryService;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public IndexModel(ApplicationDbContext db, ICategoryService categoryService, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.db = db;
            this.categoryService = categoryService;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        [BindProperty(SupportsGet = true)]
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public SelectList Categories { get; set; }

        [BindProperty]
        public Filtro Filtro { get; set; }
        [BindProperty]
        public string Orden { get; set; }
        public string rut { get; set; }
        public Preferencia Preferencia { get; set; }
        public IEnumerable<Publicacion> ListaGlobal;
        public IEnumerable<Publicacion> ListaLocal;
        public IEnumerable<Publicacion> ListaActual;
        public IEnumerable<Publicacion> ListaContenido;
        public void OnGet()
        {
            ListaGlobal = db.Publicacion.ToList();
            if (signInManager.IsSignedIn(User))
            {
                rut = userManager.GetUserName(User);
                Preferencia = db.Preferencia.Find(rut);
                ListaContenido = CrearListaContenido(ListaGlobal, Preferencia, Preferencia.getTotalPuntos());
            }
            
            ListaLocal = ListaGlobal;
            ListaActual = PaginarPublicaciones(ListaLocal, 1);
            Categories = new SelectList(categoryService.GetCategories(), nameof(Category.CategoryId), nameof(Category.CategoryName));
        }
        public void OnPost()
        {
            ListaGlobal = db.Publicacion.ToList();
            if (signInManager.IsSignedIn(User))
            {
                rut = userManager.GetUserName(User);
                Preferencia = db.Preferencia.Find(rut);
                ListaContenido = CrearListaContenido(ListaGlobal, Preferencia, Preferencia.getTotalPuntos());
            }
            ListaLocal = FiltrarPublicaciones(ListaGlobal,Filtro);
            ListaLocal = OrdenarPublicaciones(ListaLocal, Orden, rut);
            ListaActual = PaginarPublicaciones(ListaLocal, 1);
            Categories = new SelectList(categoryService.GetCategories(), nameof(Category.CategoryId), nameof(Category.CategoryName));
        }
        public void OnPostPaginar(int id)
        {
            ListaGlobal = db.Publicacion.ToList();
            if (signInManager.IsSignedIn(User))
            {
                rut = userManager.GetUserName(User);
                Preferencia = db.Preferencia.Find(rut);
                ListaContenido = CrearListaContenido(ListaGlobal, Preferencia, Preferencia.getTotalPuntos());
            }
            ListaLocal = FiltrarPublicaciones(ListaGlobal,Filtro);
            ListaLocal = OrdenarPublicaciones(ListaLocal, Orden,rut);
            ListaActual = PaginarPublicaciones(ListaLocal, id);
            Categories = new SelectList(categoryService.GetCategories(), nameof(Category.CategoryId), nameof(Category.CategoryName));
        }

        public IEnumerable<Publicacion> CrearListaContenido(IEnumerable<Publicacion> Global, Preferencia preferencia, int totalPuntos)
        {
            IEnumerable<Publicacion> ListaContenido = Global;
            if (preferencia != null && totalPuntos >= 1)
            {
                preferencia = preferencia.normalizarPreferencia(preferencia, totalPuntos);
                foreach (var pub in ListaContenido)
                {
                    pub.scoreContenido = preferencia.calcularScore(pub);
                }
                ListaContenido = ListaContenido.OrderByDescending(u => u.scoreContenido);
                return ListaContenido.Take(3);
            }
            return new List<Publicacion>();
        }

        public IEnumerable<Publicacion> PaginarPublicaciones(IEnumerable<Publicacion> Local, int indice)
        {
            if (indice<1 || indice > ((Local.Count()-1)/10) + 1)
            {
                indice = 1;
            }
            List<Publicacion> Lista = new List<Publicacion>();
            int i = ((10 * indice) - 10);
            while (i< ((10 * indice)) && i < Local.Count())
            {
                Lista.Add(Local.ElementAt(i));
                i++;
            }
            return Lista;
        }
        public IEnumerable<Publicacion> FiltrarPublicaciones(IEnumerable<Publicacion> Global, Filtro filtro)
        {
            IEnumerable<Publicacion> Lista = Global;
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
            return Lista;
        }
        public IEnumerable<Publicacion> OrdenarPublicaciones(IEnumerable<Publicacion> Filtrada, string orden, string rut)
        {
            IEnumerable<Publicacion> Lista = Filtrada;
            if (orden != null)
            {
                if (orden == "Nombre (A-Z)")
                {
                    Lista = Lista.OrderBy(u => u.nombre);
                }
                if (orden == "Nombre (Z-A)")
                {
                    Lista = Lista.OrderByDescending(u => u.nombre);
                }
                if (orden == "Fecha (Nuevo-Antiguo)")
                {
                    Lista = Lista.OrderByDescending(u => u.actualizacion);
                }
                if (orden == "Fecha (Antiguo-Nuevo)")
                {
                    Lista = Lista.OrderBy(u => u.actualizacion);
                }
                if (orden == "Recomendados")
                {
                    foreach (var pub in Lista)
                    {
                        var datos = new MLModel.ModelInput()
                        {
                            Id = 1,
                            Rut = rut,
                            IdPublicacion = pub.id,
                        };
                        var result = MLModel.Predict(datos);
                        pub.score = result.Score;
                    }
                    Lista = Lista.OrderByDescending(u => u.score);
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
