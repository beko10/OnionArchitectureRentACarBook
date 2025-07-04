using AutoMapper;
using MediatR;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Repositories.CarFeatureRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;

namespace OnionArchitectureRentACarBook.Application.Features.Command.CarFeatureCommands.UpdateCarFeatureCommand;

public class UpdateCarFeatureCommandHandler : IRequestHandler<UpdateCarFeatureCommandRequest, UpdateCarFeatureCommandResponse>
{
    private readonly ICarFeatureReadRepository _carFeatureReadRepository;
    private readonly ICarFeatureWriteRepository _carFeatureWriteRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UpdateCarFeatureCommandHandler(ICarFeatureReadRepository carFeatureReadRepository, ICarFeatureWriteRepository carFeatureWriteRepository, IMapper mapper, IUnitOfWork unitOfWork)
    {
        _carFeatureReadRepository = carFeatureReadRepository;
        _carFeatureWriteRepository = carFeatureWriteRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<UpdateCarFeatureCommandResponse> Handle(UpdateCarFeatureCommandRequest request, CancellationToken cancellationToken)
    {
        if(request is null)
        {
            throw new ArgumentNullException(nameof(request), "Request cannot be null.");
        }

        if (string.IsNullOrEmpty(request.Id))
        {
            throw new ArgumentException("Car feature ID cannot be null or empty.", nameof(request.Id));
        }

        var hasCarFeature = await _carFeatureReadRepository.GetByIdAsync(id:request.Id, cancellationToken:cancellationToken);

        if (hasCarFeature is null)
        {
            return new UpdateCarFeatureCommandResponse
            {
                Result = Result.Failure(OperationMessages.CarFeatureOperationMessages.GetNotFound)
            };
        }

        _mapper.Map(request, hasCarFeature);
        
        await _carFeatureWriteRepository.UpdateAsync(entity:hasCarFeature, cancellationToken:cancellationToken);
        
        await _unitOfWork.SaveAsync();

        return new UpdateCarFeatureCommandResponse
        {
            Result = Result.Success(OperationMessages.CarFeatureOperationMessages.UpdateSuccess)
        };
    }
}
