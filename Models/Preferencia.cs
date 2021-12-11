using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Razor.Models
{
    public class Preferencia
    {
        [Key]
        [MaxLength(12)]
        public string rut { get; set; }

        public int Macho { get; set; }
        public int Hembra { get; set; }
        public int Cachorro { get; set; }
        public int Adulto { get; set; }
        public int Senior { get; set; }
        public int Desconocido { get; set; }
        public int Duro { get; set; }
        public int Rizado { get; set; }
        public int Corto { get; set; }
        public int Largo { get; set; }
        public int Lampino { get; set; }
        public int Negro { get; set; }
        public int Blanco { get; set; }
        public int Beige { get; set; }
        public int Gris { get; set; }
        public int Cafe { get; set; }
        public int Cafe_Claro { get; set; }
        public int Cafe_Oscuro { get; set; }
        public int Anaranjado { get; set; }
        public int Rubio { get; set; }
        public int Otro_Color { get; set; }
        public int Pequeno { get; set; }
        public int Mediano { get; set; }
        public int Grande { get; set; }
        public int Perro { get; set; }
        public int Gato { get; set; }
        public int Pastor_Bergamo { get; set; }
        public int Schnoodle { get; set; }
        public int Galgo { get; set; }
        public int Labrador_Retriever { get; set; }
        public int Elkhound { get; set; }
        public int Keeshoun { get; set; }
        public int Pastor_Caucasico { get; set; }
        public int Basset_Hound { get; set; }
        public int Kagnal_Turco { get; set; }
        public int Pastor_Australiano { get; set; }
        public int Xoloitzcuintle { get; set; }
        public int Corgi_Gales { get; set; }
        public int Perro_Lobo { get; set; }
        public int Alaskan_Malamute { get; set; }
        public int Mastin_Tibetano { get; set; }
        public int Shar_Pei { get; set; }
        public int Galgo_Italiano { get; set; }
        public int Spaniel_Breton { get; set; }
        public int Ratonero_Andaluz { get; set; }
        public int Fox_Terrier { get; set; }
        public int Bull_Mastiff { get; set; }
        public int Pastor_Yugoslavo { get; set; }
        public int Braco_Weimar { get; set; }
        public int Setter_Ingles { get; set; }
        public int Sabueso_Espanol { get; set; }
        public int Boyero_Berna { get; set; }
        public int Grifon_Bruselas { get; set; }
        public int Dogo_Burdeos { get; set; }
        public int Lobero_Irlandes { get; set; }
        public int Lhasa_Apso { get; set; }
        public int Bulldog_Ingles { get; set; }
        public int Cavalier_King { get; set; }
        public int Perro_Pequines { get; set; }
        public int Pug { get; set; }
        public int Parson_Russell { get; set; }
        public int Braco_Aleman { get; set; }
        public int Jack_Russell { get; set; }
        public int Pachon_Navarro { get; set; }
        public int Westie { get; set; }
        public int Galgo_Espanol { get; set; }
        public int Mastin_Espanol { get; set; }
        public int San_Bernardo { get; set; }
        public int Gran_Danes { get; set; }
        public int Pinscher { get; set; }
        public int Podenco_Andaluz { get; set; }
        public int Braco_Burgos { get; set; }
        public int Perro_Aguas_Espanol { get; set; }
        public int Dogo_Argentino { get; set; }
        public int Pomerania { get; set; }
        public int Mastin_Prineo { get; set; }
        public int Rottweiler { get; set; }
        public int Chow_Chow { get; set; }
        public int Samoyedo { get; set; }
        public int Bobtail { get; set; }
        public int Teckel { get; set; }
        public int Shih_Tzu { get; set; }
        public int Caniche { get; set; }
        public int Pitbull { get; set; }
        public int Bichon_Maltes { get; set; }
        public int Husky_Siberiano { get; set; }
        public int Cocker_Spaniel { get; set; }
        public int Border_Collie { get; set; }
        public int Dalmata { get; set; }
        public int Beagle { get; set; }
        public int Dobbermann { get; set; }
        public int Yorkshire_Terrier { get; set; }
        public int Pastor_Vasco { get; set; }
        public int Schnauzer_Enano { get; set; }
        public int Vizsla { get; set; }
        public int Pastor_Aleman { get; set; }
        public int Retriever { get; set; }
        public int Boxer { get; set; }
        public int Akita_Inu { get; set; }
        public int Galgo_Afgano { get; set; }
        public int Golden_Retriever { get; set; }
        public int Bulldog_Frances { get; set; }
        public int Chihuahua { get; set; }
        //Gatos
        public int LaPerm { get; set; }
        public int Burmilla { get; set; }
        public int Curl_Americano { get; set; }
        public int Montes { get; set; }
        public int Burmes { get; set; }
        public int Munchkin { get; set; }
        public int Shausie { get; set; }
        public int Devon_Rex { get; set; }
        public int Javanes { get; set; }
        public int Scottish_Fold { get; set; }
        public int Van_Turco { get; set; }
        public int Korat { get; set; }
        public int Somali { get; set; }
        public int Sphynx { get; set; }
        public int Savannah { get; set; }
        public int Chartreux { get; set; }
        public int Sokoke { get; set; }
        public int Selkirk_Rex { get; set; }
        public int Nebelung { get; set; }
        public int Lykoi { get; set; }
        public int Cornish_Rex { get; set; }
        public int Ocicat { get; set; }
        public int Peterbald { get; set; }
        public int Oriental_PeloCorto { get; set; }
        public int Siberiano { get; set; }
        public int Manx { get; set; }
        public int Exotico_Pelocorto { get; set; }
        public int Birmano { get; set; }
        public int Bosque_Noruega { get; set; }
        public int Snowshoe { get; set; }
        public int Bengali { get; set; }
        public int Ashera { get; set; }
        public int Abisinio { get; set; }
        public int Balines { get; set; }
        public int Maine_Coon { get; set; }
        public int British_Shorthair { get; set; }
        public int Azul_Ruso { get; set; }
        public int Bombay { get; set; }
        public int Europeo { get; set; }
        public int Mau_Egipcio { get; set; }
        public int Australian_Mist { get; set; }
        public int Himalayo { get; set; }
        public int Habana { get; set; }
        public int Persa { get; set; }
        public int Siames { get; set; }
        public int Ragdoll { get; set; }
        public int Otro_Raza { get; set; }


        public Preferencia updtPreferencia(Preferencia antigua, Publicacion pub)
        {
            Preferencia pref = antigua;
            string genero = pub.genero;
            string edad = pub.edad;
            string tamano = pub.tamano;
            string pelaje = pub.pelaje;
            string color = pub.color;
            string especie = pub.especie;
            string raza = pub.raza;
            pref = updtGenero(pref, genero);
            pref = updtEdad(pref, edad);
            pref = updtTamano(pref, tamano);
            pref = updtPelaje(pref, pelaje);
            pref = updtColor(pref, color);
            pref = updtEspecie(pref, especie);
            pref = updtRaza(pref, raza);

            return new Preferencia();
        }
        public Preferencia normalizarPreferencia(Preferencia antigua, int TotalVisitas)
        {
            Preferencia pref = antigua;
            pref.Abisinio = pref.Abisinio / TotalVisitas;
            pref.Adulto = pref.Adulto / TotalVisitas;
            pref.Akita_Inu = pref.Akita_Inu / TotalVisitas;
            pref.Alaskan_Malamute = pref.Alaskan_Malamute / TotalVisitas;
            pref.Anaranjado = pref.Anaranjado / TotalVisitas;
            pref.Ashera= pref.Ashera / TotalVisitas;
            pref.Australian_Mist = pref.Australian_Mist / TotalVisitas;
            pref.Azul_Ruso = pref.Azul_Ruso / TotalVisitas;
            pref.Balines = pref.Balines / TotalVisitas;
            pref.Basset_Hound = pref.Basset_Hound / TotalVisitas;
            pref.Beagle = pref.Beagle / TotalVisitas;
            pref.Beige = pref.Beige / TotalVisitas;
            pref.Bengali = pref.Bengali / TotalVisitas;
            pref.Bichon_Maltes = pref.Bichon_Maltes / TotalVisitas;
            pref.Birmano = pref.Birmano / TotalVisitas;
            pref.Blanco = pref.Blanco / TotalVisitas;
            pref.Bobtail = pref.Bobtail / TotalVisitas;
            pref.Bombay = pref.Bombay / TotalVisitas;
            pref.Border_Collie = pref.Border_Collie / TotalVisitas;
            pref.Bosque_Noruega = pref.Bosque_Noruega / TotalVisitas;
            pref.Boxer = pref.Boxer / TotalVisitas;
            pref.Boyero_Berna = pref.Boyero_Berna / TotalVisitas;
            pref.Braco_Aleman = pref.Braco_Aleman / TotalVisitas;
            pref.Braco_Burgos = pref.Braco_Burgos / TotalVisitas;
            pref.Braco_Weimar = pref.Braco_Weimar / TotalVisitas;
            pref.British_Shorthair = pref.British_Shorthair / TotalVisitas;
            pref.Bulldog_Frances = pref.Bulldog_Frances / TotalVisitas;
            pref.Bulldog_Ingles = pref.Bulldog_Ingles / TotalVisitas;
            pref.Bull_Mastiff = pref.Bull_Mastiff / TotalVisitas;
            pref.Burmes = pref.Burmes / TotalVisitas;
            pref.Burmilla = pref.Burmilla / TotalVisitas;
            pref.Cachorro = pref.Cachorro / TotalVisitas;
            pref.Cafe = pref.Cafe / TotalVisitas;
            pref.Cafe_Claro = pref.Cafe_Claro / TotalVisitas;
            pref.Cafe_Oscuro = pref.Cafe_Oscuro / TotalVisitas;
            pref.Caniche = pref.Caniche / TotalVisitas;
            pref.Cavalier_King = pref.Cavalier_King / TotalVisitas;
            pref.Chartreux = pref.Chartreux / TotalVisitas;
            pref.Chihuahua = pref.Chihuahua / TotalVisitas;
            pref.Chow_Chow = pref.Chow_Chow / TotalVisitas;
            pref.Cocker_Spaniel = pref.Cocker_Spaniel / TotalVisitas;
            pref.Corgi_Gales = pref.Corgi_Gales / TotalVisitas;
            pref.Cornish_Rex = pref.Cornish_Rex / TotalVisitas;
            pref.Corto = pref.Corto / TotalVisitas;
            pref.Curl_Americano = pref.Curl_Americano / TotalVisitas;
            pref.Dalmata = pref.Dalmata / TotalVisitas;
            pref.Desconocido = pref.Desconocido / TotalVisitas;
            pref.Devon_Rex = pref.Devon_Rex / TotalVisitas;
            pref.Dobbermann = pref.Dobbermann / TotalVisitas;
            pref.Dogo_Argentino = pref.Dogo_Argentino / TotalVisitas;
            pref.Dogo_Burdeos = pref.Dogo_Burdeos / TotalVisitas;
            pref.Duro = pref.Duro / TotalVisitas;
            pref.Elkhound = pref.Elkhound / TotalVisitas;
            pref.Europeo = pref.Europeo / TotalVisitas;
            pref.Exotico_Pelocorto = pref.Exotico_Pelocorto / TotalVisitas;
            pref.Fox_Terrier = pref.Fox_Terrier / TotalVisitas;
            pref.Galgo = pref.Galgo / TotalVisitas;
            pref.Galgo_Afgano = pref.Galgo_Afgano / TotalVisitas;
            pref.Galgo_Espanol = pref.Galgo_Espanol / TotalVisitas;
            pref.Galgo_Italiano = pref.Galgo_Italiano / TotalVisitas;
            pref.Gato = pref.Gato / TotalVisitas;
            pref.Golden_Retriever = pref.Golden_Retriever / TotalVisitas;
            pref.Grande = pref.Grande / TotalVisitas;
            pref.Gran_Danes = pref.Grifon_Bruselas / TotalVisitas;
            pref.Gris = pref.Gris / TotalVisitas;
            pref.Habana = pref.Habana / TotalVisitas;
            pref.Hembra = pref.Hembra / TotalVisitas;
            pref.Himalayo = pref.Himalayo / TotalVisitas;
            pref.Husky_Siberiano = pref.Husky_Siberiano / TotalVisitas;
            pref.Jack_Russell = pref.Jack_Russell / TotalVisitas;
            pref.Javanes = pref.Javanes / TotalVisitas;
            pref.Kagnal_Turco = pref.Kagnal_Turco / TotalVisitas;
            pref.Keeshoun = pref.Keeshoun / TotalVisitas;
            pref.Korat = pref.Korat / TotalVisitas;
            pref.Labrador_Retriever = pref.Labrador_Retriever / TotalVisitas;
            pref.Lampino = pref.Lampino / TotalVisitas;
            pref.LaPerm = pref.LaPerm / TotalVisitas;
            pref.Largo = pref.Largo / TotalVisitas;
            pref.Lhasa_Apso = pref.Lhasa_Apso / TotalVisitas;
            pref.Lobero_Irlandes = pref.Lobero_Irlandes / TotalVisitas;
            pref.Lykoi = pref.Lykoi / TotalVisitas;
            pref.Macho = pref.Macho / TotalVisitas;
            pref.Maine_Coon = pref.Maine_Coon / TotalVisitas;
            pref.Manx = pref.Manx / TotalVisitas;
            pref.Mastin_Espanol = pref.Mastin_Espanol / TotalVisitas;
            pref.Mastin_Prineo = pref.Mastin_Prineo / TotalVisitas;
            pref.Mastin_Tibetano = pref.Mastin_Tibetano / TotalVisitas;
            pref.Mau_Egipcio = pref.Mau_Egipcio / TotalVisitas;
            pref.Mediano = pref.Mediano / TotalVisitas;
            pref.Montes = pref.Montes / TotalVisitas;
            pref.Munchkin = pref.Munchkin / TotalVisitas;
            pref.Nebelung = pref.Nebelung / TotalVisitas;
            pref.Negro = pref.Negro / TotalVisitas;
            pref.Ocicat = pref.Ocicat / TotalVisitas;
            pref.Oriental_PeloCorto = pref.Oriental_PeloCorto / TotalVisitas;
            pref.Otro_Color = pref.Otro_Color / TotalVisitas;
            pref.Otro_Raza = pref.Otro_Raza / TotalVisitas;
            pref.Pachon_Navarro = pref.Pachon_Navarro / TotalVisitas;
            pref.Parson_Russell = pref.Parson_Russell / TotalVisitas;
            pref.Pastor_Aleman = pref.Pastor_Aleman / TotalVisitas;
            pref.Pastor_Australiano = pref.Pastor_Australiano / TotalVisitas;
            pref.Pastor_Bergamo = pref.Pastor_Bergamo / TotalVisitas;
            pref.Pastor_Caucasico = pref.Pastor_Caucasico / TotalVisitas;
            pref.Pastor_Vasco = pref.Pastor_Vasco / TotalVisitas;
            pref.Pastor_Yugoslavo = pref.Pastor_Yugoslavo / TotalVisitas;
            pref.Pequeno = pref.Pequeno / TotalVisitas;
            pref.Perro = pref.Perro / TotalVisitas;
            pref.Perro_Aguas_Espanol = pref.Perro_Aguas_Espanol / TotalVisitas;
            pref.Perro_Lobo = pref.Perro_Lobo / TotalVisitas;
            pref.Perro_Pequines = pref.Perro_Pequines / TotalVisitas;
            pref.Persa = pref.Persa / TotalVisitas;
            pref.Peterbald = pref.Peterbald / TotalVisitas;
            pref.Pinscher = pref.Pinscher / TotalVisitas;
            pref.Pitbull = pref.Pitbull / TotalVisitas;
            pref.Podenco_Andaluz = pref.Podenco_Andaluz / TotalVisitas;
            pref.Pomerania = pref.Pomerania / TotalVisitas;
            pref.Pug = pref.Pug / TotalVisitas;
            pref.Ragdoll = pref.Ragdoll / TotalVisitas;
            pref.Ratonero_Andaluz = pref.Ratonero_Andaluz / TotalVisitas;
            pref.Retriever = pref.Retriever / TotalVisitas;
            pref.Rizado = pref.Rizado / TotalVisitas;
            pref.Rottweiler = pref.Rottweiler / TotalVisitas;
            pref.Rubio = pref.Rubio / TotalVisitas;
            pref.Sabueso_Espanol = pref.Sabueso_Espanol / TotalVisitas;
            pref.Samoyedo = pref.Samoyedo / TotalVisitas;
            pref.San_Bernardo = pref.San_Bernardo / TotalVisitas;
            pref.Savannah = pref.Savannah / TotalVisitas;
            pref.Schnauzer_Enano = pref.Schnauzer_Enano / TotalVisitas;
            pref.Schnoodle = pref.Schnoodle / TotalVisitas;
            pref.Scottish_Fold = pref.Scottish_Fold / TotalVisitas;
            pref.Selkirk_Rex = pref.Selkirk_Rex / TotalVisitas;
            pref.Senior = pref.Senior / TotalVisitas;
            pref.Setter_Ingles = pref.Setter_Ingles / TotalVisitas;
            pref.Shar_Pei = pref.Shar_Pei / TotalVisitas;
            pref.Shausie = pref.Shausie / TotalVisitas;
            pref.Shih_Tzu = pref.Shih_Tzu / TotalVisitas;
            pref.Siames = pref.Siames / TotalVisitas;
            pref.Siberiano = pref.Siberiano / TotalVisitas;
            pref.Snowshoe = pref.Snowshoe / TotalVisitas;
            pref.Sokoke = pref.Sokoke / TotalVisitas;
            pref.Somali = pref.Somali / TotalVisitas;
            pref.Spaniel_Breton = pref.Spaniel_Breton / TotalVisitas;
            pref.Sphynx = pref.Sphynx / TotalVisitas;
            pref.Teckel = pref.Teckel / TotalVisitas;
            pref.Van_Turco = pref.Van_Turco / TotalVisitas;
            pref.Vizsla = pref.Vizsla / TotalVisitas;
            pref.Westie = pref.Westie / TotalVisitas;
            pref.Xoloitzcuintle = pref.Xoloitzcuintle / TotalVisitas;
            pref.Yorkshire_Terrier = pref.Yorkshire_Terrier / TotalVisitas;

            return pref;
        }


        private Preferencia updtGenero(Preferencia antigua, string mod)
        {
            Preferencia pref = antigua;
            if(mod == "Macho")
            {
                pref.Macho++;
            }
            else
            {
                pref.Hembra++;
            }
            return pref;
        }
        private Preferencia updtEdad(Preferencia antigua, string mod)
        {
            Preferencia pref = antigua;
            if (mod == "Cachorro")
            {
                pref.Cachorro++;
            }
            else if (mod == "Adulto")
            {
                pref.Adulto++;
            }
            else if (mod == "Senior")
            {
                pref.Senior++;
            }
            else if (mod == "Desconocido")
            {
                pref.Desconocido++;
            }
            return pref;
        }
        private Preferencia updtTamano(Preferencia antigua, string mod)
        {
            Preferencia pref = antigua;
            if (mod == "Pequeño")
            {
                pref.Pequeno++;
            }
            else if (mod == "Mediano")
            {
                pref.Mediano++;
            }
            else if (mod == "Grande")
            {
                pref.Grande++;
            }

            return pref;
        }
        private Preferencia updtPelaje(Preferencia antigua, string mod)
        {
            Preferencia pref = antigua;
            if (mod == "Duro")
            {
                pref.Duro++;
            }
            else if (mod == "Rizado")
            {
                pref.Rizado++;
            }
            else if (mod == "Corto")
            {
                pref.Corto++;
            }
            else if (mod == "Largo")
            {
                pref.Largo++;
            }
            else if (mod == "Lampiño")
            {
                pref.Lampino++;
            }

            return pref;
        }
        private Preferencia updtColor(Preferencia antigua, string mod)
        {
            Preferencia pref = antigua;
            if (mod == "Negro")
            {
                pref.Negro++;
            }
            else if (mod == "Blanco")
            {
                pref.Blanco++;
            }
            else if (mod == "Beige")
            {
                pref.Beige++;
            }
            else if (mod == "Gris")
            {
                pref.Gris++;
            }
            else if (mod == "Café")
            {
                pref.Cafe++;
            }
            else if (mod == "Café claro")
            {
                pref.Cafe_Claro++;
            }
            else if (mod == "Café oscuro")
            {
                pref.Cafe_Oscuro++;
            }
            else if (mod == "Anaranjado")
            {
                pref.Anaranjado++;
            }
            else if (mod == "Rubio")
            {
                pref.Rubio++;
            }
            else if (mod == "Otro")
            {
                pref.Otro_Color++;
            }
            return pref;
        }
        private Preferencia updtEspecie(Preferencia antigua, string mod)
        {
            Preferencia pref = antigua;
            if (mod == "Perro")
            {
                pref.Perro++;
            }
            else if (mod == "Gato")
            {
                pref.Gato++;
            }
            return pref;
        }
        private Preferencia updtRaza(Preferencia antigua, string mod)
        {
            Preferencia pref = antigua;
            if (mod == "Pastor Bergamo")
            {
                pref.Pastor_Bergamo++;
            }
            else if (mod == "Schnoodle")
            {
                pref.Schnoodle++;
            }
            else if (mod == "Galgo")
            {
                pref.Galgo++;
            }
            else if (mod == "Labrador Retriever")
            {
                pref.Labrador_Retriever++;
            }
            else if (mod == "Elkhound")
            {
                pref.Elkhound++;
            }
            else if (mod == "Keeshoun")
            {
                pref.Keeshoun++;
            }
            else if (mod == "Pastor Caucasico")
            {
                pref.Pastor_Caucasico++;
            }
            else if (mod == "Basset Hound")
            {
                pref.Basset_Hound++;
            }
            else if (mod == "Kangal turco")
            {
                pref.Kagnal_Turco++;
            }
            else if (mod == "Pastor ganadero australiano")
            {
                pref.Pastor_Australiano++;
            }
            else if (mod == "Xoloitzcuintle")
            {
                pref.Xoloitzcuintle++;
            }
            else if (mod == "Corgi gales de Pembroke")
            {
                pref.Corgi_Gales++;
            }
            else if (mod == "Perro Lobo Checoslovaco")
            {
                pref.Perro_Lobo++;
            }
            else if (mod == "Alaskan Malamute")
            {
                pref.Alaskan_Malamute++;
            }
            else if (mod == "Mastin tibetano")
            {
                pref.Mastin_Tibetano++;
            }
            else if (mod == "Shar Pei")
            {
                pref.Shar_Pei++;
            }
            else if (mod == "Galgo italiano")
            {
                pref.Galgo_Italiano++;
            }
            else if (mod == "Spaniel Breton")
            {
                pref.Spaniel_Breton++;
            }
            else if (mod == "Ratonero Bodeguero Andaluz")
            {
                pref.Ratonero_Andaluz++;
            }
            else if (mod == "Fox Terrier")
            {
                pref.Fox_Terrier++;
            }
            else if (mod == "BullMastiff")
            {
                pref.Bull_Mastiff++;
            }
            else if (mod == "Pastor Yugoslavo")
            {
                pref.Pastor_Yugoslavo++;
            }
            else if (mod == "Braco de Weimar")
            {
                pref.Braco_Weimar++;
            }
            else if (mod == "Setter Ingles")
            {
                pref.Setter_Ingles++;
            }
            else if (mod == "Sabueso español")
            {
                pref.Sabueso_Espanol++;
            }
            else if (mod == "Boyero de Berna")
            {
                pref.Boyero_Berna++;
            }
            else if (mod == "Grifon de Bruselas")
            {
                pref.Grifon_Bruselas++;
            }
            else if (mod == "Dogo de Burdeos")
            {
                pref.Dogo_Burdeos++;
            }
            else if (mod == "Lobero irlandes")
            {
                pref.Lobero_Irlandes++;
            }
            else if (mod == "Lhasa Apso")
            {
                pref.Lhasa_Apso++;
            }
            else if (mod == "Bulldog Ingles")
            {
                pref.Bulldog_Ingles++;
            }
            else if (mod == "Cavalier King Charles Spaniel")
            {
                pref.Cavalier_King++;
            }
            else if (mod == "Perro Pequines")
            {
                pref.Perro_Pequines++;
            }
            else if (mod == "Pug")
            {
                pref.Pug++;
            }
            else if (mod == "Parson Russel Terrier")
            {
                pref.Parson_Russell++;
            }
            else if (mod == "Braco aleman")
            {
                pref.Braco_Aleman++;
            }
            else if (mod == "Jack Russell Terrier")
            {
                pref.Jack_Russell++;
            }
            else if (mod == "Pachon Navarro")
            {
                pref.Pachon_Navarro++;
            }
            else if (mod == "Westie")
            {
                pref.Westie++;
            }
            else if (mod == "Galgo Español")
            {
                pref.Galgo_Espanol++;
            }
            else if (mod == "Mastin Español")
            {
                pref.Mastin_Espanol++;
            }
            else if (mod == "San Bernardo")
            {
                pref.San_Bernardo++;
            }
            else if (mod == "Gran Danes")
            {
                pref.Gran_Danes++;
            }
            else if (mod == "Pinscher miniatura")
            {
                pref.Pinscher++;
            }
            else if (mod == "Podenco andaluz")
            {
                pref.Podenco_Andaluz++;
            }
            else if (mod == "Braco de Burgos")
            {
                pref.Braco_Burgos++;
            }
            else if (mod == "Perro de Aguas Español")
            {
                pref.Perro_Aguas_Espanol++;
            }
            else if (mod == "Dogo Argentino")
            {
                pref.Dogo_Argentino++;
            }
            else if (mod == "Pomerania")
            {
                pref.Pomerania++;
            }
            else if (mod == "Mastin del Pirineo")
            {
                pref.Mastin_Prineo++;
            }
            else if (mod == "Rottweiler")
            {
                pref.Rottweiler++;
            }
            else if (mod == "Chow Chow")
            {
                pref.Chow_Chow++;
            }
            else if (mod == "Samoyedo")
            {
                pref.Samoyedo++;
            }
            else if (mod == "Bobtail")
            {
                pref.Bobtail++;
            }
            else if (mod == "Teckel")
            {
                pref.Teckel++;
            }
            else if (mod == "Shih Tzu")
            {
                pref.Shih_Tzu++;
            }
            else if (mod == "Caniche")
            {
                pref.Caniche++;
            }
            else if (mod == "Pitbull")
            {
                pref.Pitbull++;
            }
            else if (mod == "Bichon Maltes")
            {
                pref.Bichon_Maltes++;
            }
            else if (mod == "Husky Siberiano")
            {
                pref.Husky_Siberiano++;
            }
            else if (mod == "Cocker Spaniel")
            {
                pref.Cocker_Spaniel++;
            }
            else if (mod == "Border Collie")
            {
                pref.Border_Collie++;
            }
            else if (mod == "Dalmata")
            {
                pref.Dalmata++;
            }
            else if (mod == "Beagle")
            {
                pref.Beagle++;
            }
            else if (mod == "Dobermann")
            {
                pref.Dobbermann++;
            }
            else if (mod == "Yorkshire Terrier")
            {
                pref.Yorkshire_Terrier++;
            }
            else if (mod == "Pastor Vasco")
            {
                pref.Pastor_Vasco++;
            }
            else if (mod == "Schnauzer enano")
            {
                pref.Schnauzer_Enano++;
            }
            else if (mod == "Vizsla")
            {
                pref.Vizsla++;
            }
            else if (mod == "Pastor Aleman")
            {
                pref.Pastor_Aleman++;
            }
            else if (mod == "Retriever")
            {
                pref.Retriever++;
            }
            else if (mod == "Boxer")
            {
                pref.Boxer++;
            }
            else if (mod == "Akita Inu")
            {
                pref.Akita_Inu++;
            }
            else if (mod == "Galgo Afgano")
            {
                pref.Galgo_Afgano++;
            }
            else if (mod == "Golden Retriever")
            {
                pref.Golden_Retriever++;
            }
            else if (mod == "Bulldog Frances")
            {
                pref.Bulldog_Frances++;
            }
            else if (mod == "Chihuahua")
            {
                pref.Chihuahua++;
            }
            //Gatos
            else if (mod == "LaPerm")
            {
                pref.LaPerm++;
            }
            else if (mod == "Burmilla")
            {
                pref.Burmilla++;
            }
            else if (mod == "Curl Americano")
            {
                pref.Curl_Americano++;
            }
            else if (mod == "Montes")
            {
                pref.Montes++;
            }
            else if (mod == "Burmes")
            {
                pref.Burmes++;
            }
            else if (mod == "Munchkin")
            {
                pref.Munchkin++;
            }
            else if (mod == "Shausie")
            {
                pref.Shausie++;
            }
            else if (mod == "Devon Rex")
            {
                pref.Devon_Rex++;
            }
            else if (mod == "Javanes")
            {
                pref.Javanes++;
            }
            else if (mod == "Scottish Fold")
            {
                pref.Scottish_Fold++;
            }
            else if (mod == "Van Turco")
            {
                pref.Van_Turco++;
            }
            else if (mod == "Korat")
            {
                pref.Korat++;
            }
            else if (mod == "Somali")
            {
                pref.Somali++;
            }
            else if (mod == "Sphynx")
            {
                pref.Sphynx++;
            }
            else if (mod == "Savannah")
            {
                pref.Savannah++;
            }
            else if (mod == "Chartreux")
            {
                pref.Chartreux++;
            }
            else if (mod == "Sokoke")
            {
                pref.Sokoke++;
            }
            else if (mod == "Selkirk Rex")
            {
                pref.Selkirk_Rex++;
            }
            else if (mod == "Nebelung")
            {
                pref.Nebelung++;
            }
            else if (mod == "Lykoi")
            {
                pref.Lykoi++;
            }
            else if (mod == "Cornish Rex")
            {
                pref.Cornish_Rex++;
            }
            else if (mod == "Peterbald")
            {
                pref.Peterbald++;
            }
            else if (mod == "Oriental de pelo corto")
            {
                pref.Oriental_PeloCorto++;
            }
            else if (mod == "Siberiano")
            {
                pref.Siberiano++;
            }
            else if (mod == "Manx")
            {
                pref.Manx++;
            }
            else if (mod == "Exotico de pelo corto")
            {
                pref.Exotico_Pelocorto++;
            }
            else if (mod == "Birmano")
            {
                pref.Birmano++;
            }
            else if (mod == "Bosque de Noruega")
            {
                pref.Bosque_Noruega++;
            }
            else if (mod == "Snowshoe")
            {
                pref.Snowshoe++;
            }
            else if (mod == "Bengali")
            {
                pref.Bengali++;
            }
            else if (mod == "Ashera")
            {
                pref.Ashera++;
            }
            else if (mod == "Abisinio")
            {
                pref.Abisinio++;
            }
            else if (mod == "Balines")
            {
                pref.Balines++;
            }
            else if (mod == "Maine Coon")
            {
                pref.Maine_Coon++;
            }
            else if (mod == "British shorthair")
            {
                pref.British_Shorthair++;
            }
            else if (mod == "Azul Ruso")
            {
                pref.Azul_Ruso++;
            }
            else if (mod == "Bombay")
            {
                pref.Bombay++;
            }
            else if (mod == "Europeo")
            {
                pref.Europeo++;
            }
            else if (mod == "Mau Egipcio")
            {
                pref.Mau_Egipcio++;
            }
            else if (mod == "Australian Mist")
            {
                pref.Australian_Mist++;
            }
            else if (mod == "Himalayo")
            {
                pref.Himalayo++;
            }
            else if (mod == "Habana")
            {
                pref.Habana++;
            }
            else if (mod == "Persa")
            {
                pref.Persa++;
            }
            else if (mod == "Siames")
            {
                pref.Siames++;
            }
            else if (mod == "Ragdoll")
            {
                pref.Ragdoll++;
            }
            else if (mod == "Otro/Desconocido")
            {
                pref.Otro_Raza++;
            }

            return pref;
        }

    }
}
