
namespace Core.Interfaces;

public interface IUnitOfWorkInterface
{
    //definimos las interfaces creadas

    IActorInterface Actores { get; }
    IComentarioInterface Comentarios { get; }
    IGeneroInterface Generos { get; }
    IPeliculaInterface Peliculas { get; }
    IPeliculaActorInterface PeliculasActores { get; }

    Task<int> SaveAsync();
        
}
