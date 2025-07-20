using MediatR;

namespace OnionArchitectureRentACarBook.Application.Features.Query.LocationQueries.GetByIdLocationQuery;

public class GetByIdLocationQueryRequest : IRequest<GetByIdLocationQueryResponse>
{
    public string Id { get; set; } = null!;
} 