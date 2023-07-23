
namespace Core.Entities;

public class PeliculaActor
{
    //definimos las llaves compuestas
    public int IdPelicula { get; set; }
    public int IdActor { get; set; }
    public string ? Personaje { get; set; }
    public string ? Orden { get; set; }

    //definimos una referencia
    public Actor ? Actor { get; set; }
    public Pelicula ? Pelicula { get; set; }
        
}
