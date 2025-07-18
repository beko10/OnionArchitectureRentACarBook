using OnionArchitectureRentACarBook.Application.DTOs.CarDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Query.CarQueries.GetAllCarQuery;

public class GetAllCarQueryResponse
{
    public ResultData<IEnumerable<CarQueryDto>> Result { get; set; }
}
