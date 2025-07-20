using MediatR;

namespace OnionArchitectureRentACarBook.Application.Features.Command.FeatureCommands.DeleteFeatureCommand;

public class DeleteFeatureCommandRequest : IRequest<DeleteFeatureCommandResponse>
{
    public string Id { get; set; } = null!;
} 