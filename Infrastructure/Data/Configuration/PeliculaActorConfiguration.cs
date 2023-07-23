
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class PeliculaActorConfiguration : IEntityTypeConfiguration<PeliculaActor>
{
    public void Configure(EntityTypeBuilder<PeliculaActor> builder)
    {
        //definimos las propiedades de los atributos
        builder.ToTable("PeliculasActores");

        builder.Property(p => p.Personaje)
        .IsRequired()
        .HasMaxLength(150);

        builder.Property(p => p.Orden)
        .IsRequired()
        .HasMaxLength(50);

        //llaves FOREIGN KEY
        builder.HasOne(p => p.Actor)
        .WithMany(p => p.PeliculasActores)
        .HasForeignKey(p => p.IdActor)
        .IsRequired();

        builder.HasOne(p => p.Pelicula)
        .WithMany(p => p.PeliculasActores)
        .HasForeignKey(p => p.IdPelicula)
        .IsRequired();
    }
}
