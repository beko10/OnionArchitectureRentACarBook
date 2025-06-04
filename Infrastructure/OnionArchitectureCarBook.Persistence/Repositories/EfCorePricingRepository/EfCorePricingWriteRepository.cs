using OnionArchitectureCarBook.Application.Repositories.PricingRepository;
using OnionArchitectureCarBook.Domain.Entities;
using OnionArchitectureCarBook.Persistence.Context;

namespace OnionArchitectureCarBook.Persistence.Repositories.EfCorePricingRepository;

public class EfCorePricingWriteRepository : EfCoreWriteRepository<Pricing>, IPricingWriteRepository
{
    public EfCorePricingWriteRepository(AppDbContext context) : base(context)
    {
    }
}
