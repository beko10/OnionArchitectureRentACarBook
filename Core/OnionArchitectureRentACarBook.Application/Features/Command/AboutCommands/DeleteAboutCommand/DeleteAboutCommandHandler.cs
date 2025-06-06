using MediatR;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Repositories.AboutRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;

namespace OnionArchitectureRentACarBook.Application.Features.Command.AboutCommands.DeleteAboutCommand;

public class DeleteAboutCommandHandler : IRequestHandler<DeleteAboutCommandRequest,DeleteAboutCommandResponse>
{
    private readonly IAboutWriteRepository _aboutWriteRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteAboutCommandHandler(IAboutWriteRepository aboutWriteRepository, IUnitOfWork unitOfWork)
    {
        _aboutWriteRepository = aboutWriteRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<DeleteAboutCommandResponse> Handle(DeleteAboutCommandRequest request, CancellationToken cancellationToken)
    {
        var result = await _aboutWriteRepository.RemoveIdAsync(request.Id, cancellationToken);
        if(!result)
        {
            return new DeleteAboutCommandResponse
            {
                Result = Result.Failure(OperationMessages.AboutOperationMessages.DeleteNotFound)
            };
        }

        await _unitOfWork.SaveAsync();
        return new DeleteAboutCommandResponse
        {
            Result = Result.Success(OperationMessages.AboutOperationMessages.DeleteSuccess)
        };
    }
}
