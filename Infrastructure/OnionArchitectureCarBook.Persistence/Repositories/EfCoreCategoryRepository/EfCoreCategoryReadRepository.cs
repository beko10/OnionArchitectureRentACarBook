using OnionArchitectureCarBook.Application.Repositories.CategoryRepository;
using OnionArchitectureCarBook.Domain.Entities;
using OnionArchitectureCarBook.Persistence.Context;

namespace OnionArchitectureCarBook.Persistence.Repositories.EfCoreCategoryRepository;

public class EfCoreCategoryReadRepository : EfCoreReadRepository<Category>, ICategoryReadRepository
{
    public EfCoreCategoryReadRepository(AppDbContext context) : base(context)
    {
    }
}
