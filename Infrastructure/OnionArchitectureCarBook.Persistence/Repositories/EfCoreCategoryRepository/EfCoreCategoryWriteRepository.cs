using OnionArchitectureCarBook.Application.Repositories.CategoryRepository;
using OnionArchitectureCarBook.Domain.Entities;
using OnionArchitectureCarBook.Persistence.Context;

namespace OnionArchitectureCarBook.Persistence.Repositories.EfCoreCategoryRepository;

public class EfCoreCategoryWriteRepository : EfCoreWriteRepository<Category>, ICategoryWriteRepository
{
    public EfCoreCategoryWriteRepository(AppDbContext context) : base(context)
    {
    }
}
