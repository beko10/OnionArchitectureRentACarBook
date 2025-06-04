using OnionArchitectureCarBook.Application.Repositories.CarFeatureRepository;
using OnionArchitectureCarBook.Application.Repositories.CarPricingRepository;
using OnionArchitectureCarBook.Domain.Entities;
using OnionArchitectureCarBook.Persistence.Context;

namespace OnionArchitectureCarBook.Persistence.Repositories.EfCoreCarPricingRepository;

public class EfCoreCarPricingWriteRepository : EfCoreWriteRepository<CarPricing>, ICarPricingWriteRepository
{
    public EfCoreCarPricingWriteRepository(AppDbContext context) : base(context)
    {
    }
}
