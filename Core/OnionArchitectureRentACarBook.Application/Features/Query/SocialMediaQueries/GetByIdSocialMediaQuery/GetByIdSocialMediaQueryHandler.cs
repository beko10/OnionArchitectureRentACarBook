using MediatR;
using OnionArchitectureRentACarBook.Application.Repositories.SocialMediaRepository;
using OnionArchitectureRentACarBook.Application.DTOs.SocialMediaDtos;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using AutoMapper;

namespace OnionArchitectureRentACarBook.Application.Features.Query.SocialMediaQueries.GetByIdSocialMediaQuery;

public class GetByIdSocialMediaQueryHandler : IRequestHandler<GetByIdSocialMediaQueryRequest, GetByIdSocialMediaQueryResponse>
{
    private readonly ISocialMediaReadRepository _socialMediaReadRepository;
    private readonly IMapper _mapper;

    public GetByIdSocialMediaQueryHandler(ISocialMediaReadRepository socialMediaReadRepository, IMapper mapper)
    {
        _socialMediaReadRepository = socialMediaReadRepository;
        _mapper = mapper;
    }

    public async Task<GetByIdSocialMediaQueryResponse> Handle(GetByIdSocialMediaQueryRequest request, CancellationToken cancellationToken)
    {
        var entity = await _socialMediaReadRepository.GetByIdAsync(request.Id, cancellationToken);
        if (entity == null)
        {
            return new GetByIdSocialMediaQueryResponse
            {
                Result = ResultData<SocialMediaQueryDto>.Failure("Kayıt bulunamadı.")
            };
        }
        var dto = _mapper.Map<SocialMediaQueryDto>(entity);
        return new GetByIdSocialMediaQueryResponse
        {
            Result = ResultData<SocialMediaQueryDto>.Success(dto, "Sosyal medya kaydı başarıyla getirildi.")
        };
    }
} 