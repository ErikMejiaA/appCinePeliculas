
using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Comentario
{
    //definimos los atributos de la entidad 
    [Key]
    public int IdComentario { get; set; }
    public string ? Contenido { get; set; }
    public bool Recomendar { get; set; }

    //FOREIGN KEY
    public int IdPelicula { get; set; }

    //definios la referencia 
    public Pelicula ? Pelicula { get; set; }
    
}
