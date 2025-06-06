using OnionArchitectureRentACarBook.Application.Repositories.SocialMediaRepository;
using OnionArchitectureRentACarBook.Domain.Entities;
using OnionArchitectureRentACarBook.Persistence.Context;

namespace OnionArchitectureRentACarBook.Persistence.Repositories.EfCoreSocialMediaRepository;

public class EfCoreSocialMediaWriteRepository : EfCoreWriteRepository<SocialMedia>, ISocialMediaWriteRepository
{
    public EfCoreSocialMediaWriteRepository(AppDbContext context) : base(context)
    {
    }
}
