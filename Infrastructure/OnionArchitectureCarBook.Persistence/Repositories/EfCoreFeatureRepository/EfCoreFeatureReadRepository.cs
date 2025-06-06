using OnionArchitectureRentACarBook.Application.Repositories.FeatureRepository;
using OnionArchitectureRentACarBook.Domain.Entities;
using OnionArchitectureRentACarBook.Persistence.Context;

namespace OnionArchitectureRentACarBook.Persistence.Repositories.EfCoreFeatureRepository;

public class EfCoreFeatureReadRepository : EfCoreReadRepository<Feature>, IFeatureReadRepository
{
    public EfCoreFeatureReadRepository(AppDbContext context) : base(context)
    {
    }
}
