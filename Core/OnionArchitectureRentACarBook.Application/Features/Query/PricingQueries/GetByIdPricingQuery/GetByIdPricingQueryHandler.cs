using MediatR;
using OnionArchitectureRentACarBook.Application.Repositories.PricingRepository;
using OnionArchitectureRentACarBook.Application.DTOs.PricingDtos;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using AutoMapper;

namespace OnionArchitectureRentACarBook.Application.Features.Query.PricingQueries.GetByIdPricingQuery;

public class GetByIdPricingQueryHandler : IRequestHandler<GetByIdPricingQueryRequest, GetByIdPricingQueryResponse>
{
    private readonly IPricingReadRepository _pricingReadRepository;
    private readonly IMapper _mapper;

    public GetByIdPricingQueryHandler(IPricingReadRepository pricingReadRepository, IMapper mapper)
    {
        _pricingReadRepository = pricingReadRepository;
        _mapper = mapper;
    }

    public async Task<GetByIdPricingQueryResponse> Handle(GetByIdPricingQueryRequest request, CancellationToken cancellationToken)
    {
        var entity = await _pricingReadRepository.GetByIdAsync(request.Id, cancellationToken);
        if (entity == null)
        {
            return new GetByIdPricingQueryResponse
            {
                Result = ResultData<PricingQueryDto>.Failure("Kayıt bulunamadı.")
            };
        }
        var dto = _mapper.Map<PricingQueryDto>(entity);
        return new GetByIdPricingQueryResponse
        {
            Result = ResultData<PricingQueryDto>.Success(dto, "Fiyatlandırma başarıyla getirildi.")
        };
    }
} 