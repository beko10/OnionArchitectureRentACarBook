using OnionArchitectureRentACarBook.Application.DTOs.CarFeatureDto;

namespace OnionArchitectureRentACarBook.Application.Features.Query.CarFeatureQueries.GeAllCarFeatureQuery;

public class GeAllCarFeatureQueryResponse
{
    public ResultData<IEnumerable<CarFeatureQueryDto>> Result { get; set; } = null!;
}
