
using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Pelicula
{
    //creamos los atributos de la entidad
    [Key]
    public int IdPelicula { get; set; }
    public string ? Titulo { get; set; }
    public bool EnCine { get; set; }
    public DateTime FechaEstreno { get; set; }

    //definimos la ICollection<>
    public ICollection<PeliculaGenero> ? PeliculasGeneros { get; set; }
    public ICollection<PeliculaActor> ? PeliculasActores { get; set; }
    public ICollection<Comentario> ? Comentarios { get; set; }
   
}
