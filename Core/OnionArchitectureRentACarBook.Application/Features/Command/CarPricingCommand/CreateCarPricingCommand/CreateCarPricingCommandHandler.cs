using AutoMapper;
using MediatR;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Repositories.CarPricingRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using OnionArchitectureRentACarBook.Domain.Entities;

namespace OnionArchitectureRentACarBook.Application.Features.Command.CarPricingCommand.CreateCarPricingCommand;

public class CreateCarPricingCommandHandler : IRequestHandler<CreateCarPricingCommandRequest, CreateCarPricingCommandResponse>
{
    private readonly ICarPricingWriteRepository _carPricingWriteRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateCarPricingCommandHandler(ICarPricingWriteRepository carPricingWriteRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _carPricingWriteRepository = carPricingWriteRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<CreateCarPricingCommandResponse> Handle(CreateCarPricingCommandRequest request, CancellationToken cancellationToken)
    {
        var addedCarPricing = _mapper.Map<CarPricing>(request.CreateCarPricingCommandDtoRequest);

        await _carPricingWriteRepository.AddAsync(entity:addedCarPricing, cancellationToken:cancellationToken);

        await _unitOfWork.SaveAsync();

        return new CreateCarPricingCommandResponse
        {
            Result = Result.Success(OperationMessages.CarPricingOperationMessages.CreateSuccess)
        };

    }
}
