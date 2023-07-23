
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class PeliculaConfiguration : IEntityTypeConfiguration<Pelicula>
{
    public void Configure(EntityTypeBuilder<Pelicula> builder)
    {
        //definimos las propiedades de los atributos
        builder.ToTable("Peliculas");

        builder.Property(p => p.Titulo)
        .IsRequired()
        .HasMaxLength(150);

        builder.Property(p => p.FechaEstreno)
        .IsRequired()
        .HasColumnType("date");

    }
}
