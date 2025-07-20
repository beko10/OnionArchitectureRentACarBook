using OnionArchitectureRentACarBook.Application.DTOs.ServiceDtos;
using OnionArchitectureRentACarBook.Application.Utilities.Results;

namespace OnionArchitectureRentACarBook.Application.Features.Query.ServiceQueries.GetAllServicesQuery;

public class GetAllServicesQueryResponse
{
    public ResultData<List<ServiceQueryDto>> Result { get; set; } = null!;
} 