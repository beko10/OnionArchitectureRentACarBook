using MediatR;

namespace OnionArchitectureRentACarBook.Application.Features.Command.FooterAdressCommands.DeleteFooterAdressCommand;

public class DeleteFooterAdressCommandRequest : IRequest<DeleteFooterAdressCommandResponse>
{
    public string Id { get; set; } = null!;
} 