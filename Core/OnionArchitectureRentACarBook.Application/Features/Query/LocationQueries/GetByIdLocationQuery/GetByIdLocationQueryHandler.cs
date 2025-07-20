using MediatR;
using OnionArchitectureRentACarBook.Application.Repositories.LocationRepository;
using OnionArchitectureRentACarBook.Application.DTOs.LocationDtos;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using AutoMapper;

namespace OnionArchitectureRentACarBook.Application.Features.Query.LocationQueries.GetByIdLocationQuery;

public class GetByIdLocationQueryHandler : IRequestHandler<GetByIdLocationQueryRequest, GetByIdLocationQueryResponse>
{
    private readonly ILocationReadRepository _locationReadRepository;
    private readonly IMapper _mapper;

    public GetByIdLocationQueryHandler(ILocationReadRepository locationReadRepository, IMapper mapper)
    {
        _locationReadRepository = locationReadRepository;
        _mapper = mapper;
    }

    public async Task<GetByIdLocationQueryResponse> Handle(GetByIdLocationQueryRequest request, CancellationToken cancellationToken)
    {
        var entity = await _locationReadRepository.GetByIdAsync(request.Id, cancellationToken);
        if (entity == null)
        {
            return new GetByIdLocationQueryResponse
            {
                Result = ResultData<LocationQueryDto>.Failure("Kayıt bulunamadı.")
            };
        }
        var dto = _mapper.Map<LocationQueryDto>(entity);
        return new GetByIdLocationQueryResponse
        {
            Result = ResultData<LocationQueryDto>.Success(dto, "Lokasyon başarıyla getirildi.")
        };
    }
} 