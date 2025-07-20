using OnionArchitectureRentACarBook.Application.DTOs.FooterAdressDtos;
using OnionArchitectureRentACarBook.Application.Utilities.Results;

namespace OnionArchitectureRentACarBook.Application.Features.Query.FooterAdressQueries.GetAllFooterAdressesQuery;

public class GetAllFooterAdressesQueryResponse
{
    public ResultData<List<FooterAdressQueryDto>> Result { get; set; } = null!;
} 