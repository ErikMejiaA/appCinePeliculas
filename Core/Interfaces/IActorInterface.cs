
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Interfaces;

public interface IActorInterface
{
    //escribimos los metodos para el crud
    Task<Actor> GetByIdAsync(int id);
    Task<IEnumerable<Actor>> GetAllAsync();
    IEnumerable<Actor> Find(Expression<Func<Actor, bool>> expression);
    void Add(Actor entity);
    void AddRange(IEnumerable<Actor> entities);
    void Remove(Actor entity);
    void RemoveRange(IEnumerable<Actor> entities);
    void Update(Actor entity);
}
