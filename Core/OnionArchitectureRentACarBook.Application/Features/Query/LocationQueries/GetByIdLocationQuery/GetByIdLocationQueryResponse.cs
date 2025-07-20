using OnionArchitectureRentACarBook.Application.DTOs.LocationDtos;
using OnionArchitectureRentACarBook.Application.Utilities.Results;

namespace OnionArchitectureRentACarBook.Application.Features.Query.LocationQueries.GetByIdLocationQuery;

public class GetByIdLocationQueryResponse
{
    public ResultData<LocationQueryDto> Result { get; set; } = null!;
} 