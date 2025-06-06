using OnionArchitectureRentACarBook.Application.Repositories.CarRepository;
using OnionArchitectureRentACarBook.Domain.Entities;
using OnionArchitectureRentACarBook.Persistence.Context;

namespace OnionArchitectureRentACarBook.Persistence.Repositories.EfCoreCarRepository;

public class EfCoreCarReadRepository : EfCoreReadRepository<Car>, ICarReadRepository
{
    public EfCoreCarReadRepository(AppDbContext context) : base(context)
    {
    }
}
