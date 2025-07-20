using OnionArchitectureRentACarBook.Application.DTOs.FeatureDtos;
using OnionArchitectureRentACarBook.Application.Utilities.Results;

namespace OnionArchitectureRentACarBook.Application.Features.Query.FeatureQueries.GetByIdFeatureQuery;

public class GetByIdFeatureQueryResponse
{
    public ResultData<FeatureQueryDto> Result { get; set; } = null!;
} 