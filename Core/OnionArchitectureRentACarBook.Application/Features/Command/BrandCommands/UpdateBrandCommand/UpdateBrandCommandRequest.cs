using MediatR;

namespace OnionArchitectureRentACarBook.Application.Features.Command.BrandCommands.UpdateBrandCommand;

public class UpdateBrandCommandRequest : IRequest<UpdateBrandCommandResponse>
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
}
