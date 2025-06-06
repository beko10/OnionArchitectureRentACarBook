using AutoMapper;
using MediatR;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Repositories.BannerRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;

namespace OnionArchitectureRentACarBook.Application.Features.Command.BannerCommands.UpdateBannerCommand;

public class UpdateBannerCommandHandler : IRequestHandler<UpdateBannerCommandRequest, UpdateBannerCommandResponse>
{
    private readonly IBannerWriteRepository _bannerWriteRepository;
    private readonly IBannerReadRepository _bannerReadRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public UpdateBannerCommandHandler(IBannerWriteRepository bannerWriteRepository, IUnitOfWork unitOfWork, IMapper mapper, IBannerReadRepository bannerReadRepository)
    {
        _bannerWriteRepository = bannerWriteRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _bannerReadRepository = bannerReadRepository;
    }


    public async Task<UpdateBannerCommandResponse> Handle(UpdateBannerCommandRequest request, CancellationToken cancellationToken)
    {
        var updatedBanner = await _bannerReadRepository.GetByIdAsync(request.Id);
        if (updatedBanner == null)
        {
            return new UpdateBannerCommandResponse
            {
                Result = Result.Failure(OperationMessages.BannerOperationMessages.UpdateNotFound)
            };
        }
        await _bannerWriteRepository.UpdateAsync(updatedBanner);
        await _unitOfWork.SaveAsync();
        return new UpdateBannerCommandResponse
        {
            Result = Result.Success(OperationMessages.BannerOperationMessages.UpdateSuccess)
        };
    }
}
