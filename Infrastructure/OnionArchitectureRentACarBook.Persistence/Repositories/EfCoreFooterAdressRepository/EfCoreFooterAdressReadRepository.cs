using OnionArchitectureRentACarBook.Application.Repositories.FooterAdressRepository;
using OnionArchitectureRentACarBook.Domain.Entities;
using OnionArchitectureRentACarBook.Persistence.Context;

namespace OnionArchitectureRentACarBook.Persistence.Repositories.EfCoreFooterAdressRepository;

public class EfCoreFooterAdressReadRepository : EfCoreReadRepository<FooterAdress>, IFooterAdressReadRepository
{
    public EfCoreFooterAdressReadRepository(AppDbContext context) : base(context)
    {
    }
}
