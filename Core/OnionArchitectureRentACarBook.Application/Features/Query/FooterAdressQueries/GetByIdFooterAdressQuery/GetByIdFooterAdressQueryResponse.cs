using OnionArchitectureRentACarBook.Application.DTOs.FooterAdressDtos;
using OnionArchitectureRentACarBook.Application.Utilities.Results;

namespace OnionArchitectureRentACarBook.Application.Features.Query.FooterAdressQueries.GetByIdFooterAdressQuery;

public class GetByIdFooterAdressQueryResponse
{
    public ResultData<FooterAdressQueryDto> Result { get; set; } = null!;
} 