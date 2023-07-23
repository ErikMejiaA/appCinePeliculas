
using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class PeliculaActorRepository : IPeliculaActorInterface
{
    private readonly appCinePeliculaContext _context;

    public PeliculaActorRepository(appCinePeliculaContext context)
    {
        _context = context;
    }

    public void Add(PeliculaActor entity)
    {
        _context.Set<PeliculaActor>().Add(entity);
    }

    public void AddRange(IEnumerable<PeliculaActor> entities)
    {
        _context.Set<PeliculaActor>().AddRange(entities);
    }

    public IEnumerable<PeliculaActor> Find(Expression<Func<PeliculaActor, bool>> expression)
    {
        return _context.Set<PeliculaActor>().Where(expression);
    }

    public async Task<IEnumerable<PeliculaActor>> GetAllAsync()
    {
        return await _context.Set<PeliculaActor>().ToListAsync();
    }

    public async Task<PeliculaActor> GetByIdAsync(int idPelicula, int idActor)
    {
        return await _context.Set<PeliculaActor>()
        .FirstOrDefaultAsync(p => (p.IdPelicula == idPelicula && p.IdActor == idActor));
    }

    public void Remove(PeliculaActor entity)
    {
        _context.Set<PeliculaActor>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<PeliculaActor> entities)
    {
        _context.Set<PeliculaActor>().RemoveRange(entities);
    }

    public void Update(PeliculaActor entity)
    {
        _context.Set<PeliculaActor>().Update(entity);
    }
}
