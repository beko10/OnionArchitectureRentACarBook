using OnionArchitectureRentACarBook.Application.Repositories.CarFeatureRepository;
using OnionArchitectureRentACarBook.Domain.Entities;
using OnionArchitectureRentACarBook.Persistence.Context;

namespace OnionArchitectureRentACarBook.Persistence.Repositories.EfCoreCarFeatureRepository;

public class EfCoreCarFeatureReadRepository : EfCoreReadRepository<CarFeature>, ICarFeatureReadRepository
{
    public EfCoreCarFeatureReadRepository(AppDbContext context) : base(context)
    {
    }
}
