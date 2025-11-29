using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using VisitXpress.Repositories.Data;

namespace VisitXpress.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    protected readonly VisitXpressDbContext _context;
    public Repository(VisitXpressDbContext context) { _context = context; }

    public async Task AddAsync(TEntity entity) => await _context.Set<TEntity>().AddAsync(entity);
    public async Task<IEnumerable<TEntity>> GetAllAsync() => await _context.Set<TEntity>().ToListAsync();
    public async Task<TEntity?> GetByIdAsync(int id) => await _context.Set<TEntity>().FindAsync(id);
    public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate) => await _context.Set<TEntity>().Where(predicate).ToListAsync();
    public void Remove(TEntity entity) => _context.Set<TEntity>().Update(entity);
    public void Update(TEntity entity) => _context.Set<TEntity>().Update(entity);
}

