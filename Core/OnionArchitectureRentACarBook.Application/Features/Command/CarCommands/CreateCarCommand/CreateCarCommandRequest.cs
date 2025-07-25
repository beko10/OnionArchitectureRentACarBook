﻿using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.CarDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Command.CarCommands.CreateCarCommand;

public class CreateCarCommandRequest : IRequest<CreateCarCommandResponse>
{
    public CreateCarCommandDto CreateCarCommandDtoRequest { get; set; } = null!;
}
