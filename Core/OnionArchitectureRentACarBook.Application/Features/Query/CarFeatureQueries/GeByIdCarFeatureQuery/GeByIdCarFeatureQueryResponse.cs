using OnionArchitectureRentACarBook.Application.DTOs.CarFeatureDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Query.CarFeatureQueries.GeByIdCarFeatureQuery;

public class GeByIdCarFeatureQueryResponse
{
    public ResultData<CarFeatureQueryDto> Result { get; set; } = null!;
}
