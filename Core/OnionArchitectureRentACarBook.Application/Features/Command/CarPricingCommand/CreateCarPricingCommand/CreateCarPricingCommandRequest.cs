﻿using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.CarPricingDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Command.CarPricingCommand.CreateCarPricingCommand;

public class CreateCarPricingCommandRequest : IRequest<CreateCarPricingCommandResponse>
{
    public CreateCarPricingCommandDto? CreateCarPricingCommandDtoRequest { get; set; }
}
