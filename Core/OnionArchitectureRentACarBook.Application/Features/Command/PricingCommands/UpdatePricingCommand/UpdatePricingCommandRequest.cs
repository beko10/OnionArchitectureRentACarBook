using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.PricingDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Command.PricingCommands.UpdatePricingCommand;

public class UpdatePricingCommandRequest : IRequest<UpdatePricingCommandResponse>
{
    public UpdatePricingCommandDto UpdatePricingCommandDtoRequest { get; set; } = null!;
} 