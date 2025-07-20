using MediatR;

namespace OnionArchitectureRentACarBook.Application.Features.Command.ContactCommands.DeleteContactCommand;

public class DeleteContactCommandRequest : IRequest<DeleteContactCommandResponse>
{
    public string Id { get; set; } = null!;
} 