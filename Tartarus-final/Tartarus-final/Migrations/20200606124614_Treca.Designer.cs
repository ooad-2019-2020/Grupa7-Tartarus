﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tartarus_final.Models;

namespace Tartarus_final.Migrations
{
    [DbContext(typeof(NasContext))]
    [Migration("20200606124614_Treca")]
    partial class Treca
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Tartarus_final.Models.Cuvar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumPrijave")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cuvar");
                });

            modelBuilder.Entity("Tartarus_final.Models.Obavijest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ObavijestId")
                        .HasColumnType("int");

                    b.Property<string>("Tekst")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ObavijestId");

                    b.ToTable("Obavijesti");
                });

            modelBuilder.Entity("Tartarus_final.Models.Poruka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PorukaId")
                        .HasColumnType("int");

                    b.Property<string>("PrimalacEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tekst")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("posiljalacEmail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PorukaId");

                    b.ToTable("Poruke");
                });

            modelBuilder.Entity("Tartarus_final.Models.Prekrsaj", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumPrekrsaja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumPritvora")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumSudskeOdluke")
                        .HasColumnType("datetime2");

                    b.Property<string>("KaznenoDjelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zapisnik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ZatvorenikId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ZatvorenikId");

                    b.ToTable("Prekrsaj");
                });

            modelBuilder.Entity("Tartarus_final.Models.Sektor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("NadlezniCuvarId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NadlezniCuvarId");

                    b.ToTable("Sektor");
                });

            modelBuilder.Entity("Tartarus_final.Models.Zatvorenik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Evaluacija")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Jmbg")
                        .HasColumnType("int");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ZatvorskaKazna")
                        .HasColumnType("int");

                    b.Property<int?>("sektorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("sektorId");

                    b.ToTable("Zatvorenik");
                });

            modelBuilder.Entity("Tartarus_final.Models.Obavijest", b =>
                {
                    b.HasOne("Tartarus_final.Models.Obavijest", null)
                        .WithMany("Obavijesti")
                        .HasForeignKey("ObavijestId");
                });

            modelBuilder.Entity("Tartarus_final.Models.Poruka", b =>
                {
                    b.HasOne("Tartarus_final.Models.Poruka", null)
                        .WithMany("Poruke")
                        .HasForeignKey("PorukaId");
                });

            modelBuilder.Entity("Tartarus_final.Models.Prekrsaj", b =>
                {
                    b.HasOne("Tartarus_final.Models.Zatvorenik", null)
                        .WithMany("Prekrsaji")
                        .HasForeignKey("ZatvorenikId");
                });

            modelBuilder.Entity("Tartarus_final.Models.Sektor", b =>
                {
                    b.HasOne("Tartarus_final.Models.Cuvar", "NadlezniCuvar")
                        .WithMany()
                        .HasForeignKey("NadlezniCuvarId");
                });

            modelBuilder.Entity("Tartarus_final.Models.Zatvorenik", b =>
                {
                    b.HasOne("Tartarus_final.Models.Sektor", "sektor")
                        .WithMany()
                        .HasForeignKey("sektorId");
                });
#pragma warning restore 612, 618
        }
    }
}
