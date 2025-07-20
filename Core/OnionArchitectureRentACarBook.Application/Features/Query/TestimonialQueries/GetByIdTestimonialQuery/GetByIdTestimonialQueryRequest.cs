using MediatR;

namespace OnionArchitectureRentACarBook.Application.Features.Query.TestimonialQueries.GetByIdTestimonialQuery;

public class GetByIdTestimonialQueryRequest : IRequest<GetByIdTestimonialQueryResponse>
{
    public string Id { get; set; } = null!;
} 