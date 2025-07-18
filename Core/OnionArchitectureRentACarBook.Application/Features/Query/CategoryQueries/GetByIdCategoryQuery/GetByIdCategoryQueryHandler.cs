using AutoMapper;
using MediatR;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.DTOs.CategoryDtos;
using OnionArchitectureRentACarBook.Application.Repositories.CategoryRepository;

namespace OnionArchitectureRentACarBook.Application.Features.Query.CategoryQueries.GetByIdCategoryQuery;

public class GetByIdCategoryQueryHandler : IRequestHandler<GetByIdCategoryQueryRequest, GetByIdCategoryQueryResponse>
{
    private readonly ICategoryReadRepository _categoryReadRepository;
    private readonly IMapper _mapper;
    public GetByIdCategoryQueryHandler(ICategoryReadRepository categoryReadRepository, IMapper mapper)
    {
        _categoryReadRepository = categoryReadRepository;
        _mapper = mapper;
    }

    public async Task<GetByIdCategoryQueryResponse> Handle(GetByIdCategoryQueryRequest request, CancellationToken cancellationToken)
    {
        var searchedGetByIdExistingCategory = await _categoryReadRepository.GetByIdAsync(request.Id!, cancellationToken);
        if (searchedGetByIdExistingCategory is null)
        {
            return new GetByIdCategoryQueryResponse
            {
                Result =  ResultData<CategoryQueryDto>.Failure(OperationMessages.CategoryOperationMessages.GetNotFound)
            };
        }

        var mappedCategory = _mapper.Map<CategoryQueryDto>(searchedGetByIdExistingCategory);

        return new GetByIdCategoryQueryResponse
        {
            Result = ResultData<CategoryQueryDto>.Success(mappedCategory, OperationMessages.CategoryOperationMessages.GetSuccess)
        };
    }
}
