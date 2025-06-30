using OnionArchitectureRentACarBook.Application.DTOs.CarDto;

namespace OnionArchitectureRentACarBook.Application.Features.Query.CarQueries.GetByIdQuery;

public class GetByIdQueryResponse
{
    public ResultData<CarQueryDto> Result { get; set; }
}
