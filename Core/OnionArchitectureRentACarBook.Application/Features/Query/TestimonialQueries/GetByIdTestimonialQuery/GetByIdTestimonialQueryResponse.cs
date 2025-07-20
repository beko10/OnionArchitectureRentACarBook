using OnionArchitectureRentACarBook.Application.DTOs.TestimonialDtos;
using OnionArchitectureRentACarBook.Application.Utilities.Results;

namespace OnionArchitectureRentACarBook.Application.Features.Query.TestimonialQueries.GetByIdTestimonialQuery;

public class GetByIdTestimonialQueryResponse
{
    public ResultData<TestimonialQueryDto> Result { get; set; } = null!;
} 