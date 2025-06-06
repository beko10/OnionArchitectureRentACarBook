using AutoMapper;
using MediatR;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.DTOs.AboutDto;
using OnionArchitectureRentACarBook.Application.Repositories.AboutRepository;

namespace OnionArchitectureRentACarBook.Application.Features.Query.AboutQueries.GetByIdAboutQuery;

public class GetByIdAboutQueryHandler : IRequestHandler<GetByIdAboutQueryRequest, GetByIdAboutQueryResponse>
{
    private readonly IAboutReadRepository _aboutReadRepository;
    private readonly IMapper _mapper;
    public GetByIdAboutQueryHandler(IAboutReadRepository aboutReadRepository, IMapper mapper)
    {
        _aboutReadRepository = aboutReadRepository;
        _mapper = mapper;
    }

    public async Task<GetByIdAboutQueryResponse> Handle(GetByIdAboutQueryRequest request, CancellationToken cancellationToken)
    {
        // Validate the request
        if (string.IsNullOrEmpty(request.Id))
            return new GetByIdAboutQueryResponse
            {
                Result = ResultData<GetByIdAboutDto>.Failure("Id cannot be null or empty.")
            };

        // Fetch the About entity by Id
        var about = await _aboutReadRepository.GetByIdAsync(request.Id, cancellationToken: cancellationToken);

        // Check if the About entity was found
        if (about == null)
        {
            return new GetByIdAboutQueryResponse
            {
                Result = ResultData<GetByIdAboutDto>.Failure(OperationMessages.AboutOperationMessages.GetNotFound)
            };
        }

        // Map the About entity to GetByIdAboutDto
        var aboutDtoMapped = _mapper.Map<GetByIdAboutDto>(about);

        // Return the response with the mapped DTO
        return new GetByIdAboutQueryResponse
        {
            Result = ResultData<GetByIdAboutDto>.Success(aboutDtoMapped, OperationMessages.AboutOperationMessages.GetSuccess)
        };
    }
}
