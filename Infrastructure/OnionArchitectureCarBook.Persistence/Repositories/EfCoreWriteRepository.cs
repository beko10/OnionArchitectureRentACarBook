using Microsoft.EntityFrameworkCore;
using OnionArchitectureCarBook.Application.Repositories;
using OnionArchitectureCarBook.Domain.Common;
using OnionArchitectureCarBook.Persistence.Context;

namespace OnionArchitectureCarBook.Persistence.Repositories;

public class EfCoreWriteRepository<TEntity> : IWriteRepository<TEntity> where TEntity : BaseEntity
{
    private readonly AppDbContext _context;
    public DbSet<TEntity> _dbSet;

    public EfCoreWriteRepository(AppDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<TEntity>();
    }


    public async Task AddAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        await _dbSet.AddAsync(entity, cancellationToken);

    }

    public async Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
    {
        await _dbSet.AddRangeAsync(entities, cancellationToken);
    }

    public  Task RemoveAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
       _dbSet.Remove(entity);
       return Task.CompletedTask;     
    }

    public async Task<bool> RemoveIdAsync(string id, CancellationToken cancellationToken = default)
    {
        var hasEntity = await _dbSet.FindAsync(id, cancellationToken);
        if(hasEntity != null)
        {
            _dbSet.Remove(hasEntity);
            return true;
        }
        return false;
    }

    public Task RemoveRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
    {
        _dbSet.RemoveRange(entities);
        return Task.CompletedTask;
    }

    public Task SoftRemoveAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        entity.SoftDeletedDate = DateTime.UtcNow;
        entity.IsDeleted = true;
        _dbSet.Update(entity);
        return Task.CompletedTask;
    }

    public async Task<bool> SoftRemoveIdAsync(string id, CancellationToken cancellationToken = default)
    {
        var hasEntity = await _dbSet.FindAsync(id, cancellationToken);
        if (hasEntity != null)
        {
            hasEntity.SoftDeletedDate = DateTime.UtcNow;
            hasEntity.IsDeleted = true;
            _dbSet.Update(hasEntity);
            return true;
        }
        return false;
    }

    public Task UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        _dbSet.Update(entity);
        return Task.CompletedTask;
    }

    public Task UpdateRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
    {
        _dbSet.UpdateRange(entities);
        return Task.CompletedTask;
    }
}
