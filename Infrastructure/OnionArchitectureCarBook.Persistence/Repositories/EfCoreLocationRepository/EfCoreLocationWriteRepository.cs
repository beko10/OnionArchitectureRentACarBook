using OnionArchitectureCarBook.Application.Repositories.LocationRepository;
using OnionArchitectureCarBook.Domain.Entities;
using OnionArchitectureCarBook.Persistence.Context;

namespace OnionArchitectureCarBook.Persistence.Repositories.EfCoreLocationRepository;

public class EfCoreLocationWriteRepository : EfCoreWriteRepository<Location>, ILocationWriteRepository
{
    public EfCoreLocationWriteRepository(AppDbContext context) : base(context)
    {
    }
}
