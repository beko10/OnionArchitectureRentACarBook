using AutoMapper;
using MediatR;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.DTOs.AboutDtos;
using OnionArchitectureRentACarBook.Application.Repositories.AboutRepository;

namespace OnionArchitectureRentACarBook.Application.Features.Query.AboutQueries.GetAllAboutQuery;

public class GetAllAboutQueryHandler : IRequestHandler<GetAllAboutQueryRequest, GetAllAboutQueryResponse>
{
    private readonly IAboutReadRepository _aboutReadRepository;
    private readonly IMapper _mapper;
    public GetAllAboutQueryHandler(IAboutReadRepository aboutReadRepository, IMapper mapper)
    {
        _aboutReadRepository = aboutReadRepository;
        _mapper = mapper;
    }

    public async Task<GetAllAboutQueryResponse> Handle(GetAllAboutQueryRequest request, CancellationToken cancellationToken)
    {
        var aboutList = _aboutReadRepository.GetAll(tracking:false,cancellationToken: cancellationToken).ToList();
        if(aboutList.Count == 0)
        {
            return new GetAllAboutQueryResponse
            {
                Result = ResultData<IEnumerable<GetAllAboutDto>>.Failure(OperationMessages.AboutOperationMessages.GetAllEmpty)
            };
        }


        var aboutDtoList = _mapper.Map<IEnumerable<GetAllAboutDto>>(aboutList);
        return new GetAllAboutQueryResponse
        {
            Result = ResultData<IEnumerable<GetAllAboutDto>>.Success(aboutDtoList, OperationMessages.AboutOperationMessages.GetAllSuccess)
        };
    }
}
