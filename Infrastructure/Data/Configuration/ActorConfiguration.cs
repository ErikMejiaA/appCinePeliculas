
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class ActorConfiguration : IEntityTypeConfiguration<Actor>
{ 
    public void Configure(EntityTypeBuilder<Actor> builder)
    {
        //definimos las propiedades de los atributos
        builder.ToTable("Actores");

        builder.Property(p => p.Nombre)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.Fortuna)
        .IsRequired();

        builder.Property(p => p.FechaNacimiento)
        .IsRequired()
        .HasColumnType("date");
        
    }
}