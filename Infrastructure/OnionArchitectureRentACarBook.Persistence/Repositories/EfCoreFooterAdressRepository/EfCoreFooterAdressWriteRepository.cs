using OnionArchitectureRentACarBook.Application.Repositories.FooterAdressRepository;
using OnionArchitectureRentACarBook.Domain.Entities;
using OnionArchitectureRentACarBook.Persistence.Context;

namespace OnionArchitectureRentACarBook.Persistence.Repositories.EfCoreFooterAdressRepository;

public class EfCoreFooterAdressWriteRepository : EfCoreWriteRepository<FooterAdress>, IFooterAdressWriteRepository
{
    public EfCoreFooterAdressWriteRepository(AppDbContext context) : base(context)
    {
    }
}
