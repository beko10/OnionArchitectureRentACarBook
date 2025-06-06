using MediatR;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Repositories.BannerRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;

namespace OnionArchitectureRentACarBook.Application.Features.Command.BannerCommands.DeleteBannerCommand;

public class DeleteBannerCommandHandler : IRequestHandler<DeleteBannerCommandRequest, DeleteBannerCommandResponse>
{
    private readonly IBannerWriteRepository _bannerWriteRepository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteBannerCommandHandler(IBannerWriteRepository bannerWriteRepository, IUnitOfWork unitOfWork)
    {
        _bannerWriteRepository = bannerWriteRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<DeleteBannerCommandResponse> Handle(DeleteBannerCommandRequest request, CancellationToken cancellationToken)
    {
        var deleteOperationResult = await _bannerWriteRepository.RemoveIdAsync(request.Id);

        if(!deleteOperationResult)
        {
            return new DeleteBannerCommandResponse
            {
                Result = Result.Failure(OperationMessages.BannerOperationMessages.DeleteNotFound)
            };
        }
        await _unitOfWork.SaveAsync();
        return new DeleteBannerCommandResponse
        {
            Result = Result.Success(OperationMessages.BannerOperationMessages.DeleteSuccess)
        };
    }
}
