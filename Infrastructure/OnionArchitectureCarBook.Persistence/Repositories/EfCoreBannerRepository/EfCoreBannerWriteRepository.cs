using OnionArchitectureCarBook.Application.Repositories.BannerRepository;
using OnionArchitectureCarBook.Domain.Entities;
using OnionArchitectureCarBook.Persistence.Context;

namespace OnionArchitectureCarBook.Persistence.Repositories.EfCoreBannerRepository;

public class EfCoreBannerWriteRepository : EfCoreWriteRepository<Banner>, IBannerWriteRepository
{
    public EfCoreBannerWriteRepository(AppDbContext context) : base(context)
    {
    }
}
