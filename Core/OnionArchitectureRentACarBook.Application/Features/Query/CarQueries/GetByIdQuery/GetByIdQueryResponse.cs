using OnionArchitectureRentACarBook.Application.DTOs.CarDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Query.CarQueries.GetByIdQuery;

public class GetByIdQueryResponse
{
    public ResultData<CarQueryDto> Result { get; set; }
}
