
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Interfaces;

public interface IComentarioInterface
{
    //escribimos los metodos para el crud
    Task<Comentario> GetByIdAsync(int id);
    Task<IEnumerable<Comentario>> GetAllAsync();
    IEnumerable<Comentario> Find(Expression<Func<Comentario, bool>> expression);
    void Add(Comentario entity);
    void AddRange(IEnumerable<Comentario> entities);
    void Remove(Comentario entity);
    void RemoveRange(IEnumerable<Comentario> entities);
    void Update(Comentario entity);
        
}
