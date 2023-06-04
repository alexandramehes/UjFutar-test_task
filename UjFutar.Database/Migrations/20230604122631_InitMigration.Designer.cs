﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UjFutar.Database;

#nullable disable

namespace UjFutar.Database.Migrations
{
    [DbContext(typeof(UjFutarContext))]
    [Migration("20230604122631_InitMigration")]
    partial class InitMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
