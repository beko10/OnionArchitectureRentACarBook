using OnionArchitectureCarBook.Application.Repositories.FeatureRepository;
using OnionArchitectureCarBook.Domain.Entities;
using OnionArchitectureCarBook.Persistence.Context;

namespace OnionArchitectureCarBook.Persistence.Repositories.EfCoreFeatureRepository;

public class EfCoreFeatureWriteRepository : EfCoreWriteRepository<Feature>, IFeatureWriteRepository
{
    public EfCoreFeatureWriteRepository(AppDbContext context) : base(context)
    {
    }
}
