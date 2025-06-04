
using MediatR;
using OnionArchitectureCarBook.Application.DTOs.About;

namespace OnionArchitectureCarBook.Application.Features.Command.AboutCommands.CreateAboutCommand;

public class CreateAboutCommandRequest : IRequest<CreateAboutCommandResponse>
{
    public CreateAboutDto CreateAboutDto { get; set; } = null!;
}
