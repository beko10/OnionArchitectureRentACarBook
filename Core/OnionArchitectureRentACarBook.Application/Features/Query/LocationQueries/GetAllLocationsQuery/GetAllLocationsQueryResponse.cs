using OnionArchitectureRentACarBook.Application.DTOs.LocationDtos;
using OnionArchitectureRentACarBook.Application.Utilities.Results;

namespace OnionArchitectureRentACarBook.Application.Features.Query.LocationQueries.GetAllLocationsQuery;

public class GetAllLocationsQueryResponse
{
    public ResultData<List<LocationQueryDto>> Result { get; set; } = null!;
} 