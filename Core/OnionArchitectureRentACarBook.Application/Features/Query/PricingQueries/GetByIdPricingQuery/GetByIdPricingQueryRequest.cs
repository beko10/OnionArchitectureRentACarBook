using MediatR;

namespace OnionArchitectureRentACarBook.Application.Features.Query.PricingQueries.GetByIdPricingQuery;

public class GetByIdPricingQueryRequest : IRequest<GetByIdPricingQueryResponse>
{
    public string Id { get; set; } = null!;
} 