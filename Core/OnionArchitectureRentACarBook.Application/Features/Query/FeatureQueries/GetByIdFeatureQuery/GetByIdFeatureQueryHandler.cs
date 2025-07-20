using MediatR;
using OnionArchitectureRentACarBook.Application.Repositories.FeatureRepository;
using OnionArchitectureRentACarBook.Application.DTOs.FeatureDtos;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using AutoMapper;

namespace OnionArchitectureRentACarBook.Application.Features.Query.FeatureQueries.GetByIdFeatureQuery;

public class GetByIdFeatureQueryHandler : IRequestHandler<GetByIdFeatureQueryRequest, GetByIdFeatureQueryResponse>
{
    private readonly IFeatureReadRepository _featureReadRepository;
    private readonly IMapper _mapper;

    public GetByIdFeatureQueryHandler(IFeatureReadRepository featureReadRepository, IMapper mapper)
    {
        _featureReadRepository = featureReadRepository;
        _mapper = mapper;
    }

    public async Task<GetByIdFeatureQueryResponse> Handle(GetByIdFeatureQueryRequest request, CancellationToken cancellationToken)
    {
        var feature = await _featureReadRepository.GetByIdAsync(request.Id, cancellationToken);
        if (feature == null)
        {
            return new GetByIdFeatureQueryResponse
            {
                Result = ResultData<FeatureQueryDto>.Failure("Kayıt bulunamadı.")
            };
        }
        var dto = _mapper.Map<FeatureQueryDto>(feature);
        return new GetByIdFeatureQueryResponse
        {
            Result = ResultData<FeatureQueryDto>.Success(dto, "Özellik başarıyla getirildi.")
        };
    }
} 