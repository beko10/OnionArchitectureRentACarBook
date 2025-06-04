using OnionArchitectureCarBook.Application.Repositories.CarFeatureRepository;
using OnionArchitectureCarBook.Domain.Entities;
using OnionArchitectureCarBook.Persistence.Context;

namespace OnionArchitectureCarBook.Persistence.Repositories.EfCoreCarFeatureRepository;

public class EfCoreCarFeatureReadRepository : EfCoreReadRepository<CarFeature>, ICarFeatureReadRepository
{
    public EfCoreCarFeatureReadRepository(AppDbContext context) : base(context)
    {
    }
}
