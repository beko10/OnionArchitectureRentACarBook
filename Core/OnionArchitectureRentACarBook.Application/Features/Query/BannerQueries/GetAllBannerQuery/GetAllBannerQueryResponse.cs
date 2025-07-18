﻿using OnionArchitectureRentACarBook.Application.DTOs.BannerDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Query.BannerQueries.GetAllBannerQuery;

public class GetAllBannerQueryResponse
{
    public ResultData<IEnumerable<BannerQueryDto>> Result { get; set; } = null!;
}
