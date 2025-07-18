using OnionArchitectureRentACarBook.Application.DTOs.CategoryDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Query.CategoryQueries.GetByIdCategoryQuery;

public class GetByIdCategoryQueryResponse
{
    public ResultData<CategoryQueryDto> Result { get; set; } = null!;
}
