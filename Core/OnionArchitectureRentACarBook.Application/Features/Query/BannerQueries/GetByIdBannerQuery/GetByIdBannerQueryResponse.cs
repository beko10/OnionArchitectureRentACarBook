using OnionArchitectureRentACarBook.Application.DTOs.BannerDto;

namespace OnionArchitectureRentACarBook.Application.Features.Query.BannerQueries.GetByIdBannerQuery;

public class GetByIdBannerQueryResponse
{
    public ResultData<BannerQueryDto> Result { get; set; } = null!;
}
