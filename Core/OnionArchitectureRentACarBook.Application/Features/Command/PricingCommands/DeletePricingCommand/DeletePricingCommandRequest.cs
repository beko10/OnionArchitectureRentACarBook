using MediatR;

namespace OnionArchitectureRentACarBook.Application.Features.Command.PricingCommands.DeletePricingCommand;

public class DeletePricingCommandRequest : IRequest<DeletePricingCommandResponse>
{
    public string Id { get; set; } = null!;
} 