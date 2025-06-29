using AutoMapper;
using MediatR;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Repositories.BannerRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using OnionArchitectureRentACarBook.Domain.Entities;

namespace OnionArchitectureRentACarBook.Application.Features.Command.BannerCommands.CreateBannerCommand;

public class CreateBannerCommandHandler : IRequestHandler<CreateBannerCommandRequest, CreateBannerCommandResponse>
{
    private readonly IBannerWriteRepository _bannerWriteRepository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    public CreateBannerCommandHandler(IBannerWriteRepository bannerWriteRepository, IMapper mapper, IUnitOfWork unitOfWork)
    {
        _bannerWriteRepository = bannerWriteRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<CreateBannerCommandResponse> Handle(CreateBannerCommandRequest request, CancellationToken cancellationToken)
    {
        var createdBannerMapped = _mapper.Map<Banner>(request.CreateBannerCommandDtoRequest);
        await _bannerWriteRepository.AddAsync(entity:createdBannerMapped,cancellationToken:cancellationToken);
        await _unitOfWork.SaveAsync();
        return new CreateBannerCommandResponse
        {
            Result = Result.Success(OperationMessages.BannerOperationMessages.CreateSuccess)
        };
    }
}
