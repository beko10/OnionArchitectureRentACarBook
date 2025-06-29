
using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.AboutDto;

namespace OnionArchitectureRentACarBook.Application.Features.Command.AboutCommands.CreateAboutCommand;

public class CreateAboutCommandRequest : IRequest<CreateAboutCommandResponse>
{
    public CreateAboutDto CreateAboutDtoRequest { get; set; } = null!;
}
