
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class GeneroConfiguration : IEntityTypeConfiguration<Genero>
{
    public void Configure(EntityTypeBuilder<Genero> builder)
    {
        //definimos las propiedades de la entidad
        builder.ToTable("Generos");

        builder.Property(p => p.Nombre)
        .IsRequired()
        .HasMaxLength(50);

    }
}
