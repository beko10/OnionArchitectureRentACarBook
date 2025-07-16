using AutoMapper;
using MediatR;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.DTOs.CarPricingDto;
using OnionArchitectureRentACarBook.Application.Features.Query.CarPricingQuery.GetByIdCarPricingQuery;
using OnionArchitectureRentACarBook.Application.Repositories.CarPricingRepository;

namespace OnionArchitectureRentACarBook.Application.Features.Query.CarPricingQuery.GetByIdCarPricingQuery;

public class GetByIdCarPricingQueryHandler : IRequestHandler<GetByIdCarPricingQueryRequest, GetByIdCarPricingQueryResponse>
{
    private readonly ICarPricingReadRepository _carPricingReadRepository;
    private readonly IMapper _mapper;

    public GetByIdCarPricingQueryHandler(ICarPricingReadRepository carPricingReadRepository, IMapper mapper)
    {
        _carPricingReadRepository = carPricingReadRepository;
        _mapper = mapper;
    }

    public async Task<GetByIdCarPricingQueryResponse> Handle(GetByIdCarPricingQueryRequest request, CancellationToken cancellationToken)
    {
    
        var carPricing = _carPricingReadRepository.GetByIdAsync(request.Id, cancellationToken: cancellationToken);

        if (carPricing is null)
        {
            return new GetByIdCarPricingQueryResponse
            {
                Result = ResultData<CarPricingQueryDto>.Failure(OperationMessages.CarPricingOperationMessages.GetNotFound)
            };
        }

        var carPricingDto = _mapper.Map<CarPricingQueryDto>(carPricing);

        return new GetByIdCarPricingQueryResponse
        {
            Result = ResultData<CarPricingQueryDto>.Success(carPricingDto)
        };

    }
}
