using AutoMapper;
using MediatR;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.DTOs.CarFeatureDto;
using OnionArchitectureRentACarBook.Application.Repositories.CarFeatureRepository;

namespace OnionArchitectureRentACarBook.Application.Features.Query.CarFeatureQueries.GeAllCarFeatureQuery;

public class GeAllCarFeatureQueryHandler : IRequestHandler<GeAllCarFeatureQueryRequest, GeAllCarFeatureQueryResponse>
{
    private readonly ICarFeatureReadRepository _carFeatureReadRepository;
    private readonly IMapper _mapper;
    public GeAllCarFeatureQueryHandler(ICarFeatureReadRepository carFeatureReadRepository, IMapper mapper)
    {
        _carFeatureReadRepository = carFeatureReadRepository;
        _mapper = mapper;
    }

    public async Task<GeAllCarFeatureQueryResponse> Handle(GeAllCarFeatureQueryRequest request, CancellationToken cancellationToken)
    {
      
        var carFeatureList = _carFeatureReadRepository.GetAll(tracking:false,cancellationToken: cancellationToken);

        if (carFeatureList == null || !carFeatureList.Any())
        {
            return new GeAllCarFeatureQueryResponse
            {
                Result = ResultData<IEnumerable<CarFeatureQueryDto>>.Failure(OperationMessages.CarFeatureOperationMessages.GetAllEmpty)
            };
        }

        var carFeatureDtoList = _mapper.Map<IEnumerable<CarFeatureQueryDto>>(carFeatureList);
        return new GeAllCarFeatureQueryResponse
        {
            Result = ResultData<IEnumerable<CarFeatureQueryDto>>.Success(carFeatureDtoList, OperationMessages.CarFeatureOperationMessages.GetAllSuccess)
        };

    }
}
