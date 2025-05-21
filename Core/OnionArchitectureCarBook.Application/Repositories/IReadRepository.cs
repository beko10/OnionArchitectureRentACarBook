using OnionArchitectureCarBook.Domain.Common;
using System.Linq.Expressions;

namespace OnionArchitectureCarBook.Application.Repositories;

public interface IReadRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{
    IQueryable<TEntity> GetAll(bool tracking = true);
    IQueryable<TEntity> GetWhere(Expression<Func<bool>> expression, bool tracking = true);
    Task<TEntity> GetSingleAsync(Expression<Func<bool>> expression, bool tracking = true);
    Task<TEntity> GetByIdAsync(string id);
}
