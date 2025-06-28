using MediatR;

namespace OnionArchitectureRentACarBook.Application.Features.Command.BrandCommands.DeleteBrandCommand;

public class DeleteBrandCommandRequest : IRequest<DeleteBrandCommandResponse>
{
    public string Id { get; set; } = string.Empty;
}
