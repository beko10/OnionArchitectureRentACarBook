using OnionArchitectureRentACarBook.Application.Repositories.LocationRepository;
using OnionArchitectureRentACarBook.Domain.Entities;
using OnionArchitectureRentACarBook.Persistence.Context;

namespace OnionArchitectureRentACarBook.Persistence.Repositories.EfCoreLocationRepository;

public class EfCoreLocationWriteRepository : EfCoreWriteRepository<Location>, ILocationWriteRepository
{
    public EfCoreLocationWriteRepository(AppDbContext context) : base(context)
    {
    }
}
