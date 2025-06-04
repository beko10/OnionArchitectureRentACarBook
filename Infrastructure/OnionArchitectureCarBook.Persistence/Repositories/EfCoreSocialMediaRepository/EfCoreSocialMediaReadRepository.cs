using OnionArchitectureCarBook.Application.Repositories.SocialMediaRepository;
using OnionArchitectureCarBook.Domain.Entities;
using OnionArchitectureCarBook.Persistence.Context;

namespace OnionArchitectureCarBook.Persistence.Repositories.EfCoreSocialMediaRepository;

public class EfCoreSocialMediaReadRepository : EfCoreReadRepository<SocialMedia>, ISocialMediaReadRepository
{
    public EfCoreSocialMediaReadRepository(AppDbContext context) : base(context)
    {
    }
}
