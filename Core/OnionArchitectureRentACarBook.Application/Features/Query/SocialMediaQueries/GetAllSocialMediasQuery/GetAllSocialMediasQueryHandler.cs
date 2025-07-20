using MediatR;
using OnionArchitectureRentACarBook.Application.Repositories.SocialMediaRepository;
using OnionArchitectureRentACarBook.Application.DTOs.SocialMediaDtos;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using AutoMapper;

namespace OnionArchitectureRentACarBook.Application.Features.Query.SocialMediaQueries.GetAllSocialMediasQuery;

public class GetAllSocialMediasQueryHandler : IRequestHandler<GetAllSocialMediasQueryRequest, GetAllSocialMediasQueryResponse>
{
    private readonly ISocialMediaReadRepository _socialMediaReadRepository;
    private readonly IMapper _mapper;

    public GetAllSocialMediasQueryHandler(ISocialMediaReadRepository socialMediaReadRepository, IMapper mapper)
    {
        _socialMediaReadRepository = socialMediaReadRepository;
        _mapper = mapper;
    }

    public async Task<GetAllSocialMediasQueryResponse> Handle(GetAllSocialMediasQueryRequest request, CancellationToken cancellationToken)
    {
        var entities = await _socialMediaReadRepository.GetAllAsync(cancellationToken);
        var dtos = _mapper.Map<List<SocialMediaQueryDto>>(entities);
        return new GetAllSocialMediasQueryResponse
        {
            Result = dtos.Any()
                ? ResultData<List<SocialMediaQueryDto>>.Success(dtos, "Sosyal medya kayıtları başarıyla getirildi.")
                : ResultData<List<SocialMediaQueryDto>>.Failure("Kayıt bulunamadı.")
        };
    }
} 