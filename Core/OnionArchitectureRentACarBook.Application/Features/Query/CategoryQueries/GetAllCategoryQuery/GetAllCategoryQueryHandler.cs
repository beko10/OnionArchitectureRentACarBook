using AutoMapper;
using MediatR;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.DTOs.CategoryDtos;
using OnionArchitectureRentACarBook.Application.Repositories.CategoryRepository;

namespace OnionArchitectureRentACarBook.Application.Features.Query.CategoryQueries.GetAllCategoryQuery;

public class GetAllCategoryQueryHandler : IRequestHandler<GetAllCategoryQueryRequest, GetAllCategoryQueryResponse>
{
    private readonly ICategoryReadRepository _categoryReadRepository;
    private readonly IMapper _mapper;
    public GetAllCategoryQueryHandler(ICategoryReadRepository categoryReadRepository, IMapper mapper)
    {
        _categoryReadRepository = categoryReadRepository;
        _mapper = mapper;
    }

    public async Task<GetAllCategoryQueryResponse> Handle(GetAllCategoryQueryRequest request, CancellationToken cancellationToken)
    {
        var categoryList = _categoryReadRepository.GetAll(false).ToList();
        var categoryDtoList = _mapper.Map<IEnumerable<CategoryQueryDto>>(categoryList);
        if(categoryDtoList is null || !categoryDtoList.Any())
        {
            return new GetAllCategoryQueryResponse
            {
                Result = ResultData<IEnumerable<CategoryQueryDto>>.Failure(OperationMessages.CategoryOperationMessages.GetAllEmpty)
            };
        }

        return new GetAllCategoryQueryResponse
        {
            Result = ResultData<IEnumerable<CategoryQueryDto>>.Success(categoryDtoList, OperationMessages.CategoryOperationMessages.GetAllSuccess)
        };
    }
}
