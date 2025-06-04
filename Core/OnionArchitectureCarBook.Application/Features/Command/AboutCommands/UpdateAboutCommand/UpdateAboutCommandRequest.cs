using MediatR;
using OnionArchitectureCarBook.Application.DTOs.About;

namespace OnionArchitectureCarBook.Application.Features.Command.AboutCommands.UpdateAboutCommand;

public class UpdateAboutCommandRequest : IRequest<UpdateAboutCommandResponse>
{
    public UpdateAboutDto UpdateAboutDtoRequest { get; set; } = null!;
}
