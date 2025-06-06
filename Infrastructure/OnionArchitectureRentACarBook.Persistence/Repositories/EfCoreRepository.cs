using Microsoft.EntityFrameworkCore.Migrations;
using OnionArchitectureRentACarBook.Application.Repositories;
using OnionArchitectureRentACarBook.Domain.Common;

namespace OnionArchitectureRentACarBook.Persistence.Repositories;

public class EfCoreRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{

}
