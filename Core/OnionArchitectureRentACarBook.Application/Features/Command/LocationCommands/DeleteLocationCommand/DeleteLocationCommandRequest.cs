using MediatR;

namespace OnionArchitectureRentACarBook.Application.Features.Command.LocationCommands.DeleteLocationCommand;

public class DeleteLocationCommandRequest : IRequest<DeleteLocationCommandResponse>
{
    public string Id { get; set; } = null!;
} 