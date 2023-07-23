
namespace Core.Entities;

public class PeliculaGenero
{
    //definimos las  llaves compuestas
    public int IdPelicula { get; set; }
    public int IdGenero { get; set; }

    //definimos la referencia
    public Genero ? Genero { get; set; }
    public Pelicula ? Pelicula { get; set; }
       
}
