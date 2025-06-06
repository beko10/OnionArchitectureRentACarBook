using OnionArchitectureRentACarBook.Application.Repositories.TestimonialRepository;
using OnionArchitectureRentACarBook.Domain.Entities;
using OnionArchitectureRentACarBook.Persistence.Context;

namespace OnionArchitectureRentACarBook.Persistence.Repositories.EfCoreTestimonialRepository;

public class EfCoreTestimonialWriteRepository : EfCoreWriteRepository<Testimonial>, ITestimonialWriteRepository
{
    public EfCoreTestimonialWriteRepository(AppDbContext context) : base(context)
    {
    }
}
