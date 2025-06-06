using AutoMapper;
using MediatR;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.DTOs.BannerDto;
using OnionArchitectureRentACarBook.Application.Repositories.BannerRepository;

namespace OnionArchitectureRentACarBook.Application.Features.Query.BannerQueries.GetAllBannerQuery;

public class GetAllBannerQueryHandler : IRequestHandler<GetAllBannerQueryRequest, GetAllBannerQueryResponse>
{
    private readonly IBannerReadRepository _bannerReadRepository;
    private readonly IMapper _mapper;
    public GetAllBannerQueryHandler(IBannerReadRepository bannerReadRepository, IMapper mapper)
    {
        _bannerReadRepository = bannerReadRepository;
        _mapper = mapper;
    }

    public async Task<GetAllBannerQueryResponse> Handle(GetAllBannerQueryRequest request, CancellationToken cancellationToken)
    {
        var bannerList = _bannerReadRepository.GetAll(tracking : false,cancellationToken:cancellationToken).ToList();
        var bannerDtoMappedList = _mapper.Map<IEnumerable<BannerQueryDto>>(bannerList);
        if(bannerList.Any())
        {
            return new GetAllBannerQueryResponse
            {
                Result = ResultData<IEnumerable<BannerQueryDto>>.Failure(OperationMessages.BannerOperationMessages.GetAllEmpty)
            };
        }
        return new GetAllBannerQueryResponse
        {
            Result = ResultData<IEnumerable<BannerQueryDto>>.Success(bannerDtoMappedList, OperationMessages.BannerOperationMessages.GetAllSuccess)
        };
    }
}
