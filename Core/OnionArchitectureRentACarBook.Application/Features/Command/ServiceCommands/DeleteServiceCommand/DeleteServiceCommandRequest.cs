using MediatR;

namespace OnionArchitectureRentACarBook.Application.Features.Command.ServiceCommands.DeleteServiceCommand;

public class DeleteServiceCommandRequest : IRequest<DeleteServiceCommandResponse>
{
    public string Id { get; set; } = null!;
} 