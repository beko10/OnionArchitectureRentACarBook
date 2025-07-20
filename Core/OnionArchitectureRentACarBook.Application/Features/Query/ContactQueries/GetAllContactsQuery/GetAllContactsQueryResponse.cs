using OnionArchitectureRentACarBook.Application.DTOs.ContactDtos;
using OnionArchitectureRentACarBook.Application.Utilities.Results;

namespace OnionArchitectureRentACarBook.Application.Features.Query.ContactQueries.GetAllContactsQuery;

public class GetAllContactsQueryResponse
{
    public ResultData<List<ContactQueryDto>> Result { get; set; } = null!;
} 