using OnionArchitectureRentACarBook.Application.Repositories.CategoryRepository;
using OnionArchitectureRentACarBook.Domain.Entities;
using OnionArchitectureRentACarBook.Persistence.Context;

namespace OnionArchitectureRentACarBook.Persistence.Repositories.EfCoreCategoryRepository;

public class EfCoreCategoryWriteRepository : EfCoreWriteRepository<Category>, ICategoryWriteRepository
{
    public EfCoreCategoryWriteRepository(AppDbContext context) : base(context)
    {
    }
}
