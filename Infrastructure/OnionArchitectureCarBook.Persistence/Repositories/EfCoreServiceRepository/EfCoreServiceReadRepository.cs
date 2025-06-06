using OnionArchitectureRentACarBook.Application.Repositories.ServiceRepository;
using OnionArchitectureRentACarBook.Domain.Entities;
using OnionArchitectureRentACarBook.Persistence.Context;

namespace OnionArchitectureRentACarBook.Persistence.Repositories.EfCoreServiceRepository;

public class EfCoreServiceReadRepository : EfCoreReadRepository<Service>, IServiceReadRepository
{
    public EfCoreServiceReadRepository(AppDbContext context) : base(context)
    {
    }
}
