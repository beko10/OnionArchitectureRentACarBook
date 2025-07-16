using MediatR;

namespace OnionArchitectureRentACarBook.Application.Features.Command.CarPricingCommand.UpdateCarPricingCommand;

public class UpdateCarPricingCommandRequest : IRequest<UpdateCarPricingCommandResponse>
{
    public string? Id { get; set; }
}
