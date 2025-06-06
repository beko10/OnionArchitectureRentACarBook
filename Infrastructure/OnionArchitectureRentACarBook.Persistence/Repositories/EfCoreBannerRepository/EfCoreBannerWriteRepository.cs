using OnionArchitectureRentACarBook.Application.Repositories.BannerRepository;
using OnionArchitectureRentACarBook.Domain.Entities;
using OnionArchitectureRentACarBook.Persistence.Context;

namespace OnionArchitectureRentACarBook.Persistence.Repositories.EfCoreBannerRepository;

public class EfCoreBannerWriteRepository : EfCoreWriteRepository<Banner>, IBannerWriteRepository
{
    public EfCoreBannerWriteRepository(AppDbContext context) : base(context)
    {
    }
}
