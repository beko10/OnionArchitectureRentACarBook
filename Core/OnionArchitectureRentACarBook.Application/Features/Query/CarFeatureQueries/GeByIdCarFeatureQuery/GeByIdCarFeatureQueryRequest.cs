using MediatR;

namespace OnionArchitectureRentACarBook.Application.Features.Query.CarFeatureQueries.GeByIdCarFeatureQuery;

public class GeByIdCarFeatureQueryRequest : IRequest<GeByIdCarFeatureQueryResponse>
{
    public string? Id { get; set; }
}
