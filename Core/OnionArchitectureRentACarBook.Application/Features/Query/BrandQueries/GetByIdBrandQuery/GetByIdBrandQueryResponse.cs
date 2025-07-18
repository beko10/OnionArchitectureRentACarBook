using OnionArchitectureRentACarBook.Application.DTOs.BrandDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Query.BrandQueries.GetByIdBrandQuery;

public class GetByIdBrandQueryResponse
{
    public ResultData<BrandQueryDto> Result { get; set; }
}
