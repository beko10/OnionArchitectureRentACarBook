using OnionArchitectureCarBook.Application.Repositories.CarPricingRepository;
using OnionArchitectureCarBook.Domain.Entities;
using OnionArchitectureCarBook.Persistence.Context;

namespace OnionArchitectureCarBook.Persistence.Repositories.EfCoreCarPricingRepository;

public class EfCoreCarPricingReadRepository : EfCoreReadRepository<CarPricing>, ICarPricingReadRepository
{
    public EfCoreCarPricingReadRepository(AppDbContext context) : base(context)
    {
    }
}
