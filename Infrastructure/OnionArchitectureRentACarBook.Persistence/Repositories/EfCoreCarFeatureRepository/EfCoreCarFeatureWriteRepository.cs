using OnionArchitectureRentACarBook.Application.Repositories.CarFeatureRepository;
using OnionArchitectureRentACarBook.Domain.Entities;
using OnionArchitectureRentACarBook.Persistence.Context;

namespace OnionArchitectureRentACarBook.Persistence.Repositories.EfCoreCarFeatureRepository;

public class EfCoreCarFeatureWriteRepository : EfCoreWriteRepository<CarFeature>, ICarFeatureWriteRepository
{
    public EfCoreCarFeatureWriteRepository(AppDbContext context) : base(context)
    {
    }
}
