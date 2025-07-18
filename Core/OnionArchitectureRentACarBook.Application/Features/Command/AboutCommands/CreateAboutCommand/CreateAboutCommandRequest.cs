
using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.AboutDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Command.AboutCommands.CreateAboutCommand;

public class CreateAboutCommandRequest : IRequest<CreateAboutCommandResponse>
{
    public CreateAboutCommandDto CreateAboutDtoRequest { get; set; } = null!;
}
