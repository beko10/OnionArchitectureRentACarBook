using AutoMapper;
using MediatR;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Repositories.CategoryRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using OnionArchitectureRentACarBook.Domain.Entities;

namespace OnionArchitectureRentACarBook.Application.Features.Command.CategoryCommands.CreateCategoryCommand;

public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommandRequest, CreateCategoryCommandResponse>
{
    private readonly ICategoryWriteRepository _categoryWriteRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateCategoryCommandHandler(ICategoryWriteRepository categoryWriteRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _categoryWriteRepository = categoryWriteRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<CreateCategoryCommandResponse> Handle(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
    {
        var addedCategory = _mapper.Map<Category>(request.CreateCategoryCommandDtoRequest);

        await _categoryWriteRepository.AddAsync(addedCategory, cancellationToken);
        await _unitOfWork.SaveAsync();
        return new CreateCategoryCommandResponse
        {
           Result = Result.Success(OperationMessages)
        };
    }
}
