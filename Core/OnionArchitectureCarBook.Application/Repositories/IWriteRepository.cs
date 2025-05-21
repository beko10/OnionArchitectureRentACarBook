using OnionArchitectureCarBook.Domain.Common;
using System.Linq.Expressions;

namespace OnionArchitectureCarBook.Application.Repositories;

public interface IWriteRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{
    Task AddAsync(TEntity entity);
    Task AddRangeAsync(List<TEntity> entities);
    Task RemoveAsync(TEntity entity);
    Task RemoveRangeAsync(List<TEntity> entities);
    void Update(TEntity entity);
}
