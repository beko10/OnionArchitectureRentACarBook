using OnionArchitectureCarBook.Application.Repositories.CarRepository;
using OnionArchitectureCarBook.Domain.Entities;
using OnionArchitectureCarBook.Persistence.Context;

namespace OnionArchitectureCarBook.Persistence.Repositories.EfCoreCarRepository;

public class EfCoreCarWriteRepository : EfCoreWriteRepository<Car>, ICarWriteRepository
{
    public EfCoreCarWriteRepository(AppDbContext context) : base(context)
    {
    }
}
