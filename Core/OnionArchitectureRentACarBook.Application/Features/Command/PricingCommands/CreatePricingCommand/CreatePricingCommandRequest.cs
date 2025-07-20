using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.PricingDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Command.PricingCommands.CreatePricingCommand;

public class CreatePricingCommandRequest : IRequest<CreatePricingCommandResponse>
{
    public CreatePricingCommandDto CreatePricingCommandDtoRequest { get; set; } = null!;
} 