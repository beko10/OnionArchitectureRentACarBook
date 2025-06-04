using OnionArchitectureCarBook.Application.Repositories.BrandRepository;
using OnionArchitectureCarBook.Domain.Entities;
using OnionArchitectureCarBook.Persistence.Context;

namespace OnionArchitectureCarBook.Persistence.Repositories.EfCoreBrandRepository;

public class EfCoreBrandReadRepository : EfCoreReadRepository<Brand>, IBrandReadRepository
{
    public EfCoreBrandReadRepository(AppDbContext context) : base(context)
    {
    }
}
