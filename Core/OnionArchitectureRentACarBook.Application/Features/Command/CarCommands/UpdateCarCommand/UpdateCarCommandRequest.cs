using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.CarDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Command.CarCommands.UpdateCarCommand;

public class UpdateCarCommandRequest:IRequest<UpdateCarCommandResponse>
{
    public string  Id { get; set; } = string.Empty;
}
