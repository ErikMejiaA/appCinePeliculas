
using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class appCinePeliculaContext : DbContext
{
    public appCinePeliculaContext(DbContextOptions<appCinePeliculaContext> options) : base(options)
    {

    }

    //aqui van los DbSet<> de la entidades 
    public DbSet<Actor> ? Actores { get; set; }
    public DbSet<Comentario> ? Comentarios { get; set; }
    public DbSet<Genero> ? Generos { get; set; }
    public DbSet<Pelicula> ? Peliculas { get; set; }
    public DbSet<PeliculaActor> ? PeliculasActores { get; set; }
    public DbSet<PeliculaGenero> ? PeliculasGeneros { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //definimos las llaves primarias compuestas 
        modelBuilder.Entity<PeliculaGenero>().HasKey(p => new { p.IdPelicula, p.IdGenero });
        modelBuilder.Entity<PeliculaActor>().HasKey(p => new { p.IdPelicula, p.IdActor });
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }


    internal void SaveAsync()
    {
        throw new NotImplementedException();
    }

}
