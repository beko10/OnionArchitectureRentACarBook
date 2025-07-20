using MediatR;
using OnionArchitectureRentACarBook.Application.Repositories.LocationRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;

namespace OnionArchitectureRentACarBook.Application.Features.Command.LocationCommands.DeleteLocationCommand;

public class DeleteLocationCommandHandler : IRequestHandler<DeleteLocationCommandRequest, DeleteLocationCommandResponse>
{
    private readonly ILocationWriteRepository _locationWriteRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteLocationCommandHandler(ILocationWriteRepository locationWriteRepository, IUnitOfWork unitOfWork)
    {
        _locationWriteRepository = locationWriteRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<DeleteLocationCommandResponse> Handle(DeleteLocationCommandRequest request, CancellationToken cancellationToken)
    {
        var result = await _locationWriteRepository.RemoveIdAsync(request.Id, cancellationToken);
        if (!result)
        {
            return new DeleteLocationCommandResponse
            {
                Result = Result.Failure("Silinecek lokasyon bulunamadı.")
            };
        }

        await _unitOfWork.SaveAsync();
        return new DeleteLocationCommandResponse
        {
            Result = Result.Success("Lokasyon başarıyla silindi.")
        };
    }
} 