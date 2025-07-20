using MediatR;

namespace OnionArchitectureRentACarBook.Application.Features.Query.FeatureQueries.GetByIdFeatureQuery;

public class GetByIdFeatureQueryRequest : IRequest<GetByIdFeatureQueryResponse>
{
    public string Id { get; set; } = null!;
} 