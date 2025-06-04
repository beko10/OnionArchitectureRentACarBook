using OnionArchitectureCarBook.Application.Repositories.ServiceRepository;
using OnionArchitectureCarBook.Domain.Entities;
using OnionArchitectureCarBook.Persistence.Context;

namespace OnionArchitectureCarBook.Persistence.Repositories.EfCoreServiceRepository;

public class EfCoreServiceWriteRepository : EfCoreWriteRepository<Service>, IServiceWriteRepository
{
    public EfCoreServiceWriteRepository(AppDbContext context) : base(context)
    {
    }
}
