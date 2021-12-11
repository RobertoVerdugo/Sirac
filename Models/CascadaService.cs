﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Razor.Pages
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetCategories();
        IEnumerable<SubCategory> GetSubCategories(int categoryId);
    }
    public class CascadaService : ICategoryService
    {
        public IEnumerable<Category> GetCategories()
        {
            return new List<Category>
        {
            new Category { CategoryId = 1, CategoryName="Perro" },
            new Category { CategoryId = 2, CategoryName="Gato" },
        };
        }
        public IEnumerable<SubCategory> GetSubCategories(int categoryId)
        {
            var subCategories = new List<SubCategory> {
            new SubCategory { SubCategoryId = 1, CategoryId = 1, SubCategoryName="Pastor de Bergamo" },
            new SubCategory { SubCategoryId = 2, CategoryId = 1, SubCategoryName="Schnoodle" },
            new SubCategory { SubCategoryId = 3, CategoryId = 1, SubCategoryName="Galgo" },
            new SubCategory { SubCategoryId = 4, CategoryId = 1, SubCategoryName="Labrador Retriever" },
            new SubCategory { SubCategoryId = 5, CategoryId = 1, SubCategoryName="Elkhound" },
            new SubCategory { SubCategoryId = 6, CategoryId = 1, SubCategoryName="Keeshoun" },
            new SubCategory { SubCategoryId = 7, CategoryId = 1, SubCategoryName="Pastor Caucasico" },
            new SubCategory { SubCategoryId = 8, CategoryId = 1, SubCategoryName="Basset Hound" },
            new SubCategory { SubCategoryId = 9, CategoryId = 1, SubCategoryName="Kangal turco" },
            new SubCategory { SubCategoryId = 10, CategoryId = 1, SubCategoryName="Pastor ganadero australiano" },
            new SubCategory { SubCategoryId = 11, CategoryId = 1, SubCategoryName="Xoloitzcuintle" },
            new SubCategory { SubCategoryId = 12, CategoryId = 1, SubCategoryName="Corgi gales de Pembroke" },
            new SubCategory { SubCategoryId = 13, CategoryId = 1, SubCategoryName="Perro Lobo Checoslovaco" },
            new SubCategory { SubCategoryId = 14, CategoryId = 1, SubCategoryName="Alaskan Malamute" },
            new SubCategory { SubCategoryId = 15, CategoryId = 1, SubCategoryName="Mastin tibetano" },
            new SubCategory { SubCategoryId = 16, CategoryId = 1, SubCategoryName="Shar Pei" },
            new SubCategory { SubCategoryId = 17, CategoryId = 1, SubCategoryName="Galgo italiano" },
            new SubCategory { SubCategoryId = 18, CategoryId = 1, SubCategoryName="Spaniel Breton" },
            new SubCategory { SubCategoryId = 19, CategoryId = 1, SubCategoryName="Ratonero Bodeguero Andaluz" },
            new SubCategory { SubCategoryId = 20, CategoryId = 1, SubCategoryName="Fox Terrier" },
            new SubCategory { SubCategoryId = 21, CategoryId = 1, SubCategoryName="BullMastiff" },
            new SubCategory { SubCategoryId = 22, CategoryId = 1, SubCategoryName="Pastor Yugoslavo" },
            new SubCategory { SubCategoryId = 23, CategoryId = 1, SubCategoryName="Braco de Weimar" },
            new SubCategory { SubCategoryId = 24, CategoryId = 1, SubCategoryName="Setter Ingles" },
            new SubCategory { SubCategoryId = 25, CategoryId = 1, SubCategoryName="Sabueso español" },
            new SubCategory { SubCategoryId = 26, CategoryId = 1, SubCategoryName="Boyero de Berna" },
            new SubCategory { SubCategoryId = 27, CategoryId = 1, SubCategoryName="Grifon de Bruselas" },
            new SubCategory { SubCategoryId = 28, CategoryId = 1, SubCategoryName="Dogo de Burdeos" },
            new SubCategory { SubCategoryId = 29, CategoryId = 1, SubCategoryName="Lobero irlandes" },
            new SubCategory { SubCategoryId = 30, CategoryId = 1, SubCategoryName="Lhasa Apso" },
            new SubCategory { SubCategoryId = 31, CategoryId = 1, SubCategoryName="Bulldog Ingles" },
            new SubCategory { SubCategoryId = 32, CategoryId = 1, SubCategoryName="Cavalier King Charles Spaniel" },
            new SubCategory { SubCategoryId = 33, CategoryId = 1, SubCategoryName="Perro Pequines" },
            new SubCategory { SubCategoryId = 34, CategoryId = 1, SubCategoryName="Pug" },
            new SubCategory { SubCategoryId = 35, CategoryId = 1, SubCategoryName="Parson Russel Terrier" },
            new SubCategory { SubCategoryId = 36, CategoryId = 1, SubCategoryName="Braco aleman" },
            new SubCategory { SubCategoryId = 37, CategoryId = 1, SubCategoryName="Jack Russell Terrier" },
            new SubCategory { SubCategoryId = 38, CategoryId = 1, SubCategoryName="Pachon Navarro" },
            new SubCategory { SubCategoryId = 39, CategoryId = 1, SubCategoryName="Westie" },
            new SubCategory { SubCategoryId = 40, CategoryId = 1, SubCategoryName="Galgo Español" },
            new SubCategory { SubCategoryId = 41, CategoryId = 1, SubCategoryName="Mastin Español" },
            new SubCategory { SubCategoryId = 42, CategoryId = 1, SubCategoryName="San Bernardo" },
            new SubCategory { SubCategoryId = 43, CategoryId = 1, SubCategoryName="Gran Danes" },
            new SubCategory { SubCategoryId = 44, CategoryId = 1, SubCategoryName="Pinscher miniatura" },
            new SubCategory { SubCategoryId = 45, CategoryId = 1, SubCategoryName="Podenco andaluz" },
            new SubCategory { SubCategoryId = 46, CategoryId = 1, SubCategoryName="Braco de Burgos" },
            new SubCategory { SubCategoryId = 47, CategoryId = 1, SubCategoryName="Perro de Aguas Español" },
            new SubCategory { SubCategoryId = 48, CategoryId = 1, SubCategoryName="Dogo Argentino" },
            new SubCategory { SubCategoryId = 49, CategoryId = 1, SubCategoryName="Pomerania" },
            new SubCategory { SubCategoryId = 50, CategoryId = 1, SubCategoryName="Mastin del Pirineo" },
            new SubCategory { SubCategoryId = 51, CategoryId = 1, SubCategoryName="Rottweiler" },
            new SubCategory { SubCategoryId = 52, CategoryId = 1, SubCategoryName="Chow Chow" },
            new SubCategory { SubCategoryId = 53, CategoryId = 1, SubCategoryName="Samoyedo" },
            new SubCategory { SubCategoryId = 54, CategoryId = 1, SubCategoryName="Bobtail" },
            new SubCategory { SubCategoryId = 55, CategoryId = 1, SubCategoryName="Teckel" },
            new SubCategory { SubCategoryId = 56, CategoryId = 1, SubCategoryName="Shih Tzu" },
            new SubCategory { SubCategoryId = 57, CategoryId = 1, SubCategoryName="Caniche" },
            new SubCategory { SubCategoryId = 58, CategoryId = 1, SubCategoryName="Pitbull" },
            new SubCategory { SubCategoryId = 59, CategoryId = 1, SubCategoryName="Bichon Maltes" },
            new SubCategory { SubCategoryId = 60, CategoryId = 1, SubCategoryName="Husky Siberiano" },
            new SubCategory { SubCategoryId = 61, CategoryId = 1, SubCategoryName="Cocker Spaniel" },
            new SubCategory { SubCategoryId = 62, CategoryId = 1, SubCategoryName="Border Collie" },
            new SubCategory { SubCategoryId = 63, CategoryId = 1, SubCategoryName="Dalmata" },
            new SubCategory { SubCategoryId = 64, CategoryId = 1, SubCategoryName="Beagle" },
            new SubCategory { SubCategoryId = 65, CategoryId = 1, SubCategoryName="Dobermann" },
            new SubCategory { SubCategoryId = 66, CategoryId = 1, SubCategoryName="Yorkshire Terrier" },
            new SubCategory { SubCategoryId = 67, CategoryId = 1, SubCategoryName="Pastor Vasco" },
            new SubCategory { SubCategoryId = 68, CategoryId = 1, SubCategoryName="Schnauzer enano" },
            new SubCategory { SubCategoryId = 69, CategoryId = 1, SubCategoryName="Vizsla" },
            new SubCategory { SubCategoryId = 70, CategoryId = 1, SubCategoryName="Pastor Aleman" },
            new SubCategory { SubCategoryId = 71, CategoryId = 1, SubCategoryName="Retriever" },
            new SubCategory { SubCategoryId = 72, CategoryId = 1, SubCategoryName="Boxer" },
            new SubCategory { SubCategoryId = 73, CategoryId = 1, SubCategoryName="Akita Inu" },
            new SubCategory { SubCategoryId = 74, CategoryId = 1, SubCategoryName="Galgo Afgano" },
            new SubCategory { SubCategoryId = 75, CategoryId = 1, SubCategoryName="Golden Retriever" },
            new SubCategory { SubCategoryId = 76, CategoryId = 1, SubCategoryName="Bulldog Frances" },
            new SubCategory { SubCategoryId = 77, CategoryId = 1, SubCategoryName="Chihuahua" },

            new SubCategory { SubCategoryId = 78, CategoryId = 2, SubCategoryName="LaPerm" },
            new SubCategory { SubCategoryId = 79, CategoryId = 2, SubCategoryName="Burmilla" },
            new SubCategory { SubCategoryId = 80, CategoryId = 2, SubCategoryName="Curl Americano" },
            new SubCategory { SubCategoryId = 81, CategoryId = 2, SubCategoryName="Montes" },
            new SubCategory { SubCategoryId = 82, CategoryId = 2, SubCategoryName="Burmes" },
            new SubCategory { SubCategoryId = 83, CategoryId = 2, SubCategoryName="Munchkin" },
            new SubCategory { SubCategoryId = 84, CategoryId = 2, SubCategoryName="Shausie" },
            new SubCategory { SubCategoryId = 85, CategoryId = 2, SubCategoryName="Devon Rex" },
            new SubCategory { SubCategoryId = 86, CategoryId = 2, SubCategoryName="Javanes" },
            new SubCategory { SubCategoryId = 87, CategoryId = 2, SubCategoryName="Scottish Fold" },
            new SubCategory { SubCategoryId = 88, CategoryId = 2, SubCategoryName="Van Turco" },
            new SubCategory { SubCategoryId = 89, CategoryId = 2, SubCategoryName="Korat" },
            new SubCategory { SubCategoryId = 90, CategoryId = 2, SubCategoryName="Somali" },
            new SubCategory { SubCategoryId = 91, CategoryId = 2, SubCategoryName="Sphynx" },
            new SubCategory { SubCategoryId = 92, CategoryId = 2, SubCategoryName="Savannah" },
            new SubCategory { SubCategoryId = 93, CategoryId = 2, SubCategoryName="Chartreux" },
            new SubCategory { SubCategoryId = 94, CategoryId = 2, SubCategoryName="Sokoke" },
            new SubCategory { SubCategoryId = 95, CategoryId = 2, SubCategoryName="Selkirk Rex" },
            new SubCategory { SubCategoryId = 96, CategoryId = 2, SubCategoryName="Nebelung" },
            new SubCategory { SubCategoryId = 97, CategoryId = 2, SubCategoryName="Lykoi" },
            new SubCategory { SubCategoryId = 98, CategoryId = 2, SubCategoryName="Cornish Rex" },
            new SubCategory { SubCategoryId = 99, CategoryId = 2, SubCategoryName="Ocicat" },
            new SubCategory { SubCategoryId = 100, CategoryId = 2, SubCategoryName="Peterbald" },
            new SubCategory { SubCategoryId = 101, CategoryId = 2, SubCategoryName="Oriental de pelo corto" },
            new SubCategory { SubCategoryId = 102, CategoryId = 2, SubCategoryName="Siberiano" },
            new SubCategory { SubCategoryId = 103, CategoryId = 2, SubCategoryName="Manx" },
            new SubCategory { SubCategoryId = 104, CategoryId = 2, SubCategoryName="Exotico de pelo corto" },
            new SubCategory { SubCategoryId = 105, CategoryId = 2, SubCategoryName="Birmano" },
            new SubCategory { SubCategoryId = 106, CategoryId = 2, SubCategoryName="Bosque de Noruega" },
            new SubCategory { SubCategoryId = 107, CategoryId = 2, SubCategoryName="Snowshoe" },
            new SubCategory { SubCategoryId = 108, CategoryId = 2, SubCategoryName="Bengali" },
            new SubCategory { SubCategoryId = 109, CategoryId = 2, SubCategoryName="Ashera" },
            new SubCategory { SubCategoryId = 110, CategoryId = 2, SubCategoryName="Abisinio" },
            new SubCategory { SubCategoryId = 111, CategoryId = 2, SubCategoryName="Balines" },
            new SubCategory { SubCategoryId = 112, CategoryId = 2, SubCategoryName="Maine Coon" },
            new SubCategory { SubCategoryId = 113, CategoryId = 2, SubCategoryName="British shorthair" },
            new SubCategory { SubCategoryId = 114, CategoryId = 2, SubCategoryName="Azul Ruso" },
            new SubCategory { SubCategoryId = 115, CategoryId = 2, SubCategoryName="Bombay" },
            new SubCategory { SubCategoryId = 116, CategoryId = 2, SubCategoryName="Europeo" },
            new SubCategory { SubCategoryId = 117, CategoryId = 2, SubCategoryName="Mau Egipcio" },
            new SubCategory { SubCategoryId = 118, CategoryId = 2, SubCategoryName="Australian Mist" },
            new SubCategory { SubCategoryId = 119, CategoryId = 2, SubCategoryName="Himalayo" },
            new SubCategory { SubCategoryId = 120, CategoryId = 2, SubCategoryName="Habana" },
            new SubCategory { SubCategoryId = 121, CategoryId = 2, SubCategoryName="Persa" },
            new SubCategory { SubCategoryId = 122, CategoryId = 2, SubCategoryName="Siames" },
            new SubCategory { SubCategoryId = 123, CategoryId = 2, SubCategoryName="Ragdoll" },
        };
            List<SubCategory> listaOrdenada = subCategories.OrderBy(o => o.SubCategoryName).ToList();
            listaOrdenada.Add(new SubCategory { SubCategoryId = 124, CategoryId = 1, SubCategoryName = "Otro/Desconocido" });
            listaOrdenada.Add(new SubCategory { SubCategoryId = 125, CategoryId = 2, SubCategoryName = "Otro/Desconocido" });
            return listaOrdenada.Where(s => s.CategoryId == categoryId);
        }
    }
}