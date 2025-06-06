using OnionArchitectureRentACarBook.Application.Repositories.SocialMediaRepository;
using OnionArchitectureRentACarBook.Domain.Entities;
using OnionArchitectureRentACarBook.Persistence.Context;

namespace OnionArchitectureRentACarBook.Persistence.Repositories.EfCoreSocialMediaRepository;

public class EfCoreSocialMediaReadRepository : EfCoreReadRepository<SocialMedia>, ISocialMediaReadRepository
{
    public EfCoreSocialMediaReadRepository(AppDbContext context) : base(context)
    {
    }
}
