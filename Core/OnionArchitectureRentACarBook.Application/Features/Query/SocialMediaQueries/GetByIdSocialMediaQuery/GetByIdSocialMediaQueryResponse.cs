using OnionArchitectureRentACarBook.Application.DTOs.SocialMediaDtos;
using OnionArchitectureRentACarBook.Application.Utilities.Results;

namespace OnionArchitectureRentACarBook.Application.Features.Query.SocialMediaQueries.GetByIdSocialMediaQuery;

public class GetByIdSocialMediaQueryResponse
{
    public ResultData<SocialMediaQueryDto> Result { get; set; } = null!;
} 