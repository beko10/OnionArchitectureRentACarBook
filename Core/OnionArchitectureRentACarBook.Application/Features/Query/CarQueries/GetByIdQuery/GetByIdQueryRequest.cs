using MediatR;

namespace OnionArchitectureRentACarBook.Application.Features.Query.CarQueries.GetByIdQuery;

public class GetByIdQueryRequest : IRequest<GetByIdQueryResponse>
{
    public string Id { get; set; } = string.Empty;
}
