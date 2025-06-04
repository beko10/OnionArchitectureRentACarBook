using MediatR;

namespace OnionArchitectureCarBook.Application.Features.Query.AboutQueries.GetByIdAboutQuery;

public class GetByIdAboutQueryRequest : IRequest<GetByIdAboutQueryResponse>
{
    public string? Id { get; set; } 
}
