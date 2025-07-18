using OnionArchitectureRentACarBook.Application.DTOs.AboutDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Query.AboutQueries.GetAllAboutQuery;

public class GetAllAboutQueryResponse
{
    public ResultData<IEnumerable<GetAllAboutDto>> Result { get; set; } = null!;
}
