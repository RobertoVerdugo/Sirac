﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test_Razor.Models;

namespace Test_Razor.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Test_Razor.Models.Preferencia", b =>
                {
                    b.Property<string>("rut")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<int>("Abisinio")
                        .HasColumnType("int");

                    b.Property<int>("Adulto")
                        .HasColumnType("int");

                    b.Property<int>("Akita_Inu")
                        .HasColumnType("int");

                    b.Property<int>("Alaskan_Malamute")
                        .HasColumnType("int");

                    b.Property<int>("Anaranjado")
                        .HasColumnType("int");

                    b.Property<int>("Ashera")
                        .HasColumnType("int");

                    b.Property<int>("Australian_Mist")
                        .HasColumnType("int");

                    b.Property<int>("Azul_Ruso")
                        .HasColumnType("int");

                    b.Property<int>("Balines")
                        .HasColumnType("int");

                    b.Property<int>("Basset_Hound")
                        .HasColumnType("int");

                    b.Property<int>("Beagle")
                        .HasColumnType("int");

                    b.Property<int>("Beige")
                        .HasColumnType("int");

                    b.Property<int>("Bengali")
                        .HasColumnType("int");

                    b.Property<int>("Bichon_Maltes")
                        .HasColumnType("int");

                    b.Property<int>("Birmano")
                        .HasColumnType("int");

                    b.Property<int>("Blanco")
                        .HasColumnType("int");

                    b.Property<int>("Bobtail")
                        .HasColumnType("int");

                    b.Property<int>("Bombay")
                        .HasColumnType("int");

                    b.Property<int>("Border_Collie")
                        .HasColumnType("int");

                    b.Property<int>("Bosque_Noruega")
                        .HasColumnType("int");

                    b.Property<int>("Boxer")
                        .HasColumnType("int");

                    b.Property<int>("Boyero_Berna")
                        .HasColumnType("int");

                    b.Property<int>("Braco_Aleman")
                        .HasColumnType("int");

                    b.Property<int>("Braco_Burgos")
                        .HasColumnType("int");

                    b.Property<int>("Braco_Weimar")
                        .HasColumnType("int");

                    b.Property<int>("British_Shorthair")
                        .HasColumnType("int");

                    b.Property<int>("Bull_Mastiff")
                        .HasColumnType("int");

                    b.Property<int>("Bulldog_Frances")
                        .HasColumnType("int");

                    b.Property<int>("Bulldog_Ingles")
                        .HasColumnType("int");

                    b.Property<int>("Burmes")
                        .HasColumnType("int");

                    b.Property<int>("Burmilla")
                        .HasColumnType("int");

                    b.Property<int>("Cachorro")
                        .HasColumnType("int");

                    b.Property<int>("Cafe")
                        .HasColumnType("int");

                    b.Property<int>("Cafe_Claro")
                        .HasColumnType("int");

                    b.Property<int>("Cafe_Oscuro")
                        .HasColumnType("int");

                    b.Property<int>("Caniche")
                        .HasColumnType("int");

                    b.Property<int>("Cavalier_King")
                        .HasColumnType("int");

                    b.Property<int>("Chartreux")
                        .HasColumnType("int");

                    b.Property<int>("Chihuahua")
                        .HasColumnType("int");

                    b.Property<int>("Chow_Chow")
                        .HasColumnType("int");

                    b.Property<int>("Cocker_Spaniel")
                        .HasColumnType("int");

                    b.Property<int>("Corgi_Gales")
                        .HasColumnType("int");

                    b.Property<int>("Cornish_Rex")
                        .HasColumnType("int");

                    b.Property<int>("Corto")
                        .HasColumnType("int");

                    b.Property<int>("Curl_Americano")
                        .HasColumnType("int");

                    b.Property<int>("Dalmata")
                        .HasColumnType("int");

                    b.Property<int>("Desconocido")
                        .HasColumnType("int");

                    b.Property<int>("Devon_Rex")
                        .HasColumnType("int");

                    b.Property<int>("Dobbermann")
                        .HasColumnType("int");

                    b.Property<int>("Dogo_Argentino")
                        .HasColumnType("int");

                    b.Property<int>("Dogo_Burdeos")
                        .HasColumnType("int");

                    b.Property<int>("Duro")
                        .HasColumnType("int");

                    b.Property<int>("Elkhound")
                        .HasColumnType("int");

                    b.Property<int>("Europeo")
                        .HasColumnType("int");

                    b.Property<int>("Exotico_Pelocorto")
                        .HasColumnType("int");

                    b.Property<int>("Fox_Terrier")
                        .HasColumnType("int");

                    b.Property<int>("Galgo")
                        .HasColumnType("int");

                    b.Property<int>("Galgo_Afgano")
                        .HasColumnType("int");

                    b.Property<int>("Galgo_Espanol")
                        .HasColumnType("int");

                    b.Property<int>("Galgo_Italiano")
                        .HasColumnType("int");

                    b.Property<int>("Gato")
                        .HasColumnType("int");

                    b.Property<int>("Golden_Retriever")
                        .HasColumnType("int");

                    b.Property<int>("Gran_Danes")
                        .HasColumnType("int");

                    b.Property<int>("Grande")
                        .HasColumnType("int");

                    b.Property<int>("Grifon_Bruselas")
                        .HasColumnType("int");

                    b.Property<int>("Gris")
                        .HasColumnType("int");

                    b.Property<int>("Habana")
                        .HasColumnType("int");

                    b.Property<int>("Hembra")
                        .HasColumnType("int");

                    b.Property<int>("Himalayo")
                        .HasColumnType("int");

                    b.Property<int>("Husky_Siberiano")
                        .HasColumnType("int");

                    b.Property<int>("Jack_Russell")
                        .HasColumnType("int");

                    b.Property<int>("Javanes")
                        .HasColumnType("int");

                    b.Property<int>("Kagnal_Turco")
                        .HasColumnType("int");

                    b.Property<int>("Keeshoun")
                        .HasColumnType("int");

                    b.Property<int>("Korat")
                        .HasColumnType("int");

                    b.Property<int>("LaPerm")
                        .HasColumnType("int");

                    b.Property<int>("Labrador_Retriever")
                        .HasColumnType("int");

                    b.Property<int>("Lampino")
                        .HasColumnType("int");

                    b.Property<int>("Largo")
                        .HasColumnType("int");

                    b.Property<int>("Lhasa_Apso")
                        .HasColumnType("int");

                    b.Property<int>("Lobero_Irlandes")
                        .HasColumnType("int");

                    b.Property<int>("Lykoi")
                        .HasColumnType("int");

                    b.Property<int>("Macho")
                        .HasColumnType("int");

                    b.Property<int>("Maine_Coon")
                        .HasColumnType("int");

                    b.Property<int>("Manx")
                        .HasColumnType("int");

                    b.Property<int>("Mastin_Espanol")
                        .HasColumnType("int");

                    b.Property<int>("Mastin_Prineo")
                        .HasColumnType("int");

                    b.Property<int>("Mastin_Tibetano")
                        .HasColumnType("int");

                    b.Property<int>("Mau_Egipcio")
                        .HasColumnType("int");

                    b.Property<int>("Mediano")
                        .HasColumnType("int");

                    b.Property<int>("Montes")
                        .HasColumnType("int");

                    b.Property<int>("Munchkin")
                        .HasColumnType("int");

                    b.Property<int>("Nebelung")
                        .HasColumnType("int");

                    b.Property<int>("Negro")
                        .HasColumnType("int");

                    b.Property<int>("Ocicat")
                        .HasColumnType("int");

                    b.Property<int>("Oriental_PeloCorto")
                        .HasColumnType("int");

                    b.Property<int>("Otro_Color")
                        .HasColumnType("int");

                    b.Property<int>("Otro_Raza")
                        .HasColumnType("int");

                    b.Property<int>("Pachon_Navarro")
                        .HasColumnType("int");

                    b.Property<int>("Parson_Russell")
                        .HasColumnType("int");

                    b.Property<int>("Pastor_Aleman")
                        .HasColumnType("int");

                    b.Property<int>("Pastor_Australiano")
                        .HasColumnType("int");

                    b.Property<int>("Pastor_Bergamo")
                        .HasColumnType("int");

                    b.Property<int>("Pastor_Caucasico")
                        .HasColumnType("int");

                    b.Property<int>("Pastor_Vasco")
                        .HasColumnType("int");

                    b.Property<int>("Pastor_Yugoslavo")
                        .HasColumnType("int");

                    b.Property<int>("Pequeno")
                        .HasColumnType("int");

                    b.Property<int>("Perro")
                        .HasColumnType("int");

                    b.Property<int>("Perro_Aguas_Espanol")
                        .HasColumnType("int");

                    b.Property<int>("Perro_Lobo")
                        .HasColumnType("int");

                    b.Property<int>("Perro_Pequines")
                        .HasColumnType("int");

                    b.Property<int>("Persa")
                        .HasColumnType("int");

                    b.Property<int>("Peterbald")
                        .HasColumnType("int");

                    b.Property<int>("Pinscher")
                        .HasColumnType("int");

                    b.Property<int>("Pitbull")
                        .HasColumnType("int");

                    b.Property<int>("Podenco_Andaluz")
                        .HasColumnType("int");

                    b.Property<int>("Pomerania")
                        .HasColumnType("int");

                    b.Property<int>("Pug")
                        .HasColumnType("int");

                    b.Property<int>("Ragdoll")
                        .HasColumnType("int");

                    b.Property<int>("Ratonero_Andaluz")
                        .HasColumnType("int");

                    b.Property<int>("Retriever")
                        .HasColumnType("int");

                    b.Property<int>("Rizado")
                        .HasColumnType("int");

                    b.Property<int>("Rottweiler")
                        .HasColumnType("int");

                    b.Property<int>("Rubio")
                        .HasColumnType("int");

                    b.Property<int>("Sabueso_Espanol")
                        .HasColumnType("int");

                    b.Property<int>("Samoyedo")
                        .HasColumnType("int");

                    b.Property<int>("San_Bernardo")
                        .HasColumnType("int");

                    b.Property<int>("Savannah")
                        .HasColumnType("int");

                    b.Property<int>("Schnauzer_Enano")
                        .HasColumnType("int");

                    b.Property<int>("Schnoodle")
                        .HasColumnType("int");

                    b.Property<int>("Scottish_Fold")
                        .HasColumnType("int");

                    b.Property<int>("Selkirk_Rex")
                        .HasColumnType("int");

                    b.Property<int>("Senior")
                        .HasColumnType("int");

                    b.Property<int>("Setter_Ingles")
                        .HasColumnType("int");

                    b.Property<int>("Shar_Pei")
                        .HasColumnType("int");

                    b.Property<int>("Shausie")
                        .HasColumnType("int");

                    b.Property<int>("Shih_Tzu")
                        .HasColumnType("int");

                    b.Property<int>("Siames")
                        .HasColumnType("int");

                    b.Property<int>("Siberiano")
                        .HasColumnType("int");

                    b.Property<int>("Snowshoe")
                        .HasColumnType("int");

                    b.Property<int>("Sokoke")
                        .HasColumnType("int");

                    b.Property<int>("Somali")
                        .HasColumnType("int");

                    b.Property<int>("Spaniel_Breton")
                        .HasColumnType("int");

                    b.Property<int>("Sphynx")
                        .HasColumnType("int");

                    b.Property<int>("Teckel")
                        .HasColumnType("int");

                    b.Property<int>("Van_Turco")
                        .HasColumnType("int");

                    b.Property<int>("Vizsla")
                        .HasColumnType("int");

                    b.Property<int>("Westie")
                        .HasColumnType("int");

                    b.Property<int>("Xoloitzcuintle")
                        .HasColumnType("int");

                    b.Property<int>("Yorkshire_Terrier")
                        .HasColumnType("int");

                    b.HasKey("rut");

                    b.ToTable("Preferencia");
                });

            modelBuilder.Entity("Test_Razor.Models.Publicacion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("actualizacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("edad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("especie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("pelaje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("raza")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rut")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rutaimg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("score")
                        .HasColumnType("float");

                    b.Property<string>("tamano")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ubicacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("id");

                    b.ToTable("Publicacion");
                });

            modelBuilder.Entity("Test_Razor.Models.Reporte", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("causal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<int>("idPublicacion")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Reporte");
                });

            modelBuilder.Entity("Test_Razor.Models.Usuario", b =>
                {
                    b.Property<string>("rut")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<string>("apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(16)")
                        .HasMaxLength(16);

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.HasKey("rut");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Test_Razor.Models.Visita", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("idPublicacion")
                        .HasColumnType("int");

                    b.Property<int>("ranking")
                        .HasColumnType("int");

                    b.Property<string>("rut")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Visita");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
