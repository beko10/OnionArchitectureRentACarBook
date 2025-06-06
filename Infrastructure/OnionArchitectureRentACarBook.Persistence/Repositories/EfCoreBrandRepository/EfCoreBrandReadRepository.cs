using OnionArchitectureRentACarBook.Application.Repositories.BrandRepository;
using OnionArchitectureRentACarBook.Domain.Entities;
using OnionArchitectureRentACarBook.Persistence.Context;

namespace OnionArchitectureRentACarBook.Persistence.Repositories.EfCoreBrandRepository;

public class EfCoreBrandReadRepository : EfCoreReadRepository<Brand>, IBrandReadRepository
{
    public EfCoreBrandReadRepository(AppDbContext context) : base(context)
    {
    }
}
