using OnionArchitectureRentACarBook.Application.Repositories.BrandRepository;
using OnionArchitectureRentACarBook.Domain.Entities;
using OnionArchitectureRentACarBook.Persistence.Context;

namespace OnionArchitectureRentACarBook.Persistence.Repositories.EfCoreBrandRepository;

public class EfCoreBrandWriteRepository : EfCoreWriteRepository<Brand>, IBrandWriteRepository
{
    public EfCoreBrandWriteRepository(AppDbContext context) : base(context)
    {
    }
}
