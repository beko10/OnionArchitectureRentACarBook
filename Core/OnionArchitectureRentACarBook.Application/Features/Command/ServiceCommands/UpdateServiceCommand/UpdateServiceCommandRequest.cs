using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.ServiceDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Command.ServiceCommands.UpdateServiceCommand;

public class UpdateServiceCommandRequest : IRequest<UpdateServiceCommandResponse>
{
    public UpdateServiceCommandDto UpdateServiceCommandDtoRequest { get; set; } = null!;
} 