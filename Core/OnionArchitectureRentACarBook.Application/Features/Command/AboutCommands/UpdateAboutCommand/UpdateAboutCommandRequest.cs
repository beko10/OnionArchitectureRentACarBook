using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.AboutDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Command.AboutCommands.UpdateAboutCommand;

public class UpdateAboutCommandRequest : IRequest<UpdateAboutCommandResponse>
{
    public UpdateAboutCommandDto UpdateAboutDtoRequest { get; set; } = null!;
}
