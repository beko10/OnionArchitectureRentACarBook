using Microsoft.EntityFrameworkCore;
using OnionArchitectureRentACarBook.Application.Pagination;
using OnionArchitectureRentACarBook.Application.Repositories;
using OnionArchitectureRentACarBook.Domain.Common;
using OnionArchitectureRentACarBook.Persistence.Context;
using System.Linq.Expressions;

namespace OnionArchitectureRentACarBook.Persistence.Repositories;

public class EfCoreReadRepository<TEntity> : IReadRepository<TEntity> where TEntity : BaseEntity
{
    private readonly AppDbContext _context;
    public DbSet<TEntity> _dbSet;

    public EfCoreReadRepository(AppDbContext context)
    {
        _context = context;
        _dbSet = context.Set<TEntity>();    
    }

    public async Task<int> CountAsync(CancellationToken cancellationToken = default)
    {
        return await _dbSet.CountAsync(cancellationToken);
    }

    public async Task<int> CountWhereAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
    {
        return await _dbSet.CountAsync(predicate,cancellationToken);
    }

    public async Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
    {
        return await _dbSet.AnyAsync(predicate,cancellationToken);
    }

    public IQueryable<TEntity> GetAll(bool tracking = true, CancellationToken cancellationToken = default)
    {
        var query = _dbSet.AsQueryable();
        if(!tracking)
        {
            query = query.AsNoTracking();   
        }
        return query;
    }

    public async Task<IEnumerable<TEntity>> GetAllWithIncludesAsync(params Expression<Func<TEntity, object>>[] includes)
    {
        var query = _dbSet.AsQueryable();
        foreach(var include in includes)
        {
            query = query.Include(include);
        }
        return await query.ToListAsync();
    }

    public async Task<TEntity> GetByIdAsync(string id, CancellationToken cancellationToken = default)
    {
        return await _dbSet.FindAsync(id,cancellationToken);
    }

    public async Task<TEntity> GetByIdWithIncludesAsync(string id, params Expression<Func<TEntity, object>>[] includes)
    {
        var query = _dbSet.AsQueryable();
        foreach (var include in includes)
        {
            query = query.Include(include);
        }
        return await query.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<TEntity> GetSingleAsync(Expression<Func<TEntity,bool>> expression, bool tracking = true, CancellationToken cancellationToken = default)
    {
        var query = _dbSet.AsQueryable();
        if(!tracking)
        {
            query = query.AsNoTracking();
        }
        return await query.FirstOrDefaultAsync(expression, cancellationToken);
    }

    public IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> expression, bool tracking = true, CancellationToken cancellationToken = default)
    {
        var query = _dbSet.AsQueryable();
        if(!tracking)
        {
            query = query.AsNoTracking();
        }
        return query.Where(expression);
    }
    public async Task<PagedResult<TEntity>> GetPagedAsync(int pageNumber, int pageSize, CancellationToken cancellationToken = default)
    {
        var totalCount = await _dbSet.CountAsync(cancellationToken);
        var items = await _dbSet
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync(cancellationToken);
        return new PagedResult<TEntity>
        {
            Items = items,
            TotalCount = totalCount,
            PageNumber = pageNumber,
            PageSize = pageSize
        };
    }


    public async Task<PagedResult<TEntity>> GetWherePagedAsync(int pageNumber, int pageSize, Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
    {
        var query = _dbSet.Where(predicate);
        var totalCount = await query.CountAsync(cancellationToken);
        var items = await query
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);

        return new PagedResult<TEntity>
        {
            Items = items,
            TotalCount = totalCount,
            PageNumber = pageNumber,
            PageSize = pageSize
        };
    }
}
