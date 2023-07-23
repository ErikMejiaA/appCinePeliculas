
using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Genero
{
    //definicion de los atributos de la entidad
    [Key]
    public int IdGenero { get; set; }
    public string ? Nombre { get; set; }

    //definimos la ICollection<>
    public ICollection<PeliculaGenero> ? PeliculasGeneros { get; set; } 

    
}
