using AutoMapper;
using MediatR;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Repositories.CarRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using OnionArchitectureRentACarBook.Domain.Entities;

namespace OnionArchitectureRentACarBook.Application.Features.Command.CarCommands.CreateCarCommand;

public class CreateCarCommandHandler : IRequestHandler<CreateCarCommandRequest, CreateCarCommandResponse>
{
    private readonly ICarWriteRepository _carWriteRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public CreateCarCommandHandler(ICarWriteRepository carWriteRepository, IMapper mapper, IUnitOfWork unitOfWork)
    {
        _carWriteRepository = carWriteRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<CreateCarCommandResponse> Handle(CreateCarCommandRequest request, CancellationToken cancellationToken)
    {
        if(request.CreateCarCommandDtoRequest is null)
        {
            return new CreateCarCommandResponse
            {
                Result = Result.Failure(OperationMessages.CarOperationMessages.CreateFailed)
            }; 
        }

        var addedCar = _mapper.Map<Car>(request.CreateCarCommandDtoRequest);
        await _carWriteRepository.AddAsync(addedCar);
        await _unitOfWork.SaveAsync();

        return new CreateCarCommandResponse
        {
            Result = Result.Success(OperationMessages.CarOperationMessages.CreateSuccess)
        };

    }
}
