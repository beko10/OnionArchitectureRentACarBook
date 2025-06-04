using OnionArchitectureCarBook.Application.Repositories.FooterAdressRepository;
using OnionArchitectureCarBook.Domain.Entities;
using OnionArchitectureCarBook.Persistence.Context;

namespace OnionArchitectureCarBook.Persistence.Repositories.EfCoreFooterAdressRepository;

public class EfCoreFooterAdressWriteRepository : EfCoreWriteRepository<FooterAdress>, IFooterAdressWriteRepository
{
    public EfCoreFooterAdressWriteRepository(AppDbContext context) : base(context)
    {
    }
}
