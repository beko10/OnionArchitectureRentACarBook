using MediatR;

namespace OnionArchitectureRentACarBook.Application.Features.Command.AboutCommands.DeleteAboutCommand;

public class DeleteAboutCommandRequest : IRequest<DeleteAboutCommandResponse>
{
    public string Id { get; set; } = null!;
}
