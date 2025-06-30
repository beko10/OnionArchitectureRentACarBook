using AutoMapper;
using MediatR;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Repositories.CarRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using OnionArchitectureRentACarBook.Domain.Entities;

namespace OnionArchitectureRentACarBook.Application.Features.Command.CarCommands.UpdateCarCommand;

public class UpdateCarCommandHandler : IRequestHandler<UpdateCarCommandRequest, UpdateCarCommandResponse>
{
    private readonly ICarWriteRepository _carWriteRepository;
    private readonly ICarReadRepository _carReadRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public UpdateCarCommandHandler(ICarWriteRepository carWriteRepository, ICarReadRepository carReadRepository, IMapper mapper, IUnitOfWork unitOfWork)
    {
        _carWriteRepository = carWriteRepository;
        _carReadRepository = carReadRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<UpdateCarCommandResponse> Handle(UpdateCarCommandRequest request, CancellationToken cancellationToken)
    {
        var carExisting = await _carReadRepository.GetByIdAsync(request.Id, cancellationToken);

        if (carExisting == null)
        {
            return new UpdateCarCommandResponse
            {
                Result = Result.Failure(OperationMessages.CarOperationMessages.UpdateNotFound)
            };
        }
        _mapper.Map(request,carExisting);
        await _carWriteRepository.UpdateAsync(carExisting, cancellationToken);
        await _unitOfWork.SaveAsync();

        return new UpdateCarCommandResponse
        {
            Result = Result.Success(OperationMessages.CarOperationMessages.UpdateSuccess)
        };


    }
}
