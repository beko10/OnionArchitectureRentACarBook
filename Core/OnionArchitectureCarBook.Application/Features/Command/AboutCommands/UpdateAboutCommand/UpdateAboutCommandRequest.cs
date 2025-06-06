using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.AboutDto;

namespace OnionArchitectureRentACarBook.Application.Features.Command.AboutCommands.UpdateAboutCommand;

public class UpdateAboutCommandRequest : IRequest<UpdateAboutCommandResponse>
{
    public UpdateAboutDto UpdateAboutDtoRequest { get; set; } = null!;
}
