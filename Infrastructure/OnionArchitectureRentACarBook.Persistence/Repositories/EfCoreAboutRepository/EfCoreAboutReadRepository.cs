using OnionArchitectureRentACarBook.Application.Repositories.AboutRepository;
using OnionArchitectureRentACarBook.Domain.Entities;
using OnionArchitectureRentACarBook.Persistence.Context;

namespace OnionArchitectureRentACarBook.Persistence.Repositories.EfCoreAboutRepository;

public class EfCoreAboutReadRepository : EfCoreReadRepository<About>, IAboutReadRepository
{
    public EfCoreAboutReadRepository(AppDbContext context) : base(context)
    {
    }
}
