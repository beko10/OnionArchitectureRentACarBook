using MediatR;

namespace OnionArchitectureRentACarBook.Application.Features.Command.CarPricingCommand.DeleteCarPricingCommand;

public class DeleteCarPricingCommandRequest : IRequest<DeleteCarPricingCommandResponse>
{
    public string? Id { get; set; }
}
