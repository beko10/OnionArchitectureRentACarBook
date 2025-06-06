using OnionArchitectureRentACarBook.Application.Repositories.TestimonialRepository;
using OnionArchitectureRentACarBook.Domain.Entities;
using OnionArchitectureRentACarBook.Persistence.Context;

namespace OnionArchitectureRentACarBook.Persistence.Repositories.EfCoreTestimonialRepository;

public class EfCoreTestimonialReadRepository : EfCoreReadRepository<Testimonial>, ITestimonialReadRepository
{
    public EfCoreTestimonialReadRepository(AppDbContext context) : base(context)
    {
    }
}
