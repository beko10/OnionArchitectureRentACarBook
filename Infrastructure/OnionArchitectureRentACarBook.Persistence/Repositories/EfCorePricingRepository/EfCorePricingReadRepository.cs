using OnionArchitectureRentACarBook.Application.Repositories.PricingRepository;
using OnionArchitectureRentACarBook.Domain.Entities;
using OnionArchitectureRentACarBook.Persistence.Context;

namespace OnionArchitectureRentACarBook.Persistence.Repositories.EfCorePricingRepository;

public class EfCorePricingReadRepository : EfCoreReadRepository<Pricing>, IPricingReadRepository
{
    public EfCorePricingReadRepository(AppDbContext context) : base(context)
    {
    }
}
