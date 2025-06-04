using OnionArchitectureCarBook.Application.DTOs.About;

namespace OnionArchitectureCarBook.Application.Features.Query.AboutQueries.GetByIdAboutQuery;

public class GetByIdAboutQueryResponse
{
    public ResultData<GetByIdAboutDto> Result { get; set; } = null!; 
}
