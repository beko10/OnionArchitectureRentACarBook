using Microsoft.EntityFrameworkCore;
using OnionArchitectureCarBook.Domain.Common;

namespace OnionArchitectureCarBook.Application.Repositories;

public interface IRepository<TEntity> where TEntity : BaseEntity
{
   DbSet<TEntity> Table { get;}
}
