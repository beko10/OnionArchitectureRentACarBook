using OnionArchitectureRentACarBook.Application.DTOs.TestimonialDtos;
using OnionArchitectureRentACarBook.Application.Utilities.Results;

namespace OnionArchitectureRentACarBook.Application.Features.Query.TestimonialQueries.GetAllTestimonialsQuery;

public class GetAllTestimonialsQueryResponse
{
    public ResultData<List<TestimonialQueryDto>> Result { get; set; } = null!;
} 