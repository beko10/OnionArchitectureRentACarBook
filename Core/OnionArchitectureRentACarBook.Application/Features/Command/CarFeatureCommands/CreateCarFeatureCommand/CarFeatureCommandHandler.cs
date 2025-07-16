using AutoMapper;
using MediatR;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Repositories.CarFeatureRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using OnionArchitectureRentACarBook.Domain.Entities;

namespace OnionArchitectureRentACarBook.Application.Features.Command.CarFeatureCommands.CreateCarFeatureCommand;

internal class CarFeatureCommandHandler : IRequestHandler<CarFeatureCommandRequest, CarFeatureCommandResponse>
{
    private readonly ICarFeatureWriteRepository _carFeatureWriteRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CarFeatureCommandHandler(ICarFeatureReadRepository carFeatureReadRepository, IUnitOfWork unitOfWork, IMapper mapper, ICarFeatureWriteRepository carFeatureWriteRepository)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _carFeatureWriteRepository = carFeatureWriteRepository;
    }

    public async Task<CarFeatureCommandResponse> Handle(CarFeatureCommandRequest request, CancellationToken cancellationToken)
    {

        var addedCarFeature = _mapper.Map<CarFeature>(request.CreateCarCommandDtoRequest);
        
        await _carFeatureWriteRepository.AddAsync(entity:addedCarFeature,cancellationToken:cancellationToken);
        await _unitOfWork.SaveAsync();

        return new CarFeatureCommandResponse
        {
            Result = Result.Success(OperationMessages.CarFeatureOperationMessages.CreateSuccess)
        };
    }
}
