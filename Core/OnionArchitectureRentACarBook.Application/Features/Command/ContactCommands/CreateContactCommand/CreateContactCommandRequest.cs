using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.ContactDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Command.ContactCommands.CreateContactCommand;

public class CreateContactCommandRequest : IRequest<CreateContactCommandResponse>
{
    public CreateContactCommandDto CreateContactCommandDtoRequest { get; set; } = null!;
} 