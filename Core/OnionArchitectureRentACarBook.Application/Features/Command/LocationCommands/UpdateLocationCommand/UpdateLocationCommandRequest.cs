using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.LocationDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Command.LocationCommands.UpdateLocationCommand;

public class UpdateLocationCommandRequest : IRequest<UpdateLocationCommandResponse>
{
    public UpdateLocationCommandDto UpdateLocationCommandDtoRequest { get; set; } = null!;
} 