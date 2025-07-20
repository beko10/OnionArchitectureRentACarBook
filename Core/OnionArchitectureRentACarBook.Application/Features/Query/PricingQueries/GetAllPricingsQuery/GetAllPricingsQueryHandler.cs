using MediatR;
using OnionArchitectureRentACarBook.Application.Repositories.PricingRepository;
using OnionArchitectureRentACarBook.Application.DTOs.PricingDtos;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using AutoMapper;

namespace OnionArchitectureRentACarBook.Application.Features.Query.PricingQueries.GetAllPricingsQuery;

public class GetAllPricingsQueryHandler : IRequestHandler<GetAllPricingsQueryRequest, GetAllPricingsQueryResponse>
{
    private readonly IPricingReadRepository _pricingReadRepository;
    private readonly IMapper _mapper;

    public GetAllPricingsQueryHandler(IPricingReadRepository pricingReadRepository, IMapper mapper)
    {
        _pricingReadRepository = pricingReadRepository;
        _mapper = mapper;
    }

    public async Task<GetAllPricingsQueryResponse> Handle(GetAllPricingsQueryRequest request, CancellationToken cancellationToken)
    {
        var entities = await _pricingReadRepository.GetAllAsync(cancellationToken);
        var dtos = _mapper.Map<List<PricingQueryDto>>(entities);
        return new GetAllPricingsQueryResponse
        {
            Result = dtos.Any()
                ? ResultData<List<PricingQueryDto>>.Success(dtos, "Fiyatlandırmalar başarıyla getirildi.")
                : ResultData<List<PricingQueryDto>>.Failure("Kayıt bulunamadı.")
        };
    }
} 