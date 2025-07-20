using AutoMapper;
using MediatR;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Repositories.CarPricingRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;

namespace OnionArchitectureRentACarBook.Application.Features.Command.CarPricingCommand.DeleteCarPricingCommand;

public class DeleteCarPricingCommandHandler : IRequestHandler<DeleteCarPricingCommandRequest, DeleteCarPricingCommandResponse>
{
    private readonly ICarPricingWriteRepository _carPricingWriteRepository;
    private readonly ICarPricingReadRepository _carPricingReadRepository;
    private IUnitOfWork _unitOfWork;

    public DeleteCarPricingCommandHandler(ICarPricingWriteRepository carPricingWriteRepository, ICarPricingReadRepository carPricingReadRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _carPricingWriteRepository = carPricingWriteRepository;
        _carPricingReadRepository = carPricingReadRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<DeleteCarPricingCommandResponse> Handle(DeleteCarPricingCommandRequest request, CancellationToken cancellationToken)
    {
    

        var searchedByIdHasCarPricing = await _carPricingReadRepository.GetByIdAsync(id:request.Id,cancellationToken:cancellationToken);

        if(searchedByIdHasCarPricing is null)
        {
            return new DeleteCarPricingCommandResponse
            {
                Result = Result.Failure(OperationMessages.CarPricingOperationMessages.DeleteNotFound)
            };
        }

        await _carPricingWriteRepository.RemoveAsync(searchedByIdHasCarPricing);
        await _unitOfWork.SaveAsync();

        return new DeleteCarPricingCommandResponse
        {
            Result = Result.Success(OperationMessages.CarPricingOperationMessages.DeleteSuccess)
        };
    }
}
