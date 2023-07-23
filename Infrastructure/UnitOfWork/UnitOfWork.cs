
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repository;

namespace Infrastructure.UnitOfWork;

public class UnitOfWork : IUnitOfWorkInterface, IDisposable
{
    private readonly appCinePeliculaContext _context;

    //definimos las variables del repositorio
    private ActorRepository ? _actores;
    private ComentarioRepository ? _comentarios;
    private GeneroRepository ? _generos;
    private PeliculaActorRepository ? _peliculasActores;
    private PeliculaRepository ? _peliculas;

    public UnitOfWork(appCinePeliculaContext context)
    {
        _context = context;
    }

    public IActorInterface Actores
    {
        get
        {
            if (_actores == null) {
                _actores = new ActorRepository(_context);
            }
            return _actores;
        }
    }

    public IComentarioInterface Comentarios
    {
        get 
        {
            if (_comentarios == null) {
                _comentarios = new ComentarioRepository(_context);
            }
            return _comentarios;
        }
    }

    public IGeneroInterface Generos
    {
        get
        {
            if (_generos == null) {
                _generos = new GeneroRepository(_context);
            }
            return _generos;
        }
    }

    public IPeliculaInterface Peliculas
    {
        get 
        {
            if (_peliculas == null) {
                _peliculas = new PeliculaRepository(_context);
            }
            return _peliculas;
        }
    }

    public IPeliculaActorInterface PeliculasActores
    {
        get 
        {
            if (_peliculasActores == null) {
                _peliculasActores = new PeliculaActorRepository(_context);
            }
            return _peliculasActores;
        }
    }

    public void Dispose()
    {
        _context.Dispose();
    }

    public Task<int> SaveAsync()
    {
        return _context.SaveChangesAsync();
    }
}
