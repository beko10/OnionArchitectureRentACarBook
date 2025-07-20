using MediatR;

namespace OnionArchitectureRentACarBook.Application.Features.Query.ContactQueries.GetByIdContactQuery;

public class GetByIdContactQueryRequest : IRequest<GetByIdContactQueryResponse>
{
    public string Id { get; set; } = null!;
} 