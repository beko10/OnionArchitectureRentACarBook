using OnionArchitectureCarBook.Application.Repositories.CarDescriptionRepository;
using OnionArchitectureCarBook.Domain.Entities;
using OnionArchitectureCarBook.Persistence.Context;

namespace OnionArchitectureCarBook.Persistence.Repositories.EfCoreCarDescriptionRepository;

public class EfCoreCarDescriptionWriteRepository : EfCoreReadRepository<CarDescription>, ICarDescriptionReadRepository
{
    public EfCoreCarDescriptionWriteRepository(AppDbContext context) : base(context)
    {
    }
}
