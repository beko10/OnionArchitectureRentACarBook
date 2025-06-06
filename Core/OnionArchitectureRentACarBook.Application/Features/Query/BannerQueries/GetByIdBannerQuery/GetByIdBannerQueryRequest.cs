using MediatR;

namespace OnionArchitectureRentACarBook.Application.Features.Query.BannerQueries.GetByIdBannerQuery;

public class GetByIdBannerQueryRequest : IRequest<GetByIdBannerQueryResponse>
{
    public string? Id { get; set; }
}
