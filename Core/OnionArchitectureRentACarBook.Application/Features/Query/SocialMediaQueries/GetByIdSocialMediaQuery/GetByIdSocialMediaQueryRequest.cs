using MediatR;

namespace OnionArchitectureRentACarBook.Application.Features.Query.SocialMediaQueries.GetByIdSocialMediaQuery;

public class GetByIdSocialMediaQueryRequest : IRequest<GetByIdSocialMediaQueryResponse>
{
    public string Id { get; set; } = null!;
} 