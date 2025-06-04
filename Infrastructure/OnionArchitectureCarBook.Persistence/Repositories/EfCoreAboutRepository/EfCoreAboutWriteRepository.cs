using OnionArchitectureCarBook.Application.Repositories.AboutRepository;
using OnionArchitectureCarBook.Domain.Entities;
using OnionArchitectureCarBook.Persistence.Context;

namespace OnionArchitectureCarBook.Persistence.Repositories.EfCoreAboutRepository;

public class EfCoreAboutWriteRepository : EfCoreWriteRepository<About>, IAboutWriteRepository
{
    public EfCoreAboutWriteRepository(AppDbContext context) : base(context)
    {
    }
}
