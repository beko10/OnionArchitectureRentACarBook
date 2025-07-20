using OnionArchitectureRentACarBook.Application.DTOs.ServiceDtos;
using OnionArchitectureRentACarBook.Application.Utilities.Results;

namespace OnionArchitectureRentACarBook.Application.Features.Query.ServiceQueries.GetByIdServiceQuery;

public class GetByIdServiceQueryResponse
{
    public ResultData<ServiceQueryDto> Result { get; set; } = null!;
} 