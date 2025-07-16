using OnionArchitectureRentACarBook.Application.DTOs.CarPricingDto;

namespace OnionArchitectureRentACarBook.Application.Features.Query.CarPricingQuery.GetByIdCarPricingQuery;

public class GetByIdCarPricingQueryResponse
{
    public ResultData<CarPricingQueryDto> Result { get; set; } = null!;
}