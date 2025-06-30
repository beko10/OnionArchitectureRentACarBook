using OnionArchitectureRentACarBook.Application.DTOs.CarDto;

namespace OnionArchitectureRentACarBook.Application.Features.Query.CarQueries.GetAllCarQuery;

public class GetAllCarQueryResponse
{
    public ResultData<IEnumerable<CarQueryDto>> Result { get; set; }
}
