using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.FeatureDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Command.FeatureCommands.CreateFeatureCommand;

public class CreateFeatureCommandRequest : IRequest<CreateFeatureCommandResponse>
{
    public CreateFeatureCommandDto CreateFeatureCommandDtoRequest { get; set; } = null!;
} 