using OnionArchitectureCarBook.Application.Repositories.AboutRepository;
using OnionArchitectureCarBook.Domain.Entities;
using OnionArchitectureCarBook.Persistence.Context;

namespace OnionArchitectureCarBook.Persistence.Repositories.EfCoreAboutRepository;

public class EfCoreAboutReadRepository : EfCoreReadRepository<About>, IAboutReadRepository
{
    public EfCoreAboutReadRepository(AppDbContext context) : base(context)
    {
    }
}
