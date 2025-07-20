using MediatR;
using OnionArchitectureRentACarBook.Application.Repositories.ServiceRepository;
using OnionArchitectureRentACarBook.Application.DTOs.ServiceDtos;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using AutoMapper;

namespace OnionArchitectureRentACarBook.Application.Features.Query.ServiceQueries.GetByIdServiceQuery;

public class GetByIdServiceQueryHandler : IRequestHandler<GetByIdServiceQueryRequest, GetByIdServiceQueryResponse>
{
    private readonly IServiceReadRepository _serviceReadRepository;
    private readonly IMapper _mapper;

    public GetByIdServiceQueryHandler(IServiceReadRepository serviceReadRepository, IMapper mapper)
    {
        _serviceReadRepository = serviceReadRepository;
        _mapper = mapper;
    }

    public async Task<GetByIdServiceQueryResponse> Handle(GetByIdServiceQueryRequest request, CancellationToken cancellationToken)
    {
        var entity = await _serviceReadRepository.GetByIdAsync(request.Id, cancellationToken);
        if (entity == null)
        {
            return new GetByIdServiceQueryResponse
            {
                Result = ResultData<ServiceQueryDto>.Failure("Kayıt bulunamadı.")
            };
        }
        var dto = _mapper.Map<ServiceQueryDto>(entity);
        return new GetByIdServiceQueryResponse
        {
            Result = ResultData<ServiceQueryDto>.Success(dto, "Servis başarıyla getirildi.")
        };
    }
} 