using MediatR;

namespace OnionArchitectureRentACarBook.Application.Features.Query.FooterAdressQueries.GetByIdFooterAdressQuery;

public class GetByIdFooterAdressQueryRequest : IRequest<GetByIdFooterAdressQueryResponse>
{
    public string Id { get; set; } = null!;
} 