using MediatR;
using OnionArchitectureRentACarBook.Application.Repositories.FeatureRepository;
using OnionArchitectureRentACarBook.Application.DTOs.FeatureDtos;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using AutoMapper;

namespace OnionArchitectureRentACarBook.Application.Features.Query.FeatureQueries.GetAllFeaturesQuery;

public class GetAllFeaturesQueryHandler : IRequestHandler<GetAllFeaturesQueryRequest, GetAllFeaturesQueryResponse>
{
    private readonly IFeatureReadRepository _featureReadRepository;
    private readonly IMapper _mapper;

    public GetAllFeaturesQueryHandler(IFeatureReadRepository featureReadRepository, IMapper mapper)
    {
        _featureReadRepository = featureReadRepository;
        _mapper = mapper;
    }

    public async Task<GetAllFeaturesQueryResponse> Handle(GetAllFeaturesQueryRequest request, CancellationToken cancellationToken)
    {
        var features = await _featureReadRepository.GetAllAsync(cancellationToken);
        var featureDtos = _mapper.Map<List<FeatureQueryDto>>(features);
        return new GetAllFeaturesQueryResponse
        {
            Result = featureDtos.Any()
                ? ResultData<List<FeatureQueryDto>>.Success(featureDtos, "Özellikler başarıyla getirildi.")
                : ResultData<List<FeatureQueryDto>>.Failure("Kayıt bulunamadı.")
        };
    }
} 