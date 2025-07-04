using MediatR;

namespace OnionArchitectureRentACarBook.Application.Features.Command.CarFeatureCommands.DeleteCarFeatureCommand;

public class DeleteCarFeatureCommandRequest : IRequest<DeleteCarFeatureCommandResponse>
{
    public string? Id { get; set; }
}
