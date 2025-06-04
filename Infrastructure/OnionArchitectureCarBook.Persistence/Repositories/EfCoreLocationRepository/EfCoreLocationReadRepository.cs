using OnionArchitectureCarBook.Application.Repositories.LocationRepository;
using OnionArchitectureCarBook.Domain.Entities;
using OnionArchitectureCarBook.Persistence.Context;

namespace OnionArchitectureCarBook.Persistence.Repositories.EfCoreLocationRepository;

public class EfCoreLocationReadRepository : EfCoreReadRepository<Location>, ILocationReadRepository
{
    public EfCoreLocationReadRepository(AppDbContext context) : base(context)
    {
    }
}
