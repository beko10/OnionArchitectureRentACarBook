using MediatR;

namespace OnionArchitectureRentACarBook.Application.Features.Query.ServiceQueries.GetByIdServiceQuery;

public class GetByIdServiceQueryRequest : IRequest<GetByIdServiceQueryResponse>
{
    public string Id { get; set; } = null!;
} 