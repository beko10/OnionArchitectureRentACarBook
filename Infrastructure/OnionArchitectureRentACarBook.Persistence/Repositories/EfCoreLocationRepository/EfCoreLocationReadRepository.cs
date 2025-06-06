using OnionArchitectureRentACarBook.Application.Repositories.LocationRepository;
using OnionArchitectureRentACarBook.Domain.Entities;
using OnionArchitectureRentACarBook.Persistence.Context;

namespace OnionArchitectureRentACarBook.Persistence.Repositories.EfCoreLocationRepository;

public class EfCoreLocationReadRepository : EfCoreReadRepository<Location>, ILocationReadRepository
{
    public EfCoreLocationReadRepository(AppDbContext context) : base(context)
    {
    }
}
