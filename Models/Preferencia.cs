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

        public float Macho { get; set; }
        public float Hembra { get; set; }
        public float Cachorro { get; set; }
        public float Adulto { get; set; }
        public float Senior { get; set; }
        public float Desconocido { get; set; }
        public float Duro { get; set; }
        public float Rizado { get; set; }
        public float Corto { get; set; }
        public float Largo { get; set; }
        public float Lampino { get; set; }
        public float Negro { get; set; }
        public float Blanco { get; set; }
        public float Beige { get; set; }
        public float Gris { get; set; }
        public float Cafe { get; set; }
        public float Cafe_Claro { get; set; }
        public float Cafe_Oscuro { get; set; }
        public float Anaranjado { get; set; }
        public float Rubio { get; set; }
        public float Otro_Color { get; set; }
        public float Pequeno { get; set; }
        public float Mediano { get; set; }
        public float Grande { get; set; }
        public float Perro { get; set; }
        public float Gato { get; set; }
        public float Pastor_Bergamo { get; set; }
        public float Schnoodle { get; set; }
        public float Galgo { get; set; }
        public float Labrador_Retriever { get; set; }
        public float Elkhound { get; set; }
        public float Keeshoun { get; set; }
        public float Pastor_Caucasico { get; set; }
        public float Basset_Hound { get; set; }
        public float Kagnal_Turco { get; set; }
        public float Pastor_Australiano { get; set; }
        public float Xoloitzcuintle { get; set; }
        public float Corgi_Gales { get; set; }
        public float Perro_Lobo { get; set; }
        public float Alaskan_Malamute { get; set; }
        public float Mastin_Tibetano { get; set; }
        public float Shar_Pei { get; set; }
        public float Galgo_Italiano { get; set; }

        public float Spaniel_Breton { get; set; }
        public float Ratonero_Andaluz { get; set; }
        public float Fox_Terrier { get; set; }
        public float Bull_Mastiff { get; set; }
        public float Pastor_Yugoslavo { get; set; }
        public float Braco_Weimar { get; set; }
        public float Setter_Ingles { get; set; }
        public float Sabueso_Espanol { get; set; }
        public float Boyero_Berna { get; set; }
        public float Grifon_Bruselas { get; set; }
        public float Dogo_Burdeos { get; set; }
        public float Lobero_Irlandes { get; set; }
        public float Lhasa_Apso { get; set; }
        public float Bulldog_Ingles { get; set; }
        public float Cavalier_King { get; set; }
        public float Perro_Pequines { get; set; }
        public float Pug { get; set; }
        public float Parson_Russell { get; set; }
        public float Braco_Aleman { get; set; }
        public float Jack_Russell { get; set; }
        public float Pachon_Navarro { get; set; }
        public float Westie { get; set; }
        public float Galgo_Espanol { get; set; }
        public float Mastin_Espanol { get; set; }
        public float San_Bernardo { get; set; }
        public float Gran_Danes { get; set; }
        public float Pinscher { get; set; }
        public float Podenco_Andaluz { get; set; }
        public float Braco_Burgos { get; set; }
        public float Perro_Aguas_Espanol { get; set; }
        public float Dogo_Argentino { get; set; }
        public float Pomerania { get; set; }
        public float Mastin_Prineo { get; set; }
        public float Rottweiler { get; set; }
        public float Chow_Chow { get; set; }
        public float Samoyedo { get; set; }
        public float Bobtail { get; set; }
        public float Teckel { get; set; }
        public float Shih_Tzu { get; set; }
        public float Caniche { get; set; }
        public float Pitbull { get; set; }
        public float Bichon_Maltes { get; set; }
        public float Husky_Siberiano { get; set; }
        public float Cocker_Spaniel { get; set; }
        public float Border_Collie { get; set; }
        public float Dalmata { get; set; }
        public float Beagle { get; set; }
        public float Dobbermann { get; set; }
        public float Yorkshire_Terrier { get; set; }
        public float Pastor_Vasco { get; set; }
        public float Schnauzer_Enano { get; set; }
        public float Vizsla { get; set; }
        public float Pastor_Aleman { get; set; }
        public float Retriever { get; set; }
        public float Boxer { get; set; }
        public float Akita_Inu { get; set; }
        public float Galgo_Afgano { get; set; }
        public float Golden_Retriever { get; set; }
        public float Bulldog_Frances { get; set; }
        public float Chihuahua { get; set; }
        //Gatos
        public float LaPerm { get; set; }
        public float Burmilla { get; set; }
        public float Curl_Americano { get; set; }
        public float Montes { get; set; }
        public float Burmes { get; set; }
        public float Munchkin { get; set; }
        public float Shausie { get; set; }
        public float Devon_Rex { get; set; }
        public float Javanes { get; set; }
        public float Scottish_Fold { get; set; }
        public float Van_Turco { get; set; }
        public float Korat { get; set; }
        public float Somali { get; set; }
        public float Sphynx { get; set; }
        public float Savannah { get; set; }
        public float Chartreux { get; set; }
        public float Sokoke { get; set; }
        public float Selkirk_Rex { get; set; }
        public float Nebelung { get; set; }
        public float Lykoi { get; set; }
        public float Cornish_Rex { get; set; }
        public float Ocicat { get; set; }
        public float Peterbald { get; set; }
        public float Oriental_PeloCorto { get; set; }
        public float Siberiano { get; set; }
        public float Manx { get; set; }
        public float Exotico_Pelocorto { get; set; }
        public float Birmano { get; set; }
        public float Bosque_Noruega { get; set; }
        public float Snowshoe { get; set; }
        public float Bengali { get; set; }
        public float Ashera { get; set; }
        public float Abisinio { get; set; }
        public float Balines { get; set; }
        public float Maine_Coon { get; set; }
        public float British_Shorthair { get; set; }
        public float Azul_Ruso { get; set; }
        public float Bombay { get; set; }
        public float Europeo { get; set; }
        public float Mau_Egipcio { get; set; }
        public float Australian_Mist { get; set; }
        public float Himalayo { get; set; }
        public float Habana { get; set; }
        public float Persa { get; set; }
        public float Siames { get; set; }
        public float Ragdoll { get; set; }
        public float Otro_Raza { get; set; }

        public double getScorePublicacion(Publicacion mod)
        {
            double score = 0;

            //Añadir score segun edad
            if (mod.edad == "Cachorro")
            {
                score += this.Cachorro;
            }
            else if (mod.edad == "Adulto")
            {
                score += this.Adulto;
            }
            else if (mod.edad == "Senior")
            {
                score += this.Senior;
            }
            else if (mod.edad == "Desconocido")
            {
                score += this.Desconocido;
            }

            //Añadir score segun genero
            if (mod.genero == "Macho")
            {
                score += this.Macho;
            }
            else
            {
                score += this.Hembra;
            }

            //Añadir score segun tamaño
            if (mod.tamano == "Pequeño")
            {
                score += this.Pequeno;
            }
            else if (mod.tamano == "Mediano")
            {
                score += this.Mediano;
            }
            else if (mod.tamano == "Grande")
            {
                score += this.Grande;
            }

            //Añadir score segun tipo de pelaje
            if (mod.pelaje == "Duro")
            {
                score += this.Duro;
            }
            else if (mod.pelaje == "Rizado")
            {
                score += this.Rizado;
            }
            else if (mod.pelaje == "Corto")
            {
                score += this.Corto;
            }
            else if (mod.pelaje == "Largo")
            {
                score += this.Largo;
            }
            else if (mod.pelaje == "Lampiño")
            {
                score += this.Lampino;
            }

            //Añadir score segun color
            if (mod.color == "Negro")
            {
                score += this.Negro;
            }
            else if (mod.color == "Blanco")
            {
                score += this.Blanco;
            }
            else if (mod.color == "Beige")
            {
                score += this.Beige;
            }
            else if (mod.color == "Gris")
            {
                score += this.Gris;
            }
            else if (mod.color == "Café")
            {
                score += this.Cafe;
            }
            else if (mod.color == "Café claro")
            {
                score += this.Cafe_Claro;
            }
            else if (mod.color == "Café oscuro")
            {
                score += this.Cafe_Oscuro;
            }
            else if (mod.color == "Anaranjado")
            {
                score += this.Anaranjado;
            }
            else if (mod.color == "Rubio")
            {
                score += this.Rubio;
            }
            else if (mod.color == "Otro")
            {
                score += this.Otro_Color;
            }

            //Añadir score segun especie
            if (mod.especie == "Perro")
            {
                score += this.Perro;
            }
            else if (mod.especie == "Gato")
            {
                score += this.Gato;
            }

            //Añadir score segun raza
            if (mod.raza == "Pastor Bergamo")
            {
                score += this.Pastor_Bergamo;
            }
            else if (mod.raza == "Schnoodle")
            {
                score += this.Schnoodle;
            }
            else if (mod.raza == "Galgo")
            {
                score += this.Galgo;
            }
            else if (mod.raza == "Labrador Retriever")
            {
                score += this.Labrador_Retriever;
            }
            else if (mod.raza == "Elkhound")
            {
                score += this.Elkhound;
            }
            else if (mod.raza == "Keeshoun")
            {
                score += this.Keeshoun;
            }
            else if (mod.raza == "Pastor Caucasico")
            {
                score += this.Pastor_Caucasico;
            }
            else if (mod.raza == "Basset Hound")
            {
                score += this.Basset_Hound;
            }
            else if (mod.raza == "Kangal turco")
            {
                score += this.Kagnal_Turco;
            }
            else if (mod.raza == "Pastor ganadero australiano")
            {
                score += this.Pastor_Australiano;
            }
            else if (mod.raza == "Xoloitzcuintle")
            {
                score += this.Xoloitzcuintle;
            }
            else if (mod.raza == "Corgi gales de Pembroke")
            {
                score += this.Corgi_Gales;
            }
            else if (mod.raza == "Perro Lobo Checoslovaco")
            {
                score += this.Perro_Lobo;
            }
            else if (mod.raza == "Alaskan Malamute")
            {
                score += this.Alaskan_Malamute;
            }
            else if (mod.raza == "Mastin tibetano")
            {
                score += this.Mastin_Tibetano;
            }
            else if (mod.raza == "Shar Pei")
            {
                score += this.Shar_Pei;
            }
            else if (mod.raza == "Galgo italiano")
            {
                score += this.Galgo_Italiano;
            }
            else if (mod.raza == "Spaniel Breton")
            {
                score += this.Spaniel_Breton;
            }
            else if (mod.raza == "Ratonero Bodeguero Andaluz")
            {
                score += this.Ratonero_Andaluz;
            }
            else if (mod.raza == "Fox Terrier")
            {
                score += this.Fox_Terrier;
            }
            else if (mod.raza == "BullMastiff")
            {
                score += this.Bull_Mastiff;
            }
            else if (mod.raza == "Pastor Yugoslavo")
            {
                score += this.Pastor_Yugoslavo;
            }
            else if (mod.raza == "Braco de Weimar")
            {
                score += this.Braco_Weimar;
            }
            else if (mod.raza == "Setter Ingles")
            {
                score += this.Setter_Ingles;
            }
            else if (mod.raza == "Sabueso español")
            {
                score += this.Sabueso_Espanol;
            }
            else if (mod.raza == "Boyero de Berna")
            {
                score += this.Boyero_Berna;
            }
            else if (mod.raza == "Grifon de Bruselas")
            {
                score += this.Grifon_Bruselas;
            }
            else if (mod.raza == "Dogo de Burdeos")
            {
                score += this.Dogo_Burdeos;
            }
            else if (mod.raza == "Lobero irlandes")
            {
                score += this.Lobero_Irlandes;
            }
            else if (mod.raza == "Lhasa Apso")
            {
                score += this.Lhasa_Apso;
            }
            else if (mod.raza == "Bulldog Ingles")
            {
                score += this.Bulldog_Ingles;
            }
            else if (mod.raza == "Cavalier King Charles Spaniel")
            {
                score += this.Cavalier_King;
            }
            else if (mod.raza == "Perro Pequines")
            {
                score += this.Perro_Pequines;
            }
            else if (mod.raza == "Pug")
            {
                score += this.Pug;
            }
            else if (mod.raza == "Parson Russel Terrier")
            {
                score += this.Parson_Russell;
            }
            else if (mod.raza == "Braco aleman")
            {
                score += this.Braco_Aleman;
            }
            else if (mod.raza == "Jack Russell Terrier")
            {
                score += this.Jack_Russell;
            }
            else if (mod.raza == "Pachon Navarro")
            {
                score += this.Pachon_Navarro;
            }
            else if (mod.raza == "Westie")
            {
                score += this.Westie;
            }
            else if (mod.raza == "Galgo Español")
            {
                score += this.Galgo_Espanol;
            }
            else if (mod.raza == "Mastin Español")
            {
                score += this.Mastin_Espanol;
            }
            else if (mod.raza == "San Bernardo")
            {
                score += this.San_Bernardo;
            }
            else if (mod.raza == "Gran Danes")
            {
                score += this.Gran_Danes;
            }
            else if (mod.raza == "Pinscher miniatura")
            {
                score += this.Pinscher;
            }
            else if (mod.raza == "Podenco andaluz")
            {
                score += this.Podenco_Andaluz;
            }
            else if (mod.raza == "Braco de Burgos")
            {
                score += this.Braco_Burgos;
            }
            else if (mod.raza == "Perro de Aguas Español")
            {
                score += this.Perro_Aguas_Espanol;
            }
            else if (mod.raza == "Dogo Argentino")
            {
                score += this.Dogo_Argentino;
            }
            else if (mod.raza == "Pomerania")
            {
                score += this.Pomerania;
            }
            else if (mod.raza == "Mastin del Pirineo")
            {
                score += this.Mastin_Prineo;
            }
            else if (mod.raza == "Rottweiler")
            {
                score += this.Rottweiler;
            }
            else if (mod.raza == "Chow Chow")
            {
                score += this.Chow_Chow;
            }
            else if (mod.raza == "Samoyedo")
            {
                score += this.Samoyedo;
            }
            else if (mod.raza == "Bobtail")
            {
                score += this.Bobtail;
            }
            else if (mod.raza == "Teckel")
            {
                score += this.Teckel;
            }
            else if (mod.raza == "Shih Tzu")
            {
                score += this.Shih_Tzu;
            }
            else if (mod.raza == "Caniche")
            {
                score += this.Caniche;
            }
            else if (mod.raza == "Pitbull")
            {
                score += this.Pitbull;
            }
            else if (mod.raza == "Bichon Maltes")
            {
                score += this.Bichon_Maltes;
            }
            else if (mod.raza == "Husky Siberiano")
            {
                score += this.Husky_Siberiano;
            }
            else if (mod.raza == "Cocker Spaniel")
            {
                score += this.Cocker_Spaniel;
            }
            else if (mod.raza == "Border Collie")
            {
                score += this.Border_Collie;
            }
            else if (mod.raza == "Dalmata")
            { 
                score += this.Dalmata;
            }
            else if (mod.raza == "Beagle")
            {
                score += this.Beagle;
            }
            else if (mod.raza == "Dobermann")
            {
                score += this.Dobbermann;
            }
            else if (mod.raza == "Yorkshire Terrier")
            {
                score += this.Yorkshire_Terrier;
            }
            else if (mod.raza == "Pastor Vasco")
            {
                score += this.Pastor_Vasco;
            }
            else if (mod.raza == "Schnauzer enano")
            {
                score += this.Schnauzer_Enano;
            }
            else if (mod.raza == "Vizsla")
            {
                score += this.Vizsla;
            }
            else if (mod.raza == "Pastor Aleman")
            {
                score += this.Pastor_Aleman;
            }
            else if (mod.raza == "Retriever")
            {
                score += this.Retriever;
            }
            else if (mod.raza == "Boxer")
            {
                score += this.Boxer;
            }
            else if (mod.raza == "Akita Inu")
            {
                score += this.Akita_Inu;
            }
            else if (mod.raza == "Galgo Afgano")
            {
                score += this.Galgo_Afgano;
            }
            else if (mod.raza == "Golden Retriever")
            {
                score += this.Golden_Retriever;
            }
            else if (mod.raza == "Bulldog Frances")
            {
                score += this.Bulldog_Frances;
            }
            else if (mod.raza == "Chihuahua")
            {
                score += this.Chihuahua;
            }
            //Gatos
            else if (mod.raza == "LaPerm")
            {
                score += this.LaPerm;
            }
            else if (mod.raza == "Burmilla")
            {
                score += this.Burmilla;
            }
            else if (mod.raza == "Curl Americano")
            {
                score += this.Curl_Americano;
            }
            else if (mod.raza == "Montes")
            {
                score += this.Montes;
            }
            else if (mod.raza == "Burmes")
            {
                score += this.Burmes;
            }
            else if (mod.raza == "Munchkin")
            {
                score += this.Munchkin;
            }
            else if (mod.raza == "Shausie")
            {
                score += this.Shausie;
            }
            else if (mod.raza == "Devon Rex")
            {
                score += this.Devon_Rex;
            }
            else if (mod.raza == "Javanes")
            {
                score += this.Javanes;
            }
            else if (mod.raza == "Scottish Fold")
            {
                score += this.Scottish_Fold;
            }
            else if (mod.raza == "Van Turco")
            {
                score += this.Van_Turco;
            }
            else if (mod.raza == "Korat")
            {
                score += this.Korat;
            }
            else if (mod.raza == "Somali")
            {
                score += this.Somali;
            }
            else if (mod.raza == "Sphynx")
            {
                score += this.Sphynx;
            }
            else if (mod.raza == "Savannah")
            {
                score += this.Savannah;
            }
            else if (mod.raza == "Chartreux")
            {
                score += this.Chartreux;
            }
            else if (mod.raza == "Sokoke")
            {
                score += this.Sokoke;
            }
            else if (mod.raza == "Selkirk Rex")
            {
                score += this.Selkirk_Rex;
            }
            else if (mod.raza == "Nebelung")
            {
                score += this.Nebelung;
            }
            else if (mod.raza == "Lykoi")
            {
                score += this.Lykoi;
            }
            else if (mod.raza == "Cornish Rex")
            {
                score += this.Cornish_Rex;
            }
            else if (mod.raza == "Peterbald")
            {
                score += this.Peterbald;
            }
            else if (mod.raza == "Oriental de pelo corto")
            {
                score += this.Oriental_PeloCorto;
            }
            else if (mod.raza == "Siberiano")
            {
                score += this.Siberiano;
            }
            else if (mod.raza == "Manx")
            {
                score += this.Manx;
            }
            else if (mod.raza == "Exotico de pelo corto")
            {
                score += this.Exotico_Pelocorto;
            }
            else if (mod.raza == "Birmano")
            {
                score += this.Birmano;
            }
            else if (mod.raza == "Bosque de Noruega")
            {
                score += this.Bosque_Noruega;
            }
            else if (mod.raza == "Snowshoe")
            {
                score += this.Snowshoe;
            }
            else if (mod.raza == "Bengali")
            {
                score += this.Bengali;
            }
            else if (mod.raza == "Ashera")
            {
                score += this.Ashera;
            }
            else if (mod.raza == "Abisinio")
            {
                score += this.Abisinio;
            }
            else if (mod.raza == "Balines")
            {
                score += this.Balines;
            }
            else if (mod.raza == "Maine Coon")
            {
                score += this.Maine_Coon;
            }
            else if (mod.raza == "British shorthair")
            {
                score += this.British_Shorthair;
            }
            else if (mod.raza == "Azul Ruso")
            {
                score += this.Azul_Ruso;
            }
            else if (mod.raza == "Bombay")
            {
                score += this.Bombay;
            }
            else if (mod.raza == "Europeo")
            {
                score += this.Europeo;
            }
            else if (mod.raza == "Mau Egipcio")
            {
                score += this.Mau_Egipcio;
            }
            else if (mod.raza == "Australian Mist")
            {
                score += this.Australian_Mist;
            }
            else if (mod.raza == "Himalayo")
            {
                score += this.Himalayo;
            }
            else if (mod.raza == "Habana")
            {
                score += this.Habana;
            }
            else if (mod.raza == "Persa")
            {
                score += this.Persa;
            }
            else if (mod.raza == "Siames")
            {
                score += this.Siames;
            }
            else if (mod.raza == "Ragdoll")
            {
                score += this.Ragdoll;
            }
            else if (mod.raza == "Otro/Desconocido")
            {
                score += this.Otro_Raza;
            }

                return score;
         }
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

            return pref;
        }
        public Preferencia normalizarPreferencia(Preferencia antigua, int TotalVisitas)
        {
            if (TotalVisitas < 1)
            {
                TotalVisitas = 1;
            }
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
