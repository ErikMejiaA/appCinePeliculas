
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class PeliculaGeneroConfiguration : IEntityTypeConfiguration<PeliculaGenero>
{
    public void Configure(EntityTypeBuilder<PeliculaGenero> builder)
    {
        //definimos las propiedades de los atributos
        builder.ToTable("PeliculasGeneros");

        //llaves FOREIGN KEY
        builder.HasOne(p => p.Genero)
        .WithMany(p => p.PeliculasGeneros)
        .HasForeignKey(p => p.IdGenero)
        .IsRequired();

        builder.HasOne(p => p.Pelicula)
        .WithMany(p => p.PeliculasGeneros)
        .HasForeignKey(p => p.IdPelicula)
        .IsRequired();
    }
}
