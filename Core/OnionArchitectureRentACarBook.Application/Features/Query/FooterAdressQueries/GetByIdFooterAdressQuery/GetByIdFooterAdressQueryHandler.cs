using MediatR;
using OnionArchitectureRentACarBook.Application.Repositories.FooterAdressRepository;
using OnionArchitectureRentACarBook.Application.DTOs.FooterAdressDtos;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using AutoMapper;

namespace OnionArchitectureRentACarBook.Application.Features.Query.FooterAdressQueries.GetByIdFooterAdressQuery;

public class GetByIdFooterAdressQueryHandler : IRequestHandler<GetByIdFooterAdressQueryRequest, GetByIdFooterAdressQueryResponse>
{
    private readonly IFooterAdressReadRepository _footerAdressReadRepository;
    private readonly IMapper _mapper;

    public GetByIdFooterAdressQueryHandler(IFooterAdressReadRepository footerAdressReadRepository, IMapper mapper)
    {
        _footerAdressReadRepository = footerAdressReadRepository;
        _mapper = mapper;
    }

    public async Task<GetByIdFooterAdressQueryResponse> Handle(GetByIdFooterAdressQueryRequest request, CancellationToken cancellationToken)
    {
        var entity = await _footerAdressReadRepository.GetByIdAsync(request.Id, cancellationToken);
        if (entity == null)
        {
            return new GetByIdFooterAdressQueryResponse
            {
                Result = ResultData<FooterAdressQueryDto>.Failure("Kayıt bulunamadı.")
            };
        }
        var dto = _mapper.Map<FooterAdressQueryDto>(entity);
        return new GetByIdFooterAdressQueryResponse
        {
            Result = ResultData<FooterAdressQueryDto>.Success(dto, "Footer adres başarıyla getirildi.")
        };
    }
} 