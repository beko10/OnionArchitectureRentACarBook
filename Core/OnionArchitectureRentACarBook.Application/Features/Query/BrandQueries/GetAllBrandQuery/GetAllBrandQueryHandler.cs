using AutoMapper;
using MediatR;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.DTOs.BrandDtos;
using OnionArchitectureRentACarBook.Application.Features.Query.BrandQueries.GetAllBrandQueries;
using OnionArchitectureRentACarBook.Application.Repositories.BrandRepository;

namespace OnionArchitectureRentACarBook.Application.Features.Query.BrandQueries.GetAllBrandQuery;

public class GetAllBrandQueryHandler : IRequestHandler<GetAllBrandQueryRequest, GetAllBrandQueryResponse>
{
    private readonly IBrandReadRepository _brandReadRepository;
    private readonly IMapper _mapper;
    public GetAllBrandQueryHandler(IBrandReadRepository brandReadRepository, IMapper mapper)
    {
        _brandReadRepository = brandReadRepository;
        _mapper = mapper;
    }

    public async Task<GetAllBrandQueryResponse> Handle(GetAllBrandQueryRequest request, CancellationToken cancellationToken)
    {
        var brandList = _brandReadRepository.GetAll(tracking: false, cancellationToken: cancellationToken).ToList();
        if (brandList == null || !brandList.Any())
        {
            return new GetAllBrandQueryResponse
            {
                Result = ResultData<IEnumerable<BrandQueryDto>>.Failure(OperationMessages.BrandOperationMessages.GetAllEmpty)
            };
        }

        var brandDtoList = _mapper.Map<IEnumerable<BrandQueryDto>>(brandList);
        return new GetAllBrandQueryResponse
        {
            Result = ResultData<IEnumerable<BrandQueryDto>>.Success(brandDtoList, OperationMessages.BrandOperationMessages.GetAllSuccess)
        };
    }
}
