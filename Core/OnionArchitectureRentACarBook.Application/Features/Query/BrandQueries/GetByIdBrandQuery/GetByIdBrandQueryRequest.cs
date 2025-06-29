using MediatR;

namespace OnionArchitectureRentACarBook.Application.Features.Query.BrandQueries.GetByIdBrandQuery;

public class GetByIdBrandQueryRequest : IRequest<GetByIdBrandQueryResponse>
{
    public string Id { get; set; } = string.Empty;
}
