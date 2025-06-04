using OnionArchitectureCarBook.Application.Repositories.TestimonialRepository;
using OnionArchitectureCarBook.Domain.Entities;
using OnionArchitectureCarBook.Persistence.Context;

namespace OnionArchitectureCarBook.Persistence.Repositories.EfCoreTestimonialRepository;

public class EfCoreTestimonialWriteRepository : EfCoreWriteRepository<Testimonial>, ITestimonialWriteRepository
{
    public EfCoreTestimonialWriteRepository(AppDbContext context) : base(context)
    {
    }
}
