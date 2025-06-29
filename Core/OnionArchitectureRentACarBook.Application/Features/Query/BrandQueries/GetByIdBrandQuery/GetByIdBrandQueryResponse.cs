using OnionArchitectureRentACarBook.Application.DTOs.BrandDto;

namespace OnionArchitectureRentACarBook.Application.Features.Query.BrandQueries.GetByIdBrandQuery;

public class GetByIdBrandQueryResponse
{
    public ResultData<BrandQueryDto> Result { get; set; }
}
