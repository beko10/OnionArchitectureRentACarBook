using OnionArchitectureRentACarBook.Application.DTOs.SocialMediaDtos;
using OnionArchitectureRentACarBook.Application.Utilities.Results;

namespace OnionArchitectureRentACarBook.Application.Features.Query.SocialMediaQueries.GetAllSocialMediasQuery;

public class GetAllSocialMediasQueryResponse
{
    public ResultData<List<SocialMediaQueryDto>> Result { get; set; } = null!;
} 