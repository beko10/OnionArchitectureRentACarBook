using MediatR;
using OnionArchitectureRentACarBook.Application.Repositories.ContactRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using OnionArchitectureRentACarBook.Application.Common.Messages;

namespace OnionArchitectureRentACarBook.Application.Features.Command.ContactCommands.DeleteContactCommand;

public class DeleteContactCommandHandler : IRequestHandler<DeleteContactCommandRequest, DeleteContactCommandResponse>
{
    private readonly IContactWriteRepository _contactWriteRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteContactCommandHandler(IContactWriteRepository contactWriteRepository, IUnitOfWork unitOfWork)
    {
        _contactWriteRepository = contactWriteRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<DeleteContactCommandResponse> Handle(DeleteContactCommandRequest request, CancellationToken cancellationToken)
    {
        var result = await _contactWriteRepository.RemoveIdAsync(request.Id, cancellationToken);
        if (!result)
        {
            return new DeleteContactCommandResponse
            {
                Result = Result.Failure(OperationMessages.ContactOperationMessages.DeleteNotFound)
            };
        }

        await _unitOfWork.SaveAsync();
        return new DeleteContactCommandResponse
        {
            Result = Result.Success(OperationMessages.ContactOperationMessages.DeleteSuccess)
        };
    }
} 