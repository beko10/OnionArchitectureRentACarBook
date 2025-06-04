using OnionArchitectureCarBook.Application.Repositories.PricingRepository;
using OnionArchitectureCarBook.Domain.Entities;
using OnionArchitectureCarBook.Persistence.Context;

namespace OnionArchitectureCarBook.Persistence.Repositories.EfCorePricingRepository;

public class EfCorePricingReadRepository : EfCoreReadRepository<Pricing>, IPricingReadRepository
{
    public EfCorePricingReadRepository(AppDbContext context) : base(context)
    {
    }
}
