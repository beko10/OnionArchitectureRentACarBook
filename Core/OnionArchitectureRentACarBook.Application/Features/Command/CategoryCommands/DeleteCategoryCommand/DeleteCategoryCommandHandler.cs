using MediatR;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Repositories.CategoryRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;

namespace OnionArchitectureRentACarBook.Application.Features.Command.CategoryCommands.DeleteCategoryCommand;

public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommandRequest, DeleteCategoryCommandResponse>
{
    private readonly ICategoryWriteRepository _categoryWriteRepository;
    private readonly ICategoryReadRepository _categoryReadRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteCategoryCommandHandler(ICategoryWriteRepository categoryWriteRepository, ICategoryReadRepository categoryReadRepository, IUnitOfWork unitOfWork)
    {
        _categoryWriteRepository = categoryWriteRepository;
        _categoryReadRepository = categoryReadRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<DeleteCategoryCommandResponse> Handle(DeleteCategoryCommandRequest request, CancellationToken cancellationToken)
    {
        var searchedByIdExistsCategory = await _categoryReadRepository.GetByIdAsync(request.Id!);
        if (searchedByIdExistsCategory is null)
        {
            return new DeleteCategoryCommandResponse
            {
                Result = Result.Failure(OperationMessages.CategoryOperationMessages.DeleteNotFound)
            };
        }

        await _categoryWriteRepository.RemoveAsync(searchedByIdExistsCategory);
        await _unitOfWork.SaveAsync();
        return new DeleteCategoryCommandResponse
        {
            Result = Result.Success(OperationMessages.CategoryOperationMessages.DeleteSuccess)
        };
    }
}
