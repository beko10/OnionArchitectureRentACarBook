using OnionArchitectureRentACarBook.Application.DTOs.ContactDtos;
using OnionArchitectureRentACarBook.Application.Utilities.Results;

namespace OnionArchitectureRentACarBook.Application.Features.Query.ContactQueries.GetByIdContactQuery;

public class GetByIdContactQueryResponse
{
    public ResultData<ContactQueryDto> Result { get; set; } = null!;
} 