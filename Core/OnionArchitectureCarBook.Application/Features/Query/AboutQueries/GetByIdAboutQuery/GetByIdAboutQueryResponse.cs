using OnionArchitectureRentACarBook.Application.DTOs.AboutDto;

namespace OnionArchitectureRentACarBook.Application.Features.Query.AboutQueries.GetByIdAboutQuery;

public class GetByIdAboutQueryResponse
{
    public ResultData<GetByIdAboutDto> Result { get; set; } = null!; 
}
