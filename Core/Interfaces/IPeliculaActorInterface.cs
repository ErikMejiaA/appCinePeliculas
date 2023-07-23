
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Interfaces;

public interface IPeliculaActorInterface
{
    //escribimos los metodos para el crud
    Task<PeliculaActor> GetByIdAsync(int idPelicula, int idActor);
    Task<IEnumerable<PeliculaActor>> GetAllAsync();
    IEnumerable<PeliculaActor> Find(Expression<Func<PeliculaActor, bool>> expression);
    void Add(PeliculaActor entity);
    void AddRange(IEnumerable<PeliculaActor> entities);
    void Remove(PeliculaActor entity);
    void RemoveRange(IEnumerable<PeliculaActor> entities);
    void Update(PeliculaActor entity);
        
}
