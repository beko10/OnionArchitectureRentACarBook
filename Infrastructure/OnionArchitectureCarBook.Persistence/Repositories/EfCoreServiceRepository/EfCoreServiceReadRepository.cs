using OnionArchitectureCarBook.Application.Repositories.ServiceRepository;
using OnionArchitectureCarBook.Domain.Entities;
using OnionArchitectureCarBook.Persistence.Context;

namespace OnionArchitectureCarBook.Persistence.Repositories.EfCoreServiceRepository;

public class EfCoreServiceReadRepository : EfCoreReadRepository<Service>, IServiceReadRepository
{
    public EfCoreServiceReadRepository(AppDbContext context) : base(context)
    {
    }
}
