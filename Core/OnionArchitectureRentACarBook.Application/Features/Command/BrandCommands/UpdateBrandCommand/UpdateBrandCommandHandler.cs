using AutoMapper;
using MediatR;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Repositories.BrandRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;

namespace OnionArchitectureRentACarBook.Application.Features.Command.BrandCommands.UpdateBrandCommand;

public class UpdateBrandCommandHandler : IRequestHandler<UpdateBrandCommandRequest, UpdateBrandCommandResponse>
{
    private readonly IBrandWriteRepository _brandWriteRepository;
    private readonly IBrandReadRepository _brandReadRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UpdateBrandCommandHandler(IBrandWriteRepository brandWriteRepository, IUnitOfWork unitOfWork, IMapper mapper, IBrandReadRepository brandReadRepository)
    {
        _brandWriteRepository = brandWriteRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _brandReadRepository = brandReadRepository;
    }

    public async Task<UpdateBrandCommandResponse> Handle(UpdateBrandCommandRequest request, CancellationToken cancellationToken)
    {
        var hasBrand = await _brandReadRepository.GetByIdAsync(request.Id, cancellationToken);
        if (hasBrand == null)
        {
            return new UpdateBrandCommandResponse
            {
                Result = Result.Failure(OperationMessages.BrandOperationMessages.UpdateNotFound)
            };
        }

        _mapper.Map(request, hasBrand);
        await _brandWriteRepository.UpdateAsync(hasBrand, cancellationToken);
        await _unitOfWork.SaveAsync();
        return new UpdateBrandCommandResponse
        {
            Result = Result.Success(OperationMessages.BrandOperationMessages.UpdateSuccess)
        };

    }
}
