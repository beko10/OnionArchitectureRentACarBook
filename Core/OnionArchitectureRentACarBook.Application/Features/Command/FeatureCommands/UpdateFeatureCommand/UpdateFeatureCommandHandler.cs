using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.FeatureDtos;
using OnionArchitectureRentACarBook.Application.Repositories.FeatureRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using OnionArchitectureRentACarBook.Domain.Entities;
using AutoMapper;

namespace OnionArchitectureRentACarBook.Application.Features.Command.FeatureCommands.UpdateFeatureCommand;

public class UpdateFeatureCommandHandler : IRequestHandler<UpdateFeatureCommandRequest, UpdateFeatureCommandResponse>
{
    private readonly IFeatureWriteRepository _featureWriteRepository;
    private readonly IFeatureReadRepository _featureReadRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UpdateFeatureCommandHandler(IFeatureWriteRepository featureWriteRepository, IFeatureReadRepository featureReadRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _featureWriteRepository = featureWriteRepository;
        _featureReadRepository = featureReadRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<UpdateFeatureCommandResponse> Handle(UpdateFeatureCommandRequest request, CancellationToken cancellationToken)
    {
        var feature = await _featureReadRepository.GetByIdAsync(request.UpdateFeatureCommandDtoRequest.Id, cancellationToken);
        if (feature == null)
        {
            return new UpdateFeatureCommandResponse
            {
                Result = Result.Failure("Güncellenecek özellik bulunamadı.")
            };
        }

        _mapper.Map(request.UpdateFeatureCommandDtoRequest, feature);
        await _featureWriteRepository.UpdateAsync(feature, cancellationToken);
        await _unitOfWork.SaveAsync();

        return new UpdateFeatureCommandResponse
        {
            Result = Result.Success("Özellik başarıyla güncellendi.")
        };
    }
} 