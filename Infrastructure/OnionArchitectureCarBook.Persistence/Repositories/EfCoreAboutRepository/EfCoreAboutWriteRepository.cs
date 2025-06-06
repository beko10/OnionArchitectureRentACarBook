using OnionArchitectureRentACarBook.Application.Repositories.AboutRepository;
using OnionArchitectureRentACarBook.Domain.Entities;
using OnionArchitectureRentACarBook.Persistence.Context;

namespace OnionArchitectureRentACarBook.Persistence.Repositories.EfCoreAboutRepository;

public class EfCoreAboutWriteRepository : EfCoreWriteRepository<About>, IAboutWriteRepository
{
    public EfCoreAboutWriteRepository(AppDbContext context) : base(context)
    {
    }
}
