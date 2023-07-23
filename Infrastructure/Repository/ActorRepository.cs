
using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class ActorRepository : IActorInterface
{
    private readonly appCinePeliculaContext _context;

    public ActorRepository(appCinePeliculaContext context)
    {
        _context = context;
    }

    public void Add(Actor entity)
    {
        _context.Set<Actor>().Add(entity);
    }

    public void AddRange(IEnumerable<Actor> entities)
    {
        _context.Set<Actor>().AddRange(entities);
    }

    public IEnumerable<Actor> Find(Expression<Func<Actor, bool>> expression)
    {
        return _context.Set<Actor>().Where(expression);
    }

    public async Task<IEnumerable<Actor>> GetAllAsync()
    {
        return await _context.Set<Actor>().ToListAsync();
    }

    public async Task<Actor> GetByIdAsync(int id)
    {
        return await _context.Set<Actor>().FindAsync(id);
    }

    public void Remove(Actor entity)
    {
        _context.Set<Actor>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<Actor> entities)
    {
        _context.Set<Actor>().RemoveRange(entities);
    }

    public void Update(Actor entity)
    {
        _context.Set<Actor>().Update(entity);
    }
}
