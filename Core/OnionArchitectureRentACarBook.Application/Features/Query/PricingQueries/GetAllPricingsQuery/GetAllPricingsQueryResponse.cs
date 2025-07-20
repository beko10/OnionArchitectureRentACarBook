using OnionArchitectureRentACarBook.Application.DTOs.PricingDtos;
using OnionArchitectureRentACarBook.Application.Utilities.Results;

namespace OnionArchitectureRentACarBook.Application.Features.Query.PricingQueries.GetAllPricingsQuery;

public class GetAllPricingsQueryResponse
{
    public ResultData<List<PricingQueryDto>> Result { get; set; } = null!;
} 