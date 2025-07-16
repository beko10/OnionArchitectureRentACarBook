using MediatR;
using OnionArchitectureRentACarBook.Application.Features.Query.CarPricingQuery.GetByIdCarPricingQuery;

namespace OnionArchitectureRentACarBook.Application.Features.Query.CarPricingQuery.GetByIdCarPricingQuery;

public class GetByIdCarPricingQueryRequest : IRequest<GetByIdCarPricingQueryResponse>
{
    public string? Id { get; set; }
}