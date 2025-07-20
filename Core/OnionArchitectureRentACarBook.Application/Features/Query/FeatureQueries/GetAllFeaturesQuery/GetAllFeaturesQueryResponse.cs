using OnionArchitectureRentACarBook.Application.DTOs.FeatureDtos;
using OnionArchitectureRentACarBook.Application.Utilities.Results;

namespace OnionArchitectureRentACarBook.Application.Features.Query.FeatureQueries.GetAllFeaturesQuery;

public class GetAllFeaturesQueryResponse
{
    public ResultData<List<FeatureQueryDto>> Result { get; set; } = null!;
} 