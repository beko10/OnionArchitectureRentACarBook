using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.FeatureDtos;
using OnionArchitectureRentACarBook.Application.Repositories.FeatureRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using OnionArchitectureRentACarBook.Domain.Entities;
using AutoMapper;

namespace OnionArchitectureRentACarBook.Application.Features.Command.FeatureCommands.CreateFeatureCommand;

public class CreateFeatureCommandHandler : IRequestHandler<CreateFeatureCommandRequest, CreateFeatureCommandResponse>
{
    private readonly IFeatureWriteRepository _featureWriteRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateFeatureCommandHandler(IFeatureWriteRepository featureWriteRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _featureWriteRepository = featureWriteRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<CreateFeatureCommandResponse> Handle(CreateFeatureCommandRequest request, CancellationToken cancellationToken)
    {
        var feature = _mapper.Map<Feature>(request.CreateFeatureCommandDtoRequest);
        await _featureWriteRepository.AddAsync(feature, cancellationToken);
        await _unitOfWork.SaveAsync();

        return new CreateFeatureCommandResponse
        {
            Result = Result.Success("Özellik başarıyla eklendi.")
        };
    }
} 