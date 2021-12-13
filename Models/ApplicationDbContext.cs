﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Razor.Models
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet<Publicacion> Publicacion { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Reporte> Reporte { get; set; }
        public DbSet<Visita> Visita { get; set; }
        public DbSet<Preferencia> Preferencia { get; set; }

        public bool VerificarPublicacion(int id)
        {
            Publicacion pub =  Publicacion.Find(id);
            if (pub != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ExisteUsuario(string rut)
        {
            Usuario user = Usuario.Find(rut);
            if (user != null)
            {
                return true;
            }
            return false;

        }
        public bool VerificarPropiedadUsuario(string rut, string logued)
        {
            if (ExisteUsuario(rut))
            {
                Usuario user = Usuario.Find(rut);
                if (rut == logued)
                {
                    return true;
                }
            }
            return false;
        }

        public bool EliminarPublicacion(int id)
        {
            if (VerificarPublicacion(id))
            {
                var pub = Publicacion.Find(id);
                DeleteFile(pub.filepath);
                Publicacion.Remove(pub);
                SaveChanges();
                return true;
            }
            return false;
        }
        public void DeleteFile(string path)
        {
            FileInfo file = new FileInfo(path);
            if (file.Exists)
            {
                //System.IO.File.Delete(path);
                file.Delete();
            }
        }

        public int getTotalVisitas(string rut)
        {
            int total = 0;
            IEnumerable<Visita> Visitas = Visita.ToList();
            Visitas = Visitas.Where(u => u.rut == rut);
            foreach (var visita in Visitas)
            {
                total = total + visita.ranking;
            }
            return total;
        }
    }
}
