﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(appCinePeliculaContext))]
    partial class appCinePeliculaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Core.Entities.Actor", b =>
                {
                    b.Property<int>("IdActor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("date");

                    b.Property<decimal>("Fortuna")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdActor");

                    b.ToTable("Actores", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Comentario", b =>
                {
                    b.Property<int>("IdComentario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Contenido")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<int>("IdPelicula")
                        .HasColumnType("int");

                    b.Property<bool>("Recomendar")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("IdComentario");

                    b.HasIndex("IdPelicula");

                    b.ToTable("Comentarios", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Genero", b =>
                {
                    b.Property<int>("IdGenero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdGenero");

                    b.ToTable("Generos", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Pelicula", b =>
                {
                    b.Property<int>("IdPelicula")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("EnCine")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("FechaEstreno")
                        .HasColumnType("date");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.HasKey("IdPelicula");

                    b.ToTable("Peliculas", (string)null);
                });

            modelBuilder.Entity("Core.Entities.PeliculaActor", b =>
                {
                    b.Property<int>("IdPelicula")
                        .HasColumnType("int");

                    b.Property<int>("IdActor")
                        .HasColumnType("int");

                    b.Property<string>("Orden")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Personaje")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.HasKey("IdPelicula", "IdActor");

                    b.HasIndex("IdActor");

                    b.ToTable("PeliculasActores", (string)null);
                });

            modelBuilder.Entity("Core.Entities.PeliculaGenero", b =>
                {
                    b.Property<int>("IdPelicula")
                        .HasColumnType("int");

                    b.Property<int>("IdGenero")
                        .HasColumnType("int");

                    b.HasKey("IdPelicula", "IdGenero");

                    b.HasIndex("IdGenero");

                    b.ToTable("PeliculasGeneros", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Comentario", b =>
                {
                    b.HasOne("Core.Entities.Pelicula", "Pelicula")
                        .WithMany("Comentarios")
                        .HasForeignKey("IdPelicula")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pelicula");
                });

            modelBuilder.Entity("Core.Entities.PeliculaActor", b =>
                {
                    b.HasOne("Core.Entities.Actor", "Actor")
                        .WithMany("PeliculasActores")
                        .HasForeignKey("IdActor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Pelicula", "Pelicula")
                        .WithMany("PeliculasActores")
                        .HasForeignKey("IdPelicula")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Pelicula");
                });

            modelBuilder.Entity("Core.Entities.PeliculaGenero", b =>
                {
                    b.HasOne("Core.Entities.Genero", "Genero")
                        .WithMany("PeliculasGeneros")
                        .HasForeignKey("IdGenero")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Pelicula", "Pelicula")
                        .WithMany("PeliculasGeneros")
                        .HasForeignKey("IdPelicula")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genero");

                    b.Navigation("Pelicula");
                });

            modelBuilder.Entity("Core.Entities.Actor", b =>
                {
                    b.Navigation("PeliculasActores");
                });

            modelBuilder.Entity("Core.Entities.Genero", b =>
                {
                    b.Navigation("PeliculasGeneros");
                });

            modelBuilder.Entity("Core.Entities.Pelicula", b =>
                {
                    b.Navigation("Comentarios");

                    b.Navigation("PeliculasActores");

                    b.Navigation("PeliculasGeneros");
                });
#pragma warning restore 612, 618
        }
    }
}
