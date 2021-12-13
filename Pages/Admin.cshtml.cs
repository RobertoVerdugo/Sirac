using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Test_Razor.Models;

namespace Test_Razor.Pages
{
    [Authorize(Roles ="Admin")]
    public class AdminModel : PageModel
    {
        private readonly ApplicationDbContext db;

        public AdminModel(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Reporte> ReportesLocal;
        public IEnumerable<Reporte> ReportesActual;

        public void OnGet()
        {
            ReportesLocal = db.Reporte.ToList();
            ReportesLocal = ReportesLocal.Where(u => db.VerificarPublicacion(u.idPublicacion) == true);
            ReportesActual = PaginarReportes(ReportesLocal, 1);

        }
        public void OnPostPaginar(int id)
        {
            ReportesLocal = db.Reporte.ToList();
            ReportesLocal = ReportesLocal.Where(u => db.VerificarPublicacion(u.idPublicacion) == true);
            ReportesActual = PaginarReportes(ReportesLocal, id);
        }

        public IActionResult OnPostDelete(int id)
        {
            if (db.EliminarReporte(id))
            {
                return RedirectToPage("Admin");
            }
            else
            {
                return RedirectToPage("404Publicacion");
            }
        }

        public IEnumerable<Reporte> PaginarReportes(IEnumerable<Reporte> Local, int indice)
        {
            if (indice < 1 || indice > ((Local.Count() - 1) / 10) + 1)
            {
                indice = 1;
            }
            List<Reporte> Lista = new List<Reporte>();
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
