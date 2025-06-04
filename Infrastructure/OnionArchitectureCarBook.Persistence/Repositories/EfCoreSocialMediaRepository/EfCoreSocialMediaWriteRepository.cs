using OnionArchitectureCarBook.Application.Repositories.SocialMediaRepository;
using OnionArchitectureCarBook.Domain.Entities;
using OnionArchitectureCarBook.Persistence.Context;

namespace OnionArchitectureCarBook.Persistence.Repositories.EfCoreSocialMediaRepository;

public class EfCoreSocialMediaWriteRepository : EfCoreWriteRepository<SocialMedia>, ISocialMediaWriteRepository
{
    public EfCoreSocialMediaWriteRepository(AppDbContext context) : base(context)
    {
    }
}
