using OnionArchitectureCarBook.Application.Repositories.FooterAdressRepository;
using OnionArchitectureCarBook.Domain.Entities;
using OnionArchitectureCarBook.Persistence.Context;

namespace OnionArchitectureCarBook.Persistence.Repositories.EfCoreFooterAdressRepository;

public class EfCoreFooterAdressReadRepository : EfCoreReadRepository<FooterAdress>, IFooterAdressReadRepository
{
    public EfCoreFooterAdressReadRepository(AppDbContext context) : base(context)
    {
    }
}
