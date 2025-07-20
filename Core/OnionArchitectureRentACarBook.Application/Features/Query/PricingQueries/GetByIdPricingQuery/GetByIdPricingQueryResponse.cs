using OnionArchitectureRentACarBook.Application.DTOs.PricingDtos;
using OnionArchitectureRentACarBook.Application.Utilities.Results;

namespace OnionArchitectureRentACarBook.Application.Features.Query.PricingQueries.GetByIdPricingQuery;

public class GetByIdPricingQueryResponse
{
    public ResultData<PricingQueryDto> Result { get; set; } = null!;
} 