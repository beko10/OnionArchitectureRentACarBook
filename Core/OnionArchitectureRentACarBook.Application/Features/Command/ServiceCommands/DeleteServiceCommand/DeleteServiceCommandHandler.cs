using MediatR;
using OnionArchitectureRentACarBook.Application.Repositories.ServiceRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;

namespace OnionArchitectureRentACarBook.Application.Features.Command.ServiceCommands.DeleteServiceCommand;

public class DeleteServiceCommandHandler : IRequestHandler<DeleteServiceCommandRequest, DeleteServiceCommandResponse>
{
    private readonly IServiceWriteRepository _serviceWriteRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteServiceCommandHandler(IServiceWriteRepository serviceWriteRepository, IUnitOfWork unitOfWork)
    {
        _serviceWriteRepository = serviceWriteRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<DeleteServiceCommandResponse> Handle(DeleteServiceCommandRequest request, CancellationToken cancellationToken)
    {
        var result = await _serviceWriteRepository.RemoveIdAsync(request.Id, cancellationToken);
        if (!result)
        {
            return new DeleteServiceCommandResponse
            {
                Result = Result.Failure("Silinecek servis bulunamadı.")
            };
        }

        await _unitOfWork.SaveAsync();
        return new DeleteServiceCommandResponse
        {
            Result = Result.Success("Servis başarıyla silindi.")
        };
    }
} 