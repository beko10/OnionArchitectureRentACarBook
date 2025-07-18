using AutoMapper;
using MediatR;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Repositories.CategoryRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;

namespace OnionArchitectureRentACarBook.Application.Features.Command.CategoryCommands.UpdateCategoryCommand;

public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommandRequest, UpdateCategoryCommandResponse>
{
    private readonly ICategoryWriteRepository _categoryWriteRepository;
    private readonly ICategoryReadRepository _categoryReadRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UpdateCategoryCommandHandler(ICategoryWriteRepository categoryWriteRepository, IUnitOfWork unitOfWork, IMapper mapper, ICategoryReadRepository categoryReadRepository)
    {
        _categoryWriteRepository = categoryWriteRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _categoryReadRepository = categoryReadRepository;
    }

    public async Task<UpdateCategoryCommandResponse> Handle(UpdateCategoryCommandRequest request, CancellationToken cancellationToken)
    {
        var serachedByIdCategoryExists = await _categoryReadRepository.GetByIdAsync(request.UpdateCategoryCommandDtoRequest?.Id!, cancellationToken);

        if(serachedByIdCategoryExists is null)
        {
            return new UpdateCategoryCommandResponse
            {
                Result = Result.Failure(OperationMessages.CategoryOperationMessages.UpdateNotFound)
            };
        }

        var updatedCategory = _mapper.Map(request.UpdateCategoryCommandDtoRequest, serachedByIdCategoryExists);
        await _categoryWriteRepository.UpdateAsync(updatedCategory);
        await _unitOfWork.SaveAsync();

        return new UpdateCategoryCommandResponse
        {
            Result = Result.Success(OperationMessages.CategoryOperationMessages.UpdateSuccess)
        };
    }
}
