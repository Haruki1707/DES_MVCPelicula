﻿// <auto-generated />
using System;
using MVCPelicula.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVCPelicula.Migrations
{
    [DbContext(typeof(PeliculasDBContext))]
    [Migration("20240711002124_Peliculas_FK_Genero")]
    partial class Peliculas_FK_Genero
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MVCPelicula.Models.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("MVCPelicula.Models.Pelicula", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("FechaLanzamiento")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GeneroId")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("int");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("ID");

                    b.HasIndex("GeneroId");

                    b.ToTable("Peliculas");
                });

            modelBuilder.Entity("MVCPelicula.Models.Pelicula", b =>
                {
                    b.HasOne("MVCPelicula.Models.Genero", "Genero")
                        .WithMany("Peliculas")
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genero");
                });

            modelBuilder.Entity("MVCPelicula.Models.Genero", b =>
                {
                    b.Navigation("Peliculas");
                });
#pragma warning restore 612, 618
        }
    }
}
