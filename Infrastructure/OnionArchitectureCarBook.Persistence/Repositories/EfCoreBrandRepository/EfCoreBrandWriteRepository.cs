using OnionArchitectureCarBook.Application.Repositories.BrandRepository;
using OnionArchitectureCarBook.Domain.Entities;
using OnionArchitectureCarBook.Persistence.Context;

namespace OnionArchitectureCarBook.Persistence.Repositories.EfCoreBrandRepository;

public class EfCoreBrandWriteRepository : EfCoreWriteRepository<Brand>, IBrandWriteRepository
{
    public EfCoreBrandWriteRepository(AppDbContext context) : base(context)
    {
    }
}
