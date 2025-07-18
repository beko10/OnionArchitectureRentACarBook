using OnionArchitectureRentACarBook.Application.DTOs.CarFeatureDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Query.CarFeatureQueries.GeAllCarFeatureQuery;

public class GeAllCarFeatureQueryResponse
{
    public ResultData<IEnumerable<CarFeatureQueryDto>> Result { get; set; } = null!;
}
