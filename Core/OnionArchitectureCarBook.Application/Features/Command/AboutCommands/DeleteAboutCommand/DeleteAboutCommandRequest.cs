using MediatR;

namespace OnionArchitectureCarBook.Application.Features.Command.AboutCommands.DeleteAboutCommand;

public class DeleteAboutCommandRequest : IRequest<DeleteAboutCommandResponse>
{
    public string Id { get; set; } = null!;
}
