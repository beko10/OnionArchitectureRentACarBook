using MediatR;
using OnionArchitectureRentACarBook.Application.Repositories.PricingRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;

namespace OnionArchitectureRentACarBook.Application.Features.Command.PricingCommands.DeletePricingCommand;

public class DeletePricingCommandHandler : IRequestHandler<DeletePricingCommandRequest, DeletePricingCommandResponse>
{
    private readonly IPricingWriteRepository _pricingWriteRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DeletePricingCommandHandler(IPricingWriteRepository pricingWriteRepository, IUnitOfWork unitOfWork)
    {
        _pricingWriteRepository = pricingWriteRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<DeletePricingCommandResponse> Handle(DeletePricingCommandRequest request, CancellationToken cancellationToken)
    {
        var result = await _pricingWriteRepository.RemoveIdAsync(request.Id, cancellationToken);
        if (!result)
        {
            return new DeletePricingCommandResponse
            {
                Result = Result.Failure("Silinecek fiyatlandırma bulunamadı.")
            };
        }

        await _unitOfWork.SaveAsync();
        return new DeletePricingCommandResponse
        {
            Result = Result.Success("Fiyatlandırma başarıyla silindi.")
        };
    }
} 