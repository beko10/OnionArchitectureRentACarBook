using MediatR;

namespace OnionArchitectureRentACarBook.Application.Features.Query.CategoryQueries.GetByIdCategoryQuery;

public class GetByIdCategoryQueryRequest : IRequest<GetByIdCategoryQueryResponse>
{
    public string? Id { get; set; }
   
}
