using OnionArchitectureRentACarBook.Application.Repositories.CarRepository;
using OnionArchitectureRentACarBook.Domain.Entities;
using OnionArchitectureRentACarBook.Persistence.Context;

namespace OnionArchitectureRentACarBook.Persistence.Repositories.EfCoreCarRepository;

public class EfCoreCarWriteRepository : EfCoreWriteRepository<Car>, ICarWriteRepository
{
    public EfCoreCarWriteRepository(AppDbContext context) : base(context)
    {
    }
}
