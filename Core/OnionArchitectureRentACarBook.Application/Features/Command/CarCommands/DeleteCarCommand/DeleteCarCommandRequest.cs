using MediatR;

namespace OnionArchitectureRentACarBook.Application.Features.Command.CarCommands.DeleteCarCommand;

public class DeleteCarCommandRequest : IRequest<DeleteCarCommandResponse>
{
    public string Id { get; set; } = string.Empty;
}
