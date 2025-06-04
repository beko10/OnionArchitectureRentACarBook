using MediatR;
using OnionArchitectureCarBook.Application.Common.Messages;
using OnionArchitectureCarBook.Application.Repositories.AboutRepository;
using OnionArchitectureCarBook.Application.UnitOfWork;
using OnionArchitectureCarBook.Application.Utilities.Results;

namespace OnionArchitectureCarBook.Application.Features.Command.AboutCommands.DeleteAboutCommand;

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
