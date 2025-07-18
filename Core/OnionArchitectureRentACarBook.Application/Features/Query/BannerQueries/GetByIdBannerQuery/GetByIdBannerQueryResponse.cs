using OnionArchitectureRentACarBook.Application.DTOs.BannerDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Query.BannerQueries.GetByIdBannerQuery;

public class GetByIdBannerQueryResponse
{
    public ResultData<BannerQueryDto> Result { get; set; } = null!;
}
