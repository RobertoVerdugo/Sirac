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

namespace Test_Razor.Pages
{
    public class CrearPublModel : PageModel
    {

        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> userManager;
        private readonly IWebHostEnvironment environment;

        public CrearPublModel(ApplicationDbContext db, UserManager<IdentityUser> userManager, IWebHostEnvironment environment)
        {
            _db = db;
            this.userManager = userManager;
            this.environment = environment;
        }
        
        [BindProperty]
        public Publicacion Publicacion{ get; set; }
        [BindProperty]
        [Required]
        public IFormFile Photo { get; set; }
        public void OnGet()
        {
            
        }
        public async Task<IActionResult> OnPost()
        {
            
            if (!ModelState.IsValid/*|| yaexiste || otra comprobacion*/)
            {
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
    }
}
