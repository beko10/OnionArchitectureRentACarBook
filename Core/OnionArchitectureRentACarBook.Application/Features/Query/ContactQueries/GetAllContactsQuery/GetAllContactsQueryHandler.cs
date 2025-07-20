using MediatR;
using OnionArchitectureRentACarBook.Application.Repositories.ContactRepository;
using OnionArchitectureRentACarBook.Application.DTOs.ContactDtos;
using AutoMapper;
using OnionArchitectureRentACarBook.Application.Common.Messages;

namespace OnionArchitectureRentACarBook.Application.Features.Query.ContactQueries.GetAllContactsQuery;

public class GetAllContactsQueryHandler : IRequestHandler<GetAllContactsQueryRequest, GetAllContactsQueryResponse>
{
    private readonly IContactReadRepository _contactReadRepository;
    private readonly IMapper _mapper;

    public GetAllContactsQueryHandler(IContactReadRepository contactReadRepository, IMapper mapper)
    {
        _contactReadRepository = contactReadRepository;
        _mapper = mapper;
    }

    public async Task<GetAllContactsQueryResponse> Handle(GetAllContactsQueryRequest request, CancellationToken cancellationToken)
    {
        var contacts = await _contactReadRepository.GetAllAsync(cancellationToken);
        var contactDtos = _mapper.Map<List<ContactQueryDto>>(contacts);
        return new GetAllContactsQueryResponse
        {
            Result = contactDtos.Any()
                ? ResultData<List<ContactQueryDto>>.Success(contactDtos, OperationMessages.ContactOperationMessages.GetAllSuccess)
                : ResultData<List<ContactQueryDto>>.Failure(OperationMessages.ContactOperationMessages.GetAllEmpty)
        };
    }
} 