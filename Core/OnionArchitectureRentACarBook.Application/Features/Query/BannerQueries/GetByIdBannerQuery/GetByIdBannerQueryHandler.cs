using AutoMapper;
using MediatR;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.DTOs.BannerDtos;
using OnionArchitectureRentACarBook.Application.Repositories.BannerRepository;

namespace OnionArchitectureRentACarBook.Application.Features.Query.BannerQueries.GetByIdBannerQuery;

public class GetByIdBannerQueryHandler : IRequestHandler<GetByIdBannerQueryRequest, GetByIdBannerQueryResponse>
{
    private readonly IBannerReadRepository _bannerReadRepository;
    private readonly IMapper _mapper;
    public GetByIdBannerQueryHandler(IBannerReadRepository bannerReadRepository, IMapper mapper)
    {
        _bannerReadRepository = bannerReadRepository;
        _mapper = mapper;
    }

    public async Task<GetByIdBannerQueryResponse> Handle(GetByIdBannerQueryRequest request, CancellationToken cancellationToken)
    {
        var hasBanner = await _bannerReadRepository.GetByIdAsync(request.Id!);
        if (hasBanner == null)
            return new GetByIdBannerQueryResponse
            {
                Result = ResultData<BannerQueryDto>.Failure(OperationMessages.BannerOperationMessages.GetNotFound)
            };

        var bannerDtoMapped = _mapper.Map<BannerQueryDto>(hasBanner);
        return new GetByIdBannerQueryResponse
        {
            Result = ResultData<BannerQueryDto>.Success(bannerDtoMapped, OperationMessages.BannerOperationMessages.GetSuccess)
        };
    }
}
