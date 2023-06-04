﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UjFutar.Database;

#nullable disable

namespace UjFutar.Database.Migrations
{
    [DbContext(typeof(UjFutarContext))]
    partial class UjFutarContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UjFutar.Api.DTO.CsomagAdatok", b =>
                {
                    b.Property<int>("CsomagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CsomagId"));

                    b.Property<string>("AktualisPozicio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Allapot")
                        .HasColumnType("int");

                    b.Property<string>("JarmuRendszam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CsomagId");

                    b.ToTable("CsomagAdatok");

                    b.HasData(
                        new
                        {
                            CsomagId = 1,
                            AktualisPozicio = "Teszt utca 1",
                            Allapot = 0,
                            JarmuRendszam = ""
                        },
                        new
                        {
                            CsomagId = 2,
                            AktualisPozicio = "Teszt utca 2",
                            Allapot = 0,
                            JarmuRendszam = ""
                        },
                        new
                        {
                            CsomagId = 3,
                            AktualisPozicio = "Teszt utca 3",
                            Allapot = 0,
                            JarmuRendszam = ""
                        });
                });

            modelBuilder.Entity("UjFutar.Api.DTO.SzallitasiAdatok", b =>
                {
                    b.Property<int>("CsomagAdatokId")
                        .HasColumnType("int");

                    b.Property<int>("CimzettId")
                        .HasColumnType("int");

                    b.Property<int>("FeladoId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("CsomagAdatokId");

                    b.HasIndex("CimzettId");

                    b.HasIndex("FeladoId");

                    b.ToTable("SzallitasiAdatok");

                    b.HasData(
                        new
                        {
                            CsomagAdatokId = 1,
                            CimzettId = 2,
                            FeladoId = 1,
                            Id = 0
                        },
                        new
                        {
                            CsomagAdatokId = 2,
                            CimzettId = 1,
                            FeladoId = 3,
                            Id = 0
                        },
                        new
                        {
                            CsomagAdatokId = 3,
                            CimzettId = 3,
                            FeladoId = 2,
                            Id = 0
                        });
                });

            modelBuilder.Entity("UjFutar.Api.DTO.Szemely", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nev")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SzallitasiAdatokCsomagAdatokId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SzallitasiAdatokCsomagAdatokId");

                    b.ToTable("Szemely");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cim = "Teszt utca 1",
                            Email = "teszt1@teszt.hu",
                            Nev = "Teszt Elek1"
                        },
                        new
                        {
                            Id = 2,
                            Cim = "Teszt utca 2",
                            Email = "teszt2@teszt.hu",
                            Nev = "Teszt Elek2"
                        },
                        new
                        {
                            Id = 3,
                            Cim = "Teszt utca 3",
                            Email = "teszt3@teszt.hu",
                            Nev = "Teszt Elek3"
                        });
                });

            modelBuilder.Entity("UjFutar.Api.DTO.SzallitasiAdatok", b =>
                {
                    b.HasOne("UjFutar.Api.DTO.Szemely", "Cimzett")
                        .WithMany()
                        .HasForeignKey("CimzettId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("UjFutar.Api.DTO.CsomagAdatok", "CsomagAdatok")
                        .WithOne("SzallitasiAdatok")
                        .HasForeignKey("UjFutar.Api.DTO.SzallitasiAdatok", "CsomagAdatokId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("UjFutar.Api.DTO.Szemely", "Felado")
                        .WithMany()
                        .HasForeignKey("FeladoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cimzett");

                    b.Navigation("CsomagAdatok");

                    b.Navigation("Felado");
                });

            modelBuilder.Entity("UjFutar.Api.DTO.Szemely", b =>
                {
                    b.HasOne("UjFutar.Api.DTO.SzallitasiAdatok", "SzallitasiAdatok")
                        .WithMany()
                        .HasForeignKey("SzallitasiAdatokCsomagAdatokId");

                    b.Navigation("SzallitasiAdatok");
                });

            modelBuilder.Entity("UjFutar.Api.DTO.CsomagAdatok", b =>
                {
                    b.Navigation("SzallitasiAdatok")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
