
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Interfaces;

public interface IPeliculaInterface
{
    //escribimos los metodos para el crud
    Task<Pelicula> GetByIdAsync(int id);
    Task<IEnumerable<Pelicula>> GetAllAsync();
    IEnumerable<Pelicula> Find(Expression<Func<Pelicula, bool>> expression);
    void Add(Pelicula entity);
    void AddRange(IEnumerable<Pelicula> entities);
    void Remove(Pelicula entity);
    void RemoveRange(IEnumerable<Pelicula> entities);
    void Update(Pelicula entity);
    
}
