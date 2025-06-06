using OnionArchitectureRentACarBook.Application.Repositories.CategoryRepository;
using OnionArchitectureRentACarBook.Domain.Entities;
using OnionArchitectureRentACarBook.Persistence.Context;

namespace OnionArchitectureRentACarBook.Persistence.Repositories.EfCoreCategoryRepository;

public class EfCoreCategoryReadRepository : EfCoreReadRepository<Category>, ICategoryReadRepository
{
    public EfCoreCategoryReadRepository(AppDbContext context) : base(context)
    {
    }
}
