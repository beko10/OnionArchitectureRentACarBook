using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.ServiceDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Command.ServiceCommands.CreateServiceCommand;

public class CreateServiceCommandRequest : IRequest<CreateServiceCommandResponse>
{
    public CreateServiceCommandDto CreateServiceCommandDtoRequest { get; set; } = null!;
} 