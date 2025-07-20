using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.ContactDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Command.ContactCommands.UpdateContactCommand;

public class UpdateContactCommandRequest : IRequest<UpdateContactCommandResponse>
{
    public UpdateContactCommandDto UpdateContactCommandDtoRequest { get; set; } = null!;
} 