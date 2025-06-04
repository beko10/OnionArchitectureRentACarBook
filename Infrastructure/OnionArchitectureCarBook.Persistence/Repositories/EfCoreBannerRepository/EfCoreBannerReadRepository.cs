using OnionArchitectureCarBook.Application.Repositories.BannerRepository;
using OnionArchitectureCarBook.Domain.Entities;
using OnionArchitectureCarBook.Persistence.Context;

namespace OnionArchitectureCarBook.Persistence.Repositories.EfCoreBannerRepository;

public class EfCoreBannerReadRepository : EfCoreReadRepository<Banner>, IBannerReadRepository
{
    public EfCoreBannerReadRepository(AppDbContext context) : base(context)
    {
    }
}
