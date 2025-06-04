using Microsoft.EntityFrameworkCore.Migrations;
using OnionArchitectureCarBook.Application.Repositories;
using OnionArchitectureCarBook.Domain.Common;

namespace OnionArchitectureCarBook.Persistence.Repositories;

public class EfCoreRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{

}
