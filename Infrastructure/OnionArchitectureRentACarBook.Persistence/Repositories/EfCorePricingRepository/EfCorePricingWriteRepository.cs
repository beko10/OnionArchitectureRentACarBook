using OnionArchitectureRentACarBook.Application.Repositories.PricingRepository;
using OnionArchitectureRentACarBook.Domain.Entities;
using OnionArchitectureRentACarBook.Persistence.Context;

namespace OnionArchitectureRentACarBook.Persistence.Repositories.EfCorePricingRepository;

public class EfCorePricingWriteRepository : EfCoreWriteRepository<Pricing>, IPricingWriteRepository
{
    public EfCorePricingWriteRepository(AppDbContext context) : base(context)
    {
    }
}
