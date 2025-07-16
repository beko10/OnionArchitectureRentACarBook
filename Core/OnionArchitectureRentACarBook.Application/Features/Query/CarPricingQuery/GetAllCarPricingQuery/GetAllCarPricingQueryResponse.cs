

using OnionArchitectureRentACarBook.Application.DTOs.CarPricingDto;

namespace OnionArchitectureRentACarBook.Application.Features.Query.CarPricingQuery.GetAllCarPricingQuery;

public class GetAllCarPricingQueryResponse
{
    public ResultData<IEnumerable<CarPricingQueryDto>> Result { get; set; } = null!;
}