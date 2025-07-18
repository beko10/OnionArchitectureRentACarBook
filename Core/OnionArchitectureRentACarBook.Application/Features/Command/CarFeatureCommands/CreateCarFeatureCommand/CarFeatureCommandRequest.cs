using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.CarDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Command.CarFeatureCommands.CreateCarFeatureCommand;

public class CarFeatureCommandRequest : IRequest<CarFeatureCommandResponse>
{
    public CreateCarCommandDto? CreateCarCommandDtoRequest { get; set; } 
}
