using OnionArchitectureRentACarBook.Application.DTOs.BrandDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Query.BrandQueries.GetAllBrandQueries;

public class GetAllBrandQueryResponse
{
    public ResultData<IEnumerable<BrandQueryDto>> Result { get; set; }
}
