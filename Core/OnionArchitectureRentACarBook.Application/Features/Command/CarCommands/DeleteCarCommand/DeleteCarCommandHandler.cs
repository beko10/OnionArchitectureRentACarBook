using AutoMapper;
using MediatR;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Repositories.CarRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;

namespace OnionArchitectureRentACarBook.Application.Features.Command.CarCommands.DeleteCarCommand;

public class DeleteCarCommandHandler : IRequestHandler<DeleteCarCommandRequest, DeleteCarCommandResponse>
{
    private readonly ICarWriteRepository _carWriteRepository;
    private readonly ICarReadRepository _carReadRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public DeleteCarCommandHandler(ICarWriteRepository carWriteRepository, IUnitOfWork unitOfWork, IMapper mapper, ICarReadRepository carReadRepository)
    {
        _carWriteRepository = carWriteRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _carReadRepository = carReadRepository;
    }

    public async Task<DeleteCarCommandResponse> Handle(DeleteCarCommandRequest request, CancellationToken cancellationToken)
    {
        var hasCar = await _carReadRepository.GetByIdAsync(request.Id, cancellationToken);
        if (hasCar == null)
        {
            return new DeleteCarCommandResponse
            {
                Result = Result.Failure(OperationMessages.CarOperationMessages.DeleteNotFound)
            };
        }
        await _carWriteRepository.RemoveAsync(hasCar, cancellationToken);
        await _unitOfWork.SaveAsync();
        return new DeleteCarCommandResponse
        {
            Result = Result.Success(OperationMessages.CarOperationMessages.DeleteSuccess)
        };
    }
}
