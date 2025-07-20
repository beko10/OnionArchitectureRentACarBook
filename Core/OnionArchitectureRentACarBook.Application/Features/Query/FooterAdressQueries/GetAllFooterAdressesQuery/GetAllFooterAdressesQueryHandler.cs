using MediatR;
using OnionArchitectureRentACarBook.Application.Repositories.FooterAdressRepository;
using OnionArchitectureRentACarBook.Application.DTOs.FooterAdressDtos;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using AutoMapper;

namespace OnionArchitectureRentACarBook.Application.Features.Query.FooterAdressQueries.GetAllFooterAdressesQuery;

public class GetAllFooterAdressesQueryHandler : IRequestHandler<GetAllFooterAdressesQueryRequest, GetAllFooterAdressesQueryResponse>
{
    private readonly IFooterAdressReadRepository _footerAdressReadRepository;
    private readonly IMapper _mapper;

    public GetAllFooterAdressesQueryHandler(IFooterAdressReadRepository footerAdressReadRepository, IMapper mapper)
    {
        _footerAdressReadRepository = footerAdressReadRepository;
        _mapper = mapper;
    }

    public async Task<GetAllFooterAdressesQueryResponse> Handle(GetAllFooterAdressesQueryRequest request, CancellationToken cancellationToken)
    {
        var entities = await _footerAdressReadRepository.GetAllAsync(cancellationToken);
        var dtos = _mapper.Map<List<FooterAdressQueryDto>>(entities);
        return new GetAllFooterAdressesQueryResponse
        {
            Result = dtos.Any()
                ? ResultData<List<FooterAdressQueryDto>>.Success(dtos, "Footer adresler başarıyla getirildi.")
                : ResultData<List<FooterAdressQueryDto>>.Failure("Kayıt bulunamadı.")
        };
    }
} 