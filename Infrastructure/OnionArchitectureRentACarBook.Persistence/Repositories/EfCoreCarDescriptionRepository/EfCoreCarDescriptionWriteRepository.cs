using OnionArchitectureRentACarBook.Application.Repositories.CarDescriptionRepository;
using OnionArchitectureRentACarBook.Domain.Entities;
using OnionArchitectureRentACarBook.Persistence.Context;

namespace OnionArchitectureRentACarBook.Persistence.Repositories.EfCoreCarDescriptionRepository;

public class EfCoreCarDescriptionWriteRepository : EfCoreReadRepository<CarDescription>, ICarDescriptionReadRepository
{
    public EfCoreCarDescriptionWriteRepository(AppDbContext context) : base(context)
    {
    }
}
