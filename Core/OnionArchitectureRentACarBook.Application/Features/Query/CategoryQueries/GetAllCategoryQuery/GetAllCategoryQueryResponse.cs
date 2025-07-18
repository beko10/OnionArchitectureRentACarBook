using OnionArchitectureRentACarBook.Application.DTOs.CategoryDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Query.CategoryQueries.GetAllCategoryQuery;

public class GetAllCategoryQueryResponse
{
    public ResultData<IEnumerable<CategoryQueryDto>> Result { get; set; } = null!;
}
