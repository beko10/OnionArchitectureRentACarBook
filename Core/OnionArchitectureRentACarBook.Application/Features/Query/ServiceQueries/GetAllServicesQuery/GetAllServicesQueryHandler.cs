using MediatR;
using OnionArchitectureRentACarBook.Application.Repositories.ServiceRepository;
using OnionArchitectureRentACarBook.Application.DTOs.ServiceDtos;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using AutoMapper;

namespace OnionArchitectureRentACarBook.Application.Features.Query.ServiceQueries.GetAllServicesQuery;

public class GetAllServicesQueryHandler : IRequestHandler<GetAllServicesQueryRequest, GetAllServicesQueryResponse>
{
    private readonly IServiceReadRepository _serviceReadRepository;
    private readonly IMapper _mapper;

    public GetAllServicesQueryHandler(IServiceReadRepository serviceReadRepository, IMapper mapper)
    {
        _serviceReadRepository = serviceReadRepository;
        _mapper = mapper;
    }

    public async Task<GetAllServicesQueryResponse> Handle(GetAllServicesQueryRequest request, CancellationToken cancellationToken)
    {
        var entities = await _serviceReadRepository.GetAllAsync(cancellationToken);
        var dtos = _mapper.Map<List<ServiceQueryDto>>(entities);
        return new GetAllServicesQueryResponse
        {
            Result = dtos.Any()
                ? ResultData<List<ServiceQueryDto>>.Success(dtos, "Servisler başarıyla getirildi.")
                : ResultData<List<ServiceQueryDto>>.Failure("Kayıt bulunamadı.")
        };
    }
} 