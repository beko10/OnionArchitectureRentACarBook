using OnionArchitectureRentACarBook.Application.DTOs.BrandDto;

namespace OnionArchitectureRentACarBook.Application.Features.Query.BrandQueries.GetAllBrandQueries;

public class GetAllBrandQueryResponse
{
    public ResultData<IEnumerable<BrandQueryDto>> Result { get; set; }
}
