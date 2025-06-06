using OnionArchitectureRentACarBook.Application.Repositories.CarDescriptionRepository;
using OnionArchitectureRentACarBook.Domain.Entities;
using OnionArchitectureRentACarBook.Persistence.Context;

namespace OnionArchitectureRentACarBook.Persistence.Repositories.EfCoreCarDescriptionRepository;

public class EfCoreCarDescriptionReadRepository : EfCoreReadRepository<CarDescription>, ICarDescriptionReadRepository
{
    public EfCoreCarDescriptionReadRepository(AppDbContext context) : base(context)
    {
    }
}
