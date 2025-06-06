using OnionArchitectureRentACarBook.Application.Repositories.CarPricingRepository;
using OnionArchitectureRentACarBook.Domain.Entities;
using OnionArchitectureRentACarBook.Persistence.Context;

namespace OnionArchitectureRentACarBook.Persistence.Repositories.EfCoreCarPricingRepository;

public class EfCoreCarPricingReadRepository : EfCoreReadRepository<CarPricing>, ICarPricingReadRepository
{
    public EfCoreCarPricingReadRepository(AppDbContext context) : base(context)
    {
    }
}
