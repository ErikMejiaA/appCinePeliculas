
using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Actor
{
    //definimos los atributos de la entidad
    [Key]
    public int IdActor { get; set; }
    public string ? Nombre { get; set; }
    public decimal Fortuna { get; set; }
    public DateTime FechaNacimiento { get; set; }

    //crea la referencia ICollection<>
    public ICollection<PeliculaActor> ? PeliculasActores { get; set; }
    
}
