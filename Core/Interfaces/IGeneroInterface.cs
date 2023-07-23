
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Interfaces;

public interface IGeneroInterface
{
    //escribimos los metodos para el crud
    Task<Genero> GetByIdAsync(int id);
    Task<IEnumerable<Genero>> GetAllAsync();
    IEnumerable<Genero> Find(Expression<Func<Genero, bool>> expression);
    void Add(Genero entity);
    void AddRange(IEnumerable<Genero> entities);
    void Remove(Genero entity);
    void RemoveRange(IEnumerable<Genero> entities);
    void Update(Genero entity);
        
}
