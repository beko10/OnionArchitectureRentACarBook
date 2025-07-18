using OnionArchitectureRentACarBook.Application.DTOs.AboutDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Query.AboutQueries.GetByIdAboutQuery;

public class GetByIdAboutQueryResponse
{
    public ResultData<GetByIdAboutDto> Result { get; set; } = null!; 
}
