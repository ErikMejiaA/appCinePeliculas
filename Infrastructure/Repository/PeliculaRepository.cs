
using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class PeliculaRepository : IPeliculaInterface
{
    private readonly appCinePeliculaContext _context;

    public PeliculaRepository(appCinePeliculaContext context)
    {
        _context = context;
    }

    public void Add(Pelicula entity)
    {
        _context.Set<Pelicula>().Add(entity);
    }

    public void AddRange(IEnumerable<Pelicula> entities)
    {
        _context.Set<Pelicula>().AddRange(entities);
    }

    public IEnumerable<Pelicula> Find(Expression<Func<Pelicula, bool>> expression)
    {
        return _context.Set<Pelicula>().Where(expression);
    }

    public async Task<IEnumerable<Pelicula>> GetAllAsync()
    {
        return await _context.Set<Pelicula>().ToListAsync();
    }

    public async Task<Pelicula> GetByIdAsync(int id)
    {
        return await _context.Set<Pelicula>().FindAsync();
    }

    public void Remove(Pelicula entity)
    {
        _context.Set<Pelicula>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<Pelicula> entities)
    {
        _context.Set<Pelicula>().RemoveRange(entities);
    }

    public void Update(Pelicula entity)
    {
        _context.Set<Pelicula>().Update(entity);
    }
}
