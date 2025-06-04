using OnionArchitectureCarBook.Application.Repositories.TestimonialRepository;
using OnionArchitectureCarBook.Domain.Entities;
using OnionArchitectureCarBook.Persistence.Context;

namespace OnionArchitectureCarBook.Persistence.Repositories.EfCoreTestimonialRepository;

public class EfCoreTestimonialReadRepository : EfCoreReadRepository<Testimonial>, ITestimonialReadRepository
{
    public EfCoreTestimonialReadRepository(AppDbContext context) : base(context)
    {
    }
}
