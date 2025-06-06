using OnionArchitectureRentACarBook.Application.Repositories.ServiceRepository;
using OnionArchitectureRentACarBook.Domain.Entities;
using OnionArchitectureRentACarBook.Persistence.Context;

namespace OnionArchitectureRentACarBook.Persistence.Repositories.EfCoreServiceRepository;

public class EfCoreServiceWriteRepository : EfCoreWriteRepository<Service>, IServiceWriteRepository
{
    public EfCoreServiceWriteRepository(AppDbContext context) : base(context)
    {
    }
}
