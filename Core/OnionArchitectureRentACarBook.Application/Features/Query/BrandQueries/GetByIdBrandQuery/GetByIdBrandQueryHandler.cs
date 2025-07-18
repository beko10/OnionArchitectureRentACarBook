using AutoMapper;
using MediatR;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.DTOs.BrandDtos;
using OnionArchitectureRentACarBook.Application.Repositories.BrandRepository;

namespace OnionArchitectureRentACarBook.Application.Features.Query.BrandQueries.GetByIdBrandQuery;

public class GetByIdBrandQueryHandler : IRequestHandler<GetByIdBrandQueryRequest, GetByIdBrandQueryResponse>
{
    private readonly IBrandReadRepository _brandReadRepository;
    private readonly IMapper _mapper;
    public GetByIdBrandQueryHandler(IBrandReadRepository brandReadRepository, IMapper mapper)
    {
        _brandReadRepository = brandReadRepository;
        _mapper = mapper;
    }

    public async Task<GetByIdBrandQueryResponse> Handle(GetByIdBrandQueryRequest request, CancellationToken cancellationToken)
    {
        var brand = await _brandReadRepository.GetByIdAsync(request.Id, cancellationToken);
        if (brand == null)
        {
            return new GetByIdBrandQueryResponse
            {
                Result = ResultData<BrandQueryDto>.Failure(OperationMessages.BrandOperationMessages.GetNotFound)
            };
        }
        var brandDto = _mapper.Map<BrandQueryDto>(brand);
        return new GetByIdBrandQueryResponse
        {
            Result = ResultData<BrandQueryDto>.Success(brandDto, OperationMessages.BrandOperationMessages.GetSuccess)
        };
    }
}
