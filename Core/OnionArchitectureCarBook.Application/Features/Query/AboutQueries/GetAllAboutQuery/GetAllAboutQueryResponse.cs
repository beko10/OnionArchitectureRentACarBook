using OnionArchitectureRentACarBook.Application.DTOs.AboutDto;

namespace OnionArchitectureRentACarBook.Application.Features.Query.AboutQueries.GetAllAboutQuery;

public class GetAllAboutQueryResponse
{
    public ResultData<IEnumerable<GetAllAboutDto>> Result { get; set; } = null!;
}
