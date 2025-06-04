using OnionArchitectureCarBook.Application.Repositories.CarDescriptionRepository;
using OnionArchitectureCarBook.Domain.Entities;
using OnionArchitectureCarBook.Persistence.Context;

namespace OnionArchitectureCarBook.Persistence.Repositories.EfCoreCarDescriptionRepository;

public class EfCoreCarDescriptionReadRepository : EfCoreReadRepository<CarDescription>, ICarDescriptionReadRepository
{
    public EfCoreCarDescriptionReadRepository(AppDbContext context) : base(context)
    {
    }
}
