using MediatR;
using OnionArchitectureRentACarBook.Application.Repositories.LocationRepository;
using OnionArchitectureRentACarBook.Application.DTOs.LocationDtos;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using AutoMapper;

namespace OnionArchitectureRentACarBook.Application.Features.Query.LocationQueries.GetAllLocationsQuery;

public class GetAllLocationsQueryHandler : IRequestHandler<GetAllLocationsQueryRequest, GetAllLocationsQueryResponse>
{
    private readonly ILocationReadRepository _locationReadRepository;
    private readonly IMapper _mapper;

    public GetAllLocationsQueryHandler(ILocationReadRepository locationReadRepository, IMapper mapper)
    {
        _locationReadRepository = locationReadRepository;
        _mapper = mapper;
    }

    public async Task<GetAllLocationsQueryResponse> Handle(GetAllLocationsQueryRequest request, CancellationToken cancellationToken)
    {
        var entities = await _locationReadRepository.GetAllAsync(cancellationToken);
        var dtos = _mapper.Map<List<LocationQueryDto>>(entities);
        return new GetAllLocationsQueryResponse
        {
            Result = dtos.Any()
                ? ResultData<List<LocationQueryDto>>.Success(dtos, "Lokasyonlar başarıyla getirildi.")
                : ResultData<List<LocationQueryDto>>.Failure("Kayıt bulunamadı.")
        };
    }
} 