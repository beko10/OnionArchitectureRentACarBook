using OnionArchitectureRentACarBook.Application.Repositories.FeatureRepository;
using OnionArchitectureRentACarBook.Domain.Entities;
using OnionArchitectureRentACarBook.Persistence.Context;

namespace OnionArchitectureRentACarBook.Persistence.Repositories.EfCoreFeatureRepository;

public class EfCoreFeatureWriteRepository : EfCoreWriteRepository<Feature>, IFeatureWriteRepository
{
    public EfCoreFeatureWriteRepository(AppDbContext context) : base(context)
    {
    }
}
