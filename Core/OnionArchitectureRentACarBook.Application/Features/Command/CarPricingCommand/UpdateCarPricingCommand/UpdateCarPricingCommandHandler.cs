using AutoMapper;
using MediatR;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Repositories.CarPricingRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using OnionArchitectureRentACarBook.Domain.Entities;

namespace OnionArchitectureRentACarBook.Application.Features.Command.CarPricingCommand.UpdateCarPricingCommand;

public class UpdateCarPricingCommandHandler : IRequestHandler<UpdateCarPricingCommandRequest, UpdateCarPricingCommandResponse>
{
    private readonly ICarPricingReadRepository _carPricingReadRepository;
    private readonly ICarPricingWriteRepository _carPricingWriteRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public UpdateCarPricingCommandHandler(ICarPricingReadRepository carPricingReadRepository, ICarPricingWriteRepository carPricingWriteRepository, IMapper mapper, IUnitOfWork unitOfWork)
    {
        _carPricingReadRepository = carPricingReadRepository;
        _carPricingWriteRepository = carPricingWriteRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<UpdateCarPricingCommandResponse> Handle(UpdateCarPricingCommandRequest request, CancellationToken cancellationToken)
    {
   
        var hasCarPricing = await _carPricingReadRepository.GetByIdAsync(request.Id, cancellationToken);

        if (hasCarPricing is null)
        {
            return new UpdateCarPricingCommandResponse
            {
                Result = Result.Failure(OperationMessages.CarPricingOperationMessages.GetNotFound)
            };
        }

        _mapper.Map(request, hasCarPricing);
        await _carPricingWriteRepository.UpdateAsync(hasCarPricing);
        await _unitOfWork.SaveAsync();
        return new UpdateCarPricingCommandResponse
        {
            Result = Result.Success(OperationMessages.CarPricingOperationMessages.UpdateSuccess)
        };
    }
}
