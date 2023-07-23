
using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class ComentarioRepository : IComentarioInterface
{
    private readonly appCinePeliculaContext _context;

    public ComentarioRepository(appCinePeliculaContext context)
    {
        _context = context;
    }

    public void Add(Comentario entity)
    {
        _context.Set<Comentario>().Add(entity);
    }

    public void AddRange(IEnumerable<Comentario> entities)
    {
        _context.Set<Comentario>().AddRange(entities);
    }

    public IEnumerable<Comentario> Find(Expression<Func<Comentario, bool>> expression)
    {
        return _context.Set<Comentario>().Where(expression);
    }

    public async Task<IEnumerable<Comentario>> GetAllAsync()
    {
        return await _context.Set<Comentario>().ToListAsync();
    }

    public async Task<Comentario> GetByIdAsync(int id)
    {
        return await _context.Set<Comentario>().FindAsync(id);
    }

    public void Remove(Comentario entity)
    {
        _context.Set<Comentario>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<Comentario> entities)
    {
        _context.Set<Comentario>().RemoveRange(entities);
    }

    public void Update(Comentario entity)
    {
        _context.Set<Comentario>().Update(entity);
    }
}
