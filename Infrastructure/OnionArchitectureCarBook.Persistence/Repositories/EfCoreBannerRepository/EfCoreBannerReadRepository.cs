using OnionArchitectureRentACarBook.Application.Repositories.BannerRepository;
using OnionArchitectureRentACarBook.Domain.Entities;
using OnionArchitectureRentACarBook.Persistence.Context;

namespace OnionArchitectureRentACarBook.Persistence.Repositories.EfCoreBannerRepository;

public class EfCoreBannerReadRepository : EfCoreReadRepository<Banner>, IBannerReadRepository
{
    public EfCoreBannerReadRepository(AppDbContext context) : base(context)
    {
    }
}
