using AutoMapper;
using MediatR;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.DTOs.CarPricingDto;
using OnionArchitectureRentACarBook.Application.Repositories.CarPricingRepository;


namespace OnionArchitectureRentACarBook.Application.Features.Query.CarPricingQuery.GetAllCarPricingQuery;

public class GetAllCarPricingQueryHandler : IRequestHandler<GetAllCarPricingQueryRequest,GetAllCarPricingQueryResponse>
{

    private readonly ICarPricingReadRepository _carPricingReadRepository;
    private readonly IMapper _mapper;
    public GetAllCarPricingQueryHandler(ICarPricingReadRepository carPricingReadRepository, IMapper mapper)
    {
        _carPricingReadRepository = carPricingReadRepository;
        _mapper = mapper;
    }

    public async Task<GetAllCarPricingQueryResponse> Handle(GetAllCarPricingQueryRequest request, CancellationToken cancellationToken)
    {
        var CarPricingList = _carPricingReadRepository.GetAll(tracking: false, cancellationToken: cancellationToken).ToList();
        if (CarPricingList == null || !CarPricingList.Any())
        {
            return new GetAllCarPricingQueryResponse
            {
                Result = ResultData<IEnumerable<CarPricingQueryDto>>.Failure(OperationMessages.CarPricingOperationMessages.GetAllEmpty)
            };
        }

        var CarPricingDtoList = _mapper.Map<IEnumerable<CarPricingQueryDto>>(CarPricingList);
        
        return new GetAllCarPricingQueryResponse
        {
            Result = ResultData<IEnumerable<CarPricingQueryDto>>.Success(CarPricingDtoList)
        };
    }
}
