using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.FeatureDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Command.FeatureCommands.UpdateFeatureCommand;

public class UpdateFeatureCommandRequest : IRequest<UpdateFeatureCommandResponse>
{
    public UpdateFeatureCommandDto UpdateFeatureCommandDtoRequest { get; set; } = null!;
} 