using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.LocationDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Command.LocationCommands.CreateLocationCommand;

public class CreateLocationCommandRequest : IRequest<CreateLocationCommandResponse>
{
    public CreateLocationCommandDto CreateLocationCommandDtoRequest { get; set; } = null!;
} 