using OnionArchitectureCarBook.Application.Repositories.FeatureRepository;
using OnionArchitectureCarBook.Domain.Entities;
using OnionArchitectureCarBook.Persistence.Context;

namespace OnionArchitectureCarBook.Persistence.Repositories.EfCoreFeatureRepository;

public class EfCoreFeatureReadRepository : EfCoreReadRepository<Feature>, IFeatureReadRepository
{
    public EfCoreFeatureReadRepository(AppDbContext context) : base(context)
    {
    }
}
