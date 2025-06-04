using OnionArchitectureCarBook.Application.Repositories.CarFeatureRepository;
using OnionArchitectureCarBook.Domain.Entities;
using OnionArchitectureCarBook.Persistence.Context;

namespace OnionArchitectureCarBook.Persistence.Repositories.EfCoreCarFeatureRepository;

public class EfCoreCarFeatureWriteRepository : EfCoreWriteRepository<CarFeature>, ICarFeatureWriteRepository
{
    public EfCoreCarFeatureWriteRepository(AppDbContext context) : base(context)
    {
    }
}
