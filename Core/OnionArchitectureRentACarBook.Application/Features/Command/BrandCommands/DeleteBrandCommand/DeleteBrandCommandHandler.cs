using AutoMapper;
using MediatR;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Repositories.BannerRepository;
using OnionArchitectureRentACarBook.Application.Repositories.BrandRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;

namespace OnionArchitectureRentACarBook.Application.Features.Command.BrandCommands.DeleteBrandCommand;

public class DeleteBrandCommandHandler : IRequestHandler<DeleteBrandCommandRequest, DeleteBrandCommandResponse>
{
   
    private readonly IBrandWriteRepository _brandWriteRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IBrandReadRepository _brandReadRepository;
    private readonly IMapper _mapper;
    public DeleteBrandCommandHandler(IBrandWriteRepository brandWriteRepository, IUnitOfWork unitOfWork, IBrandReadRepository brandReadRepository, IMapper mapper)
    {

        _unitOfWork = unitOfWork;
        _brandWriteRepository = brandWriteRepository;
        _brandReadRepository = brandReadRepository;
        _mapper = mapper;
    }


    public async Task<DeleteBrandCommandResponse> Handle(DeleteBrandCommandRequest request, CancellationToken cancellationToken)
    {
        var hasBrand = await _brandReadRepository.GetByIdAsync(id:request.Id,cancellationToken:cancellationToken);
        if (hasBrand == null)
        {
            return new DeleteBrandCommandResponse
            {
                Result = Result.Failure(OperationMessages.BrandOperationMessages.DeleteNotFound)
            };
        }

        await _brandWriteRepository.RemoveIdAsync(request.Id, cancellationToken);
        await _unitOfWork.SaveAsync();
        return new DeleteBrandCommandResponse
        {
            Result = Result.Success(OperationMessages.BrandOperationMessages.DeleteSuccess)
        };
    }
}
