using AutoMapper;
using MediatR;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.DTOs.CarFeatureDto;
using OnionArchitectureRentACarBook.Application.Repositories.CarFeatureRepository;

namespace OnionArchitectureRentACarBook.Application.Features.Query.CarFeatureQueries.GeByIdCarFeatureQuery;

public class GeByIdCarFeatureQueryHandler : IRequestHandler<GeByIdCarFeatureQueryRequest, GeByIdCarFeatureQueryResponse>
{
    private readonly ICarFeatureReadRepository _carFeatureReadRepository;
    private readonly IMapper _mapper;
    public GeByIdCarFeatureQueryHandler(ICarFeatureReadRepository carFeatureReadRepository, IMapper mapper)
    {
        _carFeatureReadRepository = carFeatureReadRepository;
        _mapper = mapper;
    }

    public async Task<GeByIdCarFeatureQueryResponse> Handle(GeByIdCarFeatureQueryRequest request, CancellationToken cancellationToken)
    {
        if(request is null)
        {
                       throw new ArgumentNullException(nameof(request), "Request cannot be null");
        }

        if (string.IsNullOrEmpty(request.Id))
        {
            throw new ArgumentException("Id cannot be null or empty", nameof(request.Id));
        }

        var carFeature = await _carFeatureReadRepository.GetByIdAsync(request.Id, cancellationToken);

        if (carFeature is null)
        {
            return new GeByIdCarFeatureQueryResponse
            {
                Result = ResultData<CarFeatureQueryDto>.Failure(OperationMessages.CarFeatureOperationMessages.GetNotFound)
            };
        }

        var carFeatureDto = _mapper.Map<CarFeatureQueryDto>(carFeature);

        return new GeByIdCarFeatureQueryResponse
        {
            Result = ResultData<CarFeatureQueryDto>.Success(carFeatureDto, OperationMessages.CarFeatureOperationMessages.GetSuccess)
        };
    }
}
