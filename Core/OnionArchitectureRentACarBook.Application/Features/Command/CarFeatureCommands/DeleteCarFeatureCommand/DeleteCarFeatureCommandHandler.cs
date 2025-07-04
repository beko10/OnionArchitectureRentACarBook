using MediatR;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Repositories.CarFeatureRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;

namespace OnionArchitectureRentACarBook.Application.Features.Command.CarFeatureCommands.DeleteCarFeatureCommand;

public class DeleteCarFeatureCommandHandler : IRequestHandler<DeleteCarFeatureCommandRequest, DeleteCarFeatureCommandResponse>
{
    private readonly ICarFeatureReadRepository  _carFeatureReadRepository;
    private readonly ICarFeatureWriteRepository _carFeatureWriteRepository;
    private readonly IUnitOfWork _unitOfWork;
  
    public DeleteCarFeatureCommandHandler(ICarFeatureReadRepository carFeatureReadRepository, ICarFeatureWriteRepository carFeatureWriteRepository, IUnitOfWork unitOfWork)
    {
        _carFeatureReadRepository = carFeatureReadRepository;
        _carFeatureWriteRepository = carFeatureWriteRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<DeleteCarFeatureCommandResponse> Handle(DeleteCarFeatureCommandRequest request, CancellationToken cancellationToken)
    {
        if(request is null)
        {
            throw new ArgumentNullException(nameof(request));
        }

        if(string.IsNullOrEmpty(request.Id))
        {
            throw new ArgumentNullException(nameof(request.Id));
        }

        var deletedCarFeature = await _carFeatureReadRepository.GetByIdAsync(id : request.Id,cancellationToken:cancellationToken);

        if(deletedCarFeature is null)
        {
            return new DeleteCarFeatureCommandResponse
            {
                Result = Result.Failure(OperationMessages.CarFeatureOperationMessages.GetNotFound)
            };
        }

        await _carFeatureWriteRepository.RemoveAsync(entity:deletedCarFeature,cancellationToken:cancellationToken);

        await _unitOfWork.SaveAsync();

        return new DeleteCarFeatureCommandResponse
        {
            Result = Result.Success(OperationMessages.CarFeatureOperationMessages.DeleteFailed)
        };
    }
}
