using OnionArchitectureRentACarBook.Application.Repositories.CarPricingRepository;
using OnionArchitectureRentACarBook.Domain.Entities;
using OnionArchitectureRentACarBook.Persistence.Context;

namespace OnionArchitectureRentACarBook.Persistence.Repositories.EfCoreCarPricingRepository;

public class EfCoreCarPricingWriteRepository : EfCoreWriteRepository<CarPricing>, ICarPricingWriteRepository
{
    public EfCoreCarPricingWriteRepository(AppDbContext context) : base(context)
    {
    }
}
