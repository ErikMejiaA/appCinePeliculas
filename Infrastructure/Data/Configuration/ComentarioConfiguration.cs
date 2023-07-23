
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class ComentarioConfiguration : IEntityTypeConfiguration<Comentario>
{
    public void Configure(EntityTypeBuilder<Comentario> builder)
    {
        //definimos las propiedades de los atributos 
        builder.ToTable("Comentarios");

        builder.Property(p => p .Contenido)
        .IsRequired()
        .HasMaxLength(150);

        //llave FOREIGN KEY
        builder.HasOne(p => p.Pelicula)
        .WithMany(p => p.Comentarios)
        .HasForeignKey(p => p.IdPelicula)
        .IsRequired();
    }
}
