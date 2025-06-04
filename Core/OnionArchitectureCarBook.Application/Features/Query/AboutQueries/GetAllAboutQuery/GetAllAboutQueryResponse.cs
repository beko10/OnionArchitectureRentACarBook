using OnionArchitectureCarBook.Application.DTOs.About;

namespace OnionArchitectureCarBook.Application.Features.Query.AboutQueries.GetAllAboutQuery;

public class GetAllAboutQueryResponse
{
    public ResultData<IEnumerable<GetAllAboutDto>> Result { get; set; } = null!;
}
