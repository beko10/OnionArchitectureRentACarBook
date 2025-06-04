using OnionArchitectureCarBook.Application.Repositories.CarRepository;
using OnionArchitectureCarBook.Domain.Entities;
using OnionArchitectureCarBook.Persistence.Context;

namespace OnionArchitectureCarBook.Persistence.Repositories.EfCoreCarRepository;

public class EfCoreCarReadRepository : EfCoreReadRepository<Car>, ICarReadRepository
{
    public EfCoreCarReadRepository(AppDbContext context) : base(context)
    {
    }
}
