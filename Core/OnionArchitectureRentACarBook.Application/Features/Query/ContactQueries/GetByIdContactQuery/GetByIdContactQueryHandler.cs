using MediatR;
using OnionArchitectureRentACarBook.Application.Repositories.ContactRepository;
using OnionArchitectureRentACarBook.Application.DTOs.ContactDtos;
using AutoMapper;
using OnionArchitectureRentACarBook.Application.Common.Messages;

namespace OnionArchitectureRentACarBook.Application.Features.Query.ContactQueries.GetByIdContactQuery;

public class GetByIdContactQueryHandler : IRequestHandler<GetByIdContactQueryRequest, GetByIdContactQueryResponse>
{
    private readonly IContactReadRepository _contactReadRepository;
    private readonly IMapper _mapper;

    public GetByIdContactQueryHandler(IContactReadRepository contactReadRepository, IMapper mapper)
    {
        _contactReadRepository = contactReadRepository;
        _mapper = mapper;
    }

    public async Task<GetByIdContactQueryResponse> Handle(GetByIdContactQueryRequest request, CancellationToken cancellationToken)
    {
        var contact = await _contactReadRepository.GetByIdAsync(request.Id, cancellationToken);
        if (contact == null)
        {
            return new GetByIdContactQueryResponse
            {
                Result = ResultData<ContactQueryDto>.Failure(OperationMessages.ContactOperationMessages.GetNotFound)
            };
        }
        var dto = _mapper.Map<ContactQueryDto>(contact);
        return new GetByIdContactQueryResponse
        {
            Result = ResultData<ContactQueryDto>.Success(dto, OperationMessages.ContactOperationMessages.GetSuccess)
        };
    }
} 